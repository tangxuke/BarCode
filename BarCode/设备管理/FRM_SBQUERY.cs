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
    public partial class FRM_SBQUERY : Form
    {
        public FRM_SBQUERY()
        {
            InitializeComponent();
        }

        private void txtSBNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtSBNO_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strSBNO = this.txtSBNO.Text.Trim();
            if (strSBNO.Length == 0)
            {
                return;
            }
            string sqlcommand = "select * from   设备资产字典 with(nolock)  where 资产编号='" + strSBNO + "'";
            DataTable dt =DataClass.GetTable(sqlcommand);
            if (dt.Rows.Count==0)
            {
                MessageBox.Show("此设备在设备资产字典中找不到！", "系统提示");
                this.txtName.Text = "";
                this.txtGGXH.Text = "";
                this.txtPlace.Text = "";
                this.txtCWH.Text = "";
                this.txtSBNO.Focus();
                this.txtSBNO.SelectAll();
                return;
            }
            else
            {
                this.txtName.Text = dt.Rows[0]["设备名称"].ToString();
                this.txtGGXH.Text = dt.Rows[0]["规格型号"].ToString();
                this.txtPlace.Text = dt.Rows[0]["位置"].ToString();
                this.txtCWH.Text = dt.Rows[0]["仓位号"].ToString();
                CommonClass.PlaySoundOK();
                //this.txtSBNO.Focus();
                //this.txtSBNO.SelectAll();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}