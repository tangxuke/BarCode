using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarCode
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYCL_Click(object sender, EventArgs e)
        {
            原材料.frm_Main frm = new BarCode.原材料.frm_Main();
            frm.Show();
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            成品管理.frm_CP frm = new BarCode.成品管理.frm_CP();
            frm.Show();
        }

        private void frm_Main_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你真的要初始化吗？", "初始化", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                string command = "exec 条码系统初始化";
                if (!DataClass.Execute(command))
                {
                    MessageBox.Show("初始化失败！\n" + DataClass.ErrorText);
                }
                else
                {
                    MessageBox.Show("初始化成功！");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer sndPlayer = new
            System.Media.SoundPlayer("\\Program Files\\barcode\\alarm3.wav");
            sndPlayer.PlayLooping();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //CommonClass.PlaySound(true);
            CommonClass.PlaySound(false);
        }

        private void btnBCP_Click(object sender, EventArgs e)
        {
            BCP.frm_BCP frm = new BarCode.BCP.frm_BCP();
            frm.Show();
        }

        private void btnBLP_Click(object sender, EventArgs e)
        {
            BLP.FRM_BLP frm = new BarCode.BLP.FRM_BLP();
            frm.Show();
            
        }

        private void btnWorkShop_Click(object sender, EventArgs e)
        {
            车间管理.FRM_USERID frm = new BarCode.车间管理.FRM_USERID();
            frm.Show();
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            设备管理.FRM_SBMANAGER frm = new BarCode.设备管理.FRM_SBMANAGER();
            frm.Show();
        }
    }
}