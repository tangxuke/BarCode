using System;
using System.Windows;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.发料
{
    public partial class FRM_FL_PCCONTROL : Form
    {
        public FRM_FL_PCCONTROL(string clbh)
        {
            InitializeComponent();
            this.txtClbh.Text = clbh;
            this.FillPC();
        }
        private void FillPC()
        {
            string strclbh = this.txtClbh.Text.Trim();
            if (strclbh.Length == 0)
            {
                return;
            }
            string strsql = "exec 生成条码批次信息 '" + strclbh + "'";
            DataTable dt = DataClass.GetTable(strsql);
            if (dt.Rows.Count > 0)
            {
                this.cmbLLPC.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    this.cmbLLPC.Items.Add(dr["llpc"].ToString());
                }
                this.cmbLLPC.SelectedIndex = 0;
            }
        }

        private void cmbLLPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strLlpc = this.cmbLLPC.Text.Trim();
            if (strLlpc.Length == 0)
            {
                return;
            }
            string strsql = "exec 生成条码批次箱数 '" + strLlpc + "'";
            DataTable dt = new DataTable();
             dt=   DataClass.GetTable(strsql);
            this.lblInfo.Text = "此批次还有" + dt.Rows[0]["箱数"].ToString() + "箱";
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            string strLlpc = this.cmbLLPC.Text.Trim();
            string strsql = "exec 条码优先发料 '" + strLlpc + "'";
            if (DataClass.Execute(strsql))
            {
                CommonClass.PlaySoundOK();
                MessageBox.Show("设置优先发料成功!","系统提示");
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "设置优先发料配料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDisEnabled_Click(object sender, EventArgs e)
        {
            string strLlpc = this.cmbLLPC.Text.Trim();
            string strsql = "exec 条码禁止发料 '" + strLlpc + "'";
            if (DataClass.Execute(strsql))
            {
                CommonClass.PlaySoundOK();
                MessageBox.Show("设置禁止发料成功!", "系统提示");
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "设置禁止发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要删除此批次的条码？", "系统提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                string strLlpc = this.cmbLLPC.Text.Trim();
                string strsql = "exec 条码按批次删除 '" + strLlpc + "'";
                if (DataClass.Execute(strsql))
                {
                    CommonClass.PlaySoundOK();
                    MessageBox.Show("删除该批次条码成功!", "系统提示");
                }
                else
                {
                    MessageBox.Show(DataClass.ErrorText, "删除该批次条码失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }

        }

      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

 
}