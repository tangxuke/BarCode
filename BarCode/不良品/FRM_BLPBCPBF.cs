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
    public partial class FRM_BLPBCPBF : Form
    {
        public FRM_BLPBCPBF(string strBfdno)
        {
            InitializeComponent();
            this.txtBfdno.Text = strBfdno;
            this.txtXHTM.Focus();
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
            string strBfdno = this.txtBfdno.Text.Trim();
            if (strBfdno.Length == 0)
            {
                return;
            }
            this.dataGrid1.DataSource = null;
            string commandtext = "select * from 半成品不良条码库存  with(nolock) where 箱号条码='" + strXHTM + "' and  dbo.查询仓位类型(仓位号)='材料不良品'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此条码不正确，请核对它的仓位类型!", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();

                return;
            }
            this.dataGrid1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strBFDNO = this.txtBfdno.Text.Trim();
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            strXHTM = strXHTM.Substring(2);

            string command = "exec 半成品不良品报废 '" + strBFDNO + "','" + strXHTM + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
                this.dataGrid1.DataSource = null;
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }


     
    }
}