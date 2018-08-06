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
    public partial class FRM_PLDDL : Form
    {
        private string _UserID;

        public FRM_PLDDL()
        {
            InitializeComponent();
        }

        public string __UserID
        {
            get { return this._UserID; }
            set { this._UserID = value; }
        }

        private void FRM_PLDDL_Load(object sender, EventArgs e)
        {
            this.FillPldno();
        }

        #region 填充配料单号
        private void FillPldno()
        {
            string sqlcommand = "exec 生成未点料配料单号 '"+this.__UserID +"'";
            DataTable dt = DataClass.GetTable(sqlcommand);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("配料单已全部点完！", "系统提示");
                this.Close();
                return;
            }
            this.cmbPldNO.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                this.cmbPldNO.Items.Add(dr["pldno"].ToString());
            }
            this.cmbPldNO.SelectedIndex = 0;
        }

        private void cmbPldNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillXHTM();
        }
        #endregion


        private void FillXHTM()
        {
            string strpldno = this.cmbPldNO.Text.Trim();
            if (strpldno.Length == 0)
            {
                return;
            }
            string sqlcmd = "exec 查询配料单未点料信息2 '" + strpldno + "'" ;
            DataTable dt = DataClass.GetTable(sqlcmd);
            this.dataGrid1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                if (DataClass.ErrorText.Length == 0)
                {
                    MessageBox.Show("此配料单已点料完成！", "系统提示");
                }
                this.FillPldno();
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

        private void txtXhtm_LostFocus(object sender, EventArgs e)
        {

            this.FinishDL();
        }

        private void FinishDL()
        {
            string strpldno = this.cmbPldNO.Text.Trim();
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
                txtXhtm.Text = "";
                return;
            }

            strXHTM = strXHTM.Substring(2);
            strCWH = strCWH.Substring(2);

            string sqlcmd = "exec 配料点料 '" + strpldno + "','"+ strXHTM  +"','"+strCWH+"' ";
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

        private void txtCWH_GotFocus(object sender, EventArgs e)
        {
            this.txtCWH.Text = "";
        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            if (this.txtCWH.Text.Length > 0 && this.txtCWH.Text.Substring(0, 2) != "H.")
            {
                MessageBox.Show("仓位条码不合法！");
                this.txtCWH.Text = "";
                this.txtCWH.Focus();
            }
        }

     
   



    }

}