namespace BarCode.成品管理.尾数管理
{
    partial class frm_CP_WSRKD
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtCPBH = new System.Windows.Forms.TextBox();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.Text = "数量：";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.Text = "车间：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.Text = "产品编号：";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(130, 224);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 33);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(30, 224);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 33);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(107, 131);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(117, 23);
            this.txtQty.TabIndex = 19;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(107, 100);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(117, 23);
            this.txtUserID.TabIndex = 18;
            // 
            // txtCPBH
            // 
            this.txtCPBH.Location = new System.Drawing.Point(107, 69);
            this.txtCPBH.Name = "txtCPBH";
            this.txtCPBH.ReadOnly = true;
            this.txtCPBH.Size = new System.Drawing.Size(117, 23);
            this.txtCPBH.TabIndex = 17;
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(107, 38);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(117, 23);
            this.txtXHTM.TabIndex = 16;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(107, 7);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.Size = new System.Drawing.Size(117, 23);
            this.txtCWH.TabIndex = 15;
            this.txtCWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCWH_KeyPress_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.Text = "箱号条码：";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.Text = "仓位号：";
            // 
            // frm_CP_WSRKD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtCPBH);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_CP_WSRKD";
            this.Text = "尾数上架";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtCPBH;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}