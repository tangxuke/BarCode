using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.BLP
{
    public partial class FRM_BLPBF : Form
    {
        public FRM_BLPBF()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillBFDNO()
        {
            string sqlstr = "exec 生成材料不良品报废单信息";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有适合的报废单号!", "系统提示");
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbBFDno.Items.Add(dr["报废单号"].ToString().Trim());
            }
            this.cmbBFDno.SelectedIndex = 0;
            this.txtXHTM.Focus();
        }

        private void FRM_BLPBF_Load(object sender, EventArgs e)
        {
            this.FillBFDNO();
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
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确!", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            strXHTM = strXHTM.Substring(2);
            string commandtext = "select * from 仓位库存表 with(nolock)  where 箱号条码='" + strXHTM + "' and  dbo.查询仓位类型(仓位号)='材料不良品'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此条码不正确，请核对它的仓位类型!", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
         
                return;
            }
            this.txtCLBH.Text = dt.Rows[0]["材料编号"].ToString();
            this.txtLLPC.Text = dt.Rows[0]["来料批次"].ToString();
            this.txtQTY.Text = dt.Rows[0]["数量"].ToString();
            this.txtCWH.Text = dt.Rows[0]["仓位号"].ToString();
        }

       

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strBFDNO = this.cmbBFDno.Text.Trim();
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            strXHTM = strXHTM.Substring(2);
        
            string command = "exec 物料不良品报废 '" + strBFDNO + "','" + strXHTM + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
                this.txtCLBH.Text = "";
                this.txtLLPC.Text = "";
                this.txtQTY.Text = "";
                this.txtCWH.Text = "";
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void btnBCP_Click(object sender, EventArgs e)
        {
            string strbfdno = this.cmbBFDno.Text.Trim();
            FRM_BLPBCPBF frm = new FRM_BLPBCPBF(strbfdno);
            frm.Show();

        }




    }
}