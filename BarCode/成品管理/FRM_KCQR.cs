using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.成品管理
{
    public partial class FRM_KCQR : Form
    {
        public FRM_KCQR()
        {
            InitializeComponent();
            this.txtXHTM.Focus();
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }

        private void GetInfo()
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            string commandtext = "select * From 成品条码表 where 箱号条码='" + strXHTM + "'";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                return;
            }
            this.txtCpbh.Text = dt.Rows[0]["产品编号"].ToString();
            this.txtQty.Text = dt.Rows[0]["数量"].ToString();
            this.txtProdno.Text = dt.Rows[0]["生产制令号"].ToString();
            this.txtXH.Text = dt.Rows[0]["箱号"].ToString();
            this.txtLotno.Text = dt.Rows[0]["LOTNO"].ToString();
            this.txtLotno.Text = dt.Rows[0]["TMLOTNO"].ToString();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.GetInfo();
                this.btnOK.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            string commandtext = "exec 库存特别产品确认 '" + strXHTM + "'";
            if (DataClass.Execute(commandtext))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "成品特别检查失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_KCQR_Load(object sender, EventArgs e)
        {

        }



    }
}