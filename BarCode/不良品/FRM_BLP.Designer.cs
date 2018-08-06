namespace BarCode.BLP
{
    partial class FRM_BLP
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
            this.btnSJ = new System.Windows.Forms.Button();
            this.btnTHQD = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFJ = new System.Windows.Forms.Button();
            this.btnFL = new System.Windows.Forms.Button();
            this.btnBF = new System.Windows.Forms.Button();
            this.btnBFCancel = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSJ
            // 
            this.btnSJ.Location = new System.Drawing.Point(13, 10);
            this.btnSJ.Name = "btnSJ";
            this.btnSJ.Size = new System.Drawing.Size(98, 31);
            this.btnSJ.TabIndex = 0;
            this.btnSJ.Text = "上架";
            this.btnSJ.Click += new System.EventHandler(this.btnSJ_Click);
            // 
            // btnTHQD
            // 
            this.btnTHQD.Location = new System.Drawing.Point(13, 47);
            this.btnTHQD.Name = "btnTHQD";
            this.btnTHQD.Size = new System.Drawing.Size(98, 31);
            this.btnTHQD.TabIndex = 1;
            this.btnTHQD.Text = "退货";
            this.btnTHQD.Click += new System.EventHandler(this.btnTHQD_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(46, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "返回";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFJ
            // 
            this.btnFJ.Location = new System.Drawing.Point(130, 84);
            this.btnFJ.Name = "btnFJ";
            this.btnFJ.Size = new System.Drawing.Size(98, 31);
            this.btnFJ.TabIndex = 5;
            this.btnFJ.Text = "复检";
            this.btnFJ.Click += new System.EventHandler(this.btnFJ_Click);
            // 
            // btnFL
            // 
            this.btnFL.Location = new System.Drawing.Point(130, 10);
            this.btnFL.Name = "btnFL";
            this.btnFL.Size = new System.Drawing.Size(98, 31);
            this.btnFL.TabIndex = 6;
            this.btnFL.Text = "发料";
            this.btnFL.Click += new System.EventHandler(this.btnFL_Click);
            // 
            // btnBF
            // 
            this.btnBF.Location = new System.Drawing.Point(13, 121);
            this.btnBF.Name = "btnBF";
            this.btnBF.Size = new System.Drawing.Size(98, 31);
            this.btnBF.TabIndex = 7;
            this.btnBF.Text = "报废";
            this.btnBF.Click += new System.EventHandler(this.btnBF_Click);
            // 
            // btnBFCancel
            // 
            this.btnBFCancel.Location = new System.Drawing.Point(130, 121);
            this.btnBFCancel.Name = "btnBFCancel";
            this.btnBFCancel.Size = new System.Drawing.Size(98, 31);
            this.btnBFCancel.TabIndex = 8;
            this.btnBFCancel.Text = "报废取消";
            this.btnBFCancel.Click += new System.EventHandler(this.btnBFCancel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(130, 47);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(98, 31);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // FRM_BLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnBFCancel);
            this.Controls.Add(this.btnBF);
            this.Controls.Add(this.btnFL);
            this.Controls.Add(this.btnFJ);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTHQD);
            this.Controls.Add(this.btnSJ);
            this.Name = "FRM_BLP";
            this.Text = "不良品";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSJ;
        private System.Windows.Forms.Button btnTHQD;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFJ;
        private System.Windows.Forms.Button btnFL;
        private System.Windows.Forms.Button btnBF;
        private System.Windows.Forms.Button btnBFCancel;
        private System.Windows.Forms.Button btnQuery;
    }
}