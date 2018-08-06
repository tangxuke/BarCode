namespace BarCode.车间管理
{
    partial class frm_Lot_ReBack
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
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCPBH = new System.Windows.Forms.ComboBox();
            this.comboZLDH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTRSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(89, 210);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(141, 23);
            this.txtQty.TabIndex = 1;
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(89, 46);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(141, 23);
            this.txtXHTM.TabIndex = 0;
            this.txtXHTM.GotFocus += new System.EventHandler(this.txtXHTM_GotFocus);
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(131, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 28);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(30, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.Text = "退回数量";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "箱号条码";
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(89, 7);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.Size = new System.Drawing.Size(141, 23);
            this.txtCWH.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.Text = "仓位号";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "产品编号";
            // 
            // comboCPBH
            // 
            this.comboCPBH.Location = new System.Drawing.Point(89, 90);
            this.comboCPBH.Name = "comboCPBH";
            this.comboCPBH.Size = new System.Drawing.Size(141, 23);
            this.comboCPBH.TabIndex = 77;
            this.comboCPBH.SelectedIndexChanged += new System.EventHandler(this.comboCPBH_SelectedIndexChanged);
            // 
            // comboZLDH
            // 
            this.comboZLDH.Location = new System.Drawing.Point(89, 126);
            this.comboZLDH.Name = "comboZLDH";
            this.comboZLDH.Size = new System.Drawing.Size(141, 23);
            this.comboZLDH.TabIndex = 79;
            this.comboZLDH.SelectedIndexChanged += new System.EventHandler(this.comboZLDH_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "制令单号";
            // 
            // txtTRSL
            // 
            this.txtTRSL.Location = new System.Drawing.Point(89, 158);
            this.txtTRSL.Name = "txtTRSL";
            this.txtTRSL.ReadOnly = true;
            this.txtTRSL.Size = new System.Drawing.Size(141, 23);
            this.txtTRSL.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.Text = "投入数量";
            // 
            // frm_Lot_ReBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.txtTRSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboZLDH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCPBH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "frm_Lot_ReBack";
            this.Text = "线上物料退回";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCPBH;
        private System.Windows.Forms.ComboBox comboZLDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTRSL;
        private System.Windows.Forms.Label label3;
    }
}