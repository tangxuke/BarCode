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
    public partial class FRM_CPJS : Form
    {
        public FRM_CPJS()
        {
            InitializeComponent();
            this.FillUserID();
            this.txtXHTM.Focus();
        }

        private void FillUserID()
        {
            string commandtext = "exec 生成成品接收车间信息";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                return;
            }
            this.cmbUserID.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbUserID.Items.Add(dr["userid"].ToString());
            }
            this.cmbUserID.SelectedIndex = 0;
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
            this.SetInfo();
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            string commandtext = "exec 成品接收 '" + strXHTM + "'";
            if (DataClass.Execute(commandtext))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "成品接收失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.FillUnScanInfo();
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetInfo()
        {
            string strcpbh = this.cmbCpbh.Text.Trim();
            if (strcpbh.Length == 0)
            {
                return;
            }
            string commandtext = "select (case when isallcheck=1 then '特' else '' end) as info from cpzd where cpbh= '" + strcpbh + "'";
            DataTable dt = DataClass.GetTable(commandtext);
            this.lblInfo.Text = dt.Rows[0]["info"].ToString();
        }

        private void cmbCpbh_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetInfo();
            this.FillUnScanInfo();
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillCPBH();
        }

        private void FillCPBH()
        {
            string struserid = this.cmbUserID.Text.Trim();
            string commandtext = "exec 生成成品接收产品信息 '" + struserid + "'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                this.FillUserID();
                return;
            }
            this.cmbCpbh.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbCpbh.Items.Add(dr["产品编号"].ToString());
            }
            this.cmbCpbh.SelectedIndex = 0;
        }

        private void FillUnScanInfo()
        {
            string struserid = this.cmbUserID.Text.Trim();
            string strcpbh = this.cmbCpbh.Text.Trim();
            if (struserid.Length == 0 || strcpbh.Length == 0)
            {
                return;
            }
            string commandtext = "exec 生成成品接收条码信息 '" + struserid + "','" + strcpbh + "'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                this.FillCPBH();
                return;
            }
            this.dataGrid1.DataSource = dt;
        }


    }
}