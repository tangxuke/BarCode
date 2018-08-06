namespace BarCode.车间管理
{
    partial class frm_Lot_Input
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbProdNo = new System.Windows.Forms.ComboBox();
            this.cmbCLBH = new System.Windows.Forms.ComboBox();
            this.txtZZPC = new System.Windows.Forms.TextBox();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cmbCPBH = new System.Windows.Forms.ComboBox();
            this.txtKLH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCloseZZPC = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "生产制令号";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "产品编号";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "材料编号";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "制造批次";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "箱号条码";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "数量";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(28, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(129, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbProdNo
            // 
            this.cmbProdNo.Location = new System.Drawing.Point(87, 32);
            this.cmbProdNo.Name = "cmbProdNo";
            this.cmbProdNo.Size = new System.Drawing.Size(141, 23);
            this.cmbProdNo.TabIndex = 8;
            this.cmbProdNo.SelectedIndexChanged += new System.EventHandler(this.cmbProdNo_SelectedIndexChanged);
            // 
            // cmbCLBH
            // 
            this.cmbCLBH.Location = new System.Drawing.Point(87, 86);
            this.cmbCLBH.Name = "cmbCLBH";
            this.cmbCLBH.Size = new System.Drawing.Size(141, 23);
            this.cmbCLBH.TabIndex = 10;
            this.cmbCLBH.SelectedIndexChanged += new System.EventHandler(this.cmbCLBH_SelectedIndexChanged);
            // 
            // txtZZPC
            // 
            this.txtZZPC.Location = new System.Drawing.Point(87, 113);
            this.txtZZPC.Name = "txtZZPC";
            this.txtZZPC.ReadOnly = true;
            this.txtZZPC.Size = new System.Drawing.Size(108, 23);
            this.txtZZPC.TabIndex = 11;
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(87, 174);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(108, 23);
            this.txtXHTM.TabIndex = 12;
            this.txtXHTM.TextChanged += new System.EventHandler(this.txtXHTM_TextChanged);
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(87, 201);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(141, 23);
            this.txtQty.TabIndex = 13;
            // 
            // cmbCPBH
            // 
            this.cmbCPBH.Location = new System.Drawing.Point(87, 5);
            this.cmbCPBH.Name = "cmbCPBH";
            this.cmbCPBH.Size = new System.Drawing.Size(141, 23);
            this.cmbCPBH.TabIndex = 23;
            this.cmbCPBH.SelectedIndexChanged += new System.EventHandler(this.cmbCPBH_SelectedIndexChanged);
            // 
            // txtKLH
            // 
            this.txtKLH.Location = new System.Drawing.Point(87, 59);
            this.txtKLH.Name = "txtKLH";
            this.txtKLH.ReadOnly = true;
            this.txtKLH.Size = new System.Drawing.Size(141, 23);
            this.txtKLH.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.Text = "开拉号";
            // 
            // btnCloseZZPC
            // 
            this.btnCloseZZPC.Location = new System.Drawing.Point(199, 112);
            this.btnCloseZZPC.Name = "btnCloseZZPC";
            this.btnCloseZZPC.Size = new System.Drawing.Size(30, 24);
            this.btnCloseZZPC.TabIndex = 34;
            this.btnCloseZZPC.Text = "关";
            this.btnCloseZZPC.Click += new System.EventHandler(this.btnCloseZZPC_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(198, 174);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(30, 24);
            this.btnIn.TabIndex = 35;
            this.btnIn.Text = "纳";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(87, 142);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.ReadOnly = true;
            this.txtCWH.Size = new System.Drawing.Size(141, 23);
            this.txtCWH.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.Text = "仓位号";
            // 
            // frm_Lot_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnCloseZZPC);
            this.Controls.Add(this.txtKLH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCPBH);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.txtZZPC);
            this.Controls.Add(this.cmbCLBH);
            this.Controls.Add(this.cmbProdNo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Lot_Input";
            this.Text = "物料投入";
            this.Load += new System.EventHandler(this.frm_Lot_Input_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbProdNo;
        private System.Windows.Forms.ComboBox cmbCLBH;
        private System.Windows.Forms.TextBox txtZZPC;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cmbCPBH;
        private System.Windows.Forms.TextBox txtKLH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCloseZZPC;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Label label7;
    }
}