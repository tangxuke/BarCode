namespace BarCode.原材料.发料
{
    partial class frm_FL_LXFL_Detail
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtzzpc = new System.Windows.Forms.TextBox();
            this.txtPCCount = new System.Windows.Forms.TextBox();
            this.cmbCLBH = new System.Windows.Forms.ComboBox();
            this.cmbFldNO = new System.Windows.Forms.ComboBox();
            this.txtYFXS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCpbh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.txtYqs = new System.Windows.Forms.TextBox();
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFB = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPCControl = new System.Windows.Forms.Button();
            this.btnWX = new System.Windows.Forms.Button();
            this.txtXH = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.Text = "箱号条码：";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(101, 187);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(131, 23);
            this.txtXHTM.TabIndex = 0;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(5, 213);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 26);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(161, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "关闭";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtXH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtzzpc);
            this.panel1.Controls.Add(this.txtPCCount);
            this.panel1.Controls.Add(this.cmbCLBH);
            this.panel1.Controls.Add(this.cmbFldNO);
            this.panel1.Controls.Add(this.txtYFXS);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCpbh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCWH);
            this.panel1.Controls.Add(this.txtYqs);
            this.panel1.Controls.Add(this.txtLLPC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 181);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.Text = "制造批次：";
            // 
            // txtzzpc
            // 
            this.txtzzpc.Location = new System.Drawing.Point(100, 103);
            this.txtzzpc.Name = "txtzzpc";
            this.txtzzpc.ReadOnly = true;
            this.txtzzpc.Size = new System.Drawing.Size(131, 23);
            this.txtzzpc.TabIndex = 57;
            this.txtzzpc.TabStop = false;
            // 
            // txtPCCount
            // 
            this.txtPCCount.Location = new System.Drawing.Point(190, 78);
            this.txtPCCount.Name = "txtPCCount";
            this.txtPCCount.ReadOnly = true;
            this.txtPCCount.Size = new System.Drawing.Size(42, 23);
            this.txtPCCount.TabIndex = 49;
            this.txtPCCount.TabStop = false;
            // 
            // cmbCLBH
            // 
            this.cmbCLBH.Location = new System.Drawing.Point(100, 53);
            this.cmbCLBH.Name = "cmbCLBH";
            this.cmbCLBH.Size = new System.Drawing.Size(131, 23);
            this.cmbCLBH.TabIndex = 42;
            this.cmbCLBH.SelectedIndexChanged += new System.EventHandler(this.cmbCLBH_SelectedIndexChanged);
            // 
            // cmbFldNO
            // 
            this.cmbFldNO.Location = new System.Drawing.Point(100, 3);
            this.cmbFldNO.Name = "cmbFldNO";
            this.cmbFldNO.Size = new System.Drawing.Size(131, 23);
            this.cmbFldNO.TabIndex = 35;
            this.cmbFldNO.SelectedIndexChanged += new System.EventHandler(this.cmbFldNO_SelectedIndexChanged);
            // 
            // txtYFXS
            // 
            this.txtYFXS.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtYFXS.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtYFXS.Location = new System.Drawing.Point(190, 128);
            this.txtYFXS.Name = "txtYFXS";
            this.txtYFXS.ReadOnly = true;
            this.txtYFXS.Size = new System.Drawing.Size(42, 23);
            this.txtYFXS.TabIndex = 52;
            this.txtYFXS.TabStop = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.Text = "发料单号：";
            // 
            // txtCpbh
            // 
            this.txtCpbh.Location = new System.Drawing.Point(100, 28);
            this.txtCpbh.Name = "txtCpbh";
            this.txtCpbh.ReadOnly = true;
            this.txtCpbh.Size = new System.Drawing.Size(131, 23);
            this.txtCpbh.TabIndex = 13;
            this.txtCpbh.TabStop = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.Text = "产品编号：";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(6, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.Text = "存放位置：";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.Text = "余欠数量：";
            // 
            // txtCWH
            // 
            this.txtCWH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtCWH.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCWH.Location = new System.Drawing.Point(100, 153);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.ReadOnly = true;
            this.txtCWH.Size = new System.Drawing.Size(87, 23);
            this.txtCWH.TabIndex = 9;
            this.txtCWH.TabStop = false;
            // 
            // txtYqs
            // 
            this.txtYqs.Location = new System.Drawing.Point(100, 128);
            this.txtYqs.Name = "txtYqs";
            this.txtYqs.ReadOnly = true;
            this.txtYqs.Size = new System.Drawing.Size(87, 23);
            this.txtYqs.TabIndex = 8;
            this.txtYqs.TabStop = false;
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(100, 78);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.ReadOnly = true;
            this.txtLLPC.Size = new System.Drawing.Size(87, 23);
            this.txtLLPC.TabIndex = 5;
            this.txtLLPC.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.Text = "来料批次：";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.Text = "材料编号：";
            // 
            // btnFB
            // 
            this.btnFB.Location = new System.Drawing.Point(161, 213);
            this.btnFB.Name = "btnFB";
            this.btnFB.Size = new System.Drawing.Size(75, 26);
            this.btnFB.TabIndex = 16;
            this.btnFB.Text = "分包";
            this.btnFB.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(5, 240);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 26);
            this.btnView.TabIndex = 19;
            this.btnView.Text = "查看";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPCControl
            // 
            this.btnPCControl.Location = new System.Drawing.Point(83, 240);
            this.btnPCControl.Name = "btnPCControl";
            this.btnPCControl.Size = new System.Drawing.Size(75, 26);
            this.btnPCControl.TabIndex = 55;
            this.btnPCControl.Text = "批次控制";
            this.btnPCControl.Click += new System.EventHandler(this.btnPCControl_Click);
            // 
            // btnWX
            // 
            this.btnWX.Location = new System.Drawing.Point(83, 213);
            this.btnWX.Name = "btnWX";
            this.btnWX.Size = new System.Drawing.Size(75, 26);
            this.btnWX.TabIndex = 59;
            this.btnWX.Text = "外箱发料";
            this.btnWX.Click += new System.EventHandler(this.btnWX_Click);
            // 
            // txtXH
            // 
            this.txtXH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtXH.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtXH.Location = new System.Drawing.Point(190, 153);
            this.txtXH.Name = "txtXH";
            this.txtXH.ReadOnly = true;
            this.txtXH.Size = new System.Drawing.Size(42, 23);
            this.txtXH.TabIndex = 64;
            this.txtXH.TabStop = false;
            // 
            // frm_FL_LXFL_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.btnWX);
            this.Controls.Add(this.btnPCControl);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnFB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_FL_LXFL_Detail";
            this.Text = "当天发料明细";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLLPC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.TextBox txtYqs;
        private System.Windows.Forms.TextBox txtCpbh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFldNO;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cmbCLBH;
        private System.Windows.Forms.TextBox txtYFXS;
        private System.Windows.Forms.TextBox txtPCCount;
        private System.Windows.Forms.Button btnPCControl;
        private System.Windows.Forms.Button btnWX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtzzpc;
        private System.Windows.Forms.TextBox txtXH;
    }
}