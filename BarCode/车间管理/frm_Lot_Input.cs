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
    public partial class frm_Lot_Input : Form
    {
        private string cUserId;

        public frm_Lot_Input(string cUserID)
        {
            InitializeComponent();
            this.Text = "物料投入 - " + cUserID;
            this.cUserId = cUserID;
        }

        private void frm_Lot_Input_Load(object sender, EventArgs e)
        {
            this.FillCPBH();
        }

        private void FillCPBH()
        {
            string selectcmd = "exec 查询生产制令产品 '" + this.cUserId + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("请先建立生产制令单！", "系统提示");
                return;
            }
            else
            {
                this.cmbCPBH.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    this.cmbCPBH.Items.Add(dr["CPBH"].ToString());
                }
            }
            this.cmbCPBH.SelectedIndex = 0;
        }

        private void cmbCPBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillProd();
        }

        private void FillProd()
        {
            string _cpbh = this.cmbCPBH.Text.Trim();
            string selectcmd = "exec 查询生产制令单 '" + this.cUserId + "','" + _cpbh + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("请先建立生产制令单！", "系统提示");
                return;
            }
            else
            {
                this.cmbProdNo.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    this.cmbProdNo.Items.Add(dr["PRODNO"].ToString());
                }
            }
            this.cmbProdNo.SelectedIndex = 0;
        }

        private void cmbProdNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillKLH();
            this.FillCLBH();
        }

        private void FillKLH()
        {
            string _prodno = this.cmbProdNo.Text.Trim();
            string selectcmd = "select isnull(开拉号,'') as 开拉号 from pdlots where prodno ='" + _prodno + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("请先建立生产制令单！", "系统提示");
                return;
            }
            else
            {
                this.txtKLH.Text = dt.Rows[0]["开拉号"].ToString();
            }


        }

        private void FillCLBH()
        {
            string _KLH = this.txtKLH.Text.Trim();
            string selectcmd = "select 材料编号 from 开拉明细表 where 开拉号= '" + _KLH + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("请先建立生产制令单！", "系统提示");
                return;
            }
            else
            {
                this.cmbCLBH.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    this.cmbCLBH.Items.Add(dr["材料编号"].ToString());
                }
            }
            this.cmbCLBH.SelectedIndex = 0;
        }

        private void cmbCLBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillZZPC();
        }

        private void FillZZPC()
        {
            string _clbh = this.cmbCLBH.Text.Trim();

            string selectcmd = "exec 查询生产制令制造批次'" + this.cUserId + "','" + _clbh + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("该材料还没有制造批次在车间！", "系统提示"); 
                this.txtZZPC.Text = "";
                this.txtCWH.Text = "";

                return;
            }
            this.txtZZPC.Text = dt.Rows[0]["制造批次"].ToString();
            this.txtCWH.Text=dt.Rows[0]["仓位号"].ToString();
            this.txtXHTM.Focus();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtQty.Focus();
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string _xhtm = this.txtXHTM.Text.Trim();
            if (_xhtm.Length==0)
            {
                return ;
            }
            _xhtm=_xhtm.Substring(2);
            string _zzpc = this.txtZZPC.Text.Trim();
            string selectcmd = "exec 查询生产制令条码信息'" + _xhtm + "','" + _zzpc + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("扫入条码不正确！", "系统提示");
                this.btnIn.Focus();
                //this.txtXHTM.SelectAll();
                //this.txtXHTM.Focus();
                return;
            }
            if (dt.Rows[0]["制造批次"].ToString() != this.txtZZPC.Text.Trim())
            {
                MessageBox.Show("请按制造批次投料！", "系统提示");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            this.txtQty.Text = dt.Rows[0]["可投入数量"].ToString();
            this.txtQty.SelectAll();
            this.txtQty.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string _prodno = this.cmbProdNo.Text.Trim();
            string _xhtm = this.txtXHTM.Text.Trim();
            if (_xhtm.Length == 0)
            {
                return;
            }
            _xhtm = _xhtm.Substring(2);
            string _qty = this.txtQty.Text.Trim();
            string strsql = "exec 物料投入2 '" + _prodno + "','" + _xhtm + "'," + _qty + "";

            if (DataClass.Execute(strsql))
            {
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtQty.Text = "";
                this.FillZZPC();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseZZPC_Click(object sender, EventArgs e)
        {
            string zzpc = this.txtZZPC.Text.Trim();
            string strsql = "exec 条码_车间_关闭箱号条码 '" + this.cUserId + "','" + zzpc + "'";

            if (DataClass.Execute(strsql))
            {
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtQty.Text = "";
                this.FillZZPC();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "关闭箱号条码失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string _xhtm = this.txtXHTM.Text.Trim() ;
            if (_xhtm.Length == 0)
                return;
            if (_xhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            _xhtm = _xhtm.Substring(2);

            //直接上传
            string command = "exec 车间条码盘点 '" + _xhtm + "','" + this.cUserId + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
                this.FillZZPC();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "条码纳入失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXHTM.SelectAll();
            this.txtXHTM.Focus();
        }

        private void txtXHTM_TextChanged(object sender, EventArgs e)
        {

        }



    }

       



}