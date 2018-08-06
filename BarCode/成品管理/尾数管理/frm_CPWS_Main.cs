using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.成品管理
{
    public partial class frm_CPWS_Main : Form
    {
        public frm_CPWS_Main()
        {
            InitializeComponent();
        }

        private void btnWSRKD_Click(object sender, EventArgs e)
        {
            尾数管理.frm_CP_WSRKD frm = new BarCode.成品管理.尾数管理.frm_CP_WSRKD();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            尾数管理.frm_CP_WSCKD frm = new BarCode.成品管理.尾数管理.frm_CP_WSCKD();
            frm.Show();
        }


    
    }
}