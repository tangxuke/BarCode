namespace BarCode.原材料
{
    partial class frm_Main
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
            this.btnWLSJ = new System.Windows.Forms.Button();
            this.btnFL = new System.Windows.Forms.Button();
            this.btnCX = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBF = new System.Windows.Forms.Button();
            this.btnRefStock = new System.Windows.Forms.Button();
            this.btnBLP = new System.Windows.Forms.Button();
            this.btnDL = new System.Windows.Forms.Button();
            this.btnSL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWLSJ
            // 
            this.btnWLSJ.Location = new System.Drawing.Point(18, 8);
            this.btnWLSJ.Name = "btnWLSJ";
            this.btnWLSJ.Size = new System.Drawing.Size(93, 28);
            this.btnWLSJ.TabIndex = 0;
            this.btnWLSJ.Text = "进仓";
            this.btnWLSJ.Click += new System.EventHandler(this.btnSL_Click);
            // 
            // btnFL
            // 
            this.btnFL.Location = new System.Drawing.Point(128, 8);
            this.btnFL.Name = "btnFL";
            this.btnFL.Size = new System.Drawing.Size(93, 28);
            this.btnFL.TabIndex = 1;
            this.btnFL.Text = "发料";
            this.btnFL.Click += new System.EventHandler(this.btnFL_Click);
            // 
            // btnCX
            // 
            this.btnCX.Location = new System.Drawing.Point(128, 76);
            this.btnCX.Name = "btnCX";
            this.btnCX.Size = new System.Drawing.Size(93, 28);
            this.btnCX.TabIndex = 4;
            this.btnCX.TabStop = false;
            this.btnCX.Text = "查询";
            this.btnCX.Click += new System.EventHandler(this.btnCX_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBF
            // 
            this.btnBF.Location = new System.Drawing.Point(18, 42);
            this.btnBF.Name = "btnBF";
            this.btnBF.Size = new System.Drawing.Size(93, 28);
            this.btnBF.TabIndex = 7;
            this.btnBF.Text = "报废";
            this.btnBF.Click += new System.EventHandler(this.btnBF_Click);
            // 
            // btnRefStock
            // 
            this.btnRefStock.Location = new System.Drawing.Point(18, 110);
            this.btnRefStock.Name = "btnRefStock";
            this.btnRefStock.Size = new System.Drawing.Size(93, 28);
            this.btnRefStock.TabIndex = 10;
            this.btnRefStock.Text = "更新库存";
            this.btnRefStock.Click += new System.EventHandler(this.btnRefStock_Click);
            // 
            // btnBLP
            // 
            this.btnBLP.Location = new System.Drawing.Point(128, 42);
            this.btnBLP.Name = "btnBLP";
            this.btnBLP.Size = new System.Drawing.Size(93, 28);
            this.btnBLP.TabIndex = 12;
            this.btnBLP.Text = "不良品";
            this.btnBLP.Click += new System.EventHandler(this.btnBLP_Click);
            // 
            // btnDL
            // 
            this.btnDL.Location = new System.Drawing.Point(18, 76);
            this.btnDL.Name = "btnDL";
            this.btnDL.Size = new System.Drawing.Size(93, 28);
            this.btnDL.TabIndex = 13;
            this.btnDL.Text = "呆滞料";
            this.btnDL.Click += new System.EventHandler(this.btnDL_Click);
            // 
            // btnSL
            // 
            this.btnSL.Location = new System.Drawing.Point(128, 110);
            this.btnSL.Name = "btnSL";
            this.btnSL.Size = new System.Drawing.Size(93, 28);
            this.btnSL.TabIndex = 14;
            this.btnSL.Text = "收料";
            this.btnSL.Click += new System.EventHandler(this.btnSL_Click_1);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.btnSL);
            this.Controls.Add(this.btnDL);
            this.Controls.Add(this.btnBLP);
            this.Controls.Add(this.btnRefStock);
            this.Controls.Add(this.btnBF);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCX);
            this.Controls.Add(this.btnFL);
            this.Controls.Add(this.btnWLSJ);
            this.Name = "frm_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWLSJ;
        private System.Windows.Forms.Button btnFL;
        private System.Windows.Forms.Button btnCX;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBF;
        private System.Windows.Forms.Button btnRefStock;
        private System.Windows.Forms.Button btnBLP;
        private System.Windows.Forms.Button btnDL;
        private System.Windows.Forms.Button btnSL;

    }
}