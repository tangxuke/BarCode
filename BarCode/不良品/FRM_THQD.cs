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
    public partial class FRM_THQD : Form
    {
        public FRM_THQD()
        {
            InitializeComponent();
        }


        private void FillTHQD()
        {
            string commandtext = "select * from thqd_index with(nolock)  where isnull(isaudit,0)=0";
            DataTable dt = DataClass.GetTable(commandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有适合的退货清单号!","系统提示");
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbTHQD.Items.Add(dr["thdh"].ToString().Trim());
            }
            this.cmbTHQD.SelectedIndex = 0;
            this.txtXHTM.Focus();
        }

        private void FRM_THQD_Load(object sender, EventArgs e)
        {
            this.FillTHQD();
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if(strXHTM.Length==0)
            {
                return;
            }
            if (strXHTM.Substring(0,2)!="M.")
            {
                MessageBox.Show("箱号条码不正确!", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return ;
            }
            strXHTM=strXHTM.Substring(2);
            string commandtext = "select * from 仓位库存表  with(nolock) where 箱号条码='" + strXHTM + "' and  dbo.查询仓位类型(仓位号)='材料不良品'";
            DataTable dt=DataClass.GetTable(commandtext);
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("此条码不正确，或已经退给供应商了!","系统提示");
                return;
            }
            this.txtCLBH.Text=dt.Rows[0]["材料编号"].ToString();
            this.txtLLPC.Text=dt.Rows[0]["来料批次"].ToString();
            this.txtQTY.Text=dt.Rows[0]["数量"].ToString();

            this.btnOK_Click(null, null);
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length==0)
            {
                return;
            }
            if (strXHTM.Substring(0,2)!="M.")
            {
                MessageBox.Show("箱号条码不正确!", "系统提示");
                this.txtXHTM.Focus();
                return ;
            }
            strXHTM=strXHTM.Substring(2);
            string strTHQD = this.cmbTHQD.Text.Trim();
            string command = "exec 物料退货 '" + strTHQD + "','" + strXHTM + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "退货失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXHTM.Text = "";
            this.txtCLBH.Text = "";
            this.txtLLPC.Text = "";
            this.txtQTY.Text = "";
            this.txtXHTM.Focus();


        }

        private void btnBCP_Click(object sender, EventArgs e)
        {
            FRM_THQD_BCP frm = new FRM_THQD_BCP(this.cmbTHQD.Text.Trim());
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXHTM_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            string strTHDH = this.cmbTHQD.Text.Trim();
            string commandtext = "exec 退货清单审核 '" + strTHDH + "'";
            if( DataClass.Execute(commandtext))
            {
                MessageBox.Show("审核成功!", "系统提示");
            }
            else
            {
                MessageBox.Show("审核失败!", "系统提示");
                return;
            }
        }

        private void txtXHTM_TextChanged(object sender, EventArgs e)
        {

        }



    }
}