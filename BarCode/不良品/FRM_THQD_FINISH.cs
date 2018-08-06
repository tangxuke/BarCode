using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.BLP
{
    public partial class FRM_THQD_FINISH : Form
    {
        public FRM_THQD_FINISH()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTHQD()
        {
            string commandtext = "exec 生成退货清单信息";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有适合的退货清单号!", "系统提示");
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbTHQD.Items.Add(dr["thdh"].ToString().Trim());
            }
            this.cmbTHQD.SelectedIndex = 0;
            
        }

        private void FillTHQDXHTM()
        {
            string strTHDH = this.cmbTHQD.Text.Trim();
            string commandtext = "exec 生成退货单条码信息 '" + strTHDH + "'";
            DataTable dt = DataClass.GetTable(commandtext);
            this.dataGrid1.DataSource = dt;
            this.txtXHTM.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strTHDH = this.cmbTHQD.Text.Trim();     
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确!", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            strXHTM = strXHTM.Substring(2);
            string commandtext = "exec 物料退货完成 '" + strTHDH + "', '" + strXHTM + "'";

            if (DataClass.Execute(commandtext))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "退货失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            this.FillTHQDXHTM();
        }


   
        private void FRM_THQD_FINISH_Load(object sender, EventArgs e)
        {
            this.FillTHQD();
             
        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTHQD_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillTHQDXHTM();
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
        }

        private void txtXHTM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确!", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            this.btnOK_Click(null, null);
        }


        

       
    }
}