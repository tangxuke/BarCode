namespace BarCode.车间管理
{
    partial class frm_inputQuery
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
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbCLBH = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(78, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 26);
            this.btnClose.TabIndex = 73;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbCLBH
            // 
            this.cmbCLBH.Location = new System.Drawing.Point(85, 127);
            this.cmbCLBH.Name = "cmbCLBH";
            this.cmbCLBH.Size = new System.Drawing.Size(145, 23);
            this.cmbCLBH.TabIndex = 71;
            this.cmbCLBH.SelectedIndexChanged += new System.EventHandler(this.cmbCLBH_SelectedIndexChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(85, 152);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(145, 23);
            this.txtQty.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.Text = "投入数量";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.Text = "材料编号";
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(85, 103);
            this.txtLine.Name = "txtLine";
            this.txtLine.ReadOnly = true;
            this.txtLine.Size = new System.Drawing.Size(145, 23);
            this.txtLine.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.Text = "组号";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(85, 79);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(145, 23);
            this.txtUserID.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.Text = "车间";
            // 
            // txtCPBH
            // 
            this.txtCPBH.Location = new System.Drawing.Point(85, 55);
            this.txtCPBH.Name = "txtCPBH";
            this.txtCPBH.ReadOnly = true;
            this.txtCPBH.Size = new System.Drawing.Size(145, 23);
            this.txtCPBH.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.Text = "产品编号";
            // 
            // txtLotNo
            // 
            this.txtLotNo.Location = new System.Drawing.Point(85, 31);
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.ReadOnly = true;
            this.txtLotNo.Size = new System.Drawing.Size(145, 23);
            this.txtLotNo.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.Text = "Lot NO";
            // 
            // txtProdno
            // 
            this.txtProdno.Location = new System.Drawing.Point(85, 7);
            this.txtProdno.Name = "txtProdno";
            this.txtProdno.Size = new System.Drawing.Size(145, 23);
            this.txtProdno.TabIndex = 64;
            this.txtProdno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdno_KeyPress);
            this.txtProdno.LostFocus += new System.EventHandler(this.txtProdno_LostFocus);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.Text = "生产令号";
            // 
            // frm_inputQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbCLBH);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label9);
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
            this.Name = "frm_inputQuery";
            this.Text = "投入查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbCLBH;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
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
    }
}