﻿namespace BarCode.车间管理
{
    partial class FRM_FLDDL
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
            this.txtXhtm = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFldNO = new System.Windows.Forms.ComboBox();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtXhtm
            // 
            this.txtXhtm.Location = new System.Drawing.Point(89, 69);
            this.txtXhtm.Name = "txtXhtm";
            this.txtXhtm.Size = new System.Drawing.Size(127, 23);
            this.txtXhtm.TabIndex = 1;
            this.txtXhtm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXhtm_KeyPress);
            this.txtXhtm.LostFocus += new System.EventHandler(this.txtXhtm_LostFocus);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(147, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "返回";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(2, 108);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(234, 133);
            this.dataGrid1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "箱号条码";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "发料单号";
            // 
            // cmbFldNO
            // 
            this.cmbFldNO.Location = new System.Drawing.Point(89, 3);
            this.cmbFldNO.Name = "cmbFldNO";
            this.cmbFldNO.Size = new System.Drawing.Size(127, 23);
            this.cmbFldNO.TabIndex = 15;
            this.cmbFldNO.SelectedIndexChanged += new System.EventHandler(this.cmbFldNO_SelectedIndexChanged);
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(89, 36);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.Size = new System.Drawing.Size(127, 23);
            this.txtCWH.TabIndex = 0;
            this.txtCWH.GotFocus += new System.EventHandler(this.txtCWH_GotFocus);
            this.txtCWH.LostFocus += new System.EventHandler(this.txtCWH_LostFocus);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "仓位号";
            // 
            // FRM_FLDDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFldNO);
            this.Controls.Add(this.txtXhtm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_FLDDL";
            this.Text = "发料单点料";
            this.Load += new System.EventHandler(this.FRM_FLDDL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtXhtm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFldNO;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Label label3;
    }
}