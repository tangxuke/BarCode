using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.进仓
{
    public partial class frm_JC : Form
    {
        public frm_JC()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWLSJ_Click(object sender, EventArgs e)
        {
            frm_JC_WLSJ frm = new frm_JC_WLSJ();
            frm.Show();
        }

        private void btnWLYD_Click(object sender, EventArgs e)
        {
            frm_JC_WLYD frm = new frm_JC_WLYD();
            frm.Show();
        }

        private void btnBCPSJ_Click(object sender, EventArgs e)
        {
            frm_JC_BCPSJ frm = new frm_JC_BCPSJ();
            frm.Show();
        }

        private void btnTLDL_Click(object sender, EventArgs e)
        {
            FRM_JC_TLSJ frm = new FRM_JC_TLSJ();
            frm.Show();
        }

        private void btnINBox_Click(object sender, EventArgs e)
        {
            FRM_INBOX frm = new FRM_INBOX();
            frm.Show();
        }

        private void btnWXSJ_Click(object sender, EventArgs e)
        {
            frm_WXSJ frm = new frm_WXSJ();
            frm.Show();
        }

     
      

      

       
    }
}