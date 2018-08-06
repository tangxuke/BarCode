namespace BarCode.原材料.发料
{
    partial class frm_FL_PTFL
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
            this.btnExit = new System.Windows.Forms.Button();
            this.comboCGY = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKSFL = new System.Windows.Forms.Button();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbwhid = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(47, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboCGY
            // 
            this.comboCGY.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.comboCGY.Location = new System.Drawing.Point(88, 49);
            this.comboCGY.Name = "comboCGY";
            this.comboCGY.Size = new System.Drawing.Size(138, 26);
            this.comboCGY.TabIndex = 2;
            this.comboCGY.SelectedIndexChanged += new System.EventHandler(this.comboCGY_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.Text = "发料仓管：";
            // 
            // btnKSFL
            // 
            this.btnKSFL.Location = new System.Drawing.Point(47, 134);
            this.btnKSFL.Name = "btnKSFL";
            this.btnKSFL.Size = new System.Drawing.Size(150, 35);
            this.btnKSFL.TabIndex = 3;
            this.btnKSFL.Text = "开始发料";
            this.btnKSFL.Click += new System.EventHandler(this.btnKSFL_Click);
            // 
            // cmbUserID
            // 
            this.cmbUserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.cmbUserID.Location = new System.Drawing.Point(88, 80);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(138, 26);
            this.cmbUserID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.Text = "车间：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.Text = "库别：";
            // 
            // cmbwhid
            // 
            this.cmbwhid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.cmbwhid.Location = new System.Drawing.Point(88, 17);
            this.cmbwhid.Name = "cmbwhid";
            this.cmbwhid.Size = new System.Drawing.Size(138, 26);
            this.cmbwhid.TabIndex = 25;
            this.cmbwhid.SelectedIndexChanged += new System.EventHandler(this.cmbwhid_SelectedIndexChanged_1);
            // 
            // frm_FL_PTFL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbwhid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUserID);
            this.Controls.Add(this.btnKSFL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCGY);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_FL_PTFL";
            this.Text = "配套发料";
            this.Load += new System.EventHandler(this.frm_FL_PTFL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboCGY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKSFL;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbwhid;
    }
}