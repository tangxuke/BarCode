namespace BarCode.车间管理
{
    partial class frm_InputBack
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
            this.txtLine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPBH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLotNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZZPC = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCLBH = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbLLPC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(80, 103);
            this.txtLine.Name = "txtLine";
            this.txtLine.ReadOnly = true;
            this.txtLine.Size = new System.Drawing.Size(145, 23);
            this.txtLine.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.Text = "组号";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(80, 79);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(145, 23);
            this.txtUserID.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.Text = "车间";
            // 
            // txtCPBH
            // 
            this.txtCPBH.Location = new System.Drawing.Point(80, 55);
            this.txtCPBH.Name = "txtCPBH";
            this.txtCPBH.ReadOnly = true;
            this.txtCPBH.Size = new System.Drawing.Size(145, 23);
            this.txtCPBH.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.Text = "产品编号";
            // 
            // txtLotNo
            // 
            this.txtLotNo.Location = new System.Drawing.Point(80, 31);
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.ReadOnly = true;
            this.txtLotNo.Size = new System.Drawing.Size(145, 23);
            this.txtLotNo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.Text = "Lot NO";
            // 
            // txtProdno
            // 
            this.txtProdno.Location = new System.Drawing.Point(80, 7);
            this.txtProdno.Name = "txtProdno";
            this.txtProdno.Size = new System.Drawing.Size(145, 23);
            this.txtProdno.TabIndex = 18;
            this.txtProdno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdno_KeyPress);
            this.txtProdno.LostFocus += new System.EventHandler(this.txtProdno_LostFocus);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.Text = "生产令号";
            // 
            // cmbZZPC
            // 
            this.cmbZZPC.Location = new System.Drawing.Point(80, 175);
            this.cmbZZPC.Name = "cmbZZPC";
            this.cmbZZPC.Size = new System.Drawing.Size(145, 23);
            this.cmbZZPC.TabIndex = 37;
            this.cmbZZPC.SelectedIndexChanged += new System.EventHandler(this.cmbZZPC_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.Text = "制造批次";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(80, 201);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(145, 23);
            this.txtQty.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.Text = "数量";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.Text = "来料批次";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.Text = "材料编号";
            // 
            // cmbCLBH
            // 
            this.cmbCLBH.Location = new System.Drawing.Point(80, 127);
            this.cmbCLBH.Name = "cmbCLBH";
            this.cmbCLBH.Size = new System.Drawing.Size(145, 23);
            this.cmbCLBH.TabIndex = 42;
            this.cmbCLBH.SelectedIndexChanged += new System.EventHandler(this.cmbCLBH_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(124, 242);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 26);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 242);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 26);
            this.btnOK.TabIndex = 43;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbLLPC
            // 
            this.cmbLLPC.Location = new System.Drawing.Point(80, 151);
            this.cmbLLPC.Name = "cmbLLPC";
            this.cmbLLPC.Size = new System.Drawing.Size(145, 23);
            this.cmbLLPC.TabIndex = 54;
            this.cmbLLPC.SelectedIndexChanged += new System.EventHandler(this.cmbLLPC_SelectedIndexChanged);
            // 
            // frm_InputBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.cmbLLPC);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbCLBH);
            this.Controls.Add(this.cmbZZPC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCPBH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLotNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdno);
            this.Controls.Add(this.label1);
            this.Name = "frm_InputBack";
            this.Text = "物料退回";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLotNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZZPC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCLBH;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbLLPC;
    }
}