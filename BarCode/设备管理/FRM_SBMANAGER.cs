using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.设备管理
{
    public partial class FRM_SBMANAGER : Form
    {
        public FRM_SBMANAGER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_SBFL frm = new FRM_SBFL();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_SBQXFL frm = new FRM_SBQXFL();
            frm.Show();
        }

        private void btnJC_Click(object sender, EventArgs e)
        {
            FRM_SBJC frm = new FRM_SBJC();
            frm.Show();
        }

        private void btnSBQuery_Click(object sender, EventArgs e)
        {
            FRM_SBQUERY frm = new FRM_SBQUERY();
            frm.Show();
        }

        private void btnCWHQuery_Click(object sender, EventArgs e)
        {
            FRM_SBCWHQUERY frm = new FRM_SBCWHQUERY();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_SBSJ frm = new FRM_SBSJ();
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FRM_SBYD frm = new FRM_SBYD();
            frm.Show();
        }

        
    }
}