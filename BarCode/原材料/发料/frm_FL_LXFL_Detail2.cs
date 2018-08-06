using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.发料
{
    public partial class frm_FL_LXFL_Detail2 : Form
    {
        private DataTable datatableFLD;
        private DataTable datatableFLCL;
        private DataTable datatableYQS;

        private string whid,cgy, userid;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="strCGY">仓管员</param>
        /// <param name="date">日期</param>
        /// <param name="klkc">考虑库存</param>
        /// <param name="klyq">考虑余欠</param>
        public frm_FL_LXFL_Detail2(string whid,string strCGY, string strUserID)
        {
            InitializeComponent();
            this.whid = whid;
            this.cgy = strCGY;
            this.userid = strUserID;
            this.FillFLD();
        }

        private void FillFLD()
        {
            this.cmbFldNO.Items.Clear();
            string selectcmd = "exec 生成发料单信息2 '"+this.whid +"','" + this.cgy + "','" + this.userid + "'";
            datatableFLD = DataClass.GetTable(selectcmd);
            if (datatableFLD.Rows.Count == 0)
            {
                MessageBox.Show("此车间料已发完！", "系统提示");
                this.Close();
                return;
            }
            foreach (DataRow dr in datatableFLD.Rows)
            {
                this.cmbFldNO.Items.Add(dr["发料单号"].ToString().Trim());
            }
            this.cmbFldNO.SelectedIndex = 0;
        }

        private void cmbFldNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtCpbh.Text = datatableFLD.Select("发料单号='" + this.cmbFldNO.Text.Trim() + "'")[0]["产品编号"].ToString();
            this.FillClbh();
        }

        private void FillClbh()
        {
            this.cmbCLBH.Items.Clear();
            string strFldno = this.cmbFldNO.Text.Trim();
            string selectcmd = "exec 生成发料材料信息2 '"+this.whid +"', '" + strFldno + "', '" + this.cgy + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                this.FillFLD();
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbCLBH.Items.Add(dr["材料编号"].ToString().Trim());
            }
            this.cmbCLBH.SelectedIndex = 0;
        }

        private void cmbCLBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillYQS();
        }

        private void FillYQS()
        {
            string selectcmd = "exec 生成发料材料余欠信息2 '"+ this.whid+"', '" + this.cmbFldNO.Text.Trim() + "','" + this.cmbCLBH.Text.Trim() + "'";
            this.datatableYQS = DataClass.GetTable(selectcmd);
            if (datatableYQS.Rows.Count == 0)
            {
                this.FillClbh();
                return;
            }
            if (datatableYQS.Rows[0]["来料批次"].ToString()=="")
            {
                this.FillClbh();
                return;
            }
            this.txtYqs.Text = datatableYQS.Rows[0]["余欠数"].ToString();
            this.txtCWH.Text = datatableYQS.Rows[0]["仓位号"].ToString();
            this.txtLLPC.Text = datatableYQS.Rows[0]["来料批次"].ToString();
            this.txtZZPC.Text = datatableYQS.Rows[0]["制造批次"].ToString();
            this.txtPCCount.Text = datatableYQS.Rows[0]["批次箱数"].ToString();
            this.txtYFXS.Text = datatableYQS.Rows[0]["已发箱数"].ToString();
            this.txtXH.Text = datatableYQS.Rows[0]["外箱箱号"].ToString();
            this.txtXHTM.Focus();
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
            if (this.CheckXHTM())
            {
                this.btnOK_Click(null, null);
            }
            else
            {
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
            }
        }

        private bool CheckXHTM()
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM == "")
            {
                return true;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("请扫入正确的箱号条码！", "系统提示");
                return false;
            }
            strXHTM = strXHTM.Substring(2);
            string strzzpc = this.txtZZPC.Text.Trim();
            string selectcmd = "select * from 仓位库存表 with(nolock)  where 外箱条码号='" + strXHTM + "' and 制造批次='" + strzzpc + "'";
            DataTable dt = DataClass.GetTable(selectcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("请按指定制造批次发料！", "系统提示");
                return false;
            }
            return true;
        }

        private void ClearAll()
        {
            this.cmbCLBH.Items.Clear();
            this.txtLLPC.Text = "";
            this.txtZZPC.Text = "";
            this.txtPCCount.Text = "";
            this.txtYqs.Text = "";
            this.txtCWH.Text = "";
            this.txtXHTM.Text = "";
            this.txtXH.Text = "";
            this.txtYFXS.Text = "";
            this.txtXHTM.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string xhtm = this.txtXHTM.Text;
            if (xhtm.Length == 0)
                return;
            if (xhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不正确！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            xhtm = xhtm.Substring(2);
            string fldno = this.cmbFldNO.Text;
            string clbh = this.cmbCLBH.Text;
            string strzzpc = this.txtZZPC.Text.Trim();
            //直接上传
            string command = "exec 物料发料_外箱 '" + fldno + "','" + xhtm + "','" + strzzpc  + "'";
            if (DataClass.Execute(command))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            this.txtXHTM.Text = "";
            this.FillYQS();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            制作标签.frm_BQ_Split frm = new BarCode.原材料.制作标签.frm_BQ_Split();
            frm.ShowDialog();
            string strPldno = this.cmbFldNO.Text.Trim();
            string strClbh = this.cmbCLBH.Text.Trim();
            this.txtXHTM.Focus();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frm_ShowPld frm = new frm_ShowPld(this.cmbFldNO.Text.Trim());
            frm.Show();

        }

        private void btnPCControl_Click(object sender, EventArgs e)
        {
            FRM_FL_PCCONTROL frm = new FRM_FL_PCCONTROL(this.cmbCLBH.Text.Trim());
            frm.Show();
        }

       

       
       
    }
}