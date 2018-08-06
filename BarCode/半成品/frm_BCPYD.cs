using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.BCP
{
    public partial class frm_BCPYD : Form
    {
        public frm_BCPYD()
        {
            InitializeComponent();
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string cwh = this.txtNewCWH.Text.Trim();
            string xhtm = this.txtXHTM.Text.Trim();
            if (xhtm.Length == 0)
            {
                MessageBox.Show("请扫描 箱号条码！", "系统提示");
                return;
            }
             
            if (xhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确！", "系统提示");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
            }

            cwh = cwh.Substring(2);
            xhtm = xhtm.Substring(2);

            string sqlStr = "exec 半成品移动 '" + cwh + "','" + xhtm+"'";

            if (DataClass.Execute(sqlStr))
            {
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                this.txtXHTM.SelectAll();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.Focus();
                this.txtXHTM.SelectAll();
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
                MessageBox.Show("仓位号不正确！", "系统提示");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
            }

            strXHTM = strXHTM.Substring(2);

            string sqlStr = "select 材料编号,来料批次,退料数量,仓位号 from 半成品条码库存  with(nolock)  where 箱号条码='" + strXHTM + "'    ";
            DataTable dt = DataClass.GetTable(sqlStr);
            this.dataGrid1.DataSource = dt;
           
            this.btnOK_Click(null, null);
        }

        private void frm_BCPYD_Load(object sender, EventArgs e)
        {
            this.txtNewCWH.Focus();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

      

       

       
    }
}