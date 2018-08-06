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
    public partial class FRM_BLP_QUERY : Form
    {
        public FRM_BLP_QUERY()
        {
            InitializeComponent();
        }

        private void rdCWH_Click(object sender, EventArgs e)
        {
            this.rdClbh.Checked = false;
            this.txtQuery.Text = "";
            this.txtQuery.Focus();
        }

        private void rdClbh_Click(object sender, EventArgs e)
        {
            this.rdCWH.Checked = false;
            this.txtQuery.Text = "";
            this.txtQuery.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strQuery = this.txtQuery.Text.Trim();
            string strcommand="";
            DataTable dt = new DataTable();
            if (strQuery.Length == 0)
            {
                return;
            }
            if (this.rdCWH.Checked)
            {
                strQuery = strQuery.Substring(2);
                strcommand = "exec 不良品查询_仓位号 '" + strQuery + "' ";
            }
            else
            {

                strcommand = "exec 不良品查询_材料 '" + strQuery + "' ";
            }
            dt = DataClass.GetTable(strcommand);
            if (dt.Rows.Count == 0)
            {
                this.txtQuery.SelectAll();
                this.txtQuery.Focus();
                return;
            }

            this.dataGrid1.DataSource = dt;
            this.txtQuery.SelectAll();
            this.txtQuery.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_BLP_QUERY_Load(object sender, EventArgs e)
        {
            this.txtQuery.Focus();
        }


        private void ConvertClbh()
        {
            string strClbh = this.txtQuery.Text.Trim();
            if (strClbh.Substring(0, 2) == "M.")
            {
                strClbh = strClbh.Substring(2);
                string sqlstr = "select 材料编号 from 仓位库存表 where 箱号条码='" + strClbh + "'";
                DataTable dt = DataClass.GetTable(sqlstr);
                if (dt.Rows.Count > 0)
                {
                    this.txtQuery.Text = dt.Rows[0]["材料编号"].ToString();
                }
            }
        }

        private void txtQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ConvertClbh();
            }
        }
       
    }
}