using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.报废
{
    public partial class FRM_BF : Form
    {
        public FRM_BF()
        {
            InitializeComponent();
        }

        private void btnBF_Click(object sender, EventArgs e)
        {
            frm_BFCK frm = new frm_BFCK();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frm_BFCANCEL frm = new frm_BFCANCEL();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBFSJ_Click(object sender, EventArgs e)
        {
            FRM_BFSJ frm = new FRM_BFSJ();
            frm.Show();
        }
    }
}