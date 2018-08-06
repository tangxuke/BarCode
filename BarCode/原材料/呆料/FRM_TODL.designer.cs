namespace BarCode.原材料.呆料
{
    partial class FRM_TODL
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
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbBillNo = new System.Windows.Forms.ComboBox();
            this.cmbCGY = new System.Windows.Forms.ComboBox();
            this.cmbCLBH = new System.Windows.Forms.ComboBox();
            this.txtDLQty = new System.Windows.Forms.TextBox();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtTMQty = new System.Windows.Forms.TextBox();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "单号：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "仓管员：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "材料编号：";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "箱号条码：";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.Text = "数量：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(28, 231);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 31);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(125, 231);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 31);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbBillNo
            // 
            this.cmbBillNo.Location = new System.Drawing.Point(103, 4);
            this.cmbBillNo.Name = "cmbBillNo";
            this.cmbBillNo.Size = new System.Drawing.Size(124, 27);
            this.cmbBillNo.TabIndex = 14;
            this.cmbBillNo.SelectedIndexChanged += new System.EventHandler(this.cmbBillNo_SelectedIndexChanged);
            // 
            // cmbCGY
            // 
            this.cmbCGY.Location = new System.Drawing.Point(103, 34);
            this.cmbCGY.Name = "cmbCGY";
            this.cmbCGY.Size = new System.Drawing.Size(124, 27);
            this.cmbCGY.TabIndex = 15;
            this.cmbCGY.SelectedIndexChanged += new System.EventHandler(this.cmbCGY_SelectedIndexChanged);
            // 
            // cmbCLBH
            // 
            this.cmbCLBH.Location = new System.Drawing.Point(103, 65);
            this.cmbCLBH.Name = "cmbCLBH";
            this.cmbCLBH.Size = new System.Drawing.Size(124, 27);
            this.cmbCLBH.TabIndex = 16;
            this.cmbCLBH.SelectedIndexChanged += new System.EventHandler(this.cmbCLBH_SelectedIndexChanged);
            // 
            // txtDLQty
            // 
            this.txtDLQty.Location = new System.Drawing.Point(8, 96);
            this.txtDLQty.Name = "txtDLQty";
            this.txtDLQty.ReadOnly = true;
            this.txtDLQty.Size = new System.Drawing.Size(109, 27);
            this.txtDLQty.TabIndex = 17;
            this.txtDLQty.TabStop = false;
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(103, 159);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(124, 27);
            this.txtXHTM.TabIndex = 19;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(103, 192);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(124, 27);
            this.txtQty.TabIndex = 20;
            // 
            // txtTMQty
            // 
            this.txtTMQty.Location = new System.Drawing.Point(124, 96);
            this.txtTMQty.Name = "txtTMQty";
            this.txtTMQty.ReadOnly = true;
            this.txtTMQty.Size = new System.Drawing.Size(104, 27);
            this.txtTMQty.TabIndex = 22;
            this.txtTMQty.TabStop = false;
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(125, 128);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.ReadOnly = true;
            this.txtCWH.Size = new System.Drawing.Size(104, 27);
            this.txtCWH.TabIndex = 24;
            this.txtCWH.TabStop = false;
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(9, 128);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.ReadOnly = true;
            this.txtLLPC.Size = new System.Drawing.Size(109, 27);
            this.txtLLPC.TabIndex = 23;
            this.txtLLPC.TabStop = false;
            // 
            // FRM_TODL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.txtLLPC);
            this.Controls.Add(this.txtTMQty);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.txtDLQty);
            this.Controls.Add(this.cmbCLBH);
            this.Controls.Add(this.cmbCGY);
            this.Controls.Add(this.cmbBillNo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_TODL";
            this.Text = "库存转呆料";
            this.Load += new System.EventHandler(this.FRM_TODL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbBillNo;
        private System.Windows.Forms.ComboBox cmbCGY;
        private System.Windows.Forms.ComboBox cmbCLBH;
        private System.Windows.Forms.TextBox txtDLQty;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtTMQty;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.TextBox txtLLPC;
    }
}