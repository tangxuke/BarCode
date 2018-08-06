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
    public partial class frm_YBWP : Form
    {
        public frm_YBWP()
        {
            InitializeComponent();
        }

        private void frm_YBWP_Load(object sender, EventArgs e)
        {
            this.FillFldno();
        }

        private void FillFldno()
        {
            this.cmbFldno.Items.Clear();
            string sqlstr = "SELECT * from 一般物品日报表 with(nolock) where isapprove=0";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有要发料的发料单！", "系统提示");
                this.Close();
                return;
            }
            this.cmbFldno.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbFldno.Items.Add(dr["fldh"].ToString().Trim());
            }
            this.cmbFldno.SelectedIndex = 0;
        }

        private void cmbFldno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillUserID();
        }

        private void FillUserID()
        {
            string strfldh = this.cmbFldno.Text.Trim();
            string sqlstr = "exec 生成一般物料发料单车间信息 '" + strfldh + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有车间要发料！", "系统提示");
                this.Close();
                return;
                
            }
            this.cmbUserID.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbUserID.Items.Add(dr["车间"].ToString().Trim());
            }

            this.cmbUserID.SelectedIndex = 0;
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillLLD();
        }

        private void FillLLD()
        {
            string strFldno = this.cmbFldno.Text.Trim();
            string strUserID = this.cmbUserID.Text.Trim();
            string sqlstr = "exec 生成一般物料发料单信息   '" + strFldno + "','" + strUserID + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("该车间没有找到要发的领料单号！", "系统提示");
                this.FillUserID();
                return;
            }
            this.cmbLLDH.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbLLDH.Items.Add(dr["领料单号"].ToString().Trim());
            }
            this.cmbLLDH.SelectedIndex = 0;

        }

        private void cmbLLDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillClbh();
        }

        private void FillClbh()
        {
            string strLLDH = this.cmbLLDH.Text.Trim();

            string sqlstr = "exec 生成一般物料发料单材料信息   '" + strLLDH + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("该领料单没有材料要发！", "系统提示");
                this.FillLLD();
                return;
            }
            this.cmbClbh.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbClbh.Items.Add(dr["材料编号"].ToString().Trim());
            }
            this.cmbClbh.SelectedIndex = 0;
        }

        private void cmbClbh_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fillYQS();
        }


        private void fillYQS()
        {
            string strLLDH = this.cmbLLDH.Text.Trim();
            string strClbh = this.cmbClbh.Text.Trim();
            string sqlstr = "exec 生成一般物料发料单材料余欠信息 '" + strLLDH + "','" + strClbh + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
               // MessageBox.Show("该物料没有找到条码！", "系统提示");
                this.FillClbh();
                return;
            }
            else
            {
                this.txtLLPC.Text = dt.Rows[0]["来料批次"].ToString();
                this.txtYFSL.Text = dt.Rows[0]["需发数量"].ToString();
                this.txtSFSL.Text = dt.Rows[0]["实发数量"].ToString();
                this.txtCWH.Text = dt.Rows[0]["仓位号"].ToString();
                this.txtXHTM.Focus();
            }
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM == "")
            {
                return;
            }
            strXHTM = strXHTM.Substring(2);
            string strFldno = this.cmbFldno.Text.Trim();
            string strLldno = this.cmbLLDH.Text.Trim();
            string strXhtm = this.txtXHTM.Text.Trim();
            strXhtm = strXhtm.Substring(2);
            //直接上传
            string command = "exec 一般物品发料 '" + strFldno + "','" + strLldno + "','" + strXhtm + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();

            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            this.fillYQS();
            this.txtXHTM.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM == "")
            {
                return;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("请扫入正确的箱号条码！", "系统提示");
                return ;
            }
            this.btnOK_Click(null, null);
        }

        private void btnFB_Click(object sender, EventArgs e)
        {
            //BQ_制作标签.frm_BQ_Split frm = new BarCode.YCL_原材料.BQ_制作标签.frm_BQ_Split();
            //frm.ShowDialog();
            //this.txtXHTM.Focus();
            制作标签.frm_BQ_Split frm = new BarCode.原材料.制作标签.frm_BQ_Split();
            frm.ShowDialog();
            this.txtXHTM.Focus();
        }

        



       


    
      





    }
}