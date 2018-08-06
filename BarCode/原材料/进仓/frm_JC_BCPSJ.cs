using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.进仓
{
    public partial class frm_JC_BCPSJ : Form
    {
        public frm_JC_BCPSJ()
        {
            InitializeComponent();
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXTM.Focus();
            }
        }

        private void txtXTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtXTM_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text;
            string strXTM = this.txtXTM.Text;
            if (strXTM.Length == 0)
            {
                return;
            }

            if (strCWH.Length == 0)
            {
                return;
            }
            strCWH = strCWH.Substring(2);
            strXTM = strXTM.Substring(2);

            string selectcmd = "exec 半成品上架2 '" + strCWH + "', '" + strXTM + "'";

            bool result = DataClass.Execute(selectcmd);
            if (!result)
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXTM.Text = "";
                this.txtXTM.Focus();
            }
            else
            {
                CommonClass.PlaySoundOK();
            }
            this.txtXTM.Text = "";
            this.txtXTM.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}