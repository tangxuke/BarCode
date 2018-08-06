using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;

namespace BarCode
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            DataClass.FromXml("\\Program Files\\BarCode\\Setting.xml");
        }

        private void btnNX_Click(object sender, EventArgs e)
        {
            DataClass.database = "WISE_ORDER_NX";
            string userid = this.txtUser.Text;
            string password = this.txtPassword.Text;
            if (userid.Length == 0)
            {
                MessageBox.Show("请输入用户名！");
                this.txtUser.Focus();
                return;
            }

            if (DataClass.CheckUser(userid, password))
            {
                DataClass.UserId = userid;
                DataClass.Password = password;
                frm_Main frm = new frm_Main();
                //YCL_原材料.frm_Main frm = new BarCode.YCL_原材料.frm_Main();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败！\n" + DataClass.ErrorText);
                this.txtPassword.Text = "";
                this.txtPassword.Focus();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            DataClass.database = "WISE_ORDER";
            string userid = this.txtUser.Text;
            string password = this.txtPassword.Text;
            if (userid.Length == 0)
            {
                MessageBox.Show("请输入用户名！");
                this.txtUser.Focus();
                return;
            }
            
            if (DataClass.CheckUser(userid, password))
            {
                DataClass.UserId = userid;
                DataClass.Password = password;
                frm_Main frm = new frm_Main();
                //YCL_原材料.frm_Main frm = new BarCode.YCL_原材料.frm_Main();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败！\n" + DataClass.ErrorText);
                this.txtPassword.Text = "";
                this.txtPassword.Focus();
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtPassword.SelectAll();
                this.txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOk_Click(null, null);
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            this.btnOk.Focus();
        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}