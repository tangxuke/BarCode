namespace BarCode.BLP
{
    partial class FRM_BLP_QUERY
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
            this.rdCWH = new System.Windows.Forms.RadioButton();
            this.rdClbh = new System.Windows.Forms.RadioButton();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.仓位明细 = new System.Windows.Forms.DataGridTableStyle();
            this.SuspendLayout();
            // 
            // rdCWH
            // 
            this.rdCWH.Checked = true;
            this.rdCWH.Location = new System.Drawing.Point(14, 3);
            this.rdCWH.Name = "rdCWH";
            this.rdCWH.Size = new System.Drawing.Size(100, 20);
            this.rdCWH.TabIndex = 0;
            this.rdCWH.Text = "仓位号";
            this.rdCWH.Click += new System.EventHandler(this.rdCWH_Click);
            // 
            // rdClbh
            // 
            this.rdClbh.Location = new System.Drawing.Point(126, 3);
            this.rdClbh.Name = "rdClbh";
            this.rdClbh.Size = new System.Drawing.Size(100, 20);
            this.rdClbh.TabIndex = 1;
            this.rdClbh.Text = "材料编号";
            this.rdClbh.Click += new System.EventHandler(this.rdClbh_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(15, 26);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(171, 23);
            this.txtQuery.TabIndex = 2;
            this.txtQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuery_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(192, 24);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(28, 25);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "查";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(163, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 30);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(3, 51);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(232, 186);
            this.dataGrid1.TabIndex = 16;
            this.dataGrid1.TableStyles.Add(this.仓位明细);
            // 
            // 仓位明细
            // 
            this.仓位明细.MappingName = "仓位明细";
            // 
            // FRM_BLP_QUERY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.rdClbh);
            this.Controls.Add(this.rdCWH);
            this.Name = "FRM_BLP_QUERY";
            this.Text = "不良品查询";
            this.Load += new System.EventHandler(this.FRM_BLP_QUERY_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdCWH;
        private System.Windows.Forms.RadioButton rdClbh;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGridTableStyle 仓位明细;
    }
}