﻿namespace BarCode.原材料.进仓
{
    partial class frm_JC_BCPSJ
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
            this.txtXTM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtXTM
            // 
            this.txtXTM.Location = new System.Drawing.Point(87, 94);
            this.txtXTM.Name = "txtXTM";
            this.txtXTM.Size = new System.Drawing.Size(130, 23);
            this.txtXTM.TabIndex = 15;
            this.txtXTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXTM_KeyPress);
            this.txtXTM.LostFocus += new System.EventHandler(this.txtXTM_LostFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.Text = "箱条码：";
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(87, 34);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.Size = new System.Drawing.Size(130, 23);
            this.txtCWH.TabIndex = 14;
            this.txtCWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCWH_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.Text = "仓位号：";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(129, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 31);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(35, 211);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 31);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "完成";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frm_JC_BCPSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtXTM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.label1);
            this.Name = "frm_JC_BCPSJ";
            this.Text = "半成品上架";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtXTM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOK;
    }
}