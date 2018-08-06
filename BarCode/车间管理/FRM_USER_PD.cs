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
    public partial class FRM_USER_PD : Form
    {
        private string cUserid;

        public FRM_USER_PD(string strUserID)
        {
            InitializeComponent();
            cUserid = strUserID;
            this.txtUserID.Text = cUserid.Trim();
            this.txtXHTM.SelectAll();
            this.txtXHTM.Focus();
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            strXHTM = strXHTM.Substring(2);
            string sqlcmd = "exec 车间物料盘点条码 '" + strXHTM + "'";
            DataTable table1 = DataClass.GetTable(sqlcmd);
            if (table1.Rows.Count == 0)
            {
                MessageBox.Show("箱号不存在！");
                return;
            }
            DataRow row = table1.Rows[0];
            this.txtCLBH.Text = row["材料编号"].ToString();
            this.txtLLPC.Text = row["来料批次"].ToString();
            this.txtZZPC.Text = row["制造批次"].ToString();
            this.txtQty.Text = row["数量"].ToString();

            if (this.chk.Checked)
            {
                this.txtQty.SelectAll();
                this.txtQty.Focus();
            }
            else
            {
                this.btnOK_Click(null, null);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string xhtm = this.txtXHTM.Text;
            if (xhtm.Length == 0)
                return;
            if (xhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            xhtm = xhtm.Substring(2);
          
            //直接上传
            string command = "exec 车间条码盘点 '" + xhtm + "','" + cUserid + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtCLBH.Text = "";
                this.txtLLPC.Text = "";
                this.txtZZPC.Text = "";
                this.txtQty.Text = "";
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "配料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXHTM.SelectAll();
            this.txtXHTM.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}