namespace BarCode.原材料.呆料
{
    partial class FRM_DL
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
            this.btnToDL = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDLSJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToDL
            // 
            this.btnToDL.Location = new System.Drawing.Point(60, 14);
            this.btnToDL.Name = "btnToDL";
            this.btnToDL.Size = new System.Drawing.Size(102, 32);
            this.btnToDL.TabIndex = 0;
            this.btnToDL.Text = "库存转呆料";
            this.btnToDL.Click += new System.EventHandler(this.btnToDL_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "呆料转库存";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(50, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDLSJ
            // 
            this.btnDLSJ.Location = new System.Drawing.Point(60, 88);
            this.btnDLSJ.Name = "btnDLSJ";
            this.btnDLSJ.Size = new System.Drawing.Size(102, 37);
            this.btnDLSJ.TabIndex = 0;
            this.btnDLSJ.Text = "呆料上架";
            this.btnDLSJ.Click += new System.EventHandler(this.btnDLSJ_Click);
            // 
            // FRM_DL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnDLSJ);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnToDL);
            this.Name = "FRM_DL";
            this.Text = "呆料维护";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToDL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDLSJ;
    }
}