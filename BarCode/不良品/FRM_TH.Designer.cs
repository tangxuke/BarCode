namespace BarCode.BLP
{
    partial class FRM_TH
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
            this.btnTHQD = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinishTH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTHQD
            // 
            this.btnTHQD.Location = new System.Drawing.Point(61, 12);
            this.btnTHQD.Name = "btnTHQD";
            this.btnTHQD.Size = new System.Drawing.Size(105, 35);
            this.btnTHQD.TabIndex = 0;
            this.btnTHQD.Text = "退货清单维护";
            this.btnTHQD.Click += new System.EventHandler(this.btnTHQD_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(61, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(61, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消退货";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnFinishTH
            // 
            this.btnFinishTH.Location = new System.Drawing.Point(61, 101);
            this.btnFinishTH.Name = "btnFinishTH";
            this.btnFinishTH.Size = new System.Drawing.Size(105, 35);
            this.btnFinishTH.TabIndex = 6;
            this.btnFinishTH.Text = "完成退货";
            this.btnFinishTH.Click += new System.EventHandler(this.btnFinishTH_Click_1);
            // 
            // FRM_TH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnFinishTH);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTHQD);
            this.Name = "FRM_TH";
            this.Text = "不良品退货维护";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTHQD;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinishTH;
    }
}