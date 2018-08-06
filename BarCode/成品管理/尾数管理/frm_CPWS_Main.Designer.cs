namespace BarCode.成品管理
{
    partial class frm_CPWS_Main
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
            this.btnWSCKD = new System.Windows.Forms.Button();
            this.btnWSRKD = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWSCKD
            // 
            this.btnWSCKD.Location = new System.Drawing.Point(43, 72);
            this.btnWSCKD.Name = "btnWSCKD";
            this.btnWSCKD.Size = new System.Drawing.Size(152, 43);
            this.btnWSCKD.TabIndex = 19;
            this.btnWSCKD.Text = "尾数出库单";
            this.btnWSCKD.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWSRKD
            // 
            this.btnWSRKD.Location = new System.Drawing.Point(43, 19);
            this.btnWSRKD.Name = "btnWSRKD";
            this.btnWSRKD.Size = new System.Drawing.Size(152, 43);
            this.btnWSRKD.TabIndex = 18;
            this.btnWSRKD.Text = "尾数入库单";
            this.btnWSRKD.Click += new System.EventHandler(this.btnWSRKD_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(43, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 43);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "返回";
            // 
            // frm_CPWS_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnWSCKD);
            this.Controls.Add(this.btnWSRKD);
            this.Controls.Add(this.btnExit);
            this.Name = "frm_CPWS_Main";
            this.Text = "成品尾数管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWSCKD;
        private System.Windows.Forms.Button btnWSRKD;
        private System.Windows.Forms.Button btnExit;
    }
}