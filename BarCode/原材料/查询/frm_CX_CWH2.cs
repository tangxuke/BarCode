using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.查询
{
    public partial class frm_CX_CWH2 : Form
    {
        public frm_CX_CWH2()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string strclbh = this.txtCLBH.Text.Trim();
            if (strclbh.Length == 0)
            {
                MessageBox.Show("请扫入材料编号再查询！");
                return;
            }

            string strsql = "exec 查询材料库存信息 '" + strclbh + "' ";
            DataTable dtQuery =new DataTable();
            dtQuery = DataClass.GetTable(strsql);
            dtQuery.TableName = "dtQuery";
            if (dtQuery.Rows.Count == 0)
            {
                this.txtCLBH.SelectAll();
                this.txtCLBH.Focus();
                return;
            }
            this.dataGrid1.DataSource = null;
            //this.dataGrid1.TableStyles.RemoveAt(0);
            this.txtQty.Text = dtQuery.Rows[0]["总库存"].ToString();
            this.txtEDPQty.Text = dtQuery.Rows[0]["EDP库存"].ToString();
            this.txtCheckQty.Text = dtQuery.Rows[0]["待检数量"].ToString();
            this.txtOKAQty.Text = dtQuery.Rows[0]["原材料A"].ToString();
            this.txtOKBQty.Text = dtQuery.Rows[0]["原材料B"].ToString();
            this.txtnoSend.Text = dtQuery.Rows[0]["未导数量"].ToString();

            DataGridTableStyle myStyle = new DataGridTableStyle();
            this.dataGrid1.TableStyles.Add(myStyle);
            myStyle.MappingName = dtQuery.TableName;
       

            DataGridTextBoxColumn myCol1 = new DataGridTextBoxColumn();
            DataGridTextBoxColumn myCol2 = new DataGridTextBoxColumn();
            DataGridTextBoxColumn myCol3 = new DataGridTextBoxColumn();

            myStyle.GridColumnStyles.Add(myCol1);
            myCol1.HeaderText = "仓位号";
            myCol1.MappingName = "仓位号";
            myCol1.Width = 100;

            myStyle.GridColumnStyles.Add(myCol2);
            myCol2.HeaderText = "数量";
            myCol2.MappingName = "数量";
            myCol2.Width = 60;

            myStyle.GridColumnStyles.Add(myCol3);
            myCol3.HeaderText = "件数";
            myCol3.MappingName = "件数";
            myCol3.Width = 30;

            this.dataGrid1.DataSource = dtQuery;
            
     
            this.txtCLBH.SelectAll();
            this.txtCLBH.Focus();
        }

        private void frm_CX_CWH2_Load(object sender, EventArgs e)
        {
            this.txtCLBH.Focus();
        }

        private void txtCLBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ConvertClbh();
                this.btnView.Focus();
            }
        }

        private void ConvertClbh()
        {
            string strClbh = this.txtCLBH.Text.Trim();
            if (strClbh.Substring(0, 2) == "M.")
            {
                strClbh = strClbh.Substring(2);
                string sqlstr = "select 材料编号 from 仓位库存表 where 箱号条码='" + strClbh + "'";
                DataTable dt = DataClass.GetTable(sqlstr);
                if (dt.Rows.Count > 0)
                {
                    this.txtCLBH.Text = dt.Rows[0]["材料编号"].ToString();
                    this.txtEDPQty.Text = "";
                    this.txtnoSend.Text = "";
                    this.txtQty.Text = "";
                    this.txtOKAQty.Text = "";
                    this.txtOKBQty.Text = "";
                    this.txtCheckQty.Text = "";
                    this.dataGrid1.TableStyles.RemoveAt(0);
                    this.dataGrid1.DataSource = null;
                }
                else
                {
                    MessageBox.Show("该条码无法转换为材料编号！", "系统提示");
                    this.txtCLBH.SelectAll();
                    //this.txtCLBH.Focus();
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCLBH_LostFocus(object sender, EventArgs e)
        {
            string strCLBH = this.txtCLBH.Text.Trim();
            if (strCLBH.Length == 0)
            {
                return;
            }
            this.ConvertClbh();
            this.btnView.Focus();
        }


       

    }
}