namespace BarCode.成品管理
{
    partial class FRM_KCQR
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
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.txtCpbh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtXH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLotno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTMLot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "箱号条码";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(94, 9);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(138, 23);
            this.txtXHTM.TabIndex = 1;
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // txtCpbh
            // 
            this.txtCpbh.Location = new System.Drawing.Point(94, 36);
            this.txtCpbh.Name = "txtCpbh";
            this.txtCpbh.ReadOnly = true;
            this.txtCpbh.Size = new System.Drawing.Size(138, 23);
            this.txtCpbh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "产品编号";
            // 
            // txtProdno
            // 
            this.txtProdno.Location = new System.Drawing.Point(94, 64);
            this.txtProdno.Name = "txtProdno";
            this.txtProdno.ReadOnly = true;
            this.txtProdno.Size = new System.Drawing.Size(138, 23);
            this.txtProdno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "生产制令号";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(94, 92);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(138, 23);
            this.txtQty.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "数量";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(16, 221);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 32);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(130, 221);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 32);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtXH
            // 
            this.txtXH.Location = new System.Drawing.Point(94, 120);
            this.txtXH.Name = "txtXH";
            this.txtXH.ReadOnly = true;
            this.txtXH.Size = new System.Drawing.Size(138, 23);
            this.txtXH.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "箱号";
            // 
            // txtLotno
            // 
            this.txtLotno.Location = new System.Drawing.Point(93, 149);
            this.txtLotno.Name = "txtLotno";
            this.txtLotno.ReadOnly = true;
            this.txtLotno.Size = new System.Drawing.Size(138, 23);
            this.txtLotno.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "LOT  NO";
            // 
            // txtTMLot
            // 
            this.txtTMLot.Location = new System.Drawing.Point(93, 178);
            this.txtTMLot.Name = "txtTMLot";
            this.txtTMLot.ReadOnly = true;
            this.txtTMLot.Size = new System.Drawing.Size(138, 23);
            this.txtTMLot.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.Text = "条码LotNo";
            // 
            // FRM_KCQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.txtTMLot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLotno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtXH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProdno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCpbh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label1);
            this.Name = "FRM_KCQR";
            this.Text = "库存车载品确认";
            this.Load += new System.EventHandler(this.FRM_KCQR_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.TextBox txtCpbh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtXH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLotno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTMLot;
        private System.Windows.Forms.Label label7;
    }
}