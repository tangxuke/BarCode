﻿namespace BarCode.原材料.进仓
{
    partial class frm_JC_WLSJ
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtXTM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 42);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(6, 5);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(221, 32);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Location = new System.Drawing.Point(4, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 42);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(126, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 31);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "返回";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(32, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 31);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "完成";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.txtXTM);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtCWH);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(4, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 170);
            // 
            // txtXTM
            // 
            this.txtXTM.Location = new System.Drawing.Point(83, 88);
            this.txtXTM.Name = "txtXTM";
            this.txtXTM.Size = new System.Drawing.Size(130, 23);
            this.txtXTM.TabIndex = 11;
            this.txtXTM.ParentChanged += new System.EventHandler(this.txtXTM_ParentChanged);
            this.txtXTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXTM_KeyPress);
            this.txtXTM.LostFocus += new System.EventHandler(this.txtXTM_LostFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.Text = "箱条码：";
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(83, 28);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.Size = new System.Drawing.Size(130, 23);
            this.txtCWH.TabIndex = 10;
            this.txtCWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCWH_KeyPress);
            this.txtCWH.LostFocus += new System.EventHandler(this.txtCWH_LostFocus);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.Text = "仓位号：";
            // 
            // frm_JC_WLSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_JC_WLSJ";
            this.Text = "来料+发料+退料+复检+初始化";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frm_JC_WLSJ_Closing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtXTM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfo;
    }
}