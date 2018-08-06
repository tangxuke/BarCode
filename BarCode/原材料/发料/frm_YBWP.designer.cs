namespace BarCode.原材料.发料
{
    partial class frm_YBWP
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbFldno = new System.Windows.Forms.ComboBox();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.cmbLLDH = new System.Windows.Forms.ComboBox();
            this.txtYFSL = new System.Windows.Forms.TextBox();
            this.txtSFSL = new System.Windows.Forms.TextBox();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbClbh = new System.Windows.Forms.ComboBox();
            this.btnFB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.Text = "发料单号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.Text = "车间";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.Text = "领料单号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.Text = "材料编号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.Text = "需发数量";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.Text = "已发数量";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.Text = "箱号条码";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.Text = "仓位号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(13, 238);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 33);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(161, 238);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 33);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbFldno
            // 
            this.cmbFldno.Location = new System.Drawing.Point(89, 3);
            this.cmbFldno.Name = "cmbFldno";
            this.cmbFldno.Size = new System.Drawing.Size(146, 23);
            this.cmbFldno.TabIndex = 17;
            this.cmbFldno.SelectedIndexChanged += new System.EventHandler(this.cmbFldno_SelectedIndexChanged);
            // 
            // cmbUserID
            // 
            this.cmbUserID.Location = new System.Drawing.Point(89, 28);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(146, 23);
            this.cmbUserID.TabIndex = 18;
            this.cmbUserID.SelectedIndexChanged += new System.EventHandler(this.cmbUserID_SelectedIndexChanged);
            // 
            // cmbLLDH
            // 
            this.cmbLLDH.Location = new System.Drawing.Point(89, 54);
            this.cmbLLDH.Name = "cmbLLDH";
            this.cmbLLDH.Size = new System.Drawing.Size(146, 23);
            this.cmbLLDH.TabIndex = 19;
            this.cmbLLDH.SelectedIndexChanged += new System.EventHandler(this.cmbLLDH_SelectedIndexChanged);
            // 
            // txtYFSL
            // 
            this.txtYFSL.Location = new System.Drawing.Point(89, 131);
            this.txtYFSL.Name = "txtYFSL";
            this.txtYFSL.ReadOnly = true;
            this.txtYFSL.Size = new System.Drawing.Size(146, 23);
            this.txtYFSL.TabIndex = 21;
            this.txtYFSL.TabStop = false;
            // 
            // txtSFSL
            // 
            this.txtSFSL.Location = new System.Drawing.Point(89, 156);
            this.txtSFSL.Name = "txtSFSL";
            this.txtSFSL.ReadOnly = true;
            this.txtSFSL.Size = new System.Drawing.Size(146, 23);
            this.txtSFSL.TabIndex = 22;
            this.txtSFSL.TabStop = false;
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(89, 181);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.ReadOnly = true;
            this.txtCWH.Size = new System.Drawing.Size(146, 23);
            this.txtCWH.TabIndex = 23;
            this.txtCWH.TabStop = false;
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(89, 206);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(146, 23);
            this.txtXHTM.TabIndex = 1;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(89, 106);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.ReadOnly = true;
            this.txtLLPC.Size = new System.Drawing.Size(146, 23);
            this.txtLLPC.TabIndex = 26;
            this.txtLLPC.TabStop = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.Text = "来料批次";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbClbh
            // 
            this.cmbClbh.Location = new System.Drawing.Point(89, 80);
            this.cmbClbh.Name = "cmbClbh";
            this.cmbClbh.Size = new System.Drawing.Size(146, 23);
            this.cmbClbh.TabIndex = 36;
            this.cmbClbh.SelectedIndexChanged += new System.EventHandler(this.cmbClbh_SelectedIndexChanged);
            // 
            // btnFB
            // 
            this.btnFB.Location = new System.Drawing.Point(86, 238);
            this.btnFB.Name = "btnFB";
            this.btnFB.Size = new System.Drawing.Size(72, 33);
            this.btnFB.TabIndex = 46;
            this.btnFB.Text = "分包";
            this.btnFB.Click += new System.EventHandler(this.btnFB_Click);
            // 
            // frm_YBWP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnFB);
            this.Controls.Add(this.cmbClbh);
            this.Controls.Add(this.txtLLPC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.txtSFSL);
            this.Controls.Add(this.txtYFSL);
            this.Controls.Add(this.cmbLLDH);
            this.Controls.Add(this.cmbUserID);
            this.Controls.Add(this.cmbFldno);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_YBWP";
            this.Text = "一般物品发料单";
            this.Load += new System.EventHandler(this.frm_YBWP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbFldno;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.ComboBox cmbLLDH;
        private System.Windows.Forms.TextBox txtYFSL;
        private System.Windows.Forms.TextBox txtSFSL;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.TextBox txtLLPC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbClbh;
        private System.Windows.Forms.Button btnFB;
    }
}