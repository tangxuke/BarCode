using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.BCP
{
    public partial class frm_BCPFL : Form
    {
        public frm_BCPFL()
        {
            InitializeComponent();
        }
        DataTable dt;

        private void frm_BCPFL_Load(object sender, EventArgs e)
        {
           
            this.FillFldh();
        }

        private void FillFldh()
        {
            string commandtext = "EXEC 生成半成品发料单";
            dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("系统中没有符合条件的半成品发料单！", "系统提示");
                return;
            }
            {
                this.cmbFldh.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    this.cmbFldh.Items.Add(dr["fldh"].ToString().Trim());
                }
                this.cmbFldh.SelectedIndex = 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string fldh = this.cmbFldh.Text.Trim();
            string xhtm = this.txtXHTM.Text.Trim();
            if (xhtm.Length == 0)
            {
                MessageBox.Show("请扫描 箱号条码！", "系统提示");
                return;
            }
             
            if (xhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确！", "系统提示");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
            }

             
            xhtm = xhtm.Substring(2);

            string sqlStr = "exec 半成品发料 '" + fldh + "','" + xhtm +"'";

            if (DataClass.Execute(sqlStr))
            {
                //MessageBox.Show("发料成功！", "系统提示");
                CommonClass.PlaySoundOK();
                this.dataGrid1.DataSource = null;
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.FillFldh();
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("仓位号不正确！", "系统提示");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
            }

            strXHTM = strXHTM.Substring(2);

            string sqlStr = "select 材料编号,来料批次,退料数量,仓位号 from 半成品条码库存  with(nolock) where 箱号条码='" + strXHTM + "'    ";
            DataTable dt = DataClass.GetTable(sqlStr);
            this.dataGrid1.DataSource = dt;
            this.btnOK_Click(null,null);
        }

        private void cmbFldh_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtCpbh.Text = dt.Select("fldh='" + this.cmbFldh.Text.Trim() + "'")[0]["cpbh"].ToString();
            this.FoundCWH(this.txtCpbh.Text.Trim());
        }

        private void FoundCWH(string cpbh)
        {
            string sqlStr = "select  top 1 仓位号 from 半成品条码库存 with(nolock)  where 产品编号='" + cpbh + "' and dbo.查询仓位类型(仓位号)='半成品'";
            DataTable dt = DataClass.GetTable(sqlStr);
            if (dt.Rows.Count > 0)
            {
                this.txtCWH.Text = dt.Rows[0]["仓位号"].ToString();
            }
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}