namespace BarCode.设备管理
{
    partial class FRM_SBMANAGER
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
            this.btnJC = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSBQuery = new System.Windows.Forms.Button();
            this.btnCWHQuery = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJC
            // 
            this.btnJC.Location = new System.Drawing.Point(52, 5);
            this.btnJC.Name = "btnJC";
            this.btnJC.Size = new System.Drawing.Size(141, 29);
            this.btnJC.TabIndex = 0;
            this.btnJC.Text = "设备进仓";
            this.btnJC.Click += new System.EventHandler(this.btnJC_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(52, 36);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(141, 29);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "设备发出";
            this.btnOut.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(52, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "取消发出";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSBQuery
            // 
            this.btnSBQuery.Location = new System.Drawing.Point(52, 129);
            this.btnSBQuery.Name = "btnSBQuery";
            this.btnSBQuery.Size = new System.Drawing.Size(141, 29);
            this.btnSBQuery.TabIndex = 5;
            this.btnSBQuery.Text = "设备查询";
            this.btnSBQuery.Click += new System.EventHandler(this.btnSBQuery_Click);
            // 
            // btnCWHQuery
            // 
            this.btnCWHQuery.Location = new System.Drawing.Point(52, 160);
            this.btnCWHQuery.Name = "btnCWHQuery";
            this.btnCWHQuery.Size = new System.Drawing.Size(141, 29);
            this.btnCWHQuery.TabIndex = 6;
            this.btnCWHQuery.Text = "仓位查询";
            this.btnCWHQuery.Click += new System.EventHandler(this.btnCWHQuery_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "设备上架";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "设备移动";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FRM_SBMANAGER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCWHQuery);
            this.Controls.Add(this.btnSBQuery);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnJC);
            this.Name = "FRM_SBMANAGER";
            this.Text = "设备管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJC;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSBQuery;
        private System.Windows.Forms.Button btnCWHQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}