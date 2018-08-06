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
    public partial class frm_FL_LXFL : Form
    {
        public frm_FL_LXFL()
        {
            InitializeComponent();
            this.RefreshWhid();
             
        }

        private void RefreshCGY()
        {
            this.comboCGY.Items.Clear();
            string strWhid = this.cmbwhid.Text.Trim();
            if (strWhid.Length == 0)
            {
                return;
            }
            string selectcmd = "exec 生成发料仓管员信息2 '"+ strWhid  +"'";
            DataTable table = DataClass.GetTable(selectcmd);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                this.comboCGY.Items.Add(table.Rows[i][0]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKSFL_Click(object sender, EventArgs e)
        {
            if (this.comboCGY.Text.Length == 0)
            {
                MessageBox.Show("请先选择发料仓管！");
                return;
            }
            frm_FL_LXFL_Detail frm = new frm_FL_LXFL_Detail(this.cmbwhid.Text,this.comboCGY.Text, this.cmbUserID.Text.Trim());
            frm.Show();
        }


        private void RefreshUserID(string cgy)
        {
            this.cmbUserID.Items.Clear();
            string strWhid = this.cmbwhid.Text.Trim();
            if (strWhid.Length == 0)
            {
                return;
            }
            string sqlcmd;
            sqlcmd = "exec 生成发料车间信息2 '" + strWhid + "', '" + cgy + "'";
            DataTable dt = new DataTable();
            dt = DataClass.GetTable(sqlcmd);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.cmbUserID.Items.Add(dt.Rows[i]["ylbm"]);
            }
        }

        private void RefreshWhid()
        {
            this.cmbwhid.Items.Clear();
            string selectcmd = "select name from fzzl where code='whid' order by id";
            DataTable table = DataClass.GetTable(selectcmd);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                this.cmbwhid.Items.Add(table.Rows[i][0]);
            }
        }

        private void comboCGY_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshUserID(this.comboCGY.Text);
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbwhid_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshCGY();
        }
    }
}