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
    public partial class frm_InputBack : Form
    {
        public frm_InputBack()
        {
            InitializeComponent();
        }

        private void txtProdno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.cmbCLBH.Focus();
            }
        }

        private void txtProdno_LostFocus(object sender, EventArgs e)
        {
            this.FillProdNO();
        }

        private void FillProdNO()
        {
            string strProdNO = this.txtProdno.Text.Trim();
            if (strProdNO.Length == 0)
            {
                return;
            }
            string strSql = "select  * from pdlots with(nolock)  where prodno='" + strProdNO + "'";
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此生产令号不存在！", "系统提示");
                this.txtProdno.SelectAll();
                return;
            }
            this.txtCPBH.Text = dt.Rows[0]["cpbh"].ToString();
            this.txtLotNo.Text = dt.Rows[0]["pdlotno"].ToString();
            this.txtUserID.Text = dt.Rows[0]["workshopid"].ToString();
            this.txtLine.Text = dt.Rows[0]["lineid"].ToString();
            this.FillCLBH();
        }

        private void FillCLBH()
        {
            string strProdNO = this.txtProdno.Text.Trim();
            if (strProdNO.Length == 0)
            {
                return;
            }
            string strSql = "select  distinct clbh  from inputs with(nolock)  where prodno='" + strProdNO + "' order by clbh ";
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此生产令号还未投入物料，不能退回物料！", "系统提示");
                this.txtProdno.SelectAll();
                this.txtProdno.Focus();
                return;
            }
            this.cmbCLBH.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbCLBH.Items.Add(dr["clbh"].ToString());
            }
            this.cmbCLBH.SelectedIndex=0;
        }

        private void cmbCLBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillLLPC();
        }

        private void FillLLPC()
        {
            string strProdNO = this.txtProdno.Text.Trim();
            string strCLBH=this.cmbCLBH.Text.Trim();

            if (strProdNO.Length == 0 || strCLBH.Length==0)
            {
                return;
            }
            string strSql = "select  distinct llpc  from inputs  with(nolock) where prodno='" + strProdNO + "' and clbh='" + strCLBH + "' order by llpc desc ";
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count == 0)
            {

                return ;
            }
            this.cmbLLPC.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbLLPC.Items.Add(dr["llpc"].ToString());
            }
            this.cmbLLPC.SelectedIndex = 0;
        }

        private void cmbLLPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillZZPC();
        }

        private void FillZZPC()
        {
            string strProdNO = this.txtProdno.Text.Trim();
            string strLLPC = this.cmbLLPC.Text.Trim();

            if (strProdNO.Length == 0 || strLLPC.Length == 0)
            {
                return;
            }
            string strSql = "select  distinct mlotno  from inputs  with(nolock) where prodno='" + strProdNO + "' and llpc='" + strLLPC + "' order by mlotno desc ";
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count == 0)
            {
                return;
            }
            this.cmbZZPC.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbZZPC.Items.Add(dr["mlotno"].ToString());
            }
            this.cmbZZPC.SelectedIndex = 0;
            //this.txtQty.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strProdno = this.txtProdno.Text.Trim();
            string strLLPC = this.cmbLLPC.Text.Trim();
            string strZZPC = this.cmbZZPC.Text.Trim();
            string strQty = this.txtQty.Text.Trim();
            if (strProdno.Length == 0 || strLLPC.Length == 0 || strZZPC.Length == 0 || strQty.Length == 0)
            {
                return;
            }
         
            double nQty = double.Parse(strQty);
            string strsql = "exec 物料退回 '" + strProdno + "','" + strLLPC + "','" + strZZPC + "'," + nQty + "";

            if (DataClass.Execute(strsql))
            {
                CommonClass.PlaySoundOK();
                MessageBox.Show("物料退回成功!","系统提示");
                //this.cmbZZPC.Items.Clear();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "物料退回失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbZZPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strProdNO = this.txtProdno.Text.Trim();
            string strLLPC = this.cmbLLPC.Text.Trim();
            string strZZPC = this.cmbZZPC.Text.Trim();

            if (strProdNO.Length == 0 || strLLPC.Length == 0 ||strZZPC.Length==0)
            {
                return;
            }
            string strSql = "select isnull(sum(inqty),0) as 数量 from inputs with(nolock)  where prodno='" + strProdNO + "' and llpc='" + strLLPC + "' and mlotno='" + strZZPC + "' ";
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count == 0)
            {
                this.txtQty.Text = "0";
                return;
            }

            this.txtQty.Text = dt.Rows[0]["数量"].ToString();
            this.txtQty.SelectAll();
            this.txtQty.Focus();
        }



       

    }
}