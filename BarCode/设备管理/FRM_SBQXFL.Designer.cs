﻿namespace BarCode.设备管理
{
    partial class FRM_SBQXFL
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
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(83, 57);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(147, 23);
            this.txtXHTM.TabIndex = 17;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "资产编号";
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(83, 21);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.Size = new System.Drawing.Size(147, 23);
            this.txtCWH.TabIndex = 20;
            this.txtCWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCWH_KeyPress);
            this.txtCWH.LostFocus += new System.EventHandler(this.txtCWH_LostFocus);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "仓位号";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(134, 219);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 30);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(26, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 30);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FRM_SBSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label6);
            this.Name = "FRM_SBSJ";
            this.Text = "取消发料";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
    }
}