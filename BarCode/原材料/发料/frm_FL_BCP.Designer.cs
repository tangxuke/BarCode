namespace BarCode.原材料.发料
{
    partial class frm_FL_BCP
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
            this.comboFLDH = new System.Windows.Forms.ComboBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.发料批次 = new System.Windows.Forms.DataGridTableStyle();
            this.材料编号 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.来料批次 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.实发数 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.Text = "发料单号";
            // 
            // comboFLDH
            // 
            this.comboFLDH.Location = new System.Drawing.Point(88, 8);
            this.comboFLDH.Name = "comboFLDH";
            this.comboFLDH.Size = new System.Drawing.Size(132, 23);
            this.comboFLDH.TabIndex = 1;
            this.comboFLDH.SelectedIndexChanged += new System.EventHandler(this.comboFLDH_SelectedIndexChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(4, 37);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(231, 148);
            this.dataGrid1.TabIndex = 2;
            this.dataGrid1.TableStyles.Add(this.发料批次);
            // 
            // 发料批次
            // 
            this.发料批次.GridColumnStyles.Add(this.材料编号);
            this.发料批次.GridColumnStyles.Add(this.来料批次);
            this.发料批次.GridColumnStyles.Add(this.实发数);
            this.发料批次.MappingName = "发料批次";
            // 
            // 材料编号
            // 
            this.材料编号.Format = "";
            this.材料编号.FormatInfo = null;
            this.材料编号.HeaderText = "材料编号";
            this.材料编号.MappingName = "材料编号";
            this.材料编号.Width = 70;
            // 
            // 来料批次
            // 
            this.来料批次.Format = "";
            this.来料批次.FormatInfo = null;
            this.来料批次.HeaderText = "来料批次";
            this.来料批次.MappingName = "来料批次";
            this.来料批次.Width = 70;
            // 
            // 实发数
            // 
            this.实发数.Format = "";
            this.实发数.FormatInfo = null;
            this.实发数.HeaderText = "实发数";
            this.实发数.MappingName = "实发数";
            this.实发数.Width = 70;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.Text = "箱号条码";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(88, 191);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(132, 23);
            this.txtXHTM.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(22, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(148, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frm_FL_BCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.comboFLDH);
            this.Controls.Add(this.label1);
            this.Name = "frm_FL_BCP";
            this.Text = "半成品发料";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFLDH;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridTableStyle 发料批次;
        private System.Windows.Forms.DataGridTextBoxColumn 材料编号;
        private System.Windows.Forms.DataGridTextBoxColumn 来料批次;
        private System.Windows.Forms.DataGridTextBoxColumn 实发数;
    }
}