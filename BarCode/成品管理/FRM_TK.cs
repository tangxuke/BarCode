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
    public partial class FRM_TK : Form
    {
        public FRM_TK()
        {
            InitializeComponent();
            this.FillBillno();
            this.txtTK.Focus();
        }


        private void FillBillno()
        {
            this.cmbBillno.Items.Clear();
            string selectcmd = "select billno From CH_TK_INDEX where isnull(isaudit,0)=0    order by billno desc";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有找到要出货的单据！", "系统提示");
                this.Close();
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbBillno.Items.Add(dr["billno"].ToString().Trim());
            }
            this.cmbBillno.SelectedIndex = 0;
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

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {

        }

        private void cmbFldNO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strBillno = this.cmbBillno.Text.Trim();
            string strTk = this.txtTK.Text.Trim();
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strBillno.Length == 0 || strTk.Length == 0 || strXHTM.Length == 0)
            {
                return;
            }
            string command = "exec 泰科条码扫描 '" + strBillno + "','" + strXHTM + "','" + strTk+"'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "泰科条码扫描失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.SetInfo();
            this.txtXHTM.Text = "";
            this.txtTK.Text = "";
            this.txtPartNo.Text = "";
            this.txtCPBH.Text = "";
            this.txtTK.Focus();
        }

        private void cmbBillno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetInfo();
        }

        private void SetInfo()
        {
            string strBillno = this.cmbBillno.Text.Trim();
            if (strBillno.Length == 0)
            {
                return;
            }
            string selectcmd = "SELECT * FROM CH_LABLE_DETAIL WHERE BILLNO='" + strBillno + "' AND ISNULL(ISSCAN,0)=0";
            DataTable dt = DataClass.GetTable(selectcmd);
            this.lblInfo.Text = "还有【" + dt.Rows.Count.ToString() + "】箱未扫描";
            this.txtTK.Focus();
        }

        private void txtTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
        }

        private void txtTK_LostFocus(object sender, EventArgs e)
        {
            string strTK = this.txtTK.Text.Trim();
            if (strTK.Length == 0)
            {
                return;
            }
            string strBillno = this.cmbBillno.Text.Trim();
            if (strBillno.Length == 0)
            {
                return;
            }
            string selectcmd = "SELECT a.*,ISNULL(b.cpbh,'') AS cpbh  FROM CH_LABLE_DETAIL a left join cpzd b on a.part_number=b.khpm WHERE BILLNO='" + strBillno + "' AND ISNULL(ISSCAN,0)=0 and a.LICENSE_TAG='" + strTK + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("泰科条码扫描错误！", "系统提示");
                this.txtTK.Text = "";
                this.txtTK.Focus();
                return;
            }
            this.txtPartNo.Text = dt.Rows[0]["part_number"].ToString();
            this.txtCPBH.Text = dt.Rows[0]["cpbh"].ToString();
            if (this.txtCPBH.Text == "")
            {
                MessageBox.Show("泰科条码错误，找不到对应的惠昌产品编号！", "系统提示");
                return;
            }
            this.txtXHTM.SelectAll();
            this.txtXHTM.Focus();
        }

      
  
    }
}