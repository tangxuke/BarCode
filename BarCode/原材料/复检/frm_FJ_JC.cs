using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.复检
{
    public partial class frm_FJ_JC : Form
    {
        public frm_FJ_JC()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK_Click(null, null);
            }
        }

        private void txtJCSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            this.labelCWLX.Text = "";
            string strCWH = this.txtCWH.Text;
            if (strCWH.Substring(0, 2) != "H.")
            {
                MessageBox.Show("仓位号不合法！", "系统提示");
                this.txtCWH.Text = "";
                this.txtCWH.Focus();
                return;
            }


            if (strCWH.Length == 0)
                return;

            //if(!CommonClass.CheckCWH(strCWH))
            //{
            //    MessageBox.Show("仓位号不存在！");
            //    this.txtCWH.Text = "";
            //    this.txtCWH.Focus();
            //    return;
            //}
            string strCWLX = (string)DataClass.GetValue("select dbo.查询仓位类型('" + strCWH + "')");
            this.labelCWLX.Text = strCWLX;
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            this.labelCLBH.Text = "";
            this.labelLLPC.Text = "";
            string strXHTM = this.txtXHTM.Text;

            if (strXHTM.Length == 0)
                return;

            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不合法！", "系统提示");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }


            //if (!CommonClass.CheckXHTM(strXHTM))
            //{
            //    MessageBox.Show("箱号不存在！");
            //    this.txtXHTM.Text = "";
            //    this.txtXHTM.Focus();
            //    return;
            //}
            strXHTM = strXHTM.Substring(2, strXHTM.Length - 2);
            string strLLPC = CommonClass.GetLLPC(strXHTM);
            string strCLBH = CommonClass.GetCLBH(strXHTM);
            this.labelCLBH.Text = strCLBH;
            this.labelLLPC.Text = strLLPC;

            object oSl =  DataClass.GetValue(" select 数量 from 复检验判明细 where 箱号条码='" + strXHTM + "'  and 是否上架=0 order by id desc");
            if (oSl == null)
            {
                MessageBox.Show("无法读取数量信息!");

                return;
            }
            decimal nSl = (decimal)oSl;
            this.txtJCSL.Text = nSl.ToString();
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text;
            string strXHTM = this.txtXHTM.Text;
            decimal nJCSL = decimal.Parse(this.txtJCSL.Text);
            strCWH = strCWH.Substring(2, strCWH.Length - 2);
            strXHTM = strXHTM.Substring(2, strXHTM.Length - 2);

            //if (!CommonClass.CheckCWH(strCWH))
            //{
            //    MessageBox.Show("仓位号不存在！");
            //    this.txtCWH.Text = "";
            //    this.labelCWLX.Text = "";
            //    this.txtCWH.Focus();
            //    return;
            //}

            //if (!CommonClass.CheckXHTM(strXHTM))
            //{
            //    MessageBox.Show("箱号条码不存在！");
            //    this.txtXHTM.Text = "";
            //    this.labelCLBH.Text = "";
            //    this.labelLLPC.Text = "";
            //    this.txtXHTM.Focus();
            //    return;
            //}

            string commandtext = "exec 复检进仓 '" + strCWH + "','" + strXHTM + "'," + nJCSL.ToString();
            if (!DataClass.Execute(commandtext))
            {
                MessageBox.Show("执行失败！\n" + DataClass.ErrorText);
            }
            else
            {
                //MessageBox.Show("执行成功！");
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.labelCLBH.Text = "";
                this.labelLLPC.Text = "";
                this.txtXHTM.Focus();
                this.txtJCSL.Text = "";
            }
        }

        private void txtJCSL_GotFocus(object sender, EventArgs e)
        {
            this.txtJCSL.SelectAll();
        }
    }
}