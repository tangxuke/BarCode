namespace BarCode.原材料.不良品
{
    partial class frm_BLP
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
            this.btnRK = new System.Windows.Forms.Button();
            this.btnCK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRK
            // 
            this.btnRK.Location = new System.Drawing.Point(52, 26);
            this.btnRK.Name = "btnRK";
            this.btnRK.Size = new System.Drawing.Size(119, 40);
            this.btnRK.TabIndex = 0;
            this.btnRK.Text = "入库";
            this.btnRK.Click += new System.EventHandler(this.btnRK_Click);
            // 
            // btnCK
            // 
            this.btnCK.Location = new System.Drawing.Point(52, 84);
            this.btnCK.Name = "btnCK";
            this.btnCK.Size = new System.Drawing.Size(119, 40);
            this.btnCK.TabIndex = 1;
            this.btnCK.Text = "出库";
            this.btnCK.Click += new System.EventHandler(this.btnCK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(52, 219);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frm_BLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCK);
            this.Controls.Add(this.btnRK);
            this.Name = "frm_BLP";
            this.Text = "不良品";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRK;
        private System.Windows.Forms.Button btnCK;
        private System.Windows.Forms.Button btnClose;
    }
}