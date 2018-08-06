namespace BarCode
{
    partial class frm_Main
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
            this.btnYCL = new System.Windows.Forms.Button();
            this.btnCP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBCP = new System.Windows.Forms.Button();
            this.btnBLP = new System.Windows.Forms.Button();
            this.btnWorkShop = new System.Windows.Forms.Button();
            this.btnDevices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYCL
            // 
            this.btnYCL.Location = new System.Drawing.Point(48, 4);
            this.btnYCL.Name = "btnYCL";
            this.btnYCL.Size = new System.Drawing.Size(150, 32);
            this.btnYCL.TabIndex = 0;
            this.btnYCL.Text = "原材料";
            this.btnYCL.Click += new System.EventHandler(this.btnYCL_Click);
            // 
            // btnCP
            // 
            this.btnCP.Location = new System.Drawing.Point(48, 108);
            this.btnCP.Name = "btnCP";
            this.btnCP.Size = new System.Drawing.Size(150, 32);
            this.btnCP.TabIndex = 2;
            this.btnCP.Text = "成品";
            this.btnCP.Click += new System.EventHandler(this.btnCP_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(48, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBCP
            // 
            this.btnBCP.Location = new System.Drawing.Point(48, 39);
            this.btnBCP.Name = "btnBCP";
            this.btnBCP.Size = new System.Drawing.Size(150, 32);
            this.btnBCP.TabIndex = 4;
            this.btnBCP.Text = "半成品";
            this.btnBCP.Click += new System.EventHandler(this.btnBCP_Click);
            // 
            // btnBLP
            // 
            this.btnBLP.Location = new System.Drawing.Point(48, 73);
            this.btnBLP.Name = "btnBLP";
            this.btnBLP.Size = new System.Drawing.Size(150, 32);
            this.btnBLP.TabIndex = 5;
            this.btnBLP.Text = "不良品";
            this.btnBLP.Click += new System.EventHandler(this.btnBLP_Click);
            // 
            // btnWorkShop
            // 
            this.btnWorkShop.Location = new System.Drawing.Point(48, 146);
            this.btnWorkShop.Name = "btnWorkShop";
            this.btnWorkShop.Size = new System.Drawing.Size(150, 32);
            this.btnWorkShop.TabIndex = 6;
            this.btnWorkShop.Text = "车间管理";
            this.btnWorkShop.Click += new System.EventHandler(this.btnWorkShop_Click);
            // 
            // btnDevices
            // 
            this.btnDevices.Location = new System.Drawing.Point(48, 181);
            this.btnDevices.Name = "btnDevices";
            this.btnDevices.Size = new System.Drawing.Size(150, 32);
            this.btnDevices.TabIndex = 7;
            this.btnDevices.Text = "设备管理";
            this.btnDevices.Click += new System.EventHandler(this.btnDevices_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.btnDevices);
            this.Controls.Add(this.btnWorkShop);
            this.Controls.Add(this.btnBLP);
            this.Controls.Add(this.btnBCP);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCP);
            this.Controls.Add(this.btnYCL);
            this.Name = "frm_Main";
            this.Text = "主界面";
            this.Closed += new System.EventHandler(this.frm_Main_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYCL;
        private System.Windows.Forms.Button btnCP;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBCP;
        private System.Windows.Forms.Button btnBLP;
        private System.Windows.Forms.Button btnWorkShop;
        private System.Windows.Forms.Button btnDevices;
    }
}