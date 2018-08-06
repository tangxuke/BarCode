using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.发料
{
    public partial class FRM_YB : Form
    {
        public FRM_YB()
        {
            InitializeComponent();
        }

        private void btnFL_Click(object sender, EventArgs e)
        {
            frm_YBWP frm = new frm_YBWP();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FRM_YBWP_CANCEL frm = new FRM_YBWP_CANCEL();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}