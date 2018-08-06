using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.车间管理
{
    public partial class FRM_SCAN : Form
    {
        public FRM_SCAN()
        {
            InitializeComponent();
            this.FillBillno();
        }

        private void FillBillno()
        {
            string selectcmd = "exec 查询扫描条码 ";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("请先建立当天要扫描的条码内容！", "系统提示");
                return;
            }
            else
            {
                this.cmbBillno.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    this.cmbBillno.Items.Add(dr["billno"].ToString());
                }
            }
            this.cmbBillno.SelectedIndex = 0;
        }

        private void cmbBillno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillBarCode();
            this.txtBarCode.Focus();
        }

        private void FillBarCode()
        {
            string strBillno=this.cmbBillno.Text.Trim();
            string selectcmd = "select * from scan_index where billno='" + strBillno+"'";
            DataTable dt = DataClass.GetTable(selectcmd);
            this.txtCPBH.Text = dt.Rows[0]["cpbh"].ToString();
            this.txtBarSample.Text = dt.Rows[0]["barsample"].ToString();
        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtBarCode_LostFocus(object sender, EventArgs e)
        {
            string strBarsample = this.txtBarSample.Text.Trim();
            string strBarCode = this.txtBarCode.Text.Trim();
            if (strBarCode.Length == 0)
            {
                return;
            }
            if (strBarCode != strBarsample)
            {
                MessageBox.Show("扫入的条码不正确！", "系统提示");
                this.txtBarCode.SelectAll();
                this.txtBarCode.Focus();
            }
            else
            {
                this.btnOK_Click(null, null);
                this.txtBarCode.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strbillno = this.cmbBillno.Text.Trim();
            string strBarcode = this.txtBarCode.Text.Trim();
            if (strbillno.Length == 0)
            {
                MessageBox.Show("单号为空！", "系统提示");
                return;
            }
            if (strBarcode.Length == 0)
            {
                MessageBox.Show("请先扫入条码！", "系统提示");
                return;
            }
            string command = "exec 标签扫描 '" + strbillno + "','" + strBarcode + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "扫描失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtBarCode.Text = "";
            this.txtBarCode.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}