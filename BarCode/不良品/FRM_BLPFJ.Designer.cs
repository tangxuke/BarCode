namespace BarCode.BLP
{
    partial class FRM_BLPFJ
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
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCLBH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTHQD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(97, 98);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.ReadOnly = true;
            this.txtLLPC.Size = new System.Drawing.Size(130, 27);
            this.txtLLPC.TabIndex = 20;
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(97, 128);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.ReadOnly = true;
            this.txtQTY.Size = new System.Drawing.Size(130, 27);
            this.txtQTY.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "数量";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "来料批次";
            // 
            // txtCLBH
            // 
            this.txtCLBH.Location = new System.Drawing.Point(97, 68);
            this.txtCLBH.Name = "txtCLBH";
            this.txtCLBH.ReadOnly = true;
            this.txtCLBH.Size = new System.Drawing.Size(130, 27);
            this.txtCLBH.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "材料编号";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(97, 38);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(130, 27);
            this.txtXHTM.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "箱号条码";
            // 
            // cmbTHQD
            // 
            this.cmbTHQD.Location = new System.Drawing.Point(97, 6);
            this.cmbTHQD.Name = "cmbTHQD";
            this.cmbTHQD.Size = new System.Drawing.Size(130, 27);
            this.cmbTHQD.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "复检单号";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(124, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 37);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "关闭";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(22, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 37);
            this.btnOK.TabIndex = 27;
            this.btnOK.Text = "确定";
            // 
            // FRM_BLPFJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtLLPC);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCLBH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTHQD);
            this.Controls.Add(this.label1);
            this.Name = "FRM_BLPFJ";
            this.Text = "不良品复检";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLLPC;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCLBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTHQD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
    }
}