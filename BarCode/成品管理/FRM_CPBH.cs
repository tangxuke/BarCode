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
    public partial class FRM_CPBH : Form
    {
        public FRM_CPBH()
        {
            InitializeComponent();
            this.FillPackID();
            this.txtXHTM.Focus();
        }

        private void FillPackID()
        {
            string commandtext = "exec 生成出货packid信息";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                return;
            }
            this.cmbPackID.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbPackID.Items.Add(dr["packid"].ToString());
            }
            this.cmbPackID.SelectedIndex = 0;
        }

        private void SetInfo()
        {
            string strPakcID=this.cmbPackID.Text.Trim();
            string commandtext = "select count(*) as 箱数 From 成品条码表 where packid='" + strPakcID + "' and isnull(待备货,0)=0";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此PACKID已扫完全部条码！", "系统提示");
            }
            this.lblInfo.Text = dt.Rows[0]["箱数"].ToString();
        }

        private void cmbPackID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetInfo();
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
            string strXHTM = this.txtXHTM.Text.Trim();
            string strPakcID = this.cmbPackID.Text.Trim();
            if (strXHTM.Length == 0 || strPakcID.Length==0)
            {
                return;
            }
            string commandtext = "exec 成品备货扫描 '" + strPakcID + "','" + strXHTM + "'";
            if (DataClass.Execute(commandtext))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "成品备货扫描失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.SetInfo();
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }







    }
}