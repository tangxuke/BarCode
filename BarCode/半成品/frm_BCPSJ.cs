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
    public partial class frm_BCPSJ : Form
    {
        public frm_BCPSJ()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string cwh = this.txtCwh.Text.Trim();
            string xhtm = this.txtXhtm.Text.Trim();
            if (cwh.Length == 0 || xhtm.Length == 0)
            {
                MessageBox.Show("请扫描仓位号或箱号条码", "系统提示");
                return;
            }
            if (cwh.Substring(0, 2) != "H.")
            {
                MessageBox.Show("仓位号不正确！", "系统提示");
                this.txtCwh.Text = "";
                this.txtCwh.Focus();
            }

            if (xhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确！", "系统提示");
                this.txtXhtm.Text = "";
                this.txtXhtm.Focus();
            }

            cwh = cwh.Substring(2);
            xhtm = xhtm.Substring(2);

            string sqlStr = "exec 半成品上架 '" + cwh + "','" + xhtm +"'";

            if (DataClass.Execute(sqlStr))
            {
                this.txtXhtm.Text = "";
                this.dataGrid1.DataSource = null;
                CommonClass.PlaySoundOK();
                this.txtXhtm.Focus();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXhtm.SelectAll();
                this.txtXhtm.Focus();
                return;
            }
        }

        private void txtXhtm_LostFocus(object sender, EventArgs e)
        {
            string strXHTM=this.txtXhtm.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
             if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("仓位号不正确！", "系统提示");
                this.txtXhtm.Text = "";
                this.txtXhtm.Focus();
            }

            strXHTM = strXHTM.Substring(2);

            string sqlStr = "select 材料编号,来料批次,退料数量,仓位号 from 半成品条码库存  with(nolock)  where 箱号条码='" + strXHTM + "'    ";
            DataTable dt = DataClass.GetTable(sqlStr);
            this.dataGrid1.DataSource = dt;
            this.btnOK.Focus();
            this.btnOK_Click(null, null);
        }

        private void txtXhtm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
               
        }

        private void txtCwh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXhtm.Focus();
            }
        }

        private void frm_BCPSJ_Load(object sender, EventArgs e)
        {
            this.txtCwh.Focus();
        }

        private void txtCwh_LostFocus(object sender, EventArgs e)
        {

        }

      
    }
}