namespace BarCode.原材料.进仓
{
    partial class frm_JC
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
            this.btnWLSJ = new System.Windows.Forms.Button();
            this.btnWLYD = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBCPSJ = new System.Windows.Forms.Button();
            this.btnTLSJ = new System.Windows.Forms.Button();
            this.btnINBox = new System.Windows.Forms.Button();
            this.btnWXSJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWLSJ
            // 
            this.btnWLSJ.Location = new System.Drawing.Point(19, 11);
            this.btnWLSJ.Name = "btnWLSJ";
            this.btnWLSJ.Size = new System.Drawing.Size(89, 38);
            this.btnWLSJ.TabIndex = 0;
            this.btnWLSJ.Text = "物料上架";
            this.btnWLSJ.Click += new System.EventHandler(this.btnWLSJ_Click);
            // 
            // btnWLYD
            // 
            this.btnWLYD.Location = new System.Drawing.Point(128, 11);
            this.btnWLYD.Name = "btnWLYD";
            this.btnWLYD.Size = new System.Drawing.Size(89, 38);
            this.btnWLYD.TabIndex = 1;
            this.btnWLYD.Text = "物料移动";
            this.btnWLYD.Click += new System.EventHandler(this.btnWLYD_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(53, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBCPSJ
            // 
            this.btnBCPSJ.Location = new System.Drawing.Point(19, 55);
            this.btnBCPSJ.Name = "btnBCPSJ";
            this.btnBCPSJ.Size = new System.Drawing.Size(89, 38);
            this.btnBCPSJ.TabIndex = 3;
            this.btnBCPSJ.Text = "半成品上架";
            this.btnBCPSJ.Click += new System.EventHandler(this.btnBCPSJ_Click);
            // 
            // btnTLSJ
            // 
            this.btnTLSJ.Location = new System.Drawing.Point(128, 55);
            this.btnTLSJ.Name = "btnTLSJ";
            this.btnTLSJ.Size = new System.Drawing.Size(89, 38);
            this.btnTLSJ.TabIndex = 4;
            this.btnTLSJ.Text = "退料上架";
            this.btnTLSJ.Click += new System.EventHandler(this.btnTLDL_Click);
            // 
            // btnINBox
            // 
            this.btnINBox.Location = new System.Drawing.Point(128, 99);
            this.btnINBox.Name = "btnINBox";
            this.btnINBox.Size = new System.Drawing.Size(89, 38);
            this.btnINBox.TabIndex = 5;
            this.btnINBox.Text = "条码装箱";
            this.btnINBox.Click += new System.EventHandler(this.btnINBox_Click);
            // 
            // btnWXSJ
            // 
            this.btnWXSJ.Location = new System.Drawing.Point(19, 99);
            this.btnWXSJ.Name = "btnWXSJ";
            this.btnWXSJ.Size = new System.Drawing.Size(89, 38);
            this.btnWXSJ.TabIndex = 6;
            this.btnWXSJ.Text = "外箱上架";
            this.btnWXSJ.Click += new System.EventHandler(this.btnWXSJ_Click);
            // 
            // frm_JC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.btnWXSJ);
            this.Controls.Add(this.btnINBox);
            this.Controls.Add(this.btnTLSJ);
            this.Controls.Add(this.btnBCPSJ);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWLYD);
            this.Controls.Add(this.btnWLSJ);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_JC";
            this.Text = "进仓";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWLSJ;
        private System.Windows.Forms.Button btnWLYD;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBCPSJ;
        private System.Windows.Forms.Button btnTLSJ;
        private System.Windows.Forms.Button btnINBox;
        private System.Windows.Forms.Button btnWXSJ;
    }
}