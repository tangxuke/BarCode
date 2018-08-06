using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.BLP
{
    public partial class FRM_BLPSJ : Form
    {
        public FRM_BLPSJ()
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
                MessageBox.Show("仓位号不正确!", "系统提示");
                this.txtCWH.SelectAll();
                this.txtCWH.Focus();
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确!", "系统提示");
                this.txtXHTM.Focus();
                return;
            }
            strXHTM = strXHTM.Substring(2);
            string commandtext = "select * from 仓位库存表  with(nolock) where 箱号条码='" + strXHTM + "'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
              
                    MessageBox.Show("此条码不存在!", "系统提示");
                    return;
             
            }
            this.txtCLBH.Text = dt.Rows[0]["材料编号"].ToString();
            this.txtLLPC.Text = dt.Rows[0]["来料批次"].ToString();
            this.txtQty.Text = dt.Rows[0]["数量"].ToString();
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            string strCWH = this.txtCWH.Text.Trim();
            if (strCWH.Length == 0)
            {
                MessageBox.Show("请扫入仓位条码！");
                this.txtCWH.Focus();
                return;
            }
            if (strXHTM.Length == 0)
            {
                MessageBox.Show("请扫入箱条码！");
                this.txtXHTM.Focus();
                return;
            }

            strXHTM = strXHTM.Substring(2);
            strCWH = strCWH.Substring(2);
            string commandtext = "exec 不良品上架 '" + strXHTM + "','" + strCWH + "'";
            bool result = DataClass.Execute(commandtext);
            if (!result)
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            CommonClass.PlaySoundOK();
            this.txtXHTM.Text = "";
            this.txtLLPC.Text = "";
            this.txtCLBH.Text = "";
            this.txtQty.Text = "";
  
            this.txtXHTM.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void btnBCP_Click(object sender, EventArgs e)
        {
            FRM_BLPBCPSJ frm = new FRM_BLPBCPSJ();
            frm.Show();
        }

        private void FRM_BLPSJ_Load(object sender, EventArgs e)
        {
            this.txtCWH.Focus();
        }
    }
}