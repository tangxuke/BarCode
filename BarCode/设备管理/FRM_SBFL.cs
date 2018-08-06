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
    public partial class FRM_SBFL : Form
    {
        public FRM_SBFL()
        {
            InitializeComponent();
        }

        private void FRM_SBFL_Load(object sender, EventArgs e)
        {
            this.fillUserid();
        }

        #region 填充车间
        private void fillUserid()
        {
            string sqlcommand = "exec 生成设备发料车间";
            DataTable dt = this.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("系统无法找到需求的发料单！", "系统提示");
                this.Close();
                return;
            }
            this.cmbUserID.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbUserID.Items.Add(dr["发往方向"].ToString());
            }
            this.cmbUserID.SelectedIndex = 0;
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fillFldh();
        }
        #endregion

        #region 填充发料单号
        private void fillFldh()
        {
            string strUserID = this.cmbUserID.Text.Trim();
            string sqlcommand = "exec 生成设备发料单号 '" + strUserID + "'";
            DataTable dt = this.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                this.fillUserid();  //没有找到发料单，跳到上一层，先填充车间
                return;
            }
            this.cmbFldno.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbFldno.Items.Add(dr["发料单号"].ToString());
            }
            this.cmbFldno.SelectedIndex = 0;
        }

        private void cmbFldno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Fillcpbh();
            this.fillSBFL();
        }

        private void Fillcpbh()
        {
            string strfldno = this.cmbFldno.Text.Trim();
            string sqlcommand = "select 生产产品 from 设备发料单 where 发料单号='" + strfldno + "'";
            DataTable dt = this.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                return;
            }
            this.txtcpbh.Text = dt.Rows[0]["生产产品"].ToString();
        }
        #endregion

        #region 填充设备分类
        private void fillSBFL()
        {
            string strfldh = this.cmbFldno.Text.Trim();
            string sqlcommand = "exec 生成设备发料分类 '" + strfldh + "'";
            DataTable dt = this.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                this.fillFldh();  //没有找到发料单，跳到上一层，先填充发料单号
                return;
            }
            this.cmbSBFL.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbSBFL.Items.Add(dr["设备分类"].ToString());
            }
            this.cmbSBFL.SelectedIndex = 0;
        }

        private void cmbSBFL_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fillSBXH();
        }
        #endregion

        #region 填充设备型号
        private void fillSBXH()
        {
            string strfldh = this.cmbFldno.Text.Trim();
            string strSBFL = this.cmbSBFL.Text.Trim();
            string sqlcommand = "exec 生成设备发料型号 '" + strfldh + "','" + strSBFL + "'";
            DataTable dt = this.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                this.fillSBFL();  //没有找到发料单，跳到上一层，先填充发料单号
                return;
            }
            this.cmbSBXH.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbSBXH.Items.Add(dr["设备型号"].ToString());
            }
            this.cmbSBXH.SelectedIndex = 0;
        }

        private void cmbSBXH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.fillSBNO();
        }
        #endregion

        #region 填充设备流号及实发等数据
        private void fillSBNO()
        {
            string strfldh = this.cmbFldno.Text.Trim();
            string strSBFL = this.cmbSBFL.Text.Trim();
            string strSBXH = this.cmbSBXH.Text.Trim();
            string sqlcommand = "exec 生成设备发料流水号 '" + strfldh + "','" + strSBFL + "','"+strSBXH +"'";
            DataTable dt = this.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                this.fillSBXH();  //没有找到对应的数据，跳到上一层，先填充发料单号
                this.txtSBNO.Text = "";
                this.txtYF.Text = "";
                this.txtSF.Text = "";
                this.txtPlace.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            this.txtSBNO.Text = dt.Rows[0]["设备流水号"].ToString();
            this.txtYF.Text = dt.Rows[0]["应发数量"].ToString();
            this.txtSF.Text = dt.Rows[0]["实发数量"].ToString();
            this.txtPlace.Text = dt.Rows[0]["存放地点"].ToString();
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();

        }
        #endregion

        #region 取数据
        private DataTable GetTable(string sqlcommand)
        {
            if (sqlcommand.Length == 0)
            {
                return null;
            }
            DataTable dt = DataClass.GetTable(sqlcommand);
            return dt;
        }

        #endregion

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter )
            {
                this.btnOK.Focus();
            }
            
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strfldh = this.cmbFldno.Text.Trim();
            string strSBFL = this.cmbSBFL.Text.Trim();
            string strSBXH = this.cmbSBXH.Text.Trim();
            string strSBNO = this.txtSBNO.Text.Trim();
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            string sqlcommand = "exec 设备发料 '" + strfldh + "','" + strSBFL + "','" + strSBXH + "','" + strSBNO + "','" + strXHTM + "'";
            if (DataClass.Execute(sqlcommand))
            {
                CommonClass.PlaySoundOK();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "发料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            this.fillSBNO();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSJ_Click(object sender, EventArgs e)
        {
            FRM_SBQXFL frm = new FRM_SBQXFL();
            frm.Show();
        }





    }
}