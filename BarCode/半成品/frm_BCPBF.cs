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
    public partial class frm_BCPBF : Form
    {
        public frm_BCPBF()
        {
            InitializeComponent();
        }

        private void FillBFDNO()
        {
            string sqlstr = "select * from 半成品报废申请单   with(nolock)  where   是否审核=0  ";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有要报废的半成品，请先做好半成品主表！", "系统提示");
                return;
            }
            this.cmbBfdno.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbBfdno.Items.Add(dr["报废单号"].ToString());
            }
            this.cmbBfdno.SelectedIndex=0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
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

            string bfdno = this.cmbBfdno.Text.Trim();

            string sqlStr = "exec 半成品报废 '" + bfdno + "','" + xhtm + "'";

            if (DataClass.Execute(sqlStr))
            {
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                this.dataGrid1.DataSource = null;
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
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

            string sqlStr = "select 材料编号,来料批次,退料数量,仓位号 from 半成品条码库存  with(nolock)  where 箱号条码='" + strXHTM + "'    ";
            DataTable dt = DataClass.GetTable(sqlStr);
            this.dataGrid1.DataSource = dt;
            this.btnOK.Focus();
        }

        private void frm_BCPBF_Load(object sender, EventArgs e)
        {
            this.FillBFDNO();
            
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        
       
    }
}