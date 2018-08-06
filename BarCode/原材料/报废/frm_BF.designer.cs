namespace BarCode.原材料.报废
{
    partial class FRM_BF
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
            this.btnBF = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBFSJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBF
            // 
            this.btnBF.Location = new System.Drawing.Point(60, 18);
            this.btnBF.Name = "btnBF";
            this.btnBF.Size = new System.Drawing.Size(115, 36);
            this.btnBF.TabIndex = 0;
            this.btnBF.Text = "报废";
            this.btnBF.Click += new System.EventHandler(this.btnBF_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(60, 61);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消报废";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(60, 207);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBFSJ
            // 
            this.btnBFSJ.Location = new System.Drawing.Point(62, 105);
            this.btnBFSJ.Name = "btnBFSJ";
            this.btnBFSJ.Size = new System.Drawing.Size(115, 36);
            this.btnBFSJ.TabIndex = 3;
            this.btnBFSJ.Text = "报废上架";
            this.btnBFSJ.Click += new System.EventHandler(this.btnBFSJ_Click);
            // 
            // FRM_BF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnBFSJ);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBF);
            this.Name = "FRM_BF";
            this.Text = "材料报废模块";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBF;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBFSJ;
    }
}