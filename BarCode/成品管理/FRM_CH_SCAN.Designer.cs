namespace BarCode.成品管理
{
    partial class FRM_CH_SCAN
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCPBH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPackID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.Text = "产品编号";
            // 
            // cmbCPBH
            // 
            this.cmbCPBH.Location = new System.Drawing.Point(81, 33);
            this.cmbCPBH.Name = "cmbCPBH";
            this.cmbCPBH.Size = new System.Drawing.Size(149, 23);
            this.cmbCPBH.TabIndex = 3;
            this.cmbCPBH.TextChanged += new System.EventHandler(this.cmbCPBH_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.Text = "箱号条码";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(81, 63);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(149, 23);
            this.txtXHTM.TabIndex = 5;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(8, 89);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(226, 151);
            this.dataGrid1.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(34, 245);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 26);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClost
            // 
            this.btnClost.Location = new System.Drawing.Point(122, 245);
            this.btnClost.Name = "btnClost";
            this.btnClost.Size = new System.Drawing.Size(83, 26);
            this.btnClost.TabIndex = 8;
            this.btnClost.Text = "关闭";
            this.btnClost.Click += new System.EventHandler(this.btnClost_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.Text = "PackID";
            // 
            // cmbPackID
            // 
            this.cmbPackID.Location = new System.Drawing.Point(81, 4);
            this.cmbPackID.Name = "cmbPackID";
            this.cmbPackID.Size = new System.Drawing.Size(149, 23);
            this.cmbPackID.TabIndex = 12;
            this.cmbPackID.SelectedIndexChanged += new System.EventHandler(this.cmbPackID_SelectedIndexChanged);
            // 
            // FRM_CH_SCAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.cmbPackID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClost);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCPBH);
            this.Controls.Add(this.label2);
            this.Name = "FRM_CH_SCAN";
            this.Text = "出货扫描";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCPBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPackID;
    }
}