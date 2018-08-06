using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.发料
{
    public partial class FRM_YBWP_CANCEL : Form
    {
        public FRM_YBWP_CANCEL()
        {
            InitializeComponent();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            string strCWH = this.txtCWH.Text.Trim();
            if (strXHTM == "")
            {
                return;
            }
            if (strCWH == "")
            {
                return;
            }
            strXHTM = strXHTM.Substring(2);
            strCWH = strCWH.Substring(2);
     
            //直接上传
            string command = "exec 一般物品发料取消  '" + strXHTM + "','" + strCWH + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();

            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            this.txtXHTM.Text = "";
        }

        private void FRM_YBWP_CANCEL_Load(object sender, EventArgs e)
        {
            this.txtCWH.Focus();
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
            string strxhtm = this.txtXHTM.Text.Trim();
            if (strxhtm == "")
            {
                return;
            }
            this.btnOK_Click(null, null);
        }

        

        
    }
}