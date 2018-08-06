using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.车间管理
{
    public partial class FRM_USERID : Form
    {
        public FRM_USERID()
        {
            InitializeComponent();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "A3";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "A3";
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "B3";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "B3";
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "C2";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "C2";
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "C3";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "C3";
            frm.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "B8";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "B8";
            frm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "D2";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "D2";
            frm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "D3";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "D3";
            frm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "E1";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "E1";
            frm.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "E2";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "E2";
            frm.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "E3";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "E3";
            frm.Show();
            this.Close();
    }

        private void button10_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "CY";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "CY";
            frm.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "SJ";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "SJ";
            frm.Show();
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "B6";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "B6";
            frm.Show();
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "B7";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "B7";
            frm.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "SMT";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "SMT";
            frm.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "YB";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "YB";
            frm.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FRM_SCAN frm = new FRM_SCAN();
            frm.Show();
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CommonClass.pUserID = "B5";
            FRM_WORKSHOP frm = new FRM_WORKSHOP();
            frm.SetUserID = "B5";
            frm.Show();
            this.Close();
        }
    }
}