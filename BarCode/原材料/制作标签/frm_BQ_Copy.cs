using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.制作标签
{
    public partial class frm_BQ_Copy : Form
    {
        public frm_BQ_Copy()
        {
            InitializeComponent();
        }

      

  
     

        private void txtOldXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtNewXHTM.Focus();
               
            }
        }

        private void txtOldXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtOldXHTM.Text;
            if (strXHTM.Length == 0)
                return;
            string selectcmd = "if exists(select * from 箱号条码表 with(nolock)   with(nolock) where 箱号条码='" + strXHTM + "' and isnull(来料批次,'')<>'')";
            selectcmd = selectcmd + "\n     select 1";
            selectcmd = selectcmd + "\n else";
            selectcmd = selectcmd + "\n     select 0";
            if ((int)DataClass.GetValue(selectcmd) == 0)
            {
                MessageBox.Show("找不到原箱号条码！");
                this.txtOldXHTM.Text = "";
                this.lblLlpc.Text = "";
                this.lblClbh.Text = "";
                this.txtNewXHTM.Text = "";
                this.txtOldXHTM.Focus();
                return;
            }
            string llpc = (string)DataClass.GetValue("select 来料批次 from 箱号条码表 with(nolock)  where 箱号条码='" + strXHTM + "'");
            if (llpc != null)
            {
                this.lblLlpc.Text = llpc;
                string clbh = (string)DataClass.GetValue("select clbh from pckc_ym  with(nolock) where llpc='" + llpc + "'");
                 if (clbh != null)
                 {
                     this.lblClbh.Text = clbh;
                 }
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtOldXHTM.Text.Length == 0)
            {
                MessageBox.Show("请扫入原标签条码！");
                this.txtOldXHTM.Focus();
                return;
            }
            if (this.txtNewXHTM.Text.Length == 0)
            {
                MessageBox.Show("请扫入新标签条码！");
                this.txtOldXHTM.Focus();
                return;
            }
            if (this.txtSL.Text.Length == 0)
            {
                MessageBox.Show("请输入退料数量！");
                this.txtSL.Focus();
                return;
            }
            string strOldXHTM = this.txtOldXHTM.Text;
            string strNewXHTM = this.txtNewXHTM.Text;
            decimal nTLSL = decimal.Parse(this.txtSL.Text);

            string commandtext = "exec 制作新标签 '" + strOldXHTM + "','" + strNewXHTM + "'," + nTLSL.ToString();
            if (DataClass.Execute(commandtext))
            {
                this.txtOldXHTM.Text = "";
                this.txtSL.Text = "";
                this.lblClbh.Text = "";
                this.lblLlpc.Text = "";
                this.txtNewXHTM.Text = "";
                this.txtOldXHTM.Focus();
                MessageBox.Show("更新数据成功！");
            }
            else
            {
                MessageBox.Show("制作标签失败！\n" + DataClass.ErrorText);
            }
        }

        private void txtNewXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtSL.Focus();
                this.txtSL.SelectAll();
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtSL_LostFocus(object sender, EventArgs e)
        {
            if (this.txtSL.Text.Length == 0)
                return;
            decimal nTLSL = decimal.Parse(this.txtSL.Text);
            if (nTLSL <= 0)
            {
                MessageBox.Show("标签数量应大于零！");
                this.txtSL.Text = "";
                this.txtSL.Focus();
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewXHTM_LostFocus(object sender, EventArgs e)
        {
            string strNewXHTM = this.txtNewXHTM.Text;
            if (strNewXHTM.Length == 0)
            {
                return;
            }
            string selectcmd = "if exists(select * from 箱号条码表 with(nolock)  where 箱号条码='" + strNewXHTM + "' and isnull(来料批次,'')='')";
            selectcmd = selectcmd + "\n     select 1";
            selectcmd = selectcmd + "\n else";
            selectcmd = selectcmd + "\n     select 0";
            if ((int)DataClass.GetValue(selectcmd) == 0)
            {
                MessageBox.Show("请使用新的空白标签！");
                this.txtNewXHTM.Text = "";
                this.txtNewXHTM.Focus();
                return;
            }
        }

        private void txtLLPC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLLPC_LostFocus(object sender, EventArgs e)
        {

        }
    }
}