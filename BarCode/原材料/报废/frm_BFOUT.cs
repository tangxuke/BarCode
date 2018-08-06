using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.报废
{
    public partial class frm_BFOUT : Form
    {
        public frm_BFOUT()
        {
            InitializeComponent();
        }

        private void txtBFDNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
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
            string strBfdno = this.txtBFDNo.Text.Trim();
            string strXHTM=this.txtXHTM.Text.Trim();
            if (strXHTM.Length==0)
            {
                return ;
            }
            strXHTM=strXHTM.Substring(2);
            string sqlstr = "exec 物料报废 '" + strBfdno + "','" + strXHTM + "'";

            DataTable dtTM = DataClass.GetTable(sqlstr);
            if (dtTM.Rows.Count>0)
            {
                this.txtClbh.Text = dtTM.Rows[0]["材料编号"].ToString();
                this.txtLLPC.Text = dtTM.Rows[0]["来料批次"].ToString();
                this.txtQty.Text = dtTM.Rows[0]["数量"].ToString();
                this.txtCWH.Text = dtTM.Rows[0]["仓位号"].ToString();
            }

            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            strXHTM = strXHTM.Substring(2);
            string sqlstr = "select * from 仓位库存表 where 箱号条码='" + strXHTM + "'";

            if (DataClass.Execute(sqlstr))
            {
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtClbh.Text = "";
                this.txtLLPC.Text = "";
                this.txtQty.Text = "";
                this.txtCWH.Text = "";
                this.txtXHTM.Focus();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }







    }
}