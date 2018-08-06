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
    public partial class frm_CX_Detail : Form
    {
        public frm_CX_Detail(string clbh)
        {
            InitializeComponent();
            this.txtClbh.Text = clbh;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strClbh = this.txtClbh.Text.Trim();
            if (strClbh == "")
            {
                return;
            }
            string selectcmd = "select 材料编号,(select clmc from m_clzd   with(nolock) where clbh=仓位库存表.材料编号) as 材料名称,来料批次,仓位号,数量 from 仓位库存表 with(nolock)  where 材料编号='" + strClbh + "' and (dbo.查询仓位类型(仓位号)='原材料' or 仓位号='检验区') order by dbo.查询仓位类型(仓位号),仓位号";
            DataTable table1 = DataClass.GetTable(selectcmd);
            if (table1.Rows.Count == 0)
            {
                MessageBox.Show("没有找到数据！");
                return;
            }

            this.dataGrid1.DataSource = table1;
            this.lblXS.Text = "共" + table1.Rows.Count.ToString() + "箱";
        }
    }
}