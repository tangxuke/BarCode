namespace BarCode.设备管理
{
    partial class FRM_SBFL
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
            this.cmbFldno = new System.Windows.Forms.ComboBox();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSBFL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSBXH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSBNO = new System.Windows.Forms.TextBox();
            this.txtYF = new System.Windows.Forms.TextBox();
            this.txtSF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSJ = new System.Windows.Forms.Button();
            this.txtcpbh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.Text = "发料单号";
            // 
            // cmbFldno
            // 
            this.cmbFldno.Location = new System.Drawing.Point(86, 30);
            this.cmbFldno.Name = "cmbFldno";
            this.cmbFldno.Size = new System.Drawing.Size(147, 23);
            this.cmbFldno.TabIndex = 1;
            this.cmbFldno.SelectedIndexChanged += new System.EventHandler(this.cmbFldno_SelectedIndexChanged);
            // 
            // cmbUserID
            // 
            this.cmbUserID.Location = new System.Drawing.Point(86, 5);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(147, 23);
            this.cmbUserID.TabIndex = 3;
            this.cmbUserID.SelectedIndexChanged += new System.EventHandler(this.cmbUserID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.Text = "发料车间";
            // 
            // cmbSBFL
            // 
            this.cmbSBFL.Location = new System.Drawing.Point(86, 83);
            this.cmbSBFL.Name = "cmbSBFL";
            this.cmbSBFL.Size = new System.Drawing.Size(147, 23);
            this.cmbSBFL.TabIndex = 6;
            this.cmbSBFL.SelectedIndexChanged += new System.EventHandler(this.cmbSBFL_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.Text = "设备分类";
            // 
            // cmbSBXH
            // 
            this.cmbSBXH.Location = new System.Drawing.Point(86, 108);
            this.cmbSBXH.Name = "cmbSBXH";
            this.cmbSBXH.Size = new System.Drawing.Size(147, 23);
            this.cmbSBXH.TabIndex = 9;
            this.cmbSBXH.SelectedIndexChanged += new System.EventHandler(this.cmbSBXH_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(2, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.Text = "设备型号";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(2, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.Text = "设备流水号";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "资产编号";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(86, 213);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(147, 23);
            this.txtXHTM.TabIndex = 15;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(86, 158);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.ReadOnly = true;
            this.txtPlace.Size = new System.Drawing.Size(147, 23);
            this.txtPlace.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.Text = "存放位置";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 244);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 30);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(154, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 30);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSBNO
            // 
            this.txtSBNO.Location = new System.Drawing.Point(86, 133);
            this.txtSBNO.Name = "txtSBNO";
            this.txtSBNO.ReadOnly = true;
            this.txtSBNO.Size = new System.Drawing.Size(147, 23);
            this.txtSBNO.TabIndex = 28;
            // 
            // txtYF
            // 
            this.txtYF.Location = new System.Drawing.Point(86, 183);
            this.txtYF.Name = "txtYF";
            this.txtYF.ReadOnly = true;
            this.txtYF.Size = new System.Drawing.Size(42, 23);
            this.txtYF.TabIndex = 29;
            // 
            // txtSF
            // 
            this.txtSF.Location = new System.Drawing.Point(191, 183);
            this.txtSF.Name = "txtSF";
            this.txtSF.ReadOnly = true;
            this.txtSF.Size = new System.Drawing.Size(42, 23);
            this.txtSF.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(140, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.Text = "实发";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.Text = "应发";
            // 
            // btnSJ
            // 
            this.btnSJ.Location = new System.Drawing.Point(83, 244);
            this.btnSJ.Name = "btnSJ";
            this.btnSJ.Size = new System.Drawing.Size(71, 30);
            this.btnSJ.TabIndex = 38;
            this.btnSJ.Text = "上架";
            this.btnSJ.Click += new System.EventHandler(this.btnSJ_Click);
            // 
            // txtcpbh
            // 
            this.txtcpbh.Location = new System.Drawing.Point(86, 56);
            this.txtcpbh.Name = "txtcpbh";
            this.txtcpbh.ReadOnly = true;
            this.txtcpbh.Size = new System.Drawing.Size(147, 23);
            this.txtcpbh.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(2, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.Text = "产品编号";
            // 
            // FRM_SBFL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.txtcpbh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSJ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSF);
            this.Controls.Add(this.txtYF);
            this.Controls.Add(this.txtSBNO);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSBXH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSBFL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFldno);
            this.Controls.Add(this.label1);
            this.Name = "FRM_SBFL";
            this.Text = "设备发料";
            this.Load += new System.EventHandler(this.FRM_SBFL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFldno;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSBFL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSBXH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSBNO;
        private System.Windows.Forms.TextBox txtYF;
        private System.Windows.Forms.TextBox txtSF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSJ;
        private System.Windows.Forms.TextBox txtcpbh;
        private System.Windows.Forms.Label label10;
    }
}