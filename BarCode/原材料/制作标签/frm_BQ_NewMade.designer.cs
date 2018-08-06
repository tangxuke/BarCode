namespace BarCode.原材料.制作标签
{
    partial class frm_BQ_NewMade
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
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.txtTLSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelCLBH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.Text = "箱号条码：";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(116, 20);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(98, 23);
            this.txtXHTM.TabIndex = 1;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "来料批次：";
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(116, 57);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.Size = new System.Drawing.Size(98, 23);
            this.txtLLPC.TabIndex = 3;
            this.txtLLPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLLPC_KeyPress);
            this.txtLLPC.LostFocus += new System.EventHandler(this.txtLLPC_LostFocus);
            // 
            // txtTLSL
            // 
            this.txtTLSL.Location = new System.Drawing.Point(116, 117);
            this.txtTLSL.Name = "txtTLSL";
            this.txtTLSL.Size = new System.Drawing.Size(98, 23);
            this.txtTLSL.TabIndex = 5;
            this.txtTLSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTLSL_KeyPress);
            this.txtTLSL.LostFocus += new System.EventHandler(this.txtTLSL_LostFocus);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.Text = "箱内数量：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(26, 182);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 31);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(130, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 31);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelCLBH
            // 
            this.labelCLBH.Location = new System.Drawing.Point(116, 84);
            this.labelCLBH.Name = "labelCLBH";
            this.labelCLBH.Size = new System.Drawing.Size(119, 20);
            // 
            // frm_BQ_NewMade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.labelCLBH);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTLSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLLPC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_BQ_NewMade";
            this.Text = "制作新标签";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLLPC;
        private System.Windows.Forms.TextBox txtTLSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelCLBH;
    }
}