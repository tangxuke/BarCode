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
    public partial class frm_CP_MOVE : Form
    {
        public frm_CP_MOVE()
        {
            InitializeComponent();
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
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
                MessageBox.Show("货架条码不合法！", "系统提示");
                this.txtCWH.Text = "";
                this.txtCWH.Focus();
                return;
            }
            this.txtXHTM.Focus();
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
            string strXTM = this.txtXHTM.Text;
            if (strXTM.Length == 0)
            {
                return;
            }

            if (strXTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不合法！", "系统提示");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            strXTM = strXTM.Substring(2);
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text;
            string strXTM = this.txtXHTM.Text;
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
                this.txtXHTM.Focus();
                return;
            }

            string commandtext = "exec 成品移动 '" + strXTM + "','" + strCWH + "'";
            if (!DataClass.Execute(commandtext))
            {
                MessageBox.Show("成品移位失败！\n" + DataClass.ErrorText);
            }
            else
            {
                //MessageBox.Show("更新数据成功！");
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}