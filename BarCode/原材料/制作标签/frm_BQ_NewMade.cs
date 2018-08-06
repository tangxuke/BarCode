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
    public partial class frm_BQ_NewMade : Form
    {
        public frm_BQ_NewMade()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtLLPC.Focus();
            }
        }

        private void txtLLPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtTLSL.Focus();
            }
        }

        private void txtTLSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtXHTM.Text.Length == 0)
            {
                MessageBox.Show("请扫入空白标签条码！");
                this.txtXHTM.Focus();
                return;
            }
            if (this.txtLLPC.Text.Length == 0)
            {
                MessageBox.Show("请输入材料批次！");
                this.txtLLPC.Focus();
                return;
            }
            if (this.txtTLSL.Text.Length == 0)
            {
                MessageBox.Show("请输入退料数量！");
                this.txtTLSL.Focus();
                return;
            }
            string strXHTM = this.txtXHTM.Text;
            string strLLPC = this.txtLLPC.Text;
            decimal nTLSL = decimal.Parse(this.txtTLSL.Text);
            string commandtext = "exec 制作退料标签 '"+strXHTM+"','"+strLLPC+"',"+nTLSL.ToString();
            if(DataClass.Execute(commandtext))
            {
                this.txtXHTM.Text="";
                this.txtLLPC.Text="";
                this.labelCLBH.Text="";
                this.txtTLSL.Text="";
                this.txtXHTM.Focus();
                MessageBox.Show("更新数据成功！");
            }
            else
            {
                MessageBox.Show("制作标签失败！\n"+DataClass.ErrorText);
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text;
            if (strXHTM.Length == 0)
                return;
            string selectcmd = "if exists(select * from 箱号条码表 where 箱号条码='" + strXHTM + "' and isnull(来料批次,'')='')";
            selectcmd = selectcmd + "\n     select 1";
            selectcmd = selectcmd + "\n else";
            selectcmd = selectcmd + "\n     select 0";
            if ((int)DataClass.GetValue(selectcmd) == 0)
            {
                MessageBox.Show("请使用新的空白标签！");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            selectcmd = "if not exists(select * from 仓位库存表 where 箱号条码='" + strXHTM + "')";
            selectcmd = selectcmd + "\n     select 1";
            selectcmd = selectcmd + "\n else";
            selectcmd = selectcmd + "\n     select 0";
            if ((int)DataClass.GetValue(selectcmd) == 0)
            {
                MessageBox.Show("请使用空白的标签！");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
        }

        private void txtLLPC_LostFocus(object sender, EventArgs e)
        {
            this.labelCLBH.Text = "";
            string strLLPC = this.txtLLPC.Text;
            if (strLLPC.Length == 0)
                return;
            string selectcmd = "if exists(select * from pckc_ym  with(nolock) where llpc='" + strLLPC + "' and sfsl>0)";
            selectcmd = selectcmd + "\n     select 1";
            selectcmd = selectcmd + "\n else";
            selectcmd = selectcmd + "\n     select 0";
            if ((int)DataClass.GetValue(selectcmd) == 0)
            {
                MessageBox.Show("批次不存在！");
                this.txtLLPC.Text = "";
                this.txtLLPC.Focus();
                return;
            }
            string clbh = (string)DataClass.GetValue("select clbh from pckc_ym  with(nolock) where llpc='" + strLLPC + "'");
            if (clbh != null)
            {
                this.labelCLBH.Text = clbh;
            }
        }

        private void txtTLSL_LostFocus(object sender, EventArgs e)
        {
            if(this.txtTLSL.Text.Length==0)
                return;
            decimal nTLSL = decimal.Parse(this.txtTLSL.Text);
            if (nTLSL <= 0)
            {
                MessageBox.Show("标签数量应大于零！");
                this.txtTLSL.Text = "";
                this.txtTLSL.Focus();
                return;
            }
            string strLLPC = this.txtLLPC.Text;
            if (strLLPC.Length == 0)
            {
                MessageBox.Show("请先输入批次信息！");
                this.txtTLSL.Text = "";
                this.txtLLPC.Focus();
                return;
            }
            string selectcmd = "if exists(select * from pckc_ym  with(nolock) where llpc='" + strLLPC + "' and sfsl>=" + nTLSL.ToString() + ")";
            selectcmd += "\n      select 1";
            selectcmd += "\n else";
            selectcmd += "\n     select 0";
            if ((int)DataClass.GetValue(selectcmd) == 0)
            {
                MessageBox.Show("批次不正确或者退料数量过大！");
                this.txtTLSL.Text = "";
                this.txtTLSL.Focus();
                return;
            }
        }
    }
}