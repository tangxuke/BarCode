namespace BarCode.原材料.查询
{
    partial class frm_CX_CL
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
            this.txtCLBH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.仓位明细 = new System.Windows.Forms.DataGridTableStyle();
            this.箱号条码 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.仓位号 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.来料批次 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelCLKC = new System.Windows.Forms.Label();
            this.lblTMQty = new System.Windows.Forms.Label();
            this.labelCLMC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.Text = "材料编号：";
            // 
            // txtCLBH
            // 
            this.txtCLBH.Location = new System.Drawing.Point(101, 12);
            this.txtCLBH.Name = "txtCLBH";
            this.txtCLBH.Size = new System.Drawing.Size(100, 23);
            this.txtCLBH.TabIndex = 1;
            this.txtCLBH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCLBH_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.Text = "材料库存：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.Text = "总箱数：";
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(3, 115);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(232, 115);
            this.dataGrid1.TabIndex = 5;
            this.dataGrid1.TableStyles.Add(this.仓位明细);
            // 
            // 仓位明细
            // 
            this.仓位明细.GridColumnStyles.Add(this.箱号条码);
            this.仓位明细.GridColumnStyles.Add(this.仓位号);
            this.仓位明细.GridColumnStyles.Add(this.来料批次);
            this.仓位明细.GridColumnStyles.Add(this.数量);
            this.仓位明细.MappingName = "仓位明细";
            // 
            // 箱号条码
            // 
            this.箱号条码.Format = "";
            this.箱号条码.FormatInfo = null;
            this.箱号条码.HeaderText = "箱号条码";
            this.箱号条码.MappingName = "箱号条码";
            this.箱号条码.Width = 70;
            // 
            // 仓位号
            // 
            this.仓位号.Format = "";
            this.仓位号.FormatInfo = null;
            this.仓位号.HeaderText = "仓位号";
            this.仓位号.MappingName = "仓位号";
            this.仓位号.Width = 60;
            // 
            // 来料批次
            // 
            this.来料批次.Format = "";
            this.来料批次.FormatInfo = null;
            this.来料批次.HeaderText = "来料批次";
            this.来料批次.MappingName = "来料批次";
            this.来料批次.Width = 70;
            // 
            // 数量
            // 
            this.数量.Format = "";
            this.数量.FormatInfo = null;
            this.数量.HeaderText = "数量";
            this.数量.MappingName = "数量";
            this.数量.Width = 70;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(163, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelCLKC
            // 
            this.labelCLKC.Location = new System.Drawing.Point(101, 65);
            this.labelCLKC.Name = "labelCLKC";
            this.labelCLKC.Size = new System.Drawing.Size(123, 20);
            // 
            // lblTMQty
            // 
            this.lblTMQty.Location = new System.Drawing.Point(101, 92);
            this.lblTMQty.Name = "lblTMQty";
            this.lblTMQty.Size = new System.Drawing.Size(123, 20);
            // 
            // labelCLMC
            // 
            this.labelCLMC.Location = new System.Drawing.Point(101, 40);
            this.labelCLMC.Name = "labelCLMC";
            this.labelCLMC.Size = new System.Drawing.Size(123, 20);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.Text = "材料名称：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(207, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(28, 25);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "查";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frm_CX_CL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelCLMC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTMQty);
            this.Controls.Add(this.labelCLKC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCLBH);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CX_CL";
            this.Text = "材料查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCLBH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelCLKC;
        private System.Windows.Forms.Label lblTMQty;
        private System.Windows.Forms.DataGridTableStyle 仓位明细;
        private System.Windows.Forms.DataGridTextBoxColumn 箱号条码;
        private System.Windows.Forms.DataGridTextBoxColumn 仓位号;
        private System.Windows.Forms.DataGridTextBoxColumn 来料批次;
        private System.Windows.Forms.DataGridTextBoxColumn 数量;
        private System.Windows.Forms.Label labelCLMC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
    }
}