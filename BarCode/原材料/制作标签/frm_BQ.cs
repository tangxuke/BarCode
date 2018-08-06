using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.制作标签
{
    public partial class frm_BQ : Form
    {
        public frm_BQ()
        {
            InitializeComponent();
        }

     

        private void frm_BQ_Load(object sender, EventArgs e)
        {

        }

        private void btnNewBQ_Click(object sender, EventArgs e)
        {
            frm_BQ_NewMade frm = new frm_BQ_NewMade();
            frm.Show();
        }

        private void btnCopyBQ_Click(object sender, EventArgs e)
        {
            frm_BQ_Copy frm = new frm_BQ_Copy();
            frm.Show(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXHCF_Click(object sender, EventArgs e)
        {
            frm_BQ_Split frm = new frm_BQ_Split();
            frm.Show();
        }
    }
}