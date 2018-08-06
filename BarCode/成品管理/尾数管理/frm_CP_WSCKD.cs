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
    public partial class frm_CP_WSCKD : Form
    {
        public frm_CP_WSCKD()
        {
            InitializeComponent();
        }

        private void txtPldno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
        }

        private void txtPldno_LostFocus(object sender, EventArgs e)
        {
            this.setInfo();
        }

        private void setInfo()
        {
            string strPldno = this.txtPldno.Text.Trim();
            if (strPldno.Length == 0)
            {
                return;
            }
            string sqlStr = "select * from 成品尾数库存表 with(nolock)  where 产品编号=(select cpbh from pld_index with(nolock)  where pldno='" + strPldno + "') and 仓位类型='完成品' and 禁止发料=0";
            DataTable dt = DataClass.GetTable(sqlStr);
            if (dt.Rows.Count > 0)
            {
                this.lblInfo.Text = "还有[" + dt.Rows.Count.ToString() + "]箱可以发料";
                this.lblCWH.Text = dt.Rows[0]["仓位号"].ToString();
            }
            else
            {
                this.lblInfo.Text = "还有[XXX]箱可以发料";
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
            string strPldno = this.txtPldno.Text.Trim();
            if (strPldno == "")
            {
                MessageBox.Show("仓位号不能为空！", "系统提示");
                this.txtPldno.Focus();
            }
            string strXHTM = this.txtXHTM.Text.Trim();

            if (strXHTM.Length == 0)
            {
                return;
            }

            string strSql = "select * from 成品尾数库存表 with(nolock)  where 箱号条码=" + strXHTM;
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count > 0)
            {
                this.txtCPBH.Text = dt.Rows[0]["产品编号"].ToString();
                this.txtCWH.Text = dt.Rows[0]["仓位号"].ToString();
                this.txtQty.Text = dt.Rows[0]["数量"].ToString();
            }
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strPldno = this.txtPldno.Text.Trim();
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strPldno.Length == 0)
            {
                return;
            }
            if (strXHTM.Length == 0)
            {
                return;
            }

            string strsql = "exec 成品尾数出库 '" + strPldno + "','" + strXHTM + "'";

            bool result = DataClass.Execute(strsql);
            if (result)
            {
                CommonClass.PlaySoundOK();
                this.txtPldno.Text = "";
                this.txtXHTM.Text = "";
                this.txtCPBH.Text = "";
                this.txtCWH.Text = "";
                this.txtQty.Text = "";
                this.txtPldno.Focus();
                this.lblCWH.Text = "";
                this.lblInfo.Text = "";
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