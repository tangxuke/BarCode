namespace BarCode.原材料.复检
{
    partial class frm_FJ_JC
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
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.labelCWLX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.labelCLBH = new System.Windows.Forms.Label();
            this.labelLLPC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJCSL = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.Text = "cwh：";
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(104, 19);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.Size = new System.Drawing.Size(119, 23);
            this.txtCWH.TabIndex = 1;
            this.txtCWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCWH_KeyPress);
            this.txtCWH.LostFocus += new System.EventHandler(this.txtCWH_LostFocus);
            // 
            // labelCWLX
            // 
            this.labelCWLX.Location = new System.Drawing.Point(104, 45);
            this.labelCWLX.Name = "labelCWLX";
            this.labelCWLX.Size = new System.Drawing.Size(100, 20);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.Text = "箱号条码：";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(104, 68);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(119, 23);
            this.txtXHTM.TabIndex = 4;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // labelCLBH
            // 
            this.labelCLBH.Location = new System.Drawing.Point(104, 94);
            this.labelCLBH.Name = "labelCLBH";
            this.labelCLBH.Size = new System.Drawing.Size(100, 20);
            // 
            // labelLLPC
            // 
            this.labelLLPC.Location = new System.Drawing.Point(104, 114);
            this.labelLLPC.Name = "labelLLPC";
            this.labelLLPC.Size = new System.Drawing.Size(100, 20);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.Text = "进仓数量：";
            // 
            // txtJCSL
            // 
            this.txtJCSL.Location = new System.Drawing.Point(104, 136);
            this.txtJCSL.Name = "txtJCSL";
            this.txtJCSL.Size = new System.Drawing.Size(119, 23);
            this.txtJCSL.TabIndex = 9;
            this.txtJCSL.GotFocus += new System.EventHandler(this.txtJCSL_GotFocus);
            this.txtJCSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJCSL_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(44, 211);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 28);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(132, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 28);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frm_FJ_JC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtJCSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelLLPC);
            this.Controls.Add(this.labelCLBH);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCWLX);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.label1);
            this.Name = "frm_FJ_JC";
            this.Text = "复检进仓";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Label labelCWLX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Label labelCLBH;
        private System.Windows.Forms.Label labelLLPC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJCSL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
    }
}