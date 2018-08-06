using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.不良品
{
    public partial class frm_BLP : Form
    {
        public frm_BLP()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRK_Click(object sender, EventArgs e)
        {
            frm_BLPRK frm = new frm_BLPRK();
            frm.Show();
        }

        private void btnCK_Click(object sender, EventArgs e)
        {
            frm_BLPCK frm = new frm_BLPCK();
            frm.Show();
        }
    }
}