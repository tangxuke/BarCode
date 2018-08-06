using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BarCode.成品管理.Other
{
    public partial class frm_CP_Other_Fackbook : Form
    {
        private string cpbh = "";

        public frm_CP_Other_Fackbook()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear()
        {
            this.textBox1.Text = "";
            this.textBox1.Focus();
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
        }

        private int CheckFiles(string[] searchPaths, string xhtm, ref string file)
        {
            
            foreach (string path in searchPaths)
            {
                file="";
                if (this.CheckFiles(path, xhtm, ref file) == 1)
                {
                    return 1;
                }
            }
            return 0;
        }

        private int CheckFiles(string path, string xhtm,ref string file)
        {
            file = "";
            try
            {
                string[] files = Directory.GetFiles(path, "*" + xhtm + "*");
                if (files.Length > 0)
                {
                    file = files[0];
                    return 1;
                }
                else
                {
                    string[] paths = Directory.GetDirectories(path, "*" + this.cpbh + "*");
                    foreach (string path1 in paths)
                    {
                        if (this.CheckFiles(path1, xhtm, ref file) == 1)
                            return 1;
                    }
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                string strXHTM = this.textBox1.Text.Trim();
                string strCPBH = (string)DataClass.GetValue("select cpbh from pdlots with(nolock) where prodno=(select 生产制令号 from 成品条码表_3M where 箱号条码='"+strXHTM+"')");
                if (strCPBH == null)
                {
                    MessageBox.Show("此条码并不存在！");
                    this.Clear();
                    return;
                }
                this.cpbh = strCPBH;

                string file1="",file2="",file3="";
                //导通检查
                switch(this.CheckFiles("\\\\easytouch-pc\\QSFP  Test data",strXHTM,ref file1))
                {
                    case 1:
                        this.checkBox1.Checked=true;
                        break;
                    case 0:
                        MessageBox.Show("导通测试未通过！");
                        this.Clear();
                        return;
                    case -1:
                        MessageBox.Show("网络异常，无法访问导通测试目录，请联系电脑工程师！");
                        this.Clear();
                        return;
                }

                //烧录检查
                switch (this.CheckFiles("\\\\qsfp\\Data", strXHTM,ref file2))
                {
                    case 1:
                        this.checkBox2.Checked = true;
                        break;
                    case 0:
                        MessageBox.Show("烧录测试未通过！");
                        this.Clear();
                        return;
                    case -1:
                        MessageBox.Show("网络异常，无法访问烧录测试目录，请联系电脑工程师！");
                        this.Clear();
                        return;
                }

                //高频检查
                switch (this.CheckFiles(new string[]{"\\\\PNA\\3M","\\\\agilent\\3M"}, strXHTM,ref file3))
                {
                    case 1:
                        this.checkBox3.Checked = true;
                        break;
                    case 0:
                        MessageBox.Show("高频测试未通过！");
                        this.Clear();
                        return;
                    case -1:
                        MessageBox.Show("网络异常，无法访问高频测试目录，请联系电脑工程师！");
                        this.Clear();

                        return;
                }

                
                //更新数据库
                string sql = "update 成品条码表_3M set 测试通过=1,测试时间=getdate(),导通测试文件='"+file1+"',烧录测试文件='"+file2+"',高频测试文件='"+file3+"' where 箱号条码='"+strXHTM+"'";
                if (DataClass.Execute(sql))
                {
                     CommonClass.PlaySoundOK();
                   MessageBox.Show("测试通过！");
                }
                else
                {
                     CommonClass.PlaySoundNG();
                   MessageBox.Show("保存到数据库失败，请重新尝试或联系系统管理员！");
                }
                this.Clear();
            }
        }
    }
}