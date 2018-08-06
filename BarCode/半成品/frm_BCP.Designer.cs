namespace BarCode.BCP
{
    partial class frm_BCP
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
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutPut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnYD = new System.Windows.Forms.Button();
            this.btnBF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(61, 23);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(121, 31);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "上架";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Location = new System.Drawing.Point(61, 58);
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(121, 31);
            this.btnOutPut.TabIndex = 1;
            this.btnOutPut.Text = "发料";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(61, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "返回";
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnYD
            // 
            this.btnYD.Location = new System.Drawing.Point(61, 93);
            this.btnYD.Name = "btnYD";
            this.btnYD.Size = new System.Drawing.Size(121, 31);
            this.btnYD.TabIndex = 3;
            this.btnYD.Text = "移动";
            this.btnYD.Click += new System.EventHandler(this.btnYD_Click);
            // 
            // btnBF
            // 
            this.btnBF.Location = new System.Drawing.Point(59, 129);
            this.btnBF.Name = "btnBF";
            this.btnBF.Size = new System.Drawing.Size(121, 31);
            this.btnBF.TabIndex = 4;
            this.btnBF.Text = "报废";
            this.btnBF.Click += new System.EventHandler(this.btnBF_Click);
            // 
            // frm_BCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnBF);
            this.Controls.Add(this.btnYD);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOutPut);
            this.Controls.Add(this.btnInput);
            this.Name = "frm_BCP";
            this.Text = "半成品";
         
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutPut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnYD;
        private System.Windows.Forms.Button btnBF;

    }
}