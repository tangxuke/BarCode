namespace BarCode.原材料.查询
{
    partial class frm_CX
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
            this.btnCLCX = new System.Windows.Forms.Button();
            this.btnPCCX = new System.Windows.Forms.Button();
            this.btnXHCX = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCWCX = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCLCX
            // 
            this.btnCLCX.Location = new System.Drawing.Point(51, 6);
            this.btnCLCX.Name = "btnCLCX";
            this.btnCLCX.Size = new System.Drawing.Size(136, 35);
            this.btnCLCX.TabIndex = 0;
            this.btnCLCX.Text = "材料查询";
            this.btnCLCX.Click += new System.EventHandler(this.btnCLCX_Click);
            // 
            // btnPCCX
            // 
            this.btnPCCX.Location = new System.Drawing.Point(51, 80);
            this.btnPCCX.Name = "btnPCCX";
            this.btnPCCX.Size = new System.Drawing.Size(136, 35);
            this.btnPCCX.TabIndex = 1;
            this.btnPCCX.Text = "批次查询";
            this.btnPCCX.Click += new System.EventHandler(this.btnPCCX_Click);
            // 
            // btnXHCX
            // 
            this.btnXHCX.Location = new System.Drawing.Point(51, 117);
            this.btnXHCX.Name = "btnXHCX";
            this.btnXHCX.Size = new System.Drawing.Size(136, 35);
            this.btnXHCX.TabIndex = 2;
            this.btnXHCX.Text = "箱号查询";
            this.btnXHCX.Click += new System.EventHandler(this.btnXHCX_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(51, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCWCX
            // 
            this.btnCWCX.Location = new System.Drawing.Point(51, 154);
            this.btnCWCX.Name = "btnCWCX";
            this.btnCWCX.Size = new System.Drawing.Size(136, 35);
            this.btnCWCX.TabIndex = 4;
            this.btnCWCX.Text = "仓位明细查询";
            this.btnCWCX.Click += new System.EventHandler(this.btnCWCX_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "仓位汇总查询";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "材料查询2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_CX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCWCX);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXHCX);
            this.Controls.Add(this.btnPCCX);
            this.Controls.Add(this.btnCLCX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CX";
            this.Text = "查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCLCX;
        private System.Windows.Forms.Button btnPCCX;
        private System.Windows.Forms.Button btnXHCX;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCWCX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}