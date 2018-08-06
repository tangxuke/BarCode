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
    public partial class FRM_BLPBCPSJ : Form
    {
        public FRM_BLPBCPSJ()
        {
            InitializeComponent();
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text;
            if (strCWH.Length == 0)
            {
                return;
            }
            if (strCWH.Substring(0, 2) != "H.")
            {
                MessageBox.Show("仓位号不正确!", "系统提示");
                this.txtCWH.SelectAll();
                this.txtCWH.Focus();
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
                this.txtXHTM.Focus();
                return;
            }
            strXHTM = strXHTM.Substring(2);
            this.dataGrid1.DataSource = null;
            string commandtext = "select * from 半成品不良条码库存  with(nolock)  where 箱号条码='" + strXHTM + "' and dbo.查询仓位类型(仓位号)='材料不良品'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此条码不符合上架条件!", "系统提示");
                return;
            }
            this.dataGrid1.DataSource = dt;
            this.Refresh();
            this.btnOK_Click(null, null);
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            string strCWH = this.txtCWH.Text.Trim();
            if (strCWH.Length == 0)
            {
                MessageBox.Show("请扫入仓位条码！");
                this.txtCWH.Focus();
                return;
            }
            if (strXHTM.Length == 0)
            {
                MessageBox.Show("请扫入箱条码！");
                this.txtXHTM.Focus();
                return;
            }

            strXHTM = strXHTM.Substring(2);
            strCWH = strCWH.Substring(2);
            string commandtext = "exec 不良半成品上架 '" + strXHTM + "','" + strCWH + "'";
            bool result = DataClass.Execute(commandtext);
            if (!result)
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            CommonClass.PlaySoundOK();
            this.dataGrid1.DataSource = null;
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_BLPBCPSJ_Load(object sender, EventArgs e)
        {
            this.txtCWH.Focus();
        }

     

    }
}