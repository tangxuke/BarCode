using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.复检
{
    public partial class frm_FJ_XJ : Form
    {
        public frm_FJ_XJ()
        {
            InitializeComponent();
        }

        public frm_FJ_XJ(string strFjdno)
        {
            InitializeComponent();
            this.txtFjdno.Text = strFjdno;
            this.SetRefresh();
            this.txtXHTM.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //this.btnFJXJ.Focus();
                this.btnFJXJ_Click(null, null);
            }
        }

        private void txtXHTM_LostFocus(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text;
            if (this.txtXHTM.Text.Length == 0)
                return;
            this.labelCLBH.Text = "";
            this.labelLLPC.Text = "";
            this.labelSL.Text = "";
            this.lblCWH.Text = "";


            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不合法！", "系统提示");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            strXHTM = strXHTM.Substring(2, strXHTM.Length - 2);

            DataTable table = DataClass.GetTable("select * from 仓位库存表  with(nolock) where 箱号条码='" + strXHTM + "'");
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("无法找到数据！");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            DataRow row = table.Rows[0];
            this.labelCLBH.Text = row["材料编号"].ToString();
            this.labelLLPC.Text = row["来料批次"].ToString();
            this.labelSL.Text = row["数量"].ToString();
        }

        private void btnFJXJ_Click(object sender, EventArgs e)
        {
            string strXHTM = this.txtXHTM.Text;
            if (strXHTM.Length == 0)
            {
                MessageBox.Show("请输入箱号条码！");
                this.txtXHTM.Focus();
                return;
            }
            string strFjdno;
            strFjdno = this.txtFjdno.Text.Trim();
            if (strFjdno.Length == 0)
            {
                MessageBox.Show("复检单号不能为空！");
                this.txtFjdno.SelectAll();
                this.txtFjdno.Focus();
                return;
            }

            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不合法！", "系统提示");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            strXHTM = strXHTM.Substring(2, strXHTM.Length - 2);

            string commandtext = "exec 复检下架 '"+ strFjdno +"','"+strXHTM+"'";
            if (DataClass.Execute(commandtext))
            {
                //MessageBox.Show("下架成功！");
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.labelCLBH.Text = "";
                this.labelLLPC.Text = "";
                this.labelSL.Text = "";
                this.txtXHTM.Focus();
            }
            else
            {
                MessageBox.Show("下架失败！\n" + DataClass.ErrorText);
                this.txtXHTM.Focus();
            }
            this.SetRefresh();
        }

     

        private void SetRefresh()
        {
            //还有XX箱等下架，建议：
            string txtFjdno;
            this.labelCLBH.Text = "";
            this.labelLLPC.Text = "";
            this.labelSL.Text = "";
            this.txtXHTM.Text = "";

            txtFjdno = this.txtFjdno.Text.Trim();
            this.lblInfo.Text = "";
            if (txtFjdno.Length == 0)
            {
                return;
            }

            string sqlCmd;
            sqlCmd = "select top 1 *,isnull((select 仓位号 from 仓位库存表 with(nolock)  where 箱号条码=复检箱号条码.箱号条码),'') as cwh from 复检箱号条码  with(nolock) where 复检单号='" + txtFjdno + "' and 已下架=0  order by cwh";
            DataTable table = DataClass.GetTable(sqlCmd);
            if (table.Rows.Count == 0)
            {
                this.lblInfo.Text = "没有待复检下架的物料！";
                return;
            }
            this.lblInfo.Text = "建议下架：";

            DataRow row = table.Rows[0];
            this.lblCWH.Text=row["cwh"].ToString();
            this.labelCLBH.Text = row["材料编号"].ToString();
            this.labelLLPC.Text = row["来料批次"].ToString();
            this.labelSL.Text = row["数量"].ToString();

            //this.txtXHTM.Text=row["箱号条码"].ToString();
        }

        private void txtFjdno_LostFocus(object sender, EventArgs e)
        {
            this.SetRefresh();
            this.txtXHTM.Focus();
        }

        private void txtFjdno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.Focus();
            }
        }
    }
}