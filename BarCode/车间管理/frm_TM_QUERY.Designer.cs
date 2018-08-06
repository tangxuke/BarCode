namespace BarCode.车间管理
{
    partial class frm_TM_QUERY
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClbh = new System.Windows.Forms.TextBox();
            this.txtCLMC = new System.Windows.Forms.TextBox();
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.Text = "箱号条码：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(14, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 35);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(90, 5);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(141, 23);
            this.txtXHTM.TabIndex = 10;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(122, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 35);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "关闭";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.Text = "数量：";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.Text = "来料批次：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.Text = "材料名称：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.Text = "材料编号：";
            // 
            // txtClbh
            // 
            this.txtClbh.Location = new System.Drawing.Point(90, 36);
            this.txtClbh.Name = "txtClbh";
            this.txtClbh.ReadOnly = true;
            this.txtClbh.Size = new System.Drawing.Size(141, 23);
            this.txtClbh.TabIndex = 35;
            // 
            // txtCLMC
            // 
            this.txtCLMC.Location = new System.Drawing.Point(90, 67);
            this.txtCLMC.Name = "txtCLMC";
            this.txtCLMC.ReadOnly = true;
            this.txtCLMC.Size = new System.Drawing.Size(141, 23);
            this.txtCLMC.TabIndex = 36;
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(90, 98);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.ReadOnly = true;
            this.txtLLPC.Size = new System.Drawing.Size(141, 23);
            this.txtLLPC.TabIndex = 37;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(90, 129);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(141, 23);
            this.txtQty.TabIndex = 38;
            // 
            // frm_TM_QUERY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtLLPC);
            this.Controls.Add(this.txtCLMC);
            this.Controls.Add(this.txtClbh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.btnExit);
            this.Name = "frm_TM_QUERY";
            this.Text = "条码查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClbh;
        private System.Windows.Forms.TextBox txtCLMC;
        private System.Windows.Forms.TextBox txtLLPC;
        private System.Windows.Forms.TextBox txtQty;
    }
}