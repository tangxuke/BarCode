namespace BarCode.车间管理
{
    partial class FRM_SCAN
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
            this.cmbBillno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPBH = new System.Windows.Forms.TextBox();
            this.txtBarSample = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.Text = "单号";
            // 
            // cmbBillno
            // 
            this.cmbBillno.Location = new System.Drawing.Point(88, 12);
            this.cmbBillno.Name = "cmbBillno";
            this.cmbBillno.Size = new System.Drawing.Size(129, 23);
            this.cmbBillno.TabIndex = 1;
            this.cmbBillno.SelectedIndexChanged += new System.EventHandler(this.cmbBillno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.Text = "产品编号";
            // 
            // txtCPBH
            // 
            this.txtCPBH.Location = new System.Drawing.Point(88, 45);
            this.txtCPBH.Name = "txtCPBH";
            this.txtCPBH.Size = new System.Drawing.Size(129, 23);
            this.txtCPBH.TabIndex = 3;
            // 
            // txtBarSample
            // 
            this.txtBarSample.Location = new System.Drawing.Point(88, 77);
            this.txtBarSample.Name = "txtBarSample";
            this.txtBarSample.Size = new System.Drawing.Size(129, 23);
            this.txtBarSample.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.Text = "标签样本";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(88, 137);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(129, 23);
            this.txtBarCode.TabIndex = 8;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            this.txtBarCode.LostFocus += new System.EventHandler(this.txtBarCode_LostFocus);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.Text = "条码号";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(40, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 26);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(126, 219);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FRM_SCAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBarSample);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCPBH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBillno);
            this.Controls.Add(this.label1);
            this.Name = "FRM_SCAN";
            this.Text = "标签扫描";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBillno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPBH;
        private System.Windows.Forms.TextBox txtBarSample;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}