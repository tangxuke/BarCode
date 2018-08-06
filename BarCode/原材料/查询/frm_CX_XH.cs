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
    public partial class frm_CX_XH : Form
    {
        public frm_CX_XH()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshData()
        {
            string strXHTM = this.txtXHTM.Text;
            this.labelCLBH.Text = "";
            this.labelCLMC.Text = "";
            this.labelLLPC.Text = "";
            this.labelCFWZ.Text = "";
            this.labelKCSL.Text = "";
         
            if (strXHTM.Length == 0)
                return;
            strXHTM = strXHTM.Substring(2);
            string selectcmd = "select 材料编号,(select clmc from m_clzd with(nolock)  where clbh=仓位库存表.材料编号) as 材料名称,来料批次,仓位号,数量,dbo.get_clsjkc(材料编号,'dgwp') as 材料总库存 from 仓位库存表 with(nolock)  where 箱号条码='" + strXHTM + "'";
            DataTable table1 = DataClass.GetTable(selectcmd);
            if (table1.Rows.Count == 0)
            {
                MessageBox.Show("箱号不存在！");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            DataRow row = table1.Rows[0];
            this.labelCLBH.Text = row["材料编号"].ToString();
            this.labelCLMC.Text = row["材料名称"].ToString();
            this.labelLLPC.Text = row["来料批次"].ToString();
            this.labelCFWZ.Text = row["仓位号"].ToString();
            string strCWLX = (string)DataClass.GetValue("select dbo.查询仓位类型('" + row["仓位号"].ToString() + "')");
            this.labelCFWZ.Text += " " + strCWLX;
            this.labelKCSL.Text = row["数量"].ToString();
            this.lblStock.Text = row["材料总库存"].ToString();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frm_CX_Detail frm = new frm_CX_Detail(this.labelCLBH.Text.Trim());
            frm.Show();
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }
    }
}