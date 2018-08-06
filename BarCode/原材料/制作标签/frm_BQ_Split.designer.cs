namespace BarCode.原材料.制作标签
{
    partial class frm_BQ_Split
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
            this.txtOldXHTM = new System.Windows.Forms.TextBox();
            this.labelCLBH = new System.Windows.Forms.Label();
            this.labelLLPC = new System.Windows.Forms.Label();
            this.labelSL = new System.Windows.Forms.Label();
            this.txtNewXHTM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCFSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelCWH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.Text = "原箱号条码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtOldXHTM
            // 
            this.txtOldXHTM.Location = new System.Drawing.Point(116, 30);
            this.txtOldXHTM.Name = "txtOldXHTM";
            this.txtOldXHTM.Size = new System.Drawing.Size(100, 23);
            this.txtOldXHTM.TabIndex = 1;
            this.txtOldXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldXHTM_KeyPress);
            this.txtOldXHTM.LostFocus += new System.EventHandler(this.txtOldXHTM_LostFocus);
            // 
            // labelCLBH
            // 
            this.labelCLBH.Location = new System.Drawing.Point(116, 57);
            this.labelCLBH.Name = "labelCLBH";
            this.labelCLBH.Size = new System.Drawing.Size(100, 20);
            // 
            // labelLLPC
            // 
            this.labelLLPC.Location = new System.Drawing.Point(116, 81);
            this.labelLLPC.Name = "labelLLPC";
            this.labelLLPC.Size = new System.Drawing.Size(100, 20);
            // 
            // labelSL
            // 
            this.labelSL.Location = new System.Drawing.Point(116, 105);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(100, 20);
            // 
            // txtNewXHTM
            // 
            this.txtNewXHTM.Location = new System.Drawing.Point(116, 156);
            this.txtNewXHTM.Name = "txtNewXHTM";
            this.txtNewXHTM.Size = new System.Drawing.Size(100, 23);
            this.txtNewXHTM.TabIndex = 6;
            this.txtNewXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewXHTM_KeyPress);
            this.txtNewXHTM.LostFocus += new System.EventHandler(this.txtNewXHTM_LostFocus);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.Text = "新箱号条码：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCFSL
            // 
            this.txtCFSL.Location = new System.Drawing.Point(116, 185);
            this.txtCFSL.Name = "txtCFSL";
            this.txtCFSL.Size = new System.Drawing.Size(100, 23);
            this.txtCFSL.TabIndex = 9;
            this.txtCFSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCFSL_KeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.Text = "拆分数量：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(40, 228);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 26);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(135, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 26);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelCWH
            // 
            this.labelCWH.Location = new System.Drawing.Point(116, 125);
            this.labelCWH.Name = "labelCWH";
            this.labelCWH.Size = new System.Drawing.Size(100, 20);
            // 
            // frm_BQ_Split
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.labelCWH);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCFSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNewXHTM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSL);
            this.Controls.Add(this.labelLLPC);
            this.Controls.Add(this.labelCLBH);
            this.Controls.Add(this.txtOldXHTM);
            this.Controls.Add(this.label1);
            this.Name = "frm_BQ_Split";
            this.Text = "箱号拆分";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldXHTM;
        private System.Windows.Forms.Label labelCLBH;
        private System.Windows.Forms.Label labelLLPC;
        private System.Windows.Forms.Label labelSL;
        private System.Windows.Forms.TextBox txtNewXHTM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCFSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelCWH;
    }
}