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
    public partial class frm_CX_PC : Form
    {
        public frm_CX_PC()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCLBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.RefreshData();
            }
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void RefreshData()
        {
            this.ConvertLlpc();
            this.txtCLBH.SelectAll();
            this.txtCLBH.Focus();
            this.labelCLBH.Text = "";
            this.labelStock.Text = "";
    
            this.labelCLBH.Text = "";
            this.dataGrid1.DataSource = null;
            string strLLPC = this.txtCLBH.Text;
            if (strLLPC.Length == 0)
            {
                return;
            }
            string selectcmd = "select 箱号条码,仓位号,材料编号,来料批次,数量,dbo.get_clsjkc(材料编号,'dgwp') as edpstock from 仓位库存表 where 来料批次='" + strLLPC + "' and 数量>0 AND (dbo.查询仓位类型(仓位号) in('原材料','待检区') or 箱号条码 in (select 箱号条码 from  edp未确认条码)) order by 仓位号,来料批次 ";
            DataTable table2 = DataClass.GetTable(selectcmd);
            if (table2.Rows.Count > 0)
            {
                this.labelCLBH.Text = table2.Rows[0]["材料编号"].ToString();
                this.labelStock.Text = table2.Rows[0]["edpStock"].ToString();
                //this.lblInfo.Text = "共" + table2.Rows.Count.ToString() + "箱";
            }
            else
            {
                MessageBox.Show("批次不存在！");
                return;
            }
            table2.TableName = "仓位明细";
            this.dataGrid1.DataSource = table2;
            this.Text = "批次查询 - " + strLLPC;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void ConvertLlpc()
        {
            string strClbh = this.txtCLBH.Text.Trim();
            if (strClbh.Substring(0, 2) == "M.")
            {
                strClbh = strClbh.Substring(2);
                string sqlstr = "select 来料批次 from 仓位库存表 where 箱号条码='" + strClbh + "'";
                DataTable dt = DataClass.GetTable(sqlstr);
                if (dt.Rows.Count > 0)
                {
                    this.txtCLBH.Text = dt.Rows[0]["来料批次"].ToString();
                }
            }
        }

   
    }
}