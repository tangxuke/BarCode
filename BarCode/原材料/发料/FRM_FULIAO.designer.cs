namespace BarCode.原材料.发料
{
    partial class FRM_FULIAO
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
            this.cmbClbh = new System.Windows.Forms.ComboBox();
            this.txtSFSL = new System.Windows.Forms.TextBox();
            this.txtYFSL = new System.Windows.Forms.TextBox();
            this.cmbLLDH = new System.Windows.Forms.ComboBox();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCLMC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbClbh
            // 
            this.cmbClbh.Location = new System.Drawing.Point(89, 57);
            this.cmbClbh.Name = "cmbClbh";
            this.cmbClbh.Size = new System.Drawing.Size(146, 23);
            this.cmbClbh.TabIndex = 54;
            this.cmbClbh.SelectedIndexChanged += new System.EventHandler(this.cmbClbh_SelectedIndexChanged);
            // 
            // txtSFSL
            // 
            this.txtSFSL.Location = new System.Drawing.Point(89, 137);
            this.txtSFSL.Name = "txtSFSL";
            this.txtSFSL.Size = new System.Drawing.Size(146, 23);
            this.txtSFSL.TabIndex = 51;
            this.txtSFSL.TabStop = false;
            // 
            // txtYFSL
            // 
            this.txtYFSL.Location = new System.Drawing.Point(89, 110);
            this.txtYFSL.Name = "txtYFSL";
            this.txtYFSL.ReadOnly = true;
            this.txtYFSL.Size = new System.Drawing.Size(146, 23);
            this.txtYFSL.TabIndex = 50;
            this.txtYFSL.TabStop = false;
            // 
            // cmbLLDH
            // 
            this.cmbLLDH.Location = new System.Drawing.Point(89, 31);
            this.cmbLLDH.Name = "cmbLLDH";
            this.cmbLLDH.Size = new System.Drawing.Size(146, 23);
            this.cmbLLDH.TabIndex = 49;
            this.cmbLLDH.SelectedIndexChanged += new System.EventHandler(this.cmbLLDH_SelectedIndexChanged);
            // 
            // cmbUserID
            // 
            this.cmbUserID.Location = new System.Drawing.Point(89, 5);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(146, 23);
            this.cmbUserID.TabIndex = 48;
            this.cmbUserID.SelectedIndexChanged += new System.EventHandler(this.cmbUserID_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(125, 238);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 33);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(21, 238);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 33);
            this.btnOK.TabIndex = 46;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.Text = "实发数量";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.Text = "需发数量";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.Text = "材料编号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.Text = "领料单号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.Text = "车间";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.Text = "材料名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCLMC
            // 
            this.txtCLMC.Location = new System.Drawing.Point(89, 84);
            this.txtCLMC.Name = "txtCLMC";
            this.txtCLMC.ReadOnly = true;
            this.txtCLMC.Size = new System.Drawing.Size(146, 23);
            this.txtCLMC.TabIndex = 63;
            this.txtCLMC.TabStop = false;
            // 
            // FRM_FULIAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.txtCLMC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClbh);
            this.Controls.Add(this.txtSFSL);
            this.Controls.Add(this.txtYFSL);
            this.Controls.Add(this.cmbLLDH);
            this.Controls.Add(this.cmbUserID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FRM_FULIAO";
            this.Text = "辅料发料";
            this.Load += new System.EventHandler(this.FRM_FULIAO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClbh;
        private System.Windows.Forms.TextBox txtSFSL;
        private System.Windows.Forms.TextBox txtYFSL;
        private System.Windows.Forms.ComboBox cmbLLDH;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCLMC;
    }
}