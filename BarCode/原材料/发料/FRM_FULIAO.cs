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
    public partial class FRM_FULIAO : Form
    {
        public FRM_FULIAO()
        {
            InitializeComponent();
        }

        private void FRM_FULIAO_Load(object sender, EventArgs e)
        {
            this.FillUserID();
        }

        private void FillUserID()
        {
             
            string sqlstr = "exec 生成辅料发料单车间信息 ";
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
            this.fillLLD();
        }

        private void fillLLD()
        {
            string strUserID = this.cmbUserID.Text.Trim();
            string sqlstr = "exec 生成辅料发料单信息   '" + strUserID + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
               // MessageBox.Show("该车间没有找到要发的领料单号！", "系统提示");
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

        private void FillClbh()
        {
            string strLLDH = this.cmbLLDH.Text.Trim();

            string sqlstr = "exec 生成辅料发料单材料信息   '" + strLLDH + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("该领料单没有材料要发！", "系统提示");
                this.fillLLD();
                return;
            }
            this.cmbClbh.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbClbh.Items.Add(dr["材料编号"].ToString().Trim());
            }
            this.cmbClbh.SelectedIndex = 0;
        }

        private void cmbLLDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillClbh();
        }

        private void cmbClbh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strLLDH = this.cmbLLDH.Text.Trim();
            string strClbh = this.cmbClbh.Text.Trim();
            string sqlstr = "exec 生成辅料发料单材料余欠信息 '" + strLLDH + "','" + strClbh + "'";
            DataTable dt = DataClass.GetTable(sqlstr);
            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("该物料已发完！", "系统提示");
                this.FillClbh();
                return;
            }
            else
            {
                this.txtCLMC.Text = dt.Rows[0]["材料名称"].ToString();
                this.txtYFSL.Text = dt.Rows[0]["应发数量"].ToString();
                this.txtSFSL.Text = dt.Rows[0]["可发数量"].ToString();
                this.txtSFSL.SelectAll();
                this.txtSFSL.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strLldno = this.cmbLLDH.Text.Trim();
            string strCLBH = this.cmbClbh.Text.Trim();
            string strQty = this.txtSFSL.Text.Trim();
            if (strQty == "")
            {
                return;
            }
            
            //直接上传
            string command = "exec 辅料发料  '" + strLldno + "','"+strCLBH+"','" + strQty + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
                this.FillClbh();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                
                return;
            }
            
        }

    }
}