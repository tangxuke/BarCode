using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.成品管理
{
    public partial class FRM_TBJC : Form
    {
        public FRM_TBJC()
        {
            InitializeComponent();
            this.FillCpbh();
            this.txtXHTM.Focus();
        }
        private void FillCpbh()
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            string commandtext = "exec 生成特别检查产品信息";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有未扫描的产品存在","系统提示");
                this.Close();
                return;
            }
            this.cmbCPBH.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbCPBH.Items.Add(dr["产品编号"].ToString());
            }
            this.cmbCPBH.SelectedIndex = 0;
        }

        private void cmbCPBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillCustItemNo();
            this.fillUnScaninfo();
        }



        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }

        private void FillCustItemNo()
        {
            string strCPBH = this.cmbCPBH.Text.Trim();
            string commandtext = "select khpm from cpzd where cpbh='" + strCPBH + "'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                return;
            }
            this.txtKHPM.Text = dt.Rows[0]["khpm"].ToString();
        }



        private void fillUnScaninfo()
        {
            string strCPBH = this.cmbCPBH.Text.Trim();
            string commandtext = "exec 生成特别检查产品未扫信息 '" + strCPBH + "'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                this.FillCpbh();
                return;
            }
            this.dataGrid1.DataSource = dt;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            string strCPBH = this.cmbCPBH.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            string commandtext = "exec 特别检查验判 '" + strXHTM + "','" + strCPBH + "'";
            if (DataClass.Execute(commandtext))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "成品特别检查失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.fillUnScaninfo();
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}