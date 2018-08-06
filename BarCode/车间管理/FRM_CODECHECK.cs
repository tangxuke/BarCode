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
    public partial class FRM_CODECHECK : Form
    {
        public FRM_CODECHECK()
        {
            InitializeComponent();
        }

        private void txtxhtm_LostFocus(object sender, EventArgs e)
        {
            if (this.txtxhtm.Text.Trim().Length == 0)
            {
                return;
            }
            string sqlcommand = "exec 查询3M条码表2 '"+ this.txtxhtm.Text.Trim() +"' ";
            DataTable dt = DataClass.GetTable(sqlcommand);
            if (dt == null)
            {
                MessageBox.Show("无法查询到条码相关信息", "系统提示");
                this.txtxhtm.SelectAll();
                this.txtxhtm.Focus();
                return;
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("无法查询到条码相关信息", "系统提示");
                this.txtxhtm.SelectAll();
                this.txtxhtm.Focus();
                return;
            }
            this.txtProdno.Text = dt.Rows[0]["生产制令号"].ToString();
            this.txtrq.Text = dt.Rows[0]["生产日期"].ToString();
            this.txtNo.Text = dt.Rows[0]["序列号"].ToString();
            this.txtCPBH.Text = dt.Rows[0]["产品编号"].ToString();
            this.btnOK_Click(null, null);
            
        }

        private void txtxhtm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtxhtm.Text.Trim().Length == 0)
            {
                return;
            }
            string strsql = "exec 条码点检 '" + this.txtxhtm.Text.Trim() + "'";

            if (DataClass.Execute(strsql))
            {
                CommonClass.PlaySoundOK();
                this.txtCPBH.Text = "";
                this.txtNo.Text = "";
                this.txtProdno.Text = "";
                this.txtrq.Text = "";

            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "3M条码点检失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtxhtm.SelectAll();
                this.txtxhtm.Focus();
                return;
            }
            this.txtxhtm.Text = "";
            this.txtxhtm.Focus();
        }

      
    }
}