namespace BarCode.BCP
{
    partial class frm_BCPFL
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
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.txtCpbh = new System.Windows.Forms.TextBox();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.cmbFldh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.Text = "发料单号";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.Text = "箱号条码";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(67, 63);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(169, 27);
            this.txtXHTM.TabIndex = 4;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // txtCpbh
            // 
            this.txtCpbh.Location = new System.Drawing.Point(7, 34);
            this.txtCpbh.Name = "txtCpbh";
            this.txtCpbh.ReadOnly = true;
            this.txtCpbh.Size = new System.Drawing.Size(112, 27);
            this.txtCpbh.TabIndex = 6;
            // 
            // txtCWH
            // 
            this.txtCWH.ForeColor = System.Drawing.Color.Red;
            this.txtCWH.Location = new System.Drawing.Point(124, 34);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.ReadOnly = true;
            this.txtCWH.Size = new System.Drawing.Size(112, 27);
            this.txtCWH.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(130, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 32);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "返回";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(27, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 32);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(2, 97);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(234, 141);
            this.dataGrid1.TabIndex = 21;
            // 
            // cmbFldh
            // 
            this.cmbFldh.Location = new System.Drawing.Point(67, 5);
            this.cmbFldh.Name = "cmbFldh";
            this.cmbFldh.Size = new System.Drawing.Size(169, 27);
            this.cmbFldh.TabIndex = 22;
            this.cmbFldh.SelectedIndexChanged += new System.EventHandler(this.cmbFldh_SelectedIndexChanged);
            // 
            // frm_BCPFL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(239, 275);
            this.Controls.Add(this.cmbFldh);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.txtCpbh);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_BCPFL";
            this.Text = "半成品发料";
            this.Load += new System.EventHandler(this.frm_BCPFL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.TextBox txtCpbh;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.ComboBox cmbFldh;
    }
}