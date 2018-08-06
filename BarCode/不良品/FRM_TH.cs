using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.BLP
{
    public partial class FRM_TH : Form
    {
        public FRM_TH()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTHQD_Click(object sender, EventArgs e)
        {
            FRM_THQD frm = new FRM_THQD();
            frm.Show();
        }

        private void btnSJ_Click(object sender, EventArgs e)
        {
            FRM_THQD_SJ frm = new FRM_THQD_SJ();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnFinishTH_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            FRM_THQD_CANCEL FRM = new FRM_THQD_CANCEL();
            FRM.Show();
        }

        private void btnFinishTH_Click_1(object sender, EventArgs e)
        {
            FRM_THQD_FINISH frm = new FRM_THQD_FINISH();
            frm.Show();
        }
    }
}