namespace BarCode.原材料.收料
{
    partial class FRM_SL_ZZPC
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCGY = new System.Windows.Forms.ComboBox();
            this.cmbLLPC = new System.Windows.Forms.ComboBox();
            this.txtCLBH = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtZZPC = new System.Windows.Forms.TextBox();
            this.txtZZPCQty = new System.Windows.Forms.TextBox();
            this.txtZZPCSUMQty = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.txtGHF = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRemain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "收料仓管";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "来料批次";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "材料编号";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "数量";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "制造批次";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.Text = "数量";
            // 
            // cmbCGY
            // 
            this.cmbCGY.Location = new System.Drawing.Point(77, 2);
            this.cmbCGY.Name = "cmbCGY";
            this.cmbCGY.Size = new System.Drawing.Size(152, 23);
            this.cmbCGY.TabIndex = 7;
            this.cmbCGY.SelectedIndexChanged += new System.EventHandler(this.cmbCGY_SelectedIndexChanged);
            // 
            // cmbLLPC
            // 
            this.cmbLLPC.Location = new System.Drawing.Point(77, 27);
            this.cmbLLPC.Name = "cmbLLPC";
            this.cmbLLPC.Size = new System.Drawing.Size(152, 23);
            this.cmbLLPC.TabIndex = 8;
            this.cmbLLPC.SelectedIndexChanged += new System.EventHandler(this.cmbLLPC_SelectedIndexChanged);
            // 
            // txtCLBH
            // 
            this.txtCLBH.Location = new System.Drawing.Point(77, 53);
            this.txtCLBH.Name = "txtCLBH";
            this.txtCLBH.ReadOnly = true;
            this.txtCLBH.Size = new System.Drawing.Size(75, 23);
            this.txtCLBH.TabIndex = 9;
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(77, 77);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.ReadOnly = true;
            this.txtQTY.Size = new System.Drawing.Size(75, 23);
            this.txtQTY.TabIndex = 10;
            // 
            // txtZZPC
            // 
            this.txtZZPC.Location = new System.Drawing.Point(77, 102);
            this.txtZZPC.Name = "txtZZPC";
            this.txtZZPC.Size = new System.Drawing.Size(152, 23);
            this.txtZZPC.TabIndex = 11;
            this.txtZZPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZZPC_KeyPress);
            // 
            // txtZZPCQty
            // 
            this.txtZZPCQty.Location = new System.Drawing.Point(77, 127);
            this.txtZZPCQty.Name = "txtZZPCQty";
            this.txtZZPCQty.Size = new System.Drawing.Size(125, 23);
            this.txtZZPCQty.TabIndex = 12;
            this.txtZZPCQty.GotFocus += new System.EventHandler(this.txtZZQty_GotFocus);
            this.txtZZPCQty.LostFocus += new System.EventHandler(this.txtZZPCQty_LostFocus);
            // 
            // txtZZPCSUMQty
            // 
            this.txtZZPCSUMQty.Location = new System.Drawing.Point(154, 77);
            this.txtZZPCSUMQty.Name = "txtZZPCSUMQty";
            this.txtZZPCSUMQty.ReadOnly = true;
            this.txtZZPCSUMQty.Size = new System.Drawing.Size(75, 23);
            this.txtZZPCSUMQty.TabIndex = 13;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(3, 152);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(231, 95);
            this.dataGrid1.TabIndex = 14;
            // 
            // txtGHF
            // 
            this.txtGHF.Location = new System.Drawing.Point(154, 53);
            this.txtGHF.Name = "txtGHF";
            this.txtGHF.ReadOnly = true;
            this.txtGHF.Size = new System.Drawing.Size(75, 23);
            this.txtGHF.TabIndex = 15;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(39, 249);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 24);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(117, 249);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 24);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRemain
            // 
            this.btnRemain.Location = new System.Drawing.Point(203, 127);
            this.btnRemain.Name = "btnRemain";
            this.btnRemain.Size = new System.Drawing.Size(26, 23);
            this.btnRemain.TabIndex = 18;
            this.btnRemain.Click += new System.EventHandler(this.btnRemain_Click);
            // 
            // FRM_SL_ZZPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnRemain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtGHF);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.txtZZPCSUMQty);
            this.Controls.Add(this.txtZZPCQty);
            this.Controls.Add(this.txtZZPC);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.txtCLBH);
            this.Controls.Add(this.cmbLLPC);
            this.Controls.Add(this.cmbCGY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_SL_ZZPC";
            this.Text = "制造批次维护";
            this.Load += new System.EventHandler(this.FRM_SL_ZZPC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCGY;
        private System.Windows.Forms.ComboBox cmbLLPC;
        private System.Windows.Forms.TextBox txtCLBH;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtZZPC;
        private System.Windows.Forms.TextBox txtZZPCQty;
        private System.Windows.Forms.TextBox txtZZPCSUMQty;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.TextBox txtGHF;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRemain;
    }
}