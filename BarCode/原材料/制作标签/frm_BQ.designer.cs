namespace BarCode.原材料.制作标签
{
    partial class frm_BQ
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
            this.btnNewBQ = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCopyBQ = new System.Windows.Forms.Button();
            this.btnXHCF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewBQ
            // 
            this.btnNewBQ.Location = new System.Drawing.Point(57, 39);
            this.btnNewBQ.Name = "btnNewBQ";
            this.btnNewBQ.Size = new System.Drawing.Size(118, 31);
            this.btnNewBQ.TabIndex = 10;
            this.btnNewBQ.Text = "制作新标签";
            this.btnNewBQ.Click += new System.EventHandler(this.btnNewBQ_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(57, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 31);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCopyBQ
            // 
            this.btnCopyBQ.Location = new System.Drawing.Point(57, 90);
            this.btnCopyBQ.Name = "btnCopyBQ";
            this.btnCopyBQ.Size = new System.Drawing.Size(118, 31);
            this.btnCopyBQ.TabIndex = 11;
            this.btnCopyBQ.Text = "复制标签";
            this.btnCopyBQ.Click += new System.EventHandler(this.btnCopyBQ_Click);
            // 
            // btnXHCF
            // 
            this.btnXHCF.Location = new System.Drawing.Point(57, 141);
            this.btnXHCF.Name = "btnXHCF";
            this.btnXHCF.Size = new System.Drawing.Size(118, 31);
            this.btnXHCF.TabIndex = 12;
            this.btnXHCF.Text = "箱号拆分";
            this.btnXHCF.Click += new System.EventHandler(this.btnXHCF_Click);
            // 
            // frm_BQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnXHCF);
            this.Controls.Add(this.btnCopyBQ);
            this.Controls.Add(this.btnNewBQ);
            this.Controls.Add(this.btnExit);
            this.Name = "frm_BQ";
            this.Text = "制作标签";
            this.Load += new System.EventHandler(this.frm_BQ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewBQ;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCopyBQ;
        private System.Windows.Forms.Button btnXHCF;
    }
}