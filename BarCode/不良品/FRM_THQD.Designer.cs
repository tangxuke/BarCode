namespace BarCode.BLP
{
    partial class FRM_THQD
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
            this.cmbTHQD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.txtCLBH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBCP = new System.Windows.Forms.Button();
            this.btnAudit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "退货单号";
            // 
            // cmbTHQD
            // 
            this.cmbTHQD.Location = new System.Drawing.Point(89, 10);
            this.cmbTHQD.Name = "cmbTHQD";
            this.cmbTHQD.Size = new System.Drawing.Size(130, 23);
            this.cmbTHQD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "箱号条码";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(89, 42);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(130, 23);
            this.txtXHTM.TabIndex = 3;
            this.txtXHTM.TextChanged += new System.EventHandler(this.txtXHTM_TextChanged);
            this.txtXHTM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtXHTM_KeyUp);
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // txtCLBH
            // 
            this.txtCLBH.Location = new System.Drawing.Point(89, 72);
            this.txtCLBH.Name = "txtCLBH";
            this.txtCLBH.ReadOnly = true;
            this.txtCLBH.Size = new System.Drawing.Size(130, 23);
            this.txtCLBH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "材料编号";
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(89, 102);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.ReadOnly = true;
            this.txtLLPC.Size = new System.Drawing.Size(130, 23);
            this.txtLLPC.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "来料批次";
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(89, 132);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.ReadOnly = true;
            this.txtQTY.Size = new System.Drawing.Size(130, 23);
            this.txtQTY.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "数量";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(20, 186);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 37);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(122, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBCP
            // 
            this.btnBCP.Location = new System.Drawing.Point(20, 229);
            this.btnBCP.Name = "btnBCP";
            this.btnBCP.Size = new System.Drawing.Size(96, 37);
            this.btnBCP.TabIndex = 15;
            this.btnBCP.Text = "不良半成品";
            this.btnBCP.Click += new System.EventHandler(this.btnBCP_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.Location = new System.Drawing.Point(122, 229);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(96, 37);
            this.btnAudit.TabIndex = 21;
            this.btnAudit.Text = "审核";
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // FRM_THQD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnAudit);
            this.Controls.Add(this.btnBCP);
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
            this.Name = "FRM_THQD";
            this.Text = "退货条码维护";
            this.Load += new System.EventHandler(this.FRM_THQD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTHQD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.TextBox txtCLBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLLPC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBCP;
        private System.Windows.Forms.Button btnAudit;
    }
}