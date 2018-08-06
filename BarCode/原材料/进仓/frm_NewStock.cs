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
    public partial class frm_NewStock : Form
    {
        public frm_NewStock()
        {
            InitializeComponent();
        }

        #region 窗体载入
        private void frm_NewStock_Load(object sender, EventArgs e)
        {
            this.RefreshWhid();
            this.ClearAll();
        }

        private void RefreshWhid()
        {
            this.cmbwhid.Items.Clear();
            string selectcmd = "select name from fzzl  with(nolock) where code='whid' order by id";
            DataTable table = DataClass.GetTable(selectcmd);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                this.cmbwhid.Items.Add(table.Rows[i][0]);
            }
        }

        #endregion

        #region 公共事件
        private void ClearAll()
        {
           // this.txtCWH.Text = "";
            this.txtXHTM.Text = "";
            this.txtLLPC.Text = "";
            this.txtCLBH.Text = "";
            this.txtQty.Text = "";
        }
        #endregion

        #region 仓位号事件
        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
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
            string sqlcmd = "select * from 仓位库存表 with(nolock)  where 箱号条码='" + strXHTM + "'";
            DataTable dt = DataClass.GetTable(sqlcmd);
            if (dt.Rows.Count == 0)
            {
                return;
            }

            this.txtLLPC.Text = dt.Rows[0]["来料批次"].ToString();
            this.txtCLBH.Text = dt.Rows[0]["材料编号"].ToString();
            this.txtQty.Text = dt.Rows[0]["数量"].ToString();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtLLPC.SelectAll();
                this.txtLLPC.Focus();
            }
        }
        #endregion

        #region 来料批次事件
        private void txtLLPC_LostFocus(object sender, EventArgs e)
        {
            string txtClbh = this.txtCLBH.Text;
            if (txtClbh != "")
            {
                this.txtQty.SelectAll();
                this.txtQty.Focus();
                return;
            }
            string sqlcmd = "select clbh from m_clmx  with(nolock) where llpc='" + this.txtLLPC.Text.Trim() + "'";
            DataTable dt = DataClass.GetTable(sqlcmd);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("来料批次错误，系统没有找到该来料批次！");
                return;
            }

            this.txtCLBH.Text = dt.Rows[0]["clbh"].ToString();
        }

        private void txtLLPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtQty.SelectAll();
                this.txtQty.Focus();
            }
        }
        #endregion

        #region 按钮事件
        private void btnOK_Click(object sender, EventArgs e)
        {
            string sqlcmd;
            string strCwh;
            string strWhid;
            string strZZpc;
            strWhid=this.cmbwhid.Text;
            strCwh = this.txtCWH.Text.Trim();
            strZZpc = this.txtzzpc.Text.Trim();
            if (strCwh == "" || this.txtXHTM.Text.Trim() == "" || this.txtLLPC.Text.Trim() == "" || strZZpc=="")
            {
                MessageBox.Show("数据不正确！");
                return;
            }
            strCwh = strCwh.Substring(0, 2);

            sqlcmd = "exec 更新条码库存 '" + strWhid + "','" + this.txtCWH.Text.Trim() + "','" + this.txtXHTM.Text.Trim() + "','" + this.txtLLPC.Text.Trim() + "','" + strZZpc + "'," + this.txtQty.Text.Trim() + "";

            if (DataClass.Execute(sqlcmd))
            {
                MessageBox.Show("更新数据成功！\n");
                this.ClearAll();
                this.txtXHTM.Focus();
            }
            else
            {
                MessageBox.Show("更新数据失败！\n" + DataClass.ErrorText);
            }
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            string strCWH;
            strCWH = this.txtCWH.Text.Trim();
            if (strCWH == "")
            {
                return;
            }
            if (strCWH.Substring(0, 2) != "H.")
            {
                MessageBox.Show("仓位号不正确！");
                this.txtCWH.SelectAll();
                this.txtCWH.Focus();
            }
        }

        private void cmbwhid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}