using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BarCode.原材料.收料
{
    public partial class FRM_SL_ZZPC : Form
    {
        public FRM_SL_ZZPC()
        {
            InitializeComponent();
        }

        private void FRM_SL_ZZPC_Load(object sender, EventArgs e)
        {
            this.FillCGY();
        }

        private void FillCGY()
        {
            string commandtext = "exec 生成收料仓管员信息";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("请先维护收料仓管员！", "系统提示");
                return;
            }
            this.cmbCGY.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbCGY.Items.Add(dr["name"].ToString());
            }
            this.cmbCGY.SelectedIndex = 1;
        }

        private void FillLLPC()
        {
            string strCGY = this.cmbCGY.Text.Trim();
            string commandtext = "exec 生成收料批次信息 '" + strCGY + "'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("该仓管员没有要维护的来料批次！", "系统提示");
                return;
            }
            this.cmbLLPC.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbLLPC.Items.Add(dr["llpc"].ToString());
            }
            this.cmbLLPC.SelectedIndex = 1;
        }

        private void cmbLLPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strLLPC = this.cmbLLPC.Text.Trim();
            string commandtext = "exec 生成收料批次信息2 '" + strLLPC + "'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                this.txtCLBH.Text = "";
                this.txtGHF.Text = "";
                this.txtQTY.Text = "";
                this.txtZZPCSUMQty.Text = "";
            }
            else
            {
                this.txtCLBH.Text = dt.Rows[0]["clbh"].ToString();
                this.txtGHF.Text = dt.Rows[0]["ghf"].ToString();
                this.txtQTY.Text = dt.Rows[0]["sssl"].ToString();
                this.txtZZPCSUMQty.Text = dt.Rows[0]["zzpcqty"].ToString();
            }
            this.txtZZPC.Focus();
        }

        private void btnRemain_Click(object sender, EventArgs e)
        {
            if (this.btnRemain.Text == "")
            {
                this.btnRemain.Text = "保";
            }
            else
            {
                this.btnRemain.Text = "";
            }
        }

        private void txtZZPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtZZPCQty.Focus();
            }
        }

        private void txtZZQty_GotFocus(object sender, EventArgs e)
        {
          
        }

        private bool validNum(string s)
        {
            string pattern = "^[0-9]*$";
            Regex rx = new Regex(pattern);
            return rx.IsMatch(s);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strllpc = this.cmbLLPC.Text.Trim();
            string strZZPC = this.txtZZPC.Text.Trim();
            string strZZPCQty = this.txtZZPCQty.Text.Trim();
            string strCGY = this.cmbCGY.Text.Trim();
            if (strZZPC.Length == 0)
            {
                MessageBox.Show("请录入制造批次！", "系统提示");
                return;
            }
            if (strZZPCQty.Length == 0)
            {
                MessageBox.Show("请录入制造批次的数量！", "系统提示");
                return;
            }
            decimal qty = decimal.Parse(strZZPCQty);
            string command = "exec 物料制造批次维护 '" + strllpc + "','" + strZZPC + "','" + strCGY + "','" + qty + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();

            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "制造批次维护失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtZZPC.SelectAll();
            this.txtZZPC.Focus();
        }

        private void cmbCGY_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillLLPC();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtZZPCQty_LostFocus(object sender, EventArgs e)
        {
            string strQty = this.txtZZPCQty.Text.Trim();
            if (strQty.Length == 0)
            {
                return;
            }
            if (this.validNum(strQty) == false)
            {
                MessageBox.Show("请输入数字！", "系统提示");
                this.txtZZPCQty.Text = "";
                this.txtZZPCQty.Focus();
                return;
            }
            this.btnOK_Click(null, null);
        }

    }
}