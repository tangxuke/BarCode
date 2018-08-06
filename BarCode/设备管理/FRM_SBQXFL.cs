using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.设备管理
{
    public partial class FRM_SBQXFL : Form
    {
        public FRM_SBQXFL()
        {
            InitializeComponent();
            this.txtCWH.Focus();
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.SelectAll();
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
            if (strCWH.Length == 0)
            {
                MessageBox.Show("请扫入仓位号！", "系统提示");
                return;
            }
            strCWH = strCWH.Substring(2);
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                MessageBox.Show("请扫入设备条码！", "系统提示");
                return;
            }
            string sqlcommand = "exec 设备取消发料 '" + strCWH + "','" + strXHTM + "'";
            if (DataClass.Execute(sqlcommand))
            {
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("请扫入正确的箱号条码！", "系统提示");
                this.txtCWH.Text = "";
                this.txtCWH.Focus();
            }
        }



   
    }
}