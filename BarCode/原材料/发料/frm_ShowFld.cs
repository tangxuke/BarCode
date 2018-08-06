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
    public partial class frm_ShowFld : Form
    {
        public frm_ShowFld(string fld)
        {
            InitializeComponent();
            this.txtFldNo.Text = fld;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string strFld = this.txtFldNo.Text;
            if (strFld == "")
            {
                return;
            }

            string sqlcmd = "select 材料编号,来料批次,箱号条码,发料数量 from 发料箱号明细  with(nolock) where 发料单号='" + strFld + "' order by 材料编号,来料批次,箱号条码";
            DataTable dt = DataClass.GetTable(sqlcmd);
            this.dataGrid1.DataSource = dt;
        }
    }
}