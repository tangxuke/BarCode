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
    public partial class frm_CX_CWH : Form
    {
        public frm_CX_CWH(string cwh)
        {
            InitializeComponent();
            this.txtCWH.Text = cwh;
        }

        public frm_CX_CWH()
        {
            InitializeComponent();
      
        }

        private void frm_CX_CWH_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string strcwh = this.txtCWH.Text.Trim();
            if (strcwh.Length == 0)
            {
                MessageBox.Show("请扫入仓位号再查询！");
                return;
            }
            strcwh = strcwh.Substring(2);
            string strsql = "select 箱号条码,材料编号,来料批次,数量,dbo.get_clsjkc(材料编号,'dgwp') as EDP库存 from  仓位库存表 with(nolock)  where 仓位号='" + strcwh + "' ORDER BY 材料编号,来料批次";
            DataTable dt = new DataTable();
            dt = DataClass.GetTable(strsql);

            this.dataGrid1.DataSource = dt;
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void txtCWH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}