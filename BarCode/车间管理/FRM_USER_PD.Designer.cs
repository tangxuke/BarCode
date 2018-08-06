namespace BarCode.车间管理
{
    partial class FRM_USER_PD
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
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.txtCLBH = new System.Windows.Forms.TextBox();
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.txtZZPC = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.Text = "箱号条码";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.Text = "材料编号";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.Text = "来料批次";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.Text = "制造批次";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.Text = "数量";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(88, 36);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(139, 23);
            this.txtXHTM.TabIndex = 6;
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // txtCLBH
            // 
            this.txtCLBH.Location = new System.Drawing.Point(88, 66);
            this.txtCLBH.Name = "txtCLBH";
            this.txtCLBH.Size = new System.Drawing.Size(139, 23);
            this.txtCLBH.TabIndex = 7;
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(88, 96);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.Size = new System.Drawing.Size(139, 23);
            this.txtLLPC.TabIndex = 8;
            // 
            // txtZZPC
            // 
            this.txtZZPC.Location = new System.Drawing.Point(88, 126);
            this.txtZZPC.Name = "txtZZPC";
            this.txtZZPC.Size = new System.Drawing.Size(139, 23);
            this.txtZZPC.TabIndex = 9;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(88, 156);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(139, 23);
            this.txtQty.TabIndex = 10;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(88, 6);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(139, 23);
            this.txtUserID.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(37, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 32);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(130, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 32);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.Text = "盘点车间";
            // 
            // chk
            // 
            this.chk.Location = new System.Drawing.Point(85, 186);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(147, 20);
            this.chk.TabIndex = 17;
            this.chk.Text = "不要自动更新";
            // 
            // FRM_USER_PD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.chk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtZZPC);
            this.Controls.Add(this.txtLLPC);
            this.Controls.Add(this.txtCLBH);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_USER_PD";
            this.Text = "车间物料盘点";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.TextBox txtCLBH;
        private System.Windows.Forms.TextBox txtLLPC;
        private System.Windows.Forms.TextBox txtZZPC;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk;
    }
}