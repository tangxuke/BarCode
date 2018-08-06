namespace BarCode.BCP
{
    partial class frm_BCPSJ
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCwh = new System.Windows.Forms.TextBox();
            this.txtXhtm = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.Text = "仓位号：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.Text = "箱号条码：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 32);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(123, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "返回";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCwh
            // 
            this.txtCwh.Location = new System.Drawing.Point(107, 5);
            this.txtCwh.Name = "txtCwh";
            this.txtCwh.Size = new System.Drawing.Size(116, 23);
            this.txtCwh.TabIndex = 5;
            this.txtCwh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCwh_KeyPress);
            this.txtCwh.LostFocus += new System.EventHandler(this.txtCwh_LostFocus);
            // 
            // txtXhtm
            // 
            this.txtXhtm.Location = new System.Drawing.Point(107, 32);
            this.txtXhtm.Name = "txtXhtm";
            this.txtXhtm.Size = new System.Drawing.Size(116, 23);
            this.txtXhtm.TabIndex = 6;
            this.txtXhtm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXhtm_KeyPress);
            this.txtXhtm.LostFocus += new System.EventHandler(this.txtXhtm_LostFocus);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(2, 59);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(234, 180);
            this.dataGrid1.TabIndex = 9;
            // 
            // frm_BCPSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.txtXhtm);
            this.Controls.Add(this.txtCwh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_BCPSJ";
            this.Text = "半成品上架";
            this.Load += new System.EventHandler(this.frm_BCPSJ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCwh;
        private System.Windows.Forms.TextBox txtXhtm;
        private System.Windows.Forms.DataGrid dataGrid1;
    }
}