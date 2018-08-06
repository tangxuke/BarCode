using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btnSL_Click(object sender, EventArgs e)
        {
            进仓.frm_JC frm = new BarCode.原材料.进仓.frm_JC();
            frm.Show();
        }

        private void btnFL_Click(object sender, EventArgs e)
        {
            发料.FRM_UPDATE_ZZPC frm = new BarCode.原材料.发料.FRM_UPDATE_ZZPC();
            frm.Show();
        }

  

        private void btnCX_Click(object sender, EventArgs e)
        {
            查询.frm_CX frm = new BarCode.原材料.查询.frm_CX();
            frm.Show();
        }

     

        private void btnBF_Click(object sender, EventArgs e)
        {
            报废.FRM_BF frm = new BarCode.原材料.报废.FRM_BF();
            frm.Show();
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnRefStock_Click(object sender, EventArgs e)
        {
            进仓.frm_NewStock frm = new 进仓.frm_NewStock();
            frm.Show();
        }

       

        private void btnBLP_Click(object sender, EventArgs e)
        {
            不良品.frm_BLP frm=new BarCode.原材料.不良品.frm_BLP();
            frm.Show();
        }

        private void btnDL_Click(object sender, EventArgs e)
        {
            呆料.FRM_DL frm = new BarCode.原材料.呆料.FRM_DL();
            frm.Show();
        }

        private void btnPD_Click(object sender, EventArgs e)
        {

        }

        private void btnSL_Click_1(object sender, EventArgs e)
        {
            收料.FRM_SL_ZZPC frm = new BarCode.原材料.收料.FRM_SL_ZZPC();
            frm.Show();
        }

    
        
    }
}