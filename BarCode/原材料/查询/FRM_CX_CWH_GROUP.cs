using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.查询
{
    public partial class FRM_CX_CWH_GROUP : Form
    {
        public FRM_CX_CWH_GROUP()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string strcwh = this.txtCWH.Text.Trim();
            strcwh = strcwh.Substring(2);
            if (strcwh.Length == 0)
            {
                MessageBox.Show("请扫入仓位号再查询！");
                return;
            }
         
            string strsql = "exec 查询仓位材料信息 '" + strcwh + "'  ";
            DataTable dt = new DataTable();
            dt = DataClass.GetTable(strsql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此仓位号什么都没有！", "系统提示");
                return;
            }

            this.dataGrid1.DataSource = dt;
            this.txtCWH.Focus();
            this.txtCWH.SelectAll();
        }

        

        

       

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnView_Click(null, null);
            }
        }
    }
}