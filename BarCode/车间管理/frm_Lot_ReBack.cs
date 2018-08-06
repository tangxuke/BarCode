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
    public partial class frm_Lot_ReBack : Form
    {
        private string cUserId;
        private DataTable dt;
        public frm_Lot_ReBack(string cUserID)
        {
            InitializeComponent();
            this.cUserId = cUserID;
            this.txtCWH.Focus();
        }

        private void txtXHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.txtCWH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请扫仓位号！");
                    this.txtCWH.Focus();
                    return;
                }
                string xhtm = this.txtXHTM.Text.Trim();
                if (xhtm.Length == 0)
                {
                    return;
                }
                if(xhtm.Substring(0,2)!="M.")
                {
                    MessageBox.Show("不是有效的箱号条码！");
                    this.txtXHTM.Text="";
                    this.txtXHTM.Focus();
                    return;
                }
                this.txtCWH.Text = DataClass.GetValue("select 仓位号 from 仓位库存表_车间 where 箱号条码='" + xhtm.Substring(2) + "'").ToString();

                string sql = "exec 条码_车间_物料投入信息 '"+xhtm.Substring(2)+"','"+this.cUserId+"'";
                this.dt = DataClass.GetTable(sql);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("此条码未在本车间投入！");
                    this.txtXHTM.Text = "";
                    this.txtXHTM.Focus();
                    return;
                }
                this.FillCPBH();
                
            }
        }

        private void txtXHTM_GotFocus(object sender, EventArgs e)
        {
            //if (this.txtCWH.Text.Length == 0)
            //{
            //    MessageBox.Show("请扫仓位号！");
            //    this.txtCWH.Focus();
            //    return;
            //}
        }

        private void FillCPBH()
        {
            this.comboCPBH.Items.Clear();
            this.comboZLDH.Items.Clear();
            
            foreach (DataRow row in this.dt.Rows)
            {
                object cpbh = row["产品编号"];
                if (!this.comboCPBH.Items.Contains(cpbh))
                {
                    this.comboCPBH.Items.Add(cpbh);
                }
            }
            if (this.dt.Rows.Count > 0)
            {
                //this.FillZLDH(this.dt.Rows[0]["产品编号"].ToString());
                this.comboCPBH.SelectedIndex = 0;
            }
        }

        private void FillZLDH(string cpbh)
        {
            this.comboZLDH.Items.Clear();
            foreach (DataRow row in this.dt.Select("产品编号='" + cpbh + "'"))
            {
                this.comboZLDH.Items.Add(row["制令单号"]);
            }
            if (this.dt.Rows.Count > 0)
                this.comboZLDH.SelectedIndex = 0;
        }

        private void comboCPBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillZLDH(this.comboCPBH.Text);
        }

        private void comboZLDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtTRSL.Text = "";
            if (this.dt.Rows.Count == 0)
                return;
            this.txtTRSL.Text=this.dt.Select("产品编号='" + this.comboCPBH.Text + "' and 制令单号='" + this.comboZLDH.Text + "'")[0]["投入数量"].ToString();
            this.txtQty.Text = "";
            this.txtQty.Focus();
        }

        private void Finish()
        {
            string cwh = this.txtCWH.Text;
            if (cwh.Substring(0, 2) != "H.")
            {
                MessageBox.Show("仓位号不合法！");
                this.txtCWH.Text = "";
                this.txtCWH.Focus();
                return;
            }
            cwh=cwh.Substring(2);

            string xhtm = this.txtXHTM.Text;
            if (xhtm.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不合法！");
                this.txtXHTM.Text = "";
                this.txtXHTM.Focus();
                return;
            }
            xhtm = xhtm.Substring(2);

            decimal qty = decimal.Parse(this.txtQty.Text);
            decimal input = decimal.Parse(this.txtTRSL.Text);
            if (qty >= input)
            {
                MessageBox.Show("退回数超过投入数！");
                this.txtQty.SelectAll();
                this.txtQty.Focus();
                return;
            }

            string sql = "exec 条码_车间_物料退回 '"+xhtm+"','"+this.comboZLDH.Text+"','"+cwh+"',"+qty.ToString();
            if (DataClass.Execute(sql))
            {
                MessageBox.Show("退回成功！请将物料放入指定仓位号！");
                CommonClass.PlaySoundOK();
                this.ClearData();
            }
            else
            {
                MessageBox.Show("退回失败！");
                CommonClass.PlaySoundNG();
            }
        }

        private void ClearData()
        {
            this.txtXHTM.Text = "";
            this.txtXHTM.Focus();
            this.comboCPBH.Items.Clear();
            this.comboZLDH.Items.Clear();
            this.txtTRSL.Text = "";
            this.txtQty.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}