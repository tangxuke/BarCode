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
    public partial class frm_ShowPld : Form
    {
        public frm_ShowPld(string pld)
        {
            InitializeComponent();
            this.txtPldNo.Text = pld;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string strPld = this.txtPldNo.Text;
            if (strPld == "")
            {
                return;
            }

            string sqlcmd = "select 材料编号,来料批次,箱号条码,发料数量 from 配料箱号明细 where 配料单号='" + strPld + "' order by 材料编号,来料批次,箱号条码";
            DataTable dt = DataClass.GetTable(sqlcmd);
            this.dataGrid1.DataSource = dt;
        }
    }
}