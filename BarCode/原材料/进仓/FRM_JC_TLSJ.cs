using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.进仓
{
    public partial class FRM_JC_TLSJ : Form
    {
        public FRM_JC_TLSJ()
        {
            InitializeComponent();
        }

        private void FRM_JC_TLSJ_Load(object sender, EventArgs e)
        {
            this.cmbCGY.Items.Clear();
            this.FillCGY();
        }

        private void FillCGY()
        {
            string cSql = "exec 生成退料仓管员信息";
            DataTable dt = DataClass.GetTable(cSql);
            if (dt.Rows.Count==0)
            {
                MessageBox.Show("所有退料都已上架！","系统提示");
                return;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.cmbCGY.Items.Add(dt.Rows[i]["仓管员"].ToString().Trim());
            }
            this.cmbCGY.SelectedIndex = 0;
        }

        private void cmbCGY_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillXHTM();
            this.txtCWH.Focus();
        }

        private void FillXHTM()
        {
            string cgy = this.cmbCGY.Text.Trim();
            string cSql = "exec 生成仓管员退料信息 '" + cgy + "'";
            DataTable dt = DataClass.GetTable(cSql);
            if (dt.Rows.Count == 0)
            {
                this.FillCGY();
                return;
            }
            this.dataGrid1.DataSource = dt;
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string cwh = this.txtCWH.Text.Trim();
            if (cwh.Length == 0)
            {
                return;
            }
            if (cwh.Substring(0, 2) != "H.")
            {
                MessageBox.Show("请扫入正确的仓位号！", "系统提示");
                return ;
            }
            cwh = cwh.Substring(2);
            string xhtm = this.txtXHTM.Text.Trim();
            if (xhtm.Length == 0)
            {
                return;
            }
            if (xhtm.Substring(0, 2) != "M.") 
            {
                MessageBox.Show("请扫入正确的箱号条码！", "系统提示");
                return ;
            }
            xhtm = xhtm.Substring(2);
            string cgy = this.cmbCGY.Text.Trim();
            string cSql = "exec 退补条码上架 '" + cwh + "','" + xhtm + "','" + cgy + "'";
            if (DataClass.Execute(cSql))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "退料上架失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.Focus();
                this.txtXHTM.SelectAll();
                return;
            }
            this.FillXHTM();
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter )
            {
                this.btnOK.Focus();
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }




    }
}

 