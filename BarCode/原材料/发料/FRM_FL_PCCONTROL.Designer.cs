namespace BarCode.原材料.发料
{
    partial class FRM_FL_PCCONTROL
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
            this.txtClbh = new System.Windows.Forms.TextBox();
            this.cmbLLPC = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnDisEnabled = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.Text = "材料编号";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.Text = "来料批次";
            // 
            // txtClbh
            // 
            this.txtClbh.Location = new System.Drawing.Point(106, 10);
            this.txtClbh.Name = "txtClbh";
            this.txtClbh.Size = new System.Drawing.Size(124, 23);
            this.txtClbh.TabIndex = 3;
            // 
            // cmbLLPC
            // 
            this.cmbLLPC.Location = new System.Drawing.Point(106, 43);
            this.cmbLLPC.Name = "cmbLLPC";
            this.cmbLLPC.Size = new System.Drawing.Size(124, 23);
            this.cmbLLPC.TabIndex = 4;
            this.cmbLLPC.SelectedIndexChanged += new System.EventHandler(this.cmbLLPC_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInfo.Location = new System.Drawing.Point(16, 82);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(203, 20);
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFirst
            // 
            this.btnFirst.Enabled = false;
            this.btnFirst.Location = new System.Drawing.Point(16, 113);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(98, 31);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.Text = "优先发料";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnDisEnabled
            // 
            this.btnDisEnabled.Enabled = false;
            this.btnDisEnabled.Location = new System.Drawing.Point(127, 113);
            this.btnDisEnabled.Name = "btnDisEnabled";
            this.btnDisEnabled.Size = new System.Drawing.Size(98, 31);
            this.btnDisEnabled.TabIndex = 7;
            this.btnDisEnabled.Text = "禁止发料";
            this.btnDisEnabled.Click += new System.EventHandler(this.btnDisEnabled_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(16, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 31);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(127, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 31);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewStock
            // 
            this.btnNewStock.Location = new System.Drawing.Point(127, 150);
            this.btnNewStock.Name = "btnNewStock";
            this.btnNewStock.Size = new System.Drawing.Size(98, 31);
            this.btnNewStock.TabIndex = 10;
            this.btnNewStock.Text = "更新库存";
            // 
            // FRM_FL_PCCONTROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnNewStock);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDisEnabled);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbLLPC);
            this.Controls.Add(this.txtClbh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_FL_PCCONTROL";
            this.Text = "批次控制";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClbh;
        private System.Windows.Forms.ComboBox cmbLLPC;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnDisEnabled;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewStock;
    }
}