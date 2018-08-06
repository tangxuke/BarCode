namespace BarCode.成品管理
{
    partial class frm_CP
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
            this.btnWSManager = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnCPSJ = new System.Windows.Forms.Button();
            this.btnCPJS = new System.Windows.Forms.Button();
            this.btnCHQR = new System.Windows.Forms.Button();
            this.btnTBJC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFacebookCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWSManager
            // 
            this.btnWSManager.Location = new System.Drawing.Point(14, 6);
            this.btnWSManager.Name = "btnWSManager";
            this.btnWSManager.Size = new System.Drawing.Size(106, 37);
            this.btnWSManager.TabIndex = 18;
            this.btnWSManager.Text = "尾数管理";
            this.btnWSManager.Click += new System.EventHandler(this.btnWSManager_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(43, 224);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 37);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(14, 47);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(106, 37);
            this.btnMove.TabIndex = 19;
            this.btnMove.Text = "成品移动";
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(126, 6);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(106, 37);
            this.btnTK.TabIndex = 20;
            this.btnTK.Text = "泰科出货扫描";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnCPSJ
            // 
            this.btnCPSJ.Location = new System.Drawing.Point(126, 47);
            this.btnCPSJ.Name = "btnCPSJ";
            this.btnCPSJ.Size = new System.Drawing.Size(106, 37);
            this.btnCPSJ.TabIndex = 21;
            this.btnCPSJ.Text = "成品上架";
            this.btnCPSJ.Click += new System.EventHandler(this.btnCPSJ_Click);
            // 
            // btnCPJS
            // 
            this.btnCPJS.Location = new System.Drawing.Point(14, 90);
            this.btnCPJS.Name = "btnCPJS";
            this.btnCPJS.Size = new System.Drawing.Size(106, 37);
            this.btnCPJS.TabIndex = 22;
            this.btnCPJS.Text = "成品接收";
            this.btnCPJS.Click += new System.EventHandler(this.btnCPJS_Click);
            // 
            // btnCHQR
            // 
            this.btnCHQR.Location = new System.Drawing.Point(126, 133);
            this.btnCHQR.Name = "btnCHQR";
            this.btnCHQR.Size = new System.Drawing.Size(106, 37);
            this.btnCHQR.TabIndex = 23;
            this.btnCHQR.Text = "出货确认";
            this.btnCHQR.Click += new System.EventHandler(this.btnCHQR_Click);
            // 
            // btnTBJC
            // 
            this.btnTBJC.Location = new System.Drawing.Point(126, 90);
            this.btnTBJC.Name = "btnTBJC";
            this.btnTBJC.Size = new System.Drawing.Size(106, 37);
            this.btnTBJC.TabIndex = 24;
            this.btnTBJC.Text = "特别检查";
            this.btnTBJC.Click += new System.EventHandler(this.btnTBJC_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 25;
            this.button1.Text = "车载品确认";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFacebookCheck
            // 
            this.btnFacebookCheck.Location = new System.Drawing.Point(14, 176);
            this.btnFacebookCheck.Name = "btnFacebookCheck";
            this.btnFacebookCheck.Size = new System.Drawing.Size(218, 37);
            this.btnFacebookCheck.TabIndex = 26;
            this.btnFacebookCheck.Text = "Facebook QSFP+ 出货检查";
            this.btnFacebookCheck.Click += new System.EventHandler(this.btnFacebookCheck_Click);
            // 
            // frm_CP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnFacebookCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTBJC);
            this.Controls.Add(this.btnCHQR);
            this.Controls.Add(this.btnCPJS);
            this.Controls.Add(this.btnCPSJ);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnWSManager);
            this.Controls.Add(this.btnExit);
            this.Name = "frm_CP";
            this.Text = "成品管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWSManager;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnCPSJ;
        private System.Windows.Forms.Button btnCPJS;
        private System.Windows.Forms.Button btnCHQR;
        private System.Windows.Forms.Button btnTBJC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFacebookCheck;
    }
}