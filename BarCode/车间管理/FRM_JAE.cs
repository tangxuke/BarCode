using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.车间管理
{
    public partial class FRM_JAE : Form
    {
        public FRM_JAE()
        {
            InitializeComponent();
        }

        private void FRM_JAE_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strbillno = this.txtBarcodeno.Text.Trim();
            if (strbillno.Length == 0)
            {
                return;
            }
            if (strbillno.Length != 36)
            {
                CommonClass.PlaySoundNG();
                MessageBox.Show("扫入的条码长度不是36位长，请检查标签！", "系统提示");
                this.txtBarcodeno.SelectAll();
                this.txtBarcodeno.Focus();
                return;
            }
            CommonClass.PlaySoundOK();
            this.txtBarcodeno.SelectAll();
            this.txtBarcodeno.Focus();
        }

        private void txtBarcodeno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnClose.Focus();
            }
        }

        private void txtBarcodeno_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }
    }
}