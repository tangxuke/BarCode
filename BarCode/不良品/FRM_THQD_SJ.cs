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
    public partial class FRM_THQD_SJ : Form
    {
        public FRM_THQD_SJ()
        {
            InitializeComponent();
        }

     

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text.Trim();
            if (strCWH == "")
            {
                return;
            }
            if (strCWH.Substring(0,2) != "H.")
            {
                MessageBox.Show("仓位号不正确！", "系统提示");
                return;
            }
            this.btnOK_Click(null, null);
        }


        private void txtTHDH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtCWH.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text.Trim();
            string strTHQD = this.txtTHDH.Text.Trim();
            if (strCWH == "")
            {
                return;
            }

            strCWH = strCWH.Substring(2);
            string command = "exec 退货清单上架 '" + strTHQD + "','" + strCWH + "'";

            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "退货失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtCWH.Text = "";
            this.txtTHDH.Text = "";

        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK_Click(null, null);
            }
        }
    }
}