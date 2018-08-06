namespace BarCode.车间管理
{
    partial class FRM_WORKSHOP
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInputMateriel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBCP = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPLDDL = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn3M = new System.Windows.Forms.Button();
            this.btnSK = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInputMateriel
            // 
            this.btnInputMateriel.Enabled = false;
            this.btnInputMateriel.Location = new System.Drawing.Point(18, 40);
            this.btnInputMateriel.Name = "btnInputMateriel";
            this.btnInputMateriel.Size = new System.Drawing.Size(98, 28);
            this.btnInputMateriel.TabIndex = 0;
            this.btnInputMateriel.Text = "物料投入";
            this.btnInputMateriel.Click += new System.EventHandler(this.btnInputMateriel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(46, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(18, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "物料退回";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "条码查询";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBCP
            // 
            this.btnBCP.Location = new System.Drawing.Point(122, 40);
            this.btnBCP.Name = "btnBCP";
            this.btnBCP.Size = new System.Drawing.Size(98, 28);
            this.btnBCP.TabIndex = 4;
            this.btnBCP.Text = "半成品物料投入";
            this.btnBCP.Click += new System.EventHandler(this.btnBCP_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(122, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "物料查询";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPLDDL
            // 
            this.btnPLDDL.Location = new System.Drawing.Point(18, 10);
            this.btnPLDDL.Name = "btnPLDDL";
            this.btnPLDDL.Size = new System.Drawing.Size(98, 28);
            this.btnPLDDL.TabIndex = 6;
            this.btnPLDDL.Text = "配料单点料";
            this.btnPLDDL.Click += new System.EventHandler(this.btnPLDDL_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(122, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 28);
            this.button5.TabIndex = 7;
            this.button5.Text = "发料单点数";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn3M
            // 
            this.btn3M.Location = new System.Drawing.Point(17, 136);
            this.btn3M.Name = "btn3M";
            this.btn3M.Size = new System.Drawing.Size(98, 28);
            this.btn3M.TabIndex = 8;
            this.btn3M.Text = "3M二维条码";
            this.btn3M.Click += new System.EventHandler(this.btn3M_Click);
            // 
            // btnSK
            // 
            this.btnSK.Location = new System.Drawing.Point(122, 136);
            this.btnSK.Name = "btnSK";
            this.btnSK.Size = new System.Drawing.Size(98, 28);
            this.btnSK.TabIndex = 9;
            this.btnSK.Text = "水口料投入";
            this.btnSK.Click += new System.EventHandler(this.btnSK_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "物料比对";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 169);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 28);
            this.button6.TabIndex = 11;
            this.button6.Text = "JAE标签检查";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(122, 170);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 28);
            this.button7.TabIndex = 12;
            this.button7.Text = "车间物料盘点";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(18, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 28);
            this.button8.TabIndex = 13;
            this.button8.Text = "物料投入(新)";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(18, 72);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 28);
            this.button9.TabIndex = 14;
            this.button9.Text = "物料退回(新)";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // FRM_WORKSHOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSK);
            this.Controls.Add(this.btn3M);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnPLDDL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBCP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInputMateriel);
            this.Name = "FRM_WORKSHOP";
            this.Text = "车间管理";
            this.Load += new System.EventHandler(this.FRM_WORKSHOP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInputMateriel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBCP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPLDDL;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn3M;
        private System.Windows.Forms.Button btnSK;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}