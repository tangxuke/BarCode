using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.报废
{
    public partial class frm_BFCANCEL : Form
    {
        public frm_BFCANCEL()
        {
            InitializeComponent();
        }

        private void frm_BFCANCEL_Load(object sender, EventArgs e)
        {
             
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text.Trim();
            if (strCWH.Substring(0, 2) != "H.")
            {
                MessageBox.Show("仓位号不正确!", "系统提示");
                this.txtCWH.SelectAll();
                this.txtCWH.Focus();
                return;
            }
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确!", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            strXHTM = strXHTM.Substring(2);
            string commandtext = "select * from 仓位库存表 with(nolock)  where 箱号条码='" + strXHTM + "' and  dbo.查询仓位类型(仓位号)='报废品'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此条码不正确，仓位类型必需要是报废品!", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            this.txtCLBH.Text = dt.Rows[0]["材料编号"].ToString();
            this.txtLLPC.Text = dt.Rows[0]["来料批次"].ToString();
            this.txtQTY.Text = dt.Rows[0]["数量"].ToString();
            
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text.Trim();
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            strCWH = strCWH.Substring(2);
            strXHTM = strXHTM.Substring(2);

            string strsql = "exec 物料报废取消 '" + strCWH + "','" + strXHTM + "'";
            if (DataClass.Execute(strsql))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "报废取消失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXHTM.Text = "";
            this.txtCLBH.Text = "";
            this.txtLLPC.Text = "";
            this.txtQTY.Text = "";
            
            this.txtXHTM.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
 






    }
}