using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.制作标签
{
    public partial class frm_BQ_Split : Form
    {
        public frm_BQ_Split()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOldXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.txtNewXHTM.Focus();
        }

        private void txtNewXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.txtCFSL.Focus();
        }

        private void txtCFSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.btnOK.Focus();
        }

        private void txtOldXHTM_LostFocus(object sender, EventArgs e)
        {
            this.labelCLBH.Text = "";
            this.labelLLPC.Text = "";
            this.labelSL.Text = "";
            this.labelCWH.Text = "";

            string strXHTM = this.txtOldXHTM.Text;
            if (strXHTM.Length == 0)
                return;
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不合法！");
                this.txtOldXHTM.Text = "";
                this.txtOldXHTM.Focus();
                return;
            }

            if (strXHTM.Length == 0)
                return;

            strXHTM = strXHTM.Substring(2);

            this.labelCLBH.Text = CommonClass.GetCLBH(strXHTM);
            this.labelLLPC.Text = CommonClass.GetLLPC(strXHTM);
            this.labelSL.Text = CommonClass.GetXHKC(strXHTM).ToString();
            this.labelCWH.Text = CommonClass.GetCWH(strXHTM);
        }

        private void txtNewXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtNewXHTM.Text;
            if (strXHTM.Length == 0)
                return;
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不合法！");
                this.txtNewXHTM.Text = "";
                this.txtNewXHTM.Focus();
                return;
            }
            strXHTM = strXHTM.Substring(2);

            if (!CommonClass.CheckNewXHTM(strXHTM))
            {
                MessageBox.Show("请使用空白的箱号条码！");
                this.txtNewXHTM.Text = "";
                this.txtNewXHTM.Focus();
            }
            this.txtCFSL.ReadOnly = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strOldXHTM = this.txtOldXHTM.Text;
            if (strOldXHTM.Length == 0)
            {
                MessageBox.Show("请输入旧箱号条码！");
                this.txtOldXHTM.Focus();
                return;
            }

        
            string strNewXHTM = this.txtNewXHTM.Text;
            if (strNewXHTM.Length == 0)
            {
                MessageBox.Show("请输入新箱号条码！");
                this.txtNewXHTM.Focus();
                return;
            }

            strOldXHTM = strOldXHTM.Substring(2);
            strNewXHTM = strNewXHTM.Substring(2);
             
            if (!CommonClass.CheckNewXHTM(strNewXHTM))
            {
                MessageBox.Show("请使用空白的箱号条码！");
                this.txtNewXHTM.Text = "";
                this.txtNewXHTM.Focus();
                return;
            }

            decimal nCFSL = decimal.Parse(this.txtCFSL.Text);
            if (nCFSL <= 0)
            {
                MessageBox.Show("拆分数量应大于零！");
                this.txtCFSL.Text = "";
                this.txtCFSL.Focus();
                return;
            }

            if (nCFSL >= CommonClass.GetXHKC(strOldXHTM))
            {
                MessageBox.Show("拆分数量不应超过原箱数量！");
                this.txtCFSL.Text = "";
                this.txtCFSL.Focus();
                return;
            }

            string commandtext = "exec 箱号拆分 '" + strOldXHTM + "','" + strNewXHTM + "'," + nCFSL.ToString();
            if (!DataClass.Execute(commandtext))
            {
                MessageBox.Show("执行失败！\n" + DataClass.ErrorText);
            }
            else
            {
                MessageBox.Show("执行成功！");
                this.txtOldXHTM.Text = "";
                this.labelCLBH.Text = "";
                this.labelLLPC.Text = "";
                this.labelSL.Text = "";
                this.labelCWH.Text = "";
                this.txtOldXHTM.Focus();
                this.txtNewXHTM.Text = "";
                this.txtCFSL.Text = "";
            }
        }
    }
}