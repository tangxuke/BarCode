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
    public partial class FRM_FLDDL : Form
    {
        private string  _userID;
    
        public FRM_FLDDL()
        {
            InitializeComponent();
        }

        public string  __UserID
        {
            get
            {
                //throw new System.NotImplementedException();
                return this._userID;
            }
            set
            {
                this._userID = value;
            }
        }

        #region 填充发料单号
        private void fillFldNo()
        {
            string sqlcommand = "exec 生成未点料发料单号 '" + this.__UserID + "'";
            DataTable dt = DataClass.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("发料单已全部点完！", "系统提示");
                this.Close();
                return;
            }
            this.cmbFldNO.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbFldNO.Items.Add(dr["fldh"].ToString());
            }
            this.cmbFldNO.SelectedIndex = 0;
        }

        private void cmbFldNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillXHTM();
        }
        #endregion


        private void FillXHTM()
        {
            string strfldno = this.cmbFldNO.Text.Trim();
            if (strfldno.Length == 0)
            {
                return;
            }
            string sqlcmd = "exec 查询发料单未点料信息2 '" + strfldno + "'" ;
            DataTable dt = DataClass.GetTable(sqlcmd);
            this.dataGrid1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                if (DataClass.ErrorText.Length == 0)
                {
                    MessageBox.Show("此发料单已点料完成！", "系统提示");
                }
                this.fillFldNo();
            }
            this.txtXhtm.Focus();
        }

        private void txtXhtm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnClose.Focus();
            }
        }

       

        private void FinishDL()
        {
            string strfldno = this.cmbFldNO.Text.Trim();
            string strXHTM = this.txtXhtm.Text.Trim();
            string strCWH = this.txtCWH.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }

            if (strCWH.Length == 0)
            {
                MessageBox.Show("请扫仓位号条码！");
                this.txtCWH.Focus();
                this.txtXhtm.Text = "";
                return;
            }

            strXHTM = strXHTM.Substring(2);
            strCWH = strCWH.Substring(2);

            string sqlcmd = "exec 发料点料 '" + strfldno + "','" + strXHTM + "','"+strCWH+"' ";
            if (DataClass.Execute(sqlcmd))
            {
                CommonClass.PlaySoundOK();
                this.txtXhtm.Text = "";
                this.txtXhtm.Focus();
                this.FillXHTM();
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "点料失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXhtm.Text = "";
                this.txtXhtm.Focus();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_FLDDL_Load(object sender, EventArgs e)
        {
            this.fillFldNo();
        }

        private void txtXhtm_LostFocus(object sender, EventArgs e)
        {
            this.FinishDL();
        }

        private void txtCWH_GotFocus(object sender, EventArgs e)
        {
            this.txtCWH.Text = "";
        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            if (this.txtCWH.Text.Length > 0 && this.txtCWH.Text.Substring(0, 2) != "H.")
            {
                MessageBox.Show("不是合法仓位条码！");
                this.txtCWH.Text = "";
                this.txtCWH.Focus();
            }
        }
    }
}