namespace BarCode.原材料.查询
{
    partial class frm_CX_XH
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
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelKCSL = new System.Windows.Forms.Label();
            this.labelCFWZ = new System.Windows.Forms.Label();
            this.labelLLPC = new System.Windows.Forms.Label();
            this.labelCLMC = new System.Windows.Forms.Label();
            this.labelCLBH = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.Text = "箱号条码：";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(92, 11);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(100, 23);
            this.txtXHTM.TabIndex = 1;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(199, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(27, 24);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "查";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelKCSL);
            this.panel1.Controls.Add(this.labelCFWZ);
            this.panel1.Controls.Add(this.labelLLPC);
            this.panel1.Controls.Add(this.labelCLMC);
            this.panel1.Controls.Add(this.labelCLBH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 178);
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(89, 145);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(134, 20);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.Text = "库存总数：";
            // 
            // labelKCSL
            // 
            this.labelKCSL.Location = new System.Drawing.Point(88, 118);
            this.labelKCSL.Name = "labelKCSL";
            this.labelKCSL.Size = new System.Drawing.Size(134, 20);
            // 
            // labelCFWZ
            // 
            this.labelCFWZ.Location = new System.Drawing.Point(88, 92);
            this.labelCFWZ.Name = "labelCFWZ";
            this.labelCFWZ.Size = new System.Drawing.Size(134, 20);
            // 
            // labelLLPC
            // 
            this.labelLLPC.Location = new System.Drawing.Point(88, 62);
            this.labelLLPC.Name = "labelLLPC";
            this.labelLLPC.Size = new System.Drawing.Size(134, 20);
            // 
            // labelCLMC
            // 
            this.labelCLMC.Location = new System.Drawing.Point(88, 35);
            this.labelCLMC.Name = "labelCLMC";
            this.labelCLMC.Size = new System.Drawing.Size(134, 20);
            // 
            // labelCLBH
            // 
            this.labelCLBH.Location = new System.Drawing.Point(88, 8);
            this.labelCLBH.Name = "labelCLBH";
            this.labelCLBH.Size = new System.Drawing.Size(134, 20);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.Text = "库存数量：";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.Text = "存放位置：";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.Text = "来料批次：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.Text = "材料名称：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.Text = "材料编号：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(129, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(23, 226);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(91, 34);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "查看明细";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frm_CX_XH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CX_XH";
            this.Text = "箱号查询";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKCSL;
        private System.Windows.Forms.Label labelCFWZ;
        private System.Windows.Forms.Label labelLLPC;
        private System.Windows.Forms.Label labelCLMC;
        private System.Windows.Forms.Label labelCLBH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnView;
    }
}