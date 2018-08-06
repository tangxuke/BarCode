using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.不良品
{
    public partial class frm_BLPRK : Form
    {
        public frm_BLPRK()
        {
            InitializeComponent();
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

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXTM.SelectAll();
                this.txtXTM.Focus();
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
                MessageBox.Show("仓位号不正确！");
                this.txtCWH.SelectAll();
                this.txtCWH.Focus();
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            strCWH = strCWH.Substring(2);
            strXTM = strXTM.Substring(2);

            if (strCWH.Length == 0)
            {
                MessageBox.Show("请扫入仓位条码！");
                this.txtCWH.Focus();
                return;
            }
            if (strXTM.Length == 0)
            {
                MessageBox.Show("请扫入箱条码！");
                this.txtXTM.Focus();
                return;
            }

            string commandtext = "exec 物料不良品入库 '" + strCWH + "','" + strXTM  + "'";
            bool result = DataClass.Execute(commandtext);
            if (!result)
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            CommonClass.PlaySoundOK();
            this.txtXTM.Text = "";
            this.txtXTM.Focus();
        }

        private void frm_BLPRK_Load(object sender, EventArgs e)
        {
            this.txtCWH.Focus();
        }

      
      
    }
}