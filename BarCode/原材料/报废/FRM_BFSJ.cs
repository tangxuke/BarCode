using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.报废
{
    public partial class FRM_BFSJ : Form
    {
        public FRM_BFSJ()
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

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text;
            if (strCWH.Length == 0)
            {
                return;
            }

            if (strCWH.Substring(0, 2) != "H.")
            {
                MessageBox.Show("仓位号不合法！", "系统提示");
                this.txtCWH.Text = "";
                this.txtCWH.Focus();
                return;
            }
            this.txtXTM.Focus();
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
            string strXTM = this.txtXTM.Text;
            if (strXTM.Length == 0)
            {
                return;
            }

            if (strXTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不合法！", "系统提示");
                this.txtXTM.Text = "";
                this.txtXTM.Focus();
                return;
            }
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text;
            string strXTM = this.txtXTM.Text;
            if (strXTM.Length == 0)
            {
                MessageBox.Show("请扫入箱条码！");
                this.txtXTM.Focus();
                return;
            }
            if (strCWH.Length == 0)
            {
                MessageBox.Show("请扫入仓位条码！");
                this.txtCWH.Focus();
                return;
            }
            strCWH = strCWH.Substring(2);
            strXTM = strXTM.Substring(2);

            string strcommand = "exec 报废上架 '" + strXTM + "','" + strCWH + "'";

            bool result = DataClass.Execute(strcommand);
            if (!result)
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                CommonClass.PlaySoundOK();
                this.txtXTM.Text = "";
                this.txtXTM.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_BFSJ_Load(object sender, EventArgs e)
        {
            this.txtCWH.Focus();
        }
    }
}