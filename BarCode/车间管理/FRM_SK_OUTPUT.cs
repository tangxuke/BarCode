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
    public partial class FRM_SK_OUTPUT : Form
    {
        public FRM_SK_OUTPUT()
        {
            InitializeComponent();
        }

        private void FRM_SK_OUTPUT_Load(object sender, EventArgs e)
        {
            this.fillprodno();
        }
        private void fillprodno()
        {
            string sqlcommand = "exec 生成水口制令信息  " ;
            DataTable dt = DataClass.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("制令单号没有找到！", "系统提示");
                this.Close();
                return;
            }
            this.cmbProdno.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbProdno.Items.Add(dr["生产制令号"].ToString());
            }
            this.cmbProdno.SelectedIndex = 0;
        }

        private void cmbProdno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetCPBH();
            this.txtXHTM.Focus();
        }

        private void GetCPBH()
        {
            string sqlcommand = "select cpbh from pdlots with(nolock)  where prodno='" + this.cmbProdno.Text.Trim() + "'";
            DataTable dt = DataClass.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                return;
            }
            this.txtCPBH.Text = dt.Rows[0]["cpbh"].ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strProdno = this.cmbProdno.Text.Trim();
            string strXHTM = this.txtXHTM.Text.Trim();
            string strQty = this.txtQty.Text.Trim();

            if (strXHTM.Length == 0 && strQty.Length==0)
            {
                return;
            }
            strXHTM = strXHTM.Substring(2);
            string sqlcmd = "exec 水口发料 '" + strProdno + "','" + strXHTM + "', " + strQty;
            if (DataClass.Execute(sqlcmd))
            {
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtQty.Text = "";
                this.txtXHTM.Focus();
                 
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "点料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.Text = "";
                this.txtQty.Text = "";
                this.txtXHTM.Focus();
            }
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtQty.Focus();
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            strXHTM = strXHTM.Substring(2);
            string sqlcommand = "select 数量 from 水口条码库存表 with(nolock)  where 箱号条码='" + strXHTM + "'";
            DataTable dt = DataClass.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                return;
            }
            this.txtQty.Text = dt.Rows[0]["数量"].ToString();
            this.txtQty.SelectAll();
            this.txtQty.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   


    }
}