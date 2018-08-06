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
    public partial class frm_InputBCP : Form
    {
        public frm_InputBCP()
        {
            InitializeComponent();
        }
 

        private void txtProdno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
            }
        }

        private void txtProdno_LostFocus(object sender, EventArgs e)
        {
            this.FillProdNO();
            this.txtXHTM.Focus();
        }

        private void FillProdNO()
        {
            string strProdNO = this.txtProdno.Text.Trim();
            if (strProdNO.Length == 0)
            {
                return;
            }
            string strSql = "select  * from pdlots with(nolock)  where prodno='" + strProdNO + "'";
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此生产令号不存在！", "系统提示");
                this.txtProdno.SelectAll();
                this.txtProdno.Focus();
            }
            this.txtCPBH.Text = dt.Rows[0]["cpbh"].ToString();
            this.txtLotNo.Text = dt.Rows[0]["pdlotno"].ToString();
            this.txtUserID.Text = dt.Rows[0]["workshopid"].ToString();
            this.txtLine.Text = dt.Rows[0]["lineid"].ToString();
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
            string strXhtm = this.txtXHTM.Text.Trim();
            if (strXhtm.Length == 0)
            {
                return;
            }
            this.FillXHTM();
        }

        private void FillXHTM()
        {
            string strXHTM = this.txtXHTM.Text.Trim();
            if (strXHTM.Length == 0)
            {
                return;
            }
            if (strXHTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("扫描的条码格式不正确！", "系统提示");
                this.txtXHTM.SelectAll();
                return;
            }
            strXHTM = strXHTM.Substring(2);

            string strSql = "select 材料编号,来料批次,退料数量 from 半成品条码库存 with(nolock)  where 箱号条码='" + strXHTM + "' and dbo.查询仓位类型(仓位号)='车间' order by 材料编号";
            DataTable dt = DataClass.GetTable(strSql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("此箱号条码不存在！", "系统提示");
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
            }
            this.dataGrid1.DataSource = dt;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strProdno = this.txtProdno.Text.Trim();
            string strXhtm = this.txtXHTM.Text.Trim();
           
            if (strProdno.Length == 0 || strXhtm.Length == 0)
            {
                return;
            }
            strXhtm = strXhtm.Substring(2);
           
            string strsql = "exec 半成品投入 '" + strProdno + "','" + strXhtm + "' ";

            if (DataClass.Execute(strsql))
            {
                CommonClass.PlaySoundOK();
                this.dataGrid1.DataSource = null;
            }
            else
            {
                MessageBox.Show(DataClass.ErrorText, "半成品投入失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.txtXHTM.SelectAll();
                this.txtXHTM.Focus();
                return;
            }
            this.txtXHTM.Text = "";
            this.dataGrid1.DataSource = null;
            this.txtXHTM.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}