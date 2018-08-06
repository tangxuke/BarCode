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
    public partial class FRM_THQD_BCP : Form
    {
        public FRM_THQD_BCP(string strthqd)
        {
            InitializeComponent();
            this.txtTHDH.Text = strthqd;
        }

        private void FRM_THQD_BCP_Load(object sender, EventArgs e)
        {
            this.txtXhtm.Focus();
        }

        private void txtXhtm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtXhtm_LostFocus(object sender, EventArgs e)
        {
            string stringxhtm = this.txtXhtm.Text.Trim();
            if (stringxhtm.Length == 0)
            {
                return;
            }
            if (stringxhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("条码不正确!", "系统提示");
                this.txtXhtm.SelectAll();
                this.txtXhtm.Focus();
                return;
            }
            stringxhtm = stringxhtm.Substring(2);
            string sqlStr = "select 材料编号,来料批次,退料数量,仓位号 from 半成品不良条码库存 with(nolock)  where 箱号条码='" + stringxhtm + "'    ";
            DataTable dt = DataClass.GetTable(sqlStr);
            this.dataGrid1.DataSource = dt;
            this.btnOK.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string stringxhtm = this.txtXhtm.Text.Trim();
            if (stringxhtm.Length == 0)
            {
                return;
            }
            if (stringxhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("条码不正确!", "系统提示");
                this.txtXhtm.SelectAll();
                this.txtXhtm.Focus();
                return;
            }
            stringxhtm = stringxhtm.Substring(2);
            string strTHDH = this.txtTHDH.Text;
            if (strTHDH.Length == 0)
            {
                MessageBox.Show("退货单号不能为空!", "系统提示");
                return;
            }
            string sqlStr = "exec  半成品不良退货 '" + strTHDH + "','" + stringxhtm + "'";
            if (DataClass.Execute(sqlStr))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "退货失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXhtm.Text = "";
            this.dataGrid1.DataSource = null;
            this.txtXhtm.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}