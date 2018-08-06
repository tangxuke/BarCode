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
    public partial class FRM_CH_SCAN : Form
    {
        public FRM_CH_SCAN()
        {
            InitializeComponent();
            this.FillPackID();
        }

        private void FillPackID()
        {
            this.cmbPackID.Items.Clear();
            string sqlcommandtext = "exec 生成出货packid信息";
            DataTable dt = DataClass.GetTable(sqlcommandtext);           
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbPackID.Items.Add(dr["PackID"].ToString());
            }
            this.cmbPackID.SelectedIndex = 0;
        }

        private void cmbPackID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillCPBH();
        }

        private void FillCPBH()
        {
            this.cmbCPBH.Items.Clear();
            string strPackid = this.cmbPackID.Text.Trim();
            string sqlcommandtext = "EXEC 生成出货产品信息  '" + strPackid + "'";
            DataTable dt = DataClass.GetTable(sqlcommandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("未发现有需要扫描的产品", "系统提示");
                return;
            }
            
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbCPBH.Items.Add(dr["产品编号"].ToString());
            }
            this.cmbCPBH.SelectedIndex = 0;
        }

        private void cmbCPBH_TextChanged(object sender, EventArgs e)
        {
            this.FillUnScanTM();
            this.txtXHTM.Focus();
        }

        private void FillUnScanTM()
        {
            string strPackid = this.cmbPackID.Text.Trim();
            string strCPBH = this.cmbCPBH.Text.Trim();
            string sqlcommandtext = "EXEC 生成出货产品条码信息  '" + strPackid + "','" + strCPBH + "'";
            DataTable dt = DataClass.GetTable(sqlcommandtext);
            if (dt.Rows.Count == 0)
            {
                this.FillCPBH();
            }
            this.dataGrid1.DataSource = dt;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            string strPakcID = this.cmbPackID.Text.Trim();
            string strCPBH = this.cmbCPBH.Text.Trim();
            if (strXHTM.Length == 0 || strPakcID.Length == 0 ||strCPBH.Length==0)
            {
                return;
            }
            string commandtext = "exec 成品出货确认 '" + strPakcID + "','" + strCPBH + "','" + strXHTM + "'";
            if (DataClass.Execute(commandtext))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "成品出货确认失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.FillUnScanTM();
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void btnClost_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

    }
}