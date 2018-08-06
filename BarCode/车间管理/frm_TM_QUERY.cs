using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.车间管理
{
    public partial class frm_TM_QUERY : Form
    {
        public frm_TM_QUERY()
        {
            InitializeComponent();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK_Click(null, null);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text;
            this.txtXHTM.SelectAll();
            this.txtXHTM.Focus();

            this.txtClbh.Text = "";
            this.txtCLMC.Text = "";
            this.txtLLPC.Text = "";
            this.txtQty.Text = "";

            if (strXHTM.Length == 0)
                return;
            strXHTM = strXHTM.Substring(2);
            string selectcmd = "select *,(select clmc from m_clzd with(nolock)  where clbh=仓位库存表_车间.材料编号) as 材料名称 from 仓位库存表_车间  with(nolock) where 箱号条码='" + strXHTM + "'";
            DataTable table1 = DataClass.GetTable(selectcmd);
            if (table1.Rows.Count == 0)
            {
                MessageBox.Show("箱号不存在！");
                return;
            }
            DataRow row = table1.Rows[0];
            this.txtClbh.Text = row["材料编号"].ToString();
            this.txtCLMC.Text = row["材料名称"].ToString();
            this.txtLLPC.Text = row["来料批次"].ToString();
            this.txtQty.Text = row["数量"].ToString();
 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}