using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.BCP
{
    public partial class frm_BCP : Form
    {
        public frm_BCP()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            frm_BCPSJ frm = new frm_BCPSJ();
            frm.Show();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            frm_BCPFL frm = new frm_BCPFL();
            frm.Show();
        }

        private void btnYD_Click(object sender, EventArgs e)
        {
            frm_BCPYD frm = new frm_BCPYD();
            frm.Show();
        }

        private void btnBF_Click(object sender, EventArgs e)
        {
            frm_BCPBF frm = new frm_BCPBF();
            frm.Show();
        }

       
    }
}