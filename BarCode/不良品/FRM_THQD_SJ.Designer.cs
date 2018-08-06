namespace BarCode.BLP
{
    partial class FRM_THQD_SJ
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTHDH = new System.Windows.Forms.TextBox();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "退货单号：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "仓位号：";
            // 
            // txtTHDH
            // 
            this.txtTHDH.Location = new System.Drawing.Point(95, 14);
            this.txtTHDH.Name = "txtTHDH";
            this.txtTHDH.Size = new System.Drawing.Size(128, 23);
            this.txtTHDH.TabIndex = 3;
            this.txtTHDH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTHDH_KeyPress);
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(95, 55);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.Size = new System.Drawing.Size(128, 23);
            this.txtCWH.TabIndex = 4;
            this.txtCWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCWH_KeyPress);
            this.txtCWH.LostFocus += new System.EventHandler(this.txtCWH_LostFocus);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(22, 210);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 38);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(123, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            // 
            // FRM_THQD_SJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.txtTHDH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_THQD_SJ";
            this.Text = "退货清单上架";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTHDH;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}