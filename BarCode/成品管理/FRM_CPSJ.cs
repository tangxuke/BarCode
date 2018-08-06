using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.成品管理
{
    public partial class FRM_CPSJ : Form
    {
        public FRM_CPSJ()
        {
            InitializeComponent();
            this.txtCWH.Focus();
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter)
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
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text.Trim();
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strCWH.Length < 2 || strXHTM.Length == 0)
            {
                return;
            }
            strCWH = strCWH.Substring(2);
            string sqlcommand = "exec 成品上架 '" + strCWH + "','" + strXHTM + "'";
            if (DataClass.Execute(sqlcommand))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "成品上架失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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