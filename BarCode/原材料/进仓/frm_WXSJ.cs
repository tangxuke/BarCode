using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.进仓
{
    public partial class frm_WXSJ : Form
    {
        public frm_WXSJ()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text;
            if (strCWH.Length == 0)
            {
                return;
            }

            if (strCWH.Substring(0,2) !="H.")
            {
                MessageBox.Show("货架条码不合法！","系统提示");
                this.txtCWH.Text = "";
                this.txtCWH.Focus();
                return;
            }
 
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

            string selectcmd = "exec 外箱上架 '" + strCWH  + "', '" + strXTM + "'";
            bool result = DataClass.Execute(selectcmd);
            if (!result)
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {

                CommonClass.PlaySoundOK();
                this.ClearAll();
            }
        }

    

        /// <summary>
        /// 清空数据
        /// </summary>
        private void ClearAll()
        {
            this.txtXTM.Text = "";
            this.txtXTM.Focus();
        }

     

      
    }
}