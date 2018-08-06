namespace BarCode.原材料.发料
{
    partial class FRM_UPDATE_ZZPC
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
            this.btnLXFL = new System.Windows.Forms.Button();
            this.btnPTFL = new System.Windows.Forms.Button();
            this.btnBCP = new System.Windows.Forms.Button();
            this.btnYBWP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(208, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLXFL
            // 
            this.btnLXFL.Location = new System.Drawing.Point(130, 13);
            this.btnLXFL.Name = "btnLXFL";
            this.btnLXFL.Size = new System.Drawing.Size(96, 31);
            this.btnLXFL.TabIndex = 4;
            this.btnLXFL.Text = "发料单发料";
            this.btnLXFL.Click += new System.EventHandler(this.btnLXFL_Click);
            // 
            // btnPTFL
            // 
            this.btnPTFL.Location = new System.Drawing.Point(18, 13);
            this.btnPTFL.Name = "btnPTFL";
            this.btnPTFL.Size = new System.Drawing.Size(96, 31);
            this.btnPTFL.TabIndex = 3;
            this.btnPTFL.Text = "配料单发料";
            this.btnPTFL.Click += new System.EventHandler(this.btnPTFL_Click);
            // 
            // btnBCP
            // 
            this.btnBCP.Location = new System.Drawing.Point(18, 87);
            this.btnBCP.Name = "btnBCP";
            this.btnBCP.Size = new System.Drawing.Size(96, 31);
            this.btnBCP.TabIndex = 8;
            this.btnBCP.Text = "半成品发料";
            this.btnBCP.Click += new System.EventHandler(this.btnBCP_Click);
            // 
            // btnYBWP
            // 
            this.btnYBWP.Location = new System.Drawing.Point(18, 50);
            this.btnYBWP.Name = "btnYBWP";
            this.btnYBWP.Size = new System.Drawing.Size(96, 31);
            this.btnYBWP.TabIndex = 15;
            this.btnYBWP.Text = "一般物品";
            this.btnYBWP.Click += new System.EventHandler(this.btnYBWP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "辅料发料";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_FL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYBWP);
            this.Controls.Add(this.btnBCP);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLXFL);
            this.Controls.Add(this.btnPTFL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_FL";
            this.Text = "发料";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLXFL;
        private System.Windows.Forms.Button btnPTFL;
        private System.Windows.Forms.Button btnBCP;
        private System.Windows.Forms.Button btnYBWP;
        private System.Windows.Forms.Button button1;
    }
}