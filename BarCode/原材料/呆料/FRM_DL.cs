using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.呆料
{
    public partial class FRM_DL : Form
    {
        public FRM_DL()
        {
            InitializeComponent();
        }

        private void btnToDL_Click(object sender, EventArgs e)
        {
            FRM_TODL frm = new FRM_TODL();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDLSJ_Click(object sender, EventArgs e)
        {
            FRM_DL_SJ frm = new FRM_DL_SJ();
            frm.Show();
        }

       

    
    }
}