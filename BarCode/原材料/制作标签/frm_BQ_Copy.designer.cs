namespace BarCode.原材料.制作标签
{
    partial class frm_BQ_Copy
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewXHTM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldXHTM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClbh = new System.Windows.Forms.Label();
            this.lblLlpc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(119, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 31);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 203);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 31);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(105, 113);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(98, 23);
            this.txtSL.TabIndex = 15;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            this.txtSL.LostFocus += new System.EventHandler(this.txtSL_LostFocus);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.Text = "箱内数量：";
            // 
            // txtNewXHTM
            // 
            this.txtNewXHTM.Location = new System.Drawing.Point(105, 84);
            this.txtNewXHTM.Name = "txtNewXHTM";
            this.txtNewXHTM.Size = new System.Drawing.Size(98, 23);
            this.txtNewXHTM.TabIndex = 14;
            this.txtNewXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewXHTM_KeyPress);
            this.txtNewXHTM.LostFocus += new System.EventHandler(this.txtNewXHTM_LostFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "新箱号条码：";
            // 
            // txtOldXHTM
            // 
            this.txtOldXHTM.Location = new System.Drawing.Point(105, 14);
            this.txtOldXHTM.Name = "txtOldXHTM";
            this.txtOldXHTM.Size = new System.Drawing.Size(98, 23);
            this.txtOldXHTM.TabIndex = 13;
            this.txtOldXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldXHTM_KeyPress);
            this.txtOldXHTM.LostFocus += new System.EventHandler(this.txtOldXHTM_LostFocus);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.Text = "原箱号条码：";
            // 
            // lblClbh
            // 
            this.lblClbh.Location = new System.Drawing.Point(105, 40);
            this.lblClbh.Name = "lblClbh";
            this.lblClbh.Size = new System.Drawing.Size(97, 20);
            // 
            // lblLlpc
            // 
            this.lblLlpc.Location = new System.Drawing.Point(105, 60);
            this.lblLlpc.Name = "lblLlpc";
            this.lblLlpc.Size = new System.Drawing.Size(97, 20);
            // 
            // frm_BQ_Copy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.lblLlpc);
            this.Controls.Add(this.lblClbh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewXHTM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldXHTM);
            this.Controls.Add(this.label1);
            this.Name = "frm_BQ_Copy";
            this.Text = "复制标签";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewXHTM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldXHTM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClbh;
        private System.Windows.Forms.Label lblLlpc;
    }
}