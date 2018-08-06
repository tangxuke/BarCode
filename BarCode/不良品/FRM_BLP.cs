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
    public partial class FRM_BLP : Form
    {
        public FRM_BLP()
        {
            InitializeComponent();
        }

        private void btnSJ_Click(object sender, EventArgs e)
        {
            FRM_BLPSJ frm = new FRM_BLPSJ();
            frm.Show();
        }

        private void btnTHQD_Click(object sender, EventArgs e)
        {
            FRM_TH frm = new FRM_TH();
            frm.Show();
        }

        private void btnFinishTH_Click(object sender, EventArgs e)
        {
            FRM_THQD_FINISH frm = new FRM_THQD_FINISH();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FRM_THQD_CANCEL frm = new FRM_THQD_CANCEL();
            frm.Show();
        }

        private void btnFJ_Click(object sender, EventArgs e)
        {
            FRM_BLPFJ frm = new FRM_BLPFJ();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFL_Click(object sender, EventArgs e)
        {
            FRM_BLPFL frm = new FRM_BLPFL();
            frm.Show();
        }

        private void btnBF_Click(object sender, EventArgs e)
        {
            FRM_BLPBF frm = new FRM_BLPBF();
            frm.Show();
        }

        private void btnBFCancel_Click(object sender, EventArgs e)
        {
            原材料.报废.frm_BFCANCEL frm = new BarCode.原材料.报废.frm_BFCANCEL();
            frm.Show();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FRM_BLP_QUERY frm = new FRM_BLP_QUERY();
            frm.Show();
        }

        
    }
}