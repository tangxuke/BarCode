using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.设备管理
{
    public partial class FRM_SBJC : Form
    {
        public FRM_SBJC()
        {
            InitializeComponent();
            this.FillJCD();
        }
        private void FillJCD()
        {
            string sqlcommand = "exec 生成设备进仓单号";
            DataTable dt = DataClass.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("系统无法找到需求的进仓单！", "系统提示");
                this.Close();
                return;
            }
            this.cmbJCD.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbJCD.Items.Add(dr["进仓单号"].ToString());
            }
            this.cmbJCD.SelectedIndex = 0;
        }

        private void cmbJCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtXHTM.Focus();
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
            string strJCD = this.cmbJCD.Text.Trim();
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                MessageBox.Show("请扫入设备条码！", "系统提示");
                return;
            }
            string sqlcommand = "exec 设备进仓 '" + strJCD + "','" + strXHTM + "'";
            if (DataClass.Execute(sqlcommand))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



     
    }
}