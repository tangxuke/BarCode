using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.呆料
{
    public partial class FRM_TODL : Form
    {
        public FRM_TODL()
        {
            InitializeComponent();
        }


        #region 窗体载入填充单号
        private void FRM_TODL_Load(object sender, EventArgs e)
        {
            this.FillBillNo();
        }

        private void FillBillNo()
        {
            string sqlstr = "exec 生成呆料单信息";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有找到要转呆料的单号!", "系统提示");
                return;
            }
            this.cmbBillNo.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                this.cmbBillNo.Items.Add(dr["单号"].ToString());
            }
            this.cmbBillNo.SelectedIndex = 0;
        }
        #endregion

        #region 填充仓管员
        private void cmbBillNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillCGY();
        }

        private void FillCGY()
        {
            string strBillno = this.cmbBillNo.Text.Trim();
            if (strBillno.Length == 0)
            {
                return;
            }
            string sqlstr = "exec 生成呆料仓管员信息 '" + strBillno + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有发现该单的仓管员!", "系统提示");
                return;
            }
            this.cmbCGY.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                this.cmbCGY.Items.Add(dr["仓管员"].ToString());
            }
            this.cmbCGY.SelectedIndex = 0;
        }
        #endregion

        #region 填充仓管员的材料编号
        private void cmbCGY_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillClbh();
        }

        private void FillClbh()
        {
            string strBillno = this.cmbBillNo.Text.Trim();
            string strCGY = this.cmbCGY.Text.Trim();
            if (strBillno.Length == 0 || strCGY.Length == 0)
            {
                return;
            }
            string sqlstr = "exec 生成呆料材料信息 '" + strBillno + "','" + strCGY + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有发现该单的仓管员!", "系统提示");
                return;
            }
            this.cmbCLBH.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                this.cmbCLBH.Items.Add(dr["材料编号"].ToString());
            }
            this.cmbCLBH.SelectedIndex = 0;
        }
        #endregion

        #region 填充余欠数
        private void cmbCLBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillYQS();
        }

        private void FillYQS()
        {
            string strBillno = this.cmbBillNo.Text.Trim();
            string strClbh = this.cmbCLBH.Text.Trim();
            if (strBillno.Length == 0 || strClbh.Length == 0)
            {
                return;
            }
            string sqlstr = "exec 生成呆料材料余欠信息 '" + strBillno + "','" + strClbh + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                this.FillClbh();
                return;
            }
            this.txtDLQty.Text = dt.Rows[0]["数量"].ToString();
            this.txtTMQty.Text = dt.Rows[0]["条码数量"].ToString();
            this.txtLLPC.Text = dt.Rows[0]["来料批次"].ToString();
            this.txtCWH.Text = dt.Rows[0]["仓位号"].ToString();

            this.txtXHTM.Focus();
        }
        #endregion

        #region 检测条码
        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXhtm = this.txtXHTM.Text.Trim();
            if (strXhtm.Length == 0)
            {
                return;
            }
            if (strXhtm.Substring(0,2) != "M.")
            {
                MessageBox.Show("扫入的条码不正确!", "系统提示");
                return;
            }
            strXhtm = strXhtm.Substring(2);
            string strLlpc = this.txtLLPC.Text.Trim();
            string sqlstr = "exec 生成呆料条码信息 '" + strLlpc + "','" + strXhtm + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("该条码不符合发料条件!", "系统提示");
                return;
            }
            this.txtQty.Text = dt.Rows[0]["数量"].ToString();

            this.btnOK_Click(null, null);
        }
        #endregion

        #region 呆料发料
        private void btnOK_Click(object sender, EventArgs e)
        {
            string strBillno = this.cmbBillNo.Text.Trim();
            string strClbh = this.cmbCLBH.Text.Trim();
            string strXhtm = this.txtXHTM.Text.Trim();

            if (strBillno.Length == 0 || strClbh.Length == 0 ||strXhtm.Length==0)
            {
                return;
            }
            strXhtm = strXhtm.Substring(2);

            string command = "exec 呆料发料 '" + strBillno + "','" + strXhtm + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtQty.Text = "";
                this.FillYQS();
                this.txtXHTM.Focus();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtQty.Text = "";
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}