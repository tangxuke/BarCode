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
    public partial class frm_CP : Form
    {
        public frm_CP()
        {
            InitializeComponent();
        }

     

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWSManager_Click(object sender, EventArgs e)
        {
            frm_CPWS_Main frm = new frm_CPWS_Main();
            frm.Show();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            frm_CP_MOVE frm = new frm_CP_MOVE();
            frm.Show();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            FRM_TK frm = new FRM_TK();
            frm.Show();
        }

        private void btnCPSJ_Click(object sender, EventArgs e)
        {
            FRM_CPSJ frm = new FRM_CPSJ();
            frm.Show();
        }

        private void btnCPJS_Click(object sender, EventArgs e)
        {
            FRM_CPJS frm = new FRM_CPJS();
            frm.Show();
        }

        private void btnCHQR_Click(object sender, EventArgs e)
        {
            FRM_CH_SCAN frm = new FRM_CH_SCAN();
            frm.Show();
        }

        private void btnTBJC_Click(object sender, EventArgs e)
        {
            FRM_TBJC frm = new FRM_TBJC();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_KCQR frm = new FRM_KCQR();
            frm.Show();
        }

        private void btnFacebookCheck_Click(object sender, EventArgs e)
        {
            Other.frm_CP_Other_Fackbook frm = new BarCode.成品管理.Other.frm_CP_Other_Fackbook();
            frm.Show();
        }

      

        
    }
}