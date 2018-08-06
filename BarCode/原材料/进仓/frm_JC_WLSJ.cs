using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode.原材料.进仓
{
    public partial class frm_JC_WLSJ : Form
    {
        private _上架信息集合 _上架集合 = new _上架信息集合();
        private List<string> list原材料仓位 = new List<string>();
        private List<string> list材料不良品仓位 = new List<string>();
        public frm_JC_WLSJ()
        {
            InitializeComponent();
            string selectcmd = "select 格子号,dbo.查询仓位类型(格子号) as 类型 from 仓位表2 where dbo.查询仓位类型(格子号) in ('原材料','材料不良品')";
            DataTable table = DataClass.GetTable(selectcmd);
            foreach (DataRow row in table.Rows)
            {
                switch (row["类型"].ToString())
                {
                    case "原材料":
                        this.list原材料仓位.Add(row["格子号"].ToString());
                        break;
                    case "材料不良品":
                        this.list材料不良品仓位.Add(row["格子号"].ToString());
                        break;
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCWH_LostFocus(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text;
            if (strCWH.Length == 0)
            {
                return;
            }

            if (strCWH.Substring(0,2) !="H.")
            {
                MessageBox.Show("货架条码不合法！","系统提示");
                this.txtCWH.Text = "";
                this.txtCWH.Focus();
                return;
            }
 
        }

        private void txtCWH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.txtXTM.Focus();
            }
        }

        private void txtXTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }

        private void txtXTM_LostFocus(object sender, EventArgs e)
        {
            string strXTM = this.txtXTM.Text;
            if (strXTM.Length == 0)
            {
                return;
            }

            if (strXTM.Substring(0, 2) != "M.")
            {
                MessageBox.Show("箱号条码不合法！", "系统提示");
                this.txtXTM.Text = "";
                this.txtXTM.Focus();
                return;
            }
            this.btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strCWH = this.txtCWH.Text;
            string strXTM = this.txtXTM.Text;
            if (strXTM.Length == 0)
            {
                MessageBox.Show("请扫入箱条码！");
                this.txtXTM.Focus();
                return;
            }
            strCWH = strCWH.Substring(2, strCWH.Length - 2);
            strXTM = strXTM.Substring(2, strXTM.Length - 2);
            
            if (strCWH.Length == 0)
            {
                MessageBox.Show("请扫入仓位条码！");
                this.txtCWH.Focus();
                return;
            }
            if (strXTM.Length == 0)
            {
                MessageBox.Show("请扫入箱条码！");
                this.txtXTM.Focus();
                return;
            }

            if (!this._上架集合.Contains(strXTM))
            {
                string selectcmd = "exec 物料上架信息 '"+strXTM+"'";
                DataTable table = DataClass.GetTable(selectcmd);
                this._上架集合.FromDataTable(table);
            }
            if (!this._上架集合.Contains(strXTM))
            {
                MessageBox.Show("此箱不符合上架条件！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.ClearAll();
                return;
            }
            _上架信息 item = this._上架集合[strXTM];
            if (item.上架否)
            {
                MessageBox.Show("此箱已经上架！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.ClearAll();
                return;
            }
            if (item.状态 == "良品" && !this.list原材料仓位.Contains(strCWH))
            {
                MessageBox.Show("良品需上原材料架位！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.ClearAll();
                return;
            }
            if (item.状态 == "不良品" && !this.list材料不良品仓位.Contains(strCWH))
            {
                MessageBox.Show("不良品需上不良品架位！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.ClearAll();
                return;
            }
            item.上架否 = true;
            item.仓位号 = strCWH;
            int count = 0;
            foreach (_上架信息 obj in this._上架集合)
            {
                if (obj.上架否 && !obj.处理否)
                {
                    count++;
                }
            }
            this.labelInfo.Text = "待上传箱数：" + count.ToString() + "，缓存箱数：" + this._上架集合.Count.ToString() + "\n\r上一箱类型：" + item.上架类型.ToString();

            if (count>=1)
            {
                if (!this.UpdateData())
                {
                    MessageBox.Show("上传数据失败，请核对结果！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    this.ClearAll();
                    return;
                }
            }
            CommonClass.PlaySoundOK();
            this.ClearAll();
        }

        /// <summary>
        /// 上传数据
        /// </summary>
        /// <returns></returns>
        private bool UpdateData()
        {
            if (this._上架集合.Count == 0)
                return true;
            string commandtext = "";
            foreach (_上架信息 item in this._上架集合)
            {
                if (item.上架否 && !item.处理否)
                {
                    switch (item.上架类型)
                    {
                        case _上架类型.配料取消:
                            commandtext += "\r\n exec 配料取消 '" + item.箱号条码 + "','" + item.仓位号 + "'";
                            break;
                        case _上架类型.发料取消:
                            commandtext += "\r\n exec 发料取消 '" + item.箱号条码 + "','" + item.仓位号 + "'";
                            break;
                        case _上架类型.来料:
                            commandtext += "\r\n exec 物料上架 '" + item.仓位号 + "','" + item.箱号条码 + "'";
                            break;
                        case _上架类型.退料:
                            commandtext += "\r\n exec 退料上架 '" + item.仓位号 + "','" + item.箱号条码 + "'";
                            break;
                        case _上架类型.复检:
                            commandtext += "\r\n exec 复检进仓 '" + item.仓位号 + "','" + item.箱号条码 + "'";
                            break;
                        case _上架类型.初始化:
                            commandtext += "\r\n exec 初始化上架 '" + item.仓位号 + "','" + item.箱号条码 + "'";
                            break;
                    }
                    item.处理否 = true;
                }
            }
            if (commandtext.Length == 0)
                return true;
            bool result=DataClass.Execute(commandtext);
            if (!result)
            {
                MessageBox.Show(DataClass.ErrorText, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            return result;
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        private void ClearAll()
        {
            this.txtXTM.Text = "";
            this.txtXTM.Focus();
        }

        private void frm_JC_WLSJ_Closing(object sender, CancelEventArgs e)
        {
            if (!this.UpdateData())
            {
                MessageBox.Show("上传数据失败，请核对上架结果！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtXTM_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}