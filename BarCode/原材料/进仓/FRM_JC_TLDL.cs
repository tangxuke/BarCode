using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.进仓
{
    public partial class FRM_JC_TLDL : Form
    {
        public FRM_JC_TLDL()
        {
            InitializeComponent();
        }

        private void FillTM()
        {
            string strbillno = this.txtDH.Text.Trim();
            string sqlcommandtext = "exec 生成退料未点箱号条码信息 '" + strbillno + "'";
            DataTable dt = DataClass.GetTable(sqlcommandtext);
            this.dataGrid1.DataSource = dt;
        }

        private void FRM_JC_TLDL_Load(object sender, EventArgs e)
        {
            this.FillTM();
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
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXhtm = this.txtXHTM.Text.Trim();
            if (strXhtm.Length == 0)
            {
                return;
            }
            strXhtm = strXhtm.Substring(2);
            string sqlcommandtext = "exec  退料点料 '" + strXhtm + "'";
            if (!DataClass.Execute(sqlcommandtext))
            {
                MessageBox.Show("退料点料失败！\n" + DataClass.ErrorText);
            }
            else
            {
                //MessageBox.Show("更新数据成功！");
                CommonClass.PlaySoundOK();
                this.FillTM();
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
        }

        private void txtDH_LostFocus(object sender, EventArgs e)
        {
            this.FillTM();
        }



    }
}