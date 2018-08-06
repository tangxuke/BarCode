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
    public partial class frm_inputQuery : Form
    {
        public frm_inputQuery()
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

        private void txtProdno_LostFocus(object sender, EventArgs e)
        {
            this.FillProdNO();
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
                this.txtProdno.SelectAll();
                this.txtProdno.Focus();
                return;
            }
            this.cmbCLBH.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbCLBH.Items.Add(dr["clbh"].ToString());
            }
            this.cmbCLBH.SelectedIndex = 0;
        }

        private void cmbCLBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strProdNO = this.txtProdno.Text.Trim();
            string strCLBH = this.cmbCLBH.Text.Trim();


            if (strProdNO.Length == 0 || strCLBH.Length == 0  )
            {
                return;
            }
            string strSql = "select isnull(sum(inqty),0) as 数量 from inputs with(nolock)  where prodno='" + strProdNO + "' and clbh='" + strCLBH + "'   ";
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count == 0)
            {
                this.txtQty.Text = "0";
                return;
            }

            this.txtQty.Text = dt.Rows[0]["数量"].ToString();
            this.btnClose.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}