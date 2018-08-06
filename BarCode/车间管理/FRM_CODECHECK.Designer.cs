namespace BarCode.车间管理
{
    partial class FRM_CODECHECK
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtxhtm = new System.Windows.Forms.TextBox();
            this.txtrq = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtProdno = new System.Windows.Forms.TextBox();
            this.txtCPBH = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "条码号";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "生产制令号";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "产品编号";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "生产日期";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "序列号";
            // 
            // txtxhtm
            // 
            this.txtxhtm.Location = new System.Drawing.Point(14, 32);
            this.txtxhtm.Name = "txtxhtm";
            this.txtxhtm.Size = new System.Drawing.Size(205, 23);
            this.txtxhtm.TabIndex = 8;
            this.txtxhtm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxhtm_KeyPress);
            this.txtxhtm.LostFocus += new System.EventHandler(this.txtxhtm_LostFocus);
            // 
            // txtrq
            // 
            this.txtrq.Location = new System.Drawing.Point(80, 66);
            this.txtrq.Name = "txtrq";
            this.txtrq.ReadOnly = true;
            this.txtrq.Size = new System.Drawing.Size(139, 23);
            this.txtrq.TabIndex = 9;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(80, 96);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(139, 23);
            this.txtNo.TabIndex = 10;
            // 
            // txtProdno
            // 
            this.txtProdno.Location = new System.Drawing.Point(80, 126);
            this.txtProdno.Name = "txtProdno";
            this.txtProdno.ReadOnly = true;
            this.txtProdno.Size = new System.Drawing.Size(139, 23);
            this.txtProdno.TabIndex = 11;
            // 
            // txtCPBH
            // 
            this.txtCPBH.Location = new System.Drawing.Point(80, 156);
            this.txtCPBH.Name = "txtCPBH";
            this.txtCPBH.ReadOnly = true;
            this.txtCPBH.Size = new System.Drawing.Size(139, 23);
            this.txtCPBH.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(33, 222);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 32);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(121, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 32);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关闭";
            // 
            // FRM_CODECHECK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCPBH);
            this.Controls.Add(this.txtProdno);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtrq);
            this.Controls.Add(this.txtxhtm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_CODECHECK";
            this.Text = "3M条码检测";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtxhtm;
        private System.Windows.Forms.TextBox txtrq;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtProdno;
        private System.Windows.Forms.TextBox txtCPBH;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}