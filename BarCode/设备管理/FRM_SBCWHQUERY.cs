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
    public partial class FRM_SBCWHQUERY : Form
    {
        public FRM_SBCWHQUERY()
        {
            InitializeComponent();
        }

    

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text.Trim();
            if (strCWH.Length == 0)
            {
                return;
            }
            strCWH = strCWH.Substring(2);
            string sqlcommand = "select  资产编号,设备名称  from   设备资产字典 where 仓位号='" + strCWH + "' order by 资产编号";
            DataTable dt = DataClass.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此仓位号中一台设备也没有！", "系统提示");
                this.dataGrid1.DataSource = null;
                return;
            }
            else
            {
                this.lblInfo.Text = "共有"+ dt.Rows.Count.ToString() +"台设备";
                this.dataGrid1.DataSource = dt;
                CommonClass.PlaySoundOK();
               // this.txtCWH.Focus();
                //this.txtCWH.SelectAll();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}