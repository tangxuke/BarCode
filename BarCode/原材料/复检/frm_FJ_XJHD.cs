using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.复检
{
    public partial class frm_FJ_XJHD : Form
    {
        //private string llpc;
        private DataTable table;
        public frm_FJ_XJHD()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh_XJHD();
        }

        /// <summary>
        /// 刷新复检核对信息
        /// </summary>
        private void Refresh_XJHD()
        {
            this.dataGrid1.DataSource = null;
            string selectcmd = "select 复检单号,来料批次,材料编号,箱号条码,数量,来源 from 复检箱号条码  with(nolock) where 已下架=0 order by 来料批次,箱号条码";
            table = DataClass.GetTable(selectcmd);
            table.TableName = "复检核对";
            this.dataGrid1.DataSource = table;
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                string llpc = row["来料批次"].ToString();
                //this.Refresh_CWKC(llpc);
            }
        }

        private void btnXJ_Click(object sender, EventArgs e)
        {
            string str;
            str= this.table.Rows[this.dataGrid1.CurrentRowIndex]["复检单号"].ToString();

            frm_FJ_XJ frm = new frm_FJ_XJ(str);
            frm.ShowDialog();
            this.Refresh_XJHD();
        }

        

        /// <summary>
        /// 刷新仓位库存信息
        /// </summary>
        /// <param name="llpc">来料批次</param>
        //private void Refresh_CWKC(string llpc)
        //{
        //    if (llpc == this.llpc)
        //        return;
        //    this.dataGrid2.DataSource = null;
        //    string selectcmd = "select cwh,箱号条码,数量 from 仓位库存表 where 来料批次='"+llpc+"' order by cwh,箱号条码";
        //    DataTable table = DataClass.GetTable(selectcmd);
        //    table.TableName = "仓位信息";
        //    this.dataGrid2.DataSource = table;
        //    this.llpc = llpc;
        //}

        //private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    DataTable table = (DataTable)this.dataGrid1.DataSource;
        //    if (table.Rows.Count > 0)
        //    {
        //        DataRow row = table.Rows[this.dataGrid1.CurrentCell.RowNumber];
        //        string llpc = row["来料批次"].ToString();
        //        this.Refresh_CWKC(llpc);
        //    }
        //}
    }
}