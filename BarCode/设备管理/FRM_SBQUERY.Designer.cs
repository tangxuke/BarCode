namespace BarCode.设备管理
{
    partial class FRM_SBQUERY
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
            this.txtSBNO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGGXH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCWH = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSBNO
            // 
            this.txtSBNO.Location = new System.Drawing.Point(87, 6);
            this.txtSBNO.Name = "txtSBNO";
            this.txtSBNO.Size = new System.Drawing.Size(147, 23);
            this.txtSBNO.TabIndex = 17;
            this.txtSBNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSBNO_KeyPress);
            this.txtSBNO.LostFocus += new System.EventHandler(this.txtSBNO_LostFocus);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "设备编号";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 33);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(147, 23);
            this.txtName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "设备名称";
            // 
            // txtGGXH
            // 
            this.txtGGXH.Location = new System.Drawing.Point(87, 60);
            this.txtGGXH.Name = "txtGGXH";
            this.txtGGXH.ReadOnly = true;
            this.txtGGXH.Size = new System.Drawing.Size(147, 23);
            this.txtGGXH.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "规格型号";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(87, 87);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.ReadOnly = true;
            this.txtPlace.Size = new System.Drawing.Size(147, 23);
            this.txtPlace.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "位置";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "仓位号";
            // 
            // txtCWH
            // 
            this.txtCWH.Location = new System.Drawing.Point(87, 115);
            this.txtCWH.Name = "txtCWH";
            this.txtCWH.ReadOnly = true;
            this.txtCWH.Size = new System.Drawing.Size(147, 23);
            this.txtCWH.TabIndex = 30;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(133, 232);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 30);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 232);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 30);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FRM_SBQUERY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCWH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGGXH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSBNO);
            this.Controls.Add(this.label6);
            this.Name = "FRM_SBQUERY";
            this.Text = "设备查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSBNO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGGXH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCWH;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
    }
}