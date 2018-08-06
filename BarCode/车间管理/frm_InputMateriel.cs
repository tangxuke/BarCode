using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.车间管理
{
    public partial class frm_InputMateriel : Form
    {
        public frm_InputMateriel()
        {
            InitializeComponent();
        }

        private void txtProdno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
            }
        }

        private void txtProdno_LostFocus(object sender, EventArgs e)
        {
            this.FillProdNO();
           // this.txtXHTM.Focus();
        }

        #region 填充制令号相关信息
        private void FillProdNO()
        {
            string strProdNO = this.txtProdno.Text.Trim();
            if (strProdNO.Length == 0)
            {
                return;
            }
            string strSql = "select  * from pdlots with(nolock)  where prodno='" + strProdNO + "' and workshopid='" + CommonClass.pUserID + "'";
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此生产令号不存在,或是车间不正确！", "系统提示");
                this.txtProdno.Text = "";
                this.txtCPBH.Text = "";
                this.txtLotNo.Text = "";
                this.txtUserID.Text = "";
                this.txtLine.Text = "";
                this.txtProdno.Focus();
                return;
            }
            this.txtCPBH.Text = dt.Rows[0]["cpbh"].ToString();
            this.txtLotNo.Text = dt.Rows[0]["pdlotno"].ToString();
            this.txtUserID.Text = dt.Rows[0]["workshopid"].ToString();
            this.txtLine.Text = dt.Rows[0]["lineid"].ToString();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtQty.Focus();
            }
        }
        #endregion

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXhtm = this.txtXHTM.Text.Trim();
            if (strXhtm.Length == 0)
            {
                return;
            }

            if (!this.CheckData())
            {
                DialogResult result = MessageBox.Show("该产品部件字典中不存在此材料编号！", "请确认是否续继投入！", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                if (result.ToString() == "No")
                {
                    this.txtXHTM.Text = "";
                    this.txtClbh.Text = "";
                    this.txtLLPC.Text = "";
                    this.txtQty.Text = "";
                    this.txtzzpc.Text = "";
                    this.txtXHTM.Focus();

                }
                else
                {
                    if (!this.CheckTM())  //反回真,通过
                    {
                        MessageBox.Show("该开拉号找不到对应的材料编号,或是该物料的投入数量已大于发料数量!", "系统提示");
                        this.txtXHTM.Text = "";
                        this.txtXHTM.Focus();
                        return;
                    }
                    else
                    {
                        this.FillXHTM();
                        this.txtQty.SelectAll();
                        this.txtQty.Focus();
                    }
                }
            }
            else
            {
                this.FillXHTM();
                this.txtQty.SelectAll();
                this.txtQty.Focus();
            }
        }

        #region 填充该条码的信息
        private void FillXHTM()
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            if (strXHTM.Substring(0,2) != "M.")
            {
                MessageBox.Show("扫描的条码格式不正确！", "系统提示");
                this.txtXHTM.SelectAll();
                return;
            }
            strXHTM = strXHTM.Substring(2);

            string strSql = "exec 查询投入条码 '" + strXHTM + "'";
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此箱号条码不存在！", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
            }

            this.txtClbh.Text = dt.Rows[0]["材料编号"].ToString();
            this.txtLLPC.Text = dt.Rows[0]["来料批次"].ToString();
            this.txtQty.Text = dt.Rows[0]["可用数量"].ToString();
            this.txtzzpc.Text = dt.Rows[0]["制造批次"].ToString();
            //this.FillZZPC();
            this.btnOK.Focus();

        }
        #endregion

        #region 检测BOM
        private bool  CheckData()
        {
            string strXhtm = this.txtXHTM.Text.Trim();
            if (strXhtm.Length == 0)
            {
                return true;
            }
            string strcpbh = this.txtCPBH.Text.Trim();
            string strxhtm = this.txtXHTM.Text.Trim();
            if (strxhtm.Length == 0)
            {
                return false;
            }
            strxhtm = strxhtm.Substring(2);
            string strsql = "select * from 部件字典  with(nolock) where cpbh='" + strcpbh + "' and clbh=(select 材料编号 from 仓位库存表_车间  with(nolock)  where 箱号条码='" + strxhtm + "')";
            DataTable dt = DataClass.GetTable(strsql);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region 检测条码是否与开拉号匹配
        private bool CheckTM()
        {
            string strXhtm = this.txtXHTM.Text.Trim();
            if (strXhtm.Length == 0)
            {
                return true;
            }
            strXhtm = strXhtm.Substring(2);
            string strprodno = this.txtProdno.Text.Trim();
            string strsql = "exec 查询物料投入条码余欠 '" + strprodno + "','" + strXhtm + "'";
            DataTable dt = DataClass.GetTable(strsql);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region 填充制造批次
        private void FillZZPC()
        {
            //string strLLPC = this.txtLLPC.Text.Trim();
            //if (strLLPC.Length == 0)
            //{
            //    MessageBox.Show("此来料批次为空！","系统提示");
            //    return;
            //}
            //string strSql = "select * from IMLOTS where llpc='" + strLLPC + "' order by mlotno";
            //DataTable dt = DataClass.GetTable(strSql);
            //if (dt.Rows.Count == 0)
            //{
            //    MessageBox.Show("此来料批次没有维护制造批次！", "系统提示");
            //    return;
            //}

            //this.cmbZZPC.Items.Clear();
            //foreach (DataRow dr in dt.Rows)
            //{
            //    this.cmbZZPC.Items.Add(dr["mlotno"].ToString());
            //}
            //this.cmbZZPC.SelectedIndex = 0;

        }
        #endregion


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strProdno = this.txtProdno.Text.Trim();
            string strXhtm = this.txtXHTM.Text.Trim();
            string strZZPC = this.txtzzpc.Text.Trim();
            string strQty = this.txtQty.Text.Trim();
            if (strProdno.Length == 0 || strXhtm.Length == 0 || strZZPC.Length == 0 || strQty.Length == 0)
            {
                return;
            }
            strXhtm = strXhtm.Substring(2);
            decimal nQty = decimal.Parse(strQty);
            string strsql = "exec 物料投入 '" + strProdno + "','" + strXhtm + "','" + strZZPC + "',"+nQty+"";

            if (DataClass.Execute(strsql))
            {
                CommonClass.PlaySoundOK();
                this.txtClbh.Text = "";
                this.txtLLPC.Text = "";
                this.txtQty.Text = "";
                this.txtzzpc.Text = "";
               
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "物料投入失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void txtXHTM_TextChanged(object sender, EventArgs e)
        {

        }

    }
}