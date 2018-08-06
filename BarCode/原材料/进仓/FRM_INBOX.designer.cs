namespace BarCode.原材料.进仓
{
    partial class FRM_INBOX
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWX = new System.Windows.Forms.TextBox();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtJS = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.txtCLBH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(21, 215);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 33);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Location = new System.Drawing.Point(129, 215);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(87, 33);
            this.btnCLOSE.TabIndex = 15;
            this.btnCLOSE.Text = "关闭";
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "外箱条码：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "箱号条码：";
            // 
            // txtWX
            // 
            this.txtWX.Location = new System.Drawing.Point(86, 7);
            this.txtWX.Name = "txtWX";
            this.txtWX.Size = new System.Drawing.Size(130, 23);
            this.txtWX.TabIndex = 19;
            this.txtWX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWX_KeyPress);
            this.txtWX.LostFocus += new System.EventHandler(this.txtWX_LostFocus);
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(86, 158);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(130, 23);
            this.txtXHTM.TabIndex = 28;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtJS);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.txtLLPC);
            this.panel1.Controls.Add(this.txtCLBH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(1, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 118);
            // 
            // txtJS
            // 
            this.txtJS.Location = new System.Drawing.Point(86, 87);
            this.txtJS.Name = "txtJS";
            this.txtJS.Size = new System.Drawing.Size(130, 23);
            this.txtJS.TabIndex = 35;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(86, 61);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(130, 23);
            this.txtQty.TabIndex = 34;
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(86, 35);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.Size = new System.Drawing.Size(130, 23);
            this.txtLLPC.TabIndex = 33;
            // 
            // txtCLBH
            // 
            this.txtCLBH.Location = new System.Drawing.Point(86, 9);
            this.txtCLBH.Name = "txtCLBH";
            this.txtCLBH.Size = new System.Drawing.Size(130, 23);
            this.txtCLBH.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "总件数：";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "总数量：";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "来料批次：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "材料编号：";
            // 
            // FRM_INBOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.txtWX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCLOSE);
            this.Controls.Add(this.btnOK);
            this.MinimizeBox = false;
            this.Name = "FRM_INBOX";
            this.Text = "外箱装箱";
            this.Load += new System.EventHandler(this.frm_NewStock_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWX;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtJS;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtLLPC;
        private System.Windows.Forms.TextBox txtCLBH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}