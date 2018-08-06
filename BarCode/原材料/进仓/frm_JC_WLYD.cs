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
    public partial class frm_JC_WLYD : Form
    {
        public frm_JC_WLYD()
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

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXTM.Focus();
            }
        }

        private void txtXTM_LostFocus(object sender, EventArgs e)
        {
            this.btnOK.Enabled = false ;
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
            strXTM = strXTM.Substring(2, strXTM.Length - 2);
            this.btnOK.Enabled = true;

            string strOldCWH = DataClass.GetValue("select dbo.查询旧仓位号('" + strXTM  + "')").ToString();
            if (strOldCWH.Length !=0)
            {
                this.labelYCWH.Text = "原仓位："+strOldCWH;
            }
            this.btnOK_Click(null, null);
        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            this.btnOK.Enabled = false;
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
            this.btnOK.Enabled = true;
            this.txtXTM.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text;
            string strXTM = this.txtXTM.Text;
            strCWH = strCWH.Substring(2, strCWH.Length - 2);
            strXTM = strXTM.Substring(2, strXTM.Length - 2);
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

            string commandtext = "exec 物料移动 '" + strXTM + "','" + strCWH + "'";
            if (!DataClass.Execute(commandtext))
            {
                MessageBox.Show("物料移位失败！\n" + DataClass.ErrorText);
            }
            else
            {
                //MessageBox.Show("更新数据成功！");
                CommonClass.PlaySoundOK();
                this.txtXTM.Text = "";
                this.labelYCWH.Text = "";
                this.txtXTM.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_WLYD_Load(object sender, EventArgs e)
        {
            this.txtCWH.Focus();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}