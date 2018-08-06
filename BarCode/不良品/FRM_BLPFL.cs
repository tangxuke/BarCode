using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.BLP
{
    public partial class FRM_BLPFL : Form
    {
        private DataTable datatableFLD;
        private DataTable datatableFLCL;
        private DataTable datatableYQS;

        private string cgy, userid;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="strCGY">仓管员</param>
        /// <param name="date">日期</param>
        /// <param name="klkc">考虑库存</param>
        /// <param name="klyq">考虑余欠</param>
        public FRM_BLPFL( )
        {
            InitializeComponent();
            this.FillFLD();
        }

        private void FillFLD()
        {
            this.cmbFldNO.Items.Clear();
            string selectcmd = "exec 生成不良发料单信息 ";
            datatableFLD = DataClass.GetTable(selectcmd);
            if (datatableFLD.Rows.Count == 0)
            {
                MessageBox.Show("此车间料已发完！", "系统提示");
                this.Close();
                return;
            }
            foreach (DataRow dr in datatableFLD.Rows)
            {
                this.cmbFldNO.Items.Add(dr["发料单号"].ToString().Trim());
            }
            this.cmbFldNO.SelectedIndex = 0;
        }

        private void cmbFldNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillClbh();
        }

        private void FillClbh()
        {
            this.cmbCLBH.Items.Clear();
            string strFldno = this.cmbFldNO.Text.Trim();
            string selectcmd = "exec 生成不良发料材料信息 '" + strFldno + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                this.FillFLD();
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbCLBH.Items.Add(dr["材料编号"].ToString().Trim());
            }
            this.cmbCLBH.SelectedIndex = 0;
            this.txtXHTM.Focus();
        }

        private void cmbCLBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillYQS();
        }

        private void FillYQS()
        {
            string selectcmd = "exec 生成不良发料材料余欠信息 '" + this.cmbFldNO.Text.Trim() + "','" + this.cmbCLBH.Text.Trim() + "'";
            this.datatableYQS = DataClass.GetTable(selectcmd);
            if (datatableYQS.Rows.Count == 0)
            {
                this.FillClbh();
                return;
            }
            //this.txtYqs.Text = datatableYQS.Rows[0]["余欠数"].ToString();
            this.txtCWH.Text = datatableYQS.Rows[0]["仓位号"].ToString();
            //this.txtLLPC.Text = datatableYQS.Rows[0]["来料批次"].ToString();
            //this.txtXHTM.Focus();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }

        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            if (this.CheckXHTM())
            {
                this.btnOK_Click(null, null);
            }
            else
            {
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
            }
        }

        private bool CheckXHTM()
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM == "")
            {
                return true;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("请扫入正确的箱号条码！", "系统提示");
                return false;
            }
            strXHTM = strXHTM.Substring(2);

            string selectcmd = "select * from 仓位库存表_不良品 with(nolock)  where 箱号条码='" + strXHTM + "' ";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("该条码不存在！", "系统提示");
                return false;
            }
            return true;
        }

        private void ClearAll()
        {
            this.cmbCLBH.Items.Clear();
            //this.txtLLPC.Text = "";
            //this.txtYqs.Text = "";
            this.txtCWH.Text = "";
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string xhtm = this.txtXHTM.Text;
            if (xhtm.Length == 0)
                return;
            if (xhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            xhtm = xhtm.Substring(2);
            string fldno = this.cmbFldNO.Text;
            string clbh = this.cmbCLBH.Text;
            //直接上传
            string command = "exec 物料不良发料2 '" + fldno + "','" + xhtm + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXHTM.Text = "";
            this.FillYQS();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

     

       

       
       
    }
}