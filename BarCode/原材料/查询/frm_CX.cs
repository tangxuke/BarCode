using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.查询
{
    public partial class frm_CX : Form
    {
        public frm_CX()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCLCX_Click(object sender, EventArgs e)
        {
            frm_CX_CL frm = new frm_CX_CL();
            frm.Show();
        }

        private void btnPCCX_Click(object sender, EventArgs e)
        {
            frm_CX_PC frm = new frm_CX_PC();
            frm.Show();
        }

        private void btnXHCX_Click(object sender, EventArgs e)
        {
            frm_CX_XH frm = new frm_CX_XH();
            frm.Show();
        }

        private void btnCWCX_Click(object sender, EventArgs e)
        {
            frm_CX_CWH frm = new frm_CX_CWH();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_CX_CWH_GROUP frm = new FRM_CX_CWH_GROUP();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_CX_CWH2 frm = new frm_CX_CWH2();
            frm.Show();
        }

    }
}