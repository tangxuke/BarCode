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
    public partial class FRM_TM_COMPA : Form
    {
        public FRM_TM_COMPA()
        {
            InitializeComponent();
        }

        private void FRM_TM_COMPA_Load(object sender, EventArgs e)
        {
            this.txtTM1.Focus();
        }

        private void txtTM1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtTM2.Focus();
            }
        }

        private bool CheckXHTM1()
        {
            string strXHTM = this.txtTM1.Text.Trim();
            if (strXHTM == "")
            {
                return true;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("请扫入正确的箱号条码！", "系统提示");
                return false;
            }
            strXHTM = strXHTM.Substring(2);
            string selectcmd = "select * from 仓位库存表 with(nolock)  where 箱号条码='" + strXHTM + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("下线条码来源不明！", "系统提示");
                return false;
            }
            else
            {
                this.txtCLBH1.Text = dt.Rows[0]["材料编号"].ToString();
                this.txtZZPC1.Text = dt.Rows[0]["制造批次"].ToString();
                this.txtLLPC1.Text = dt.Rows[0]["来料批次"].ToString();
            }
            return true;
        }

        private bool CheckXHTM2()
        {
            string strXHTM = this.txtTM2.Text.Trim();
            if (strXHTM == "")
            {
                return true;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("请扫入正确的箱号条码！", "系统提示");
                return false;
            }
            strXHTM = strXHTM.Substring(2);
            string selectcmd = "select * from 仓位库存表 with(nolock)  where 箱号条码='" + strXHTM + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("上线条码来源不明！", "系统提示");
                return false;
            }
            else
            {
                this.txtCLBH2.Text = dt.Rows[0]["材料编号"].ToString();
                this.txtZZPC2.Text = dt.Rows[0]["制造批次"].ToString();
                this.txtLLPC2.Text = dt.Rows[0]["来料批次"].ToString();
            }
            return true;
        }

        private void txtTM1_LostFocus(object sender, EventArgs e)
        {
            if (this.CheckXHTM1())
            {
                this.txtTM2.Focus();
            }
            else
            {
                this.txtTM1.SelectAll();
                this.txtTM1.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string clbh1 = this.txtCLBH1.Text.Trim();
            string clbh2 = this.txtCLBH2.Text.Trim();

            if (clbh1 == clbh2)
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show("材料编号不配对", "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.ClearAll();
            this.txtTM1.Focus();
        }

        private void txtTM2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtTM2_LostFocus(object sender, EventArgs e)
        {
            string tm1 = this.txtTM1.Text.Trim();
            string tm2 = this.txtTM2.Text.Trim();
            if (tm1==tm2)
            {
                MessageBox.Show("上线条码与下线条码一样", "系统提示");
                this.txtTM2.SelectAll();
                this.txtTM2.Focus();
                return;
            }

            if (this.CheckXHTM2())
            {
                this.btnOK_Click(null, null);
            }
            else
            {
                this.txtTM2.SelectAll();
                this.txtTM2.Focus();
            }
        }

        private void ClearAll()
        {
            this.txtTM1.Text = "";
            this.txtCLBH1.Text = "";
            this.txtZZPC1.Text = "";
            this.txtLLPC1.Text = "";
            this.txtTM2.Text = "";
            this.txtCLBH2.Text = "";
            this.txtZZPC2.Text = "";
            this.txtLLPC2.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}