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
    public partial class frm_FJ : Form
    {
        public frm_FJ()
        {
            InitializeComponent();
        }

        private void btnXJ_Click(object sender, EventArgs e)
        {
            frm_FJ_XJ frm = new frm_FJ_XJ();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXJHD_Click(object sender, EventArgs e)
        {
            frm_FJ_XJHD frm = new frm_FJ_XJHD();
            frm.Show();
        }

        private void btnSJ_Click(object sender, EventArgs e)
        {
            frm_FJ_JC frm = new frm_FJ_JC();
            frm.Show();
        }

        private void btnSJHD_Click(object sender, EventArgs e)
        {
            frm_FJ_JCHD frm = new frm_FJ_JCHD();
            frm.Show();
        }
    }
}