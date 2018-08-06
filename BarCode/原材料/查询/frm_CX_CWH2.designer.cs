namespace BarCode.原材料.查询
{
    partial class frm_CX_CWH2
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCLBH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtEDPQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOKAQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOKBQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnoSend = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(4, 186);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(231, 86);
            this.dataGrid1.TabIndex = 9;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "仓位号";
            this.dataGridTextBoxColumn1.MappingName = "仓位号";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(198, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(30, 23);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "查";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.Text = "材料编号";
            // 
            // txtCLBH
            // 
            this.txtCLBH.Location = new System.Drawing.Point(79, 5);
            this.txtCLBH.Name = "txtCLBH";
            this.txtCLBH.Size = new System.Drawing.Size(116, 23);
            this.txtCLBH.TabIndex = 11;
            this.txtCLBH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCLBH_KeyPress);
            this.txtCLBH.LostFocus += new System.EventHandler(this.txtCLBH_LostFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.Text = "条码库存";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(79, 85);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(116, 23);
            this.txtQty.TabIndex = 14;
            this.txtQty.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(198, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "关 ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtEDPQty
            // 
            this.txtEDPQty.Location = new System.Drawing.Point(79, 30);
            this.txtEDPQty.Name = "txtEDPQty";
            this.txtEDPQty.ReadOnly = true;
            this.txtEDPQty.Size = new System.Drawing.Size(116, 23);
            this.txtEDPQty.TabIndex = 19;
            this.txtEDPQty.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.Text = "EDP 库存";
            // 
            // txtOKAQty
            // 
            this.txtOKAQty.Location = new System.Drawing.Point(79, 110);
            this.txtOKAQty.Name = "txtOKAQty";
            this.txtOKAQty.ReadOnly = true;
            this.txtOKAQty.Size = new System.Drawing.Size(116, 23);
            this.txtOKAQty.TabIndex = 24;
            this.txtOKAQty.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.Text = "已进仓";
            // 
            // txtCheckQty
            // 
            this.txtCheckQty.Location = new System.Drawing.Point(79, 161);
            this.txtCheckQty.Name = "txtCheckQty";
            this.txtCheckQty.ReadOnly = true;
            this.txtCheckQty.Size = new System.Drawing.Size(116, 23);
            this.txtCheckQty.TabIndex = 27;
            this.txtCheckQty.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.Text = "待检区";
            // 
            // txtOKBQty
            // 
            this.txtOKBQty.Location = new System.Drawing.Point(78, 135);
            this.txtOKBQty.Name = "txtOKBQty";
            this.txtOKBQty.ReadOnly = true;
            this.txtOKBQty.Size = new System.Drawing.Size(116, 23);
            this.txtOKBQty.TabIndex = 34;
            this.txtOKBQty.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.Text = "待进仓";
            // 
            // txtnoSend
            // 
            this.txtnoSend.Location = new System.Drawing.Point(79, 55);
            this.txtnoSend.Name = "txtnoSend";
            this.txtnoSend.ReadOnly = true;
            this.txtnoSend.Size = new System.Drawing.Size(116, 23);
            this.txtnoSend.TabIndex = 37;
            this.txtnoSend.TabStop = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.Text = "EDP未导";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 4);
            // 
            // frm_CX_CWH2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtnoSend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOKBQty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCheckQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOKAQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEDPQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCLBH);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label1);
            this.Name = "frm_CX_CWH2";
            this.Text = "物料查询";
            this.Load += new System.EventHandler(this.frm_CX_CWH2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCLBH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtEDPQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOKAQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheckQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.TextBox txtOKBQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnoSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}