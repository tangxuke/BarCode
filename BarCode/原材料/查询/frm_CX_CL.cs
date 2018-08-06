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
    public partial class frm_CX_CL : Form
    {
        public frm_CX_CL()
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

            this.ConvertClbh();
            this.txtCLBH.SelectAll();
            this.txtCLBH.Focus();
            this.labelCLKC.Text = "";
            this.lblTMQty.Text = "";
            this.dataGrid1.DataSource = null;
            string strCLBH = this.txtCLBH.Text;
            if (strCLBH.Length == 0)
            {
                return;
            }
            string selectcmd = "select clmc as 材料名称,dbo.get_clsjkc(clbh,'dgwp') as 材料库存,(select sum(sssl-sfsl) from pckc_ym with(nolock)  where clbh=m_clzd.clbh) as 批次库存 from m_clzd  with(nolock) where clbh='" + strCLBH + "'";
            DataTable table1 = DataClass.GetTable(selectcmd);
            
            if (table1.Rows.Count > 0)
            {
                this.labelCLKC.Text = table1.Rows[0]["材料库存"].ToString();
                this.labelCLMC.Text = table1.Rows[0]["材料名称"].ToString();
            }
            else
            {
                MessageBox.Show("材料不存在！");
                return;
            }
            selectcmd = "select 箱号条码,仓位号,来料批次,数量 from 仓位库存表 with(nolock)  where 材料编号='" + strCLBH + "' and 数量>0 AND (dbo.查询仓位类型(仓位号) in('原材料','待检区') or 箱号条码 in (select 箱号条码 from  edp未确认条码 with(nolock) )) order by 仓位号,来料批次 ";
            DataTable table2 = DataClass.GetTable(selectcmd);
            table2.TableName = "仓位明细";
            this.dataGrid1.DataSource = table2;
            this.Text = "材料查询 - " + strCLBH;
            this.lblTMQty.Text="共"+table2.Rows.Count.ToString()+"箱";
        }

        private void ConvertClbh()
        {
            string strClbh = this.txtCLBH.Text.Trim();
            if (strClbh.Substring(0, 2) == "M.")
            {
                strClbh = strClbh.Substring(2);
                string sqlstr = "select 材料编号 from 仓位库存表 with(nolock)  where 箱号条码='" + strClbh + "'";
                DataTable dt = DataClass.GetTable(sqlstr);
                if (dt.Rows.Count>0)
                {
                    this.txtCLBH.Text = dt.Rows[0]["材料编号"].ToString();
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

       
    }
}