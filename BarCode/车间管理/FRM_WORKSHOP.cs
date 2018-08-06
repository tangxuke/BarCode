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
    public partial class FRM_WORKSHOP : Form
    {
        private string _UserID;
    
        public FRM_WORKSHOP()
        {
            InitializeComponent();
        }

        public string SetUserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                this._UserID = value;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInputMateriel_Click(object sender, EventArgs e)
        {
            frm_InputMateriel frm = new frm_InputMateriel();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_InputBack frm = new frm_InputBack();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_TM_QUERY frm = new frm_TM_QUERY();
            frm.Show();
        }

        private void btnBCP_Click(object sender, EventArgs e)
        {
            frm_InputBCP frm = new frm_InputBCP();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_inputQuery frm = new frm_inputQuery();
            frm.Show();
        }

        private void btnPLDDL_Click(object sender, EventArgs e)
        {
            FRM_PLDDL frm = new FRM_PLDDL();
            frm.__UserID = SetUserID;
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_FLDDL frm = new FRM_FLDDL();
            frm.__UserID = this.SetUserID;
            frm.Show();
        }

        private void btn3M_Click(object sender, EventArgs e)
        {
            FRM_CODECHECK frm = new FRM_CODECHECK();
            frm.Show();
        }

        private void FRM_WORKSHOP_Load(object sender, EventArgs e)
        {

        }

        private void btnSK_Click(object sender, EventArgs e)
        {
            FRM_SK_OUTPUT frm = new FRM_SK_OUTPUT();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_TM_COMPA frm = new FRM_TM_COMPA();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRM_JAE frm = new FRM_JAE();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FRM_USER_PD frm= new FRM_USER_PD(this._UserID);
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_Lot_Input frm= new frm_Lot_Input(this._UserID);
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_Lot_ReBack frm = new frm_Lot_ReBack(this._UserID);
            frm.Show();
        }

       
         

       
        
    }
}