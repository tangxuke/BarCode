namespace BarCode.原材料.复检
{
    partial class frm_FJ
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXJ = new System.Windows.Forms.Button();
            this.btnXJHD = new System.Windows.Forms.Button();
            this.btnSJHD = new System.Windows.Forms.Button();
            this.btnSJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(53, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXJ
            // 
            this.btnXJ.Location = new System.Drawing.Point(53, 78);
            this.btnXJ.Name = "btnXJ";
            this.btnXJ.Size = new System.Drawing.Size(132, 45);
            this.btnXJ.TabIndex = 7;
            this.btnXJ.Text = "复检下架";
            this.btnXJ.Click += new System.EventHandler(this.btnXJ_Click);
            // 
            // btnXJHD
            // 
            this.btnXJHD.Location = new System.Drawing.Point(53, 66);
            this.btnXJHD.Name = "btnXJHD";
            this.btnXJHD.Size = new System.Drawing.Size(132, 28);
            this.btnXJHD.TabIndex = 8;
            this.btnXJHD.Text = "下架核对";
            this.btnXJHD.Visible = false;
            this.btnXJHD.Click += new System.EventHandler(this.btnXJHD_Click);
            // 
            // btnSJHD
            // 
            this.btnSJHD.Location = new System.Drawing.Point(53, 167);
            this.btnSJHD.Name = "btnSJHD";
            this.btnSJHD.Size = new System.Drawing.Size(132, 28);
            this.btnSJHD.TabIndex = 10;
            this.btnSJHD.Text = "进仓核对";
            this.btnSJHD.Visible = false;
            this.btnSJHD.Click += new System.EventHandler(this.btnSJHD_Click);
            // 
            // btnSJ
            // 
            this.btnSJ.Location = new System.Drawing.Point(53, 123);
            this.btnSJ.Name = "btnSJ";
            this.btnSJ.Size = new System.Drawing.Size(132, 28);
            this.btnSJ.TabIndex = 9;
            this.btnSJ.Text = "复检进仓";
            this.btnSJ.Visible = false;
            this.btnSJ.Click += new System.EventHandler(this.btnSJ_Click);
            // 
            // frm_FJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnSJHD);
            this.Controls.Add(this.btnSJ);
            this.Controls.Add(this.btnXJHD);
            this.Controls.Add(this.btnXJ);
            this.Controls.Add(this.btnExit);
            this.Name = "frm_FJ";
            this.Text = "复检";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXJ;
        private System.Windows.Forms.Button btnXJHD;
        private System.Windows.Forms.Button btnSJHD;
        private System.Windows.Forms.Button btnSJ;


    }
}