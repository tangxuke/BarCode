using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.进仓
{
    public partial class FRM_INBOX : Form
    {
        public FRM_INBOX()
        {
            InitializeComponent();
        }

        #region 窗体载入
        private void frm_NewStock_Load(object sender, EventArgs e)
        {
            this.txtWX.Focus();
        }
        #endregion

        #region 箱号条码事件
        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            if(strXHTM.Substring(0,2)!="M.")
            {
                MessageBox.Show("箱号条码不正确！");
                this.txtXHTM.Text="";
                this.txtXHTM.Focus();
                return;
            }
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK_Click(null, null);
            }
        }
        #endregion

        #region 按钮事件
        private void btnOK_Click(object sender, EventArgs e)
        {
            string sqlcmd;
            string strwx = this.txtWX.Text.Trim();
            string strxhtm = this.txtXHTM.Text.Trim();
            if (strwx.Length == 0 || strwx.Substring(0, 2) != "M.")
            {
                MessageBox.Show("外箱条码号不正确！", "系统提示");
                return;
            }
            if (strxhtm.Length == 0 || strxhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码号不正确！", "系统提示");
                return;
            }
            strxhtm = strxhtm.Substring(2);
            strwx = strwx.Substring(2);
            sqlcmd = "exec 条码装箱 '" + strwx + "','" + strxhtm + "'";
            if (DataClass.Execute(sqlcmd))
            {
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
            }
            else
            {
                MessageBox.Show("条码装箱失败！\n" + DataClass.ErrorText);
            }
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 外箱条码事件
        private void txtWX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
        }

        private void txtWX_LostFocus(object sender, EventArgs e)
        {
            string strwx = this.txtWX.Text.Trim();
            if (strwx.Length==0 || strwx.Substring(0,2)!="M.")
            {
                MessageBox.Show("外箱条码号不正确！","系统提示");
                return;
            }
            strwx = strwx.Substring(2);
            string sqlcommandtext = "select *,(select count(*) from 仓位库存表 with(nolock)  where 外箱条码号=仓位库存表_外箱.外箱条码号 and 仓位类型='原材料') as 总件数 from 仓位库存表_外箱 with(nolock)  where 外箱条码号='" + strwx + "'";
            DataTable dt = DataClass.GetTable(sqlcommandtext);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("系统没有找到外箱条码号，请再确认！", "系统提示");   
                return;
            }
            this.txtCLBH.Text = dt.Rows[0]["材料编号"].ToString();
            this.txtLLPC.Text = dt.Rows[0]["来料批次"].ToString();
            this.txtQty.Text = dt.Rows[0]["来料批次"].ToString();
            this.txtJS.Text = dt.Rows[0]["总件数"].ToString();
        }
        #endregion

      
    }
}