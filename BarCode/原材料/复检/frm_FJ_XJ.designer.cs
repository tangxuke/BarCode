namespace BarCode.原材料.复检
{
    partial class frm_FJ_XJ
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
            this.btnFJXJ = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtFjdno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCWH = new System.Windows.Forms.Label();
            this.labelSL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelLLPC = new System.Windows.Forms.Label();
            this.labelCLBH = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.Text = "箱号条码：";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(102, 184);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(114, 23);
            this.txtXHTM.TabIndex = 1;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // btnFJXJ
            // 
            this.btnFJXJ.Location = new System.Drawing.Point(29, 222);
            this.btnFJXJ.Name = "btnFJXJ";
            this.btnFJXJ.Size = new System.Drawing.Size(67, 31);
            this.btnFJXJ.TabIndex = 2;
            this.btnFJXJ.Text = "复检下架";
            this.btnFJXJ.Click += new System.EventHandler(this.btnFJXJ_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(135, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtFjdno
            // 
            this.txtFjdno.Location = new System.Drawing.Point(101, 13);
            this.txtFjdno.Name = "txtFjdno";
            this.txtFjdno.Size = new System.Drawing.Size(114, 23);
            this.txtFjdno.TabIndex = 0;
            this.txtFjdno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFjdno_KeyPress);
            this.txtFjdno.LostFocus += new System.EventHandler(this.txtFjdno_LostFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.Text = "复检单号：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCWH);
            this.panel1.Controls.Add(this.labelSL);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.labelLLPC);
            this.panel1.Controls.Add(this.labelCLBH);
            this.panel1.Location = new System.Drawing.Point(3, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 109);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.Text = "数量：";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.Text = "来料批次：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.Text = "材料编号：";
            // 
            // lblCWH
            // 
            this.lblCWH.BackColor = System.Drawing.Color.Silver;
            this.lblCWH.Location = new System.Drawing.Point(116, 6);
            this.lblCWH.Name = "lblCWH";
            this.lblCWH.Size = new System.Drawing.Size(100, 20);
            // 
            // labelSL
            // 
            this.labelSL.BackColor = System.Drawing.Color.Silver;
            this.labelSL.Location = new System.Drawing.Point(116, 81);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(100, 20);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(11, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.Text = "仓位号：";
            // 
            // labelLLPC
            // 
            this.labelLLPC.BackColor = System.Drawing.Color.Silver;
            this.labelLLPC.Location = new System.Drawing.Point(116, 56);
            this.labelLLPC.Name = "labelLLPC";
            this.labelLLPC.Size = new System.Drawing.Size(100, 20);
            // 
            // labelCLBH
            // 
            this.labelCLBH.BackColor = System.Drawing.Color.Silver;
            this.labelCLBH.Location = new System.Drawing.Point(116, 31);
            this.labelCLBH.Name = "labelCLBH";
            this.labelCLBH.Size = new System.Drawing.Size(100, 20);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(14, 42);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(201, 20);
            this.lblInfo.Text = "请输入复检单号......";
            // 
            // frm_FJ_XJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFjdno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFJXJ);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label1);
            this.Name = "frm_FJ_XJ";
            this.Text = "复检下架";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Button btnFJXJ;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtFjdno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCWH;
        private System.Windows.Forms.Label labelSL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelLLPC;
        private System.Windows.Forms.Label labelCLBH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInfo;
    }
}