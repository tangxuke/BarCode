using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.BLP
{
    public partial class FRM_THQD_CANCEL : Form
    {
        public FRM_THQD_CANCEL()
        {
            InitializeComponent();
            this.txtXHTM.Focus();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtCWH.Focus();
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
           // string strTHDH = this.txtTHDH.Text.Trim();
            //if (strTHDH.Length == 0)
            //{
            //    return;
            //}
            if (strXHTM.Length == 0)
            {
                return;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确!", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            strXHTM = strXHTM.Substring(2);
            //string commandtext = "select * from thqd_detail where thdh='" + strTHDH + "' and  isfinish=0";
            //DataTable dt = DataClass.GetTable(commandtext);
            //if (dt.Rows.Count == 0)
            //{
            //    MessageBox.Show("此条码已退货或是没有发现此条码!", "系统提示");
            //    this.txtXHTM.SelectAll();
            //    this.txtXHTM.Focus();
            //    return;
            //}
            //this.dataGrid1.DataSource = dt;
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text.Trim();

            if (strCWH.Length == 0)
            {
                return;
            }

            if (strCWH.Substring(0, 2) != "H.")
            {
                MessageBox.Show("仓位号不正确!", "系统提示");
                this.txtCWH.SelectAll();
                this.txtCWH.Focus();
                return;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            //string strTHDH = this.txtTHDH.Text.Trim();
            string strCWH = this.txtCWH.Text.Trim();
            //if (strTHDH.Length == 0)
            //{
            //    MessageBox.Show("退货单号不能为空!", "系统提示");
            //    this.txtTHDH.Focus();
            //    return;
            //}
            if (strXHTM.Length == 0)
            {
                MessageBox.Show("箱号条码不能为空!", "系统提示");
                this.txtXHTM.Focus();
                return;
            }
            if (strCWH.Length == 0)
            {
                MessageBox.Show("仓位号不能为空!", "系统提示");
                this.txtCWH.Focus();
                return;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确!", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }

            strXHTM = strXHTM.Substring(2);
            strCWH = strCWH.Substring(2);
            string commandtext = "exec 物料退货取消 '" + strXHTM + "' ,'" + strCWH + "'";

            if (DataClass.Execute(commandtext))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "退货失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        
    }
}