namespace BarCode.原材料.进仓
{
    partial class frm_NewStock
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
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.txtCLBH = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbwhid = new System.Windows.Forms.ComboBox();
            this.txtzzpc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(100, 33);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.Size = new System.Drawing.Size(125, 23);
            this.txtCWH.TabIndex = 0;
            this.txtCWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCWH_KeyPress);
            this.txtCWH.LostFocus += new System.EventHandler(this.txtCWH_LostFocus);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.Text = "仓位号";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.Text = "箱号条码";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.Text = "来料批次";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.Text = "材料编号";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.Text = "更新数量";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(100, 59);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(125, 23);
            this.txtXHTM.TabIndex = 10;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(100, 85);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.Size = new System.Drawing.Size(125, 23);
            this.txtLLPC.TabIndex = 11;
            this.txtLLPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLLPC_KeyPress);
            this.txtLLPC.LostFocus += new System.EventHandler(this.txtLLPC_LostFocus);
            // 
            // txtCLBH
            // 
            this.txtCLBH.Location = new System.Drawing.Point(100, 111);
            this.txtCLBH.Name = "txtCLBH";
            this.txtCLBH.Size = new System.Drawing.Size(125, 23);
            this.txtCLBH.TabIndex = 12;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(100, 166);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(125, 23);
            this.txtQty.TabIndex = 13;
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
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.Text = "库别";
            // 
            // cmbwhid
            // 
            this.cmbwhid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.cmbwhid.Location = new System.Drawing.Point(100, 3);
            this.cmbwhid.Name = "cmbwhid";
            this.cmbwhid.Size = new System.Drawing.Size(125, 26);
            this.cmbwhid.TabIndex = 24;
            // 
            // txtzzpc
            // 
            this.txtzzpc.Location = new System.Drawing.Point(100, 138);
            this.txtzzpc.Name = "txtzzpc";
            this.txtzzpc.Size = new System.Drawing.Size(125, 23);
            this.txtzzpc.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.Text = "制造批次";
            // 
            // frm_NewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.txtzzpc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbwhid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCLOSE);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtCLBH);
            this.Controls.Add(this.txtLLPC);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCWH);
            this.MinimizeBox = false;
            this.Name = "frm_NewStock";
            this.Text = "更新库存";
            this.Load += new System.EventHandler(this.frm_NewStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.TextBox txtLLPC;
        private System.Windows.Forms.TextBox txtCLBH;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbwhid;
        private System.Windows.Forms.TextBox txtzzpc;
        private System.Windows.Forms.Label label7;
    }
}