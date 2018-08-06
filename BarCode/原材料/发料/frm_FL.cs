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
    public partial class FRM_UPDATE_ZZPC : Form
    {
        public FRM_UPDATE_ZZPC()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWLSJ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPTFL_Click(object sender, EventArgs e)
        {
            frm_FL_PTFL frm = new frm_FL_PTFL();
            frm.Show();
        }

        private void btnLXFL_Click(object sender, EventArgs e)
        {
            frm_FL_LXFL frm = new frm_FL_LXFL();
            frm.Show();
        }


        private void btnBCP_Click(object sender, EventArgs e)
        {
            frm_FL_BCP frm = new frm_FL_BCP();
            frm.Show();
        }

  

        private void btnYBWP_Click(object sender, EventArgs e)
        {
            FRM_YB frm = new FRM_YB();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_FULIAO frm = new FRM_FULIAO();
            frm.Show();
        }

      
    }
}