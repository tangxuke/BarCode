using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.成品管理.尾数管理
{
    public partial class frm_CP_WSRKD : Form
    {
        public frm_CP_WSRKD()
        {
            InitializeComponent();
        }

   

        private void txtCWH_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
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
            string strCWH = this.txtCWH.Text.Trim();
            if (strCWH == "")
            {
                MessageBox.Show("仓位号不能为空！", "系统提示");
                this.txtCWH.Focus();
            }
            string strXHTM = this.txtXHTM.Text.Trim();

            if (strXHTM.Length == 0)
            {
                return;
            }

            string strSql = "select * from 成品尾数条码表 where 箱号条码=" + strXHTM;
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count > 0)
            {
                this.txtCPBH.Text = dt.Rows[0]["产品编号"].ToString();
                this.txtUserID.Text = dt.Rows[0]["车间"].ToString();
                this.txtQty.Text = dt.Rows[0]["数量"].ToString();
            }
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text.Trim();
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strCWH.Length == 0)
            {
                return;
            }
            if (strXHTM.Length == 0)
            {
                return;
            }
            strCWH = strCWH.Substring(2);
            string strsql = "exec 成品尾数入库 '" + strXHTM + "','" + strCWH + "'";

            bool result = DataClass.Execute(strsql);
            if (result)
            {
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtCPBH.Text = "";
                this.txtQty.Text = "";
                this.txtUserID.Text = "";
                this.txtXHTM.Focus();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}