namespace BarCode.原材料.查询
{
    partial class frm_CX_Detail
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
            this.txtClbh = new System.Windows.Forms.TextBox();
            this.lblXS = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClbh
            // 
            this.txtClbh.Location = new System.Drawing.Point(3, 3);
            this.txtClbh.Name = "txtClbh";
            this.txtClbh.Size = new System.Drawing.Size(88, 23);
            this.txtClbh.TabIndex = 0;
            // 
            // lblXS
            // 
            this.lblXS.Location = new System.Drawing.Point(149, 6);
            this.lblXS.Name = "lblXS";
            this.lblXS.Size = new System.Drawing.Size(74, 20);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(97, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(44, 24);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(3, 29);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(231, 217);
            this.dataGrid1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(81, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frm_CX_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblXS);
            this.Controls.Add(this.txtClbh);
            this.Name = "frm_CX_Detail";
            this.Text = "条码明细";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtClbh;
        private System.Windows.Forms.Label lblXS;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button btnClose;
    }
}