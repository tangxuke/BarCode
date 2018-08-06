using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.发料
{
    public partial class frm_FL_BCP : Form
    {
        public frm_FL_BCP()
        {
            InitializeComponent();

            string selectcmd = "select top 10 fldh from bcp_fld_index with(nolock)  /*where qrr=''*/ order by flrq desc";
            DataTable table = DataClass.GetTable(selectcmd);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("没有需要发料的单！");
            }
            else
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    this.comboFLDH.Items.Add(row["fldh"]);
                }
                this.comboFLDH.SelectedIndex = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 刷新发料单
        /// </summary>
        /// <param name="fldh">发料单号</param>
        private void RefreshData(string fldh)
        {
            string selectcmd = "select clbh as 材料编号,llpc as 来料批次,sfsl as 实发数 from bcp_fld_pc  with(nolock) where fldh='" + fldh + "' order by 材料编号,来料批次";
            DataTable table = DataClass.GetTable(selectcmd);
            table.TableName = "发料批次";
            this.dataGrid1.DataSource = table;
        }

        private void comboFLDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fldh = this.comboFLDH.Text;
            this.txtXHTM.Text = "";
            this.RefreshData(fldh);
            this.txtXHTM.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string fldh = this.comboFLDH.Text;
            string strXHTM = this.txtXHTM.Text;
            string commandtext = "exec 半成品发料 '"+fldh+"','"+strXHTM+"'";
            if (!DataClass.Execute(commandtext))
            {
                MessageBox.Show("执行失败！\n" + DataClass.ErrorText);
            }
            else
            {
                //MessageBox.Show("执行成功！");
                CommonClass.PlaySoundOK();
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                this.RefreshData(fldh);
            }
        }
    }
}