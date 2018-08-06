namespace BarCode.车间管理
{
    partial class frm_InputMateriel
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
            this.txtProdno = new System.Windows.Forms.TextBox();
            this.txtLotNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPBH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXHTM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClbh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLLPC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtzzpc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.Text = "生产令号";
            // 
            // txtProdno
            // 
            this.txtProdno.Location = new System.Drawing.Point(84, 3);
            this.txtProdno.Name = "txtProdno";
            this.txtProdno.Size = new System.Drawing.Size(145, 23);
            this.txtProdno.TabIndex = 1;
            this.txtProdno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdno_KeyPress);
            this.txtProdno.LostFocus += new System.EventHandler(this.txtProdno_LostFocus);
            // 
            // txtLotNo
            // 
            this.txtLotNo.Location = new System.Drawing.Point(84, 27);
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.ReadOnly = true;
            this.txtLotNo.Size = new System.Drawing.Size(145, 23);
            this.txtLotNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.Text = "Lot NO";
            // 
            // txtCPBH
            // 
            this.txtCPBH.Location = new System.Drawing.Point(84, 51);
            this.txtCPBH.Name = "txtCPBH";
            this.txtCPBH.ReadOnly = true;
            this.txtCPBH.Size = new System.Drawing.Size(145, 23);
            this.txtCPBH.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.Text = "产品编号";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(84, 75);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(145, 23);
            this.txtUserID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.Text = "车间";
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(84, 99);
            this.txtLine.Name = "txtLine";
            this.txtLine.ReadOnly = true;
            this.txtLine.Size = new System.Drawing.Size(145, 23);
            this.txtLine.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.Text = "组号";
            // 
            // txtXHTM
            // 
            this.txtXHTM.Location = new System.Drawing.Point(84, 123);
            this.txtXHTM.Name = "txtXHTM";
            this.txtXHTM.Size = new System.Drawing.Size(145, 23);
            this.txtXHTM.TabIndex = 15;
            this.txtXHTM.TextChanged += new System.EventHandler(this.txtXHTM_TextChanged);
            this.txtXHTM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXHTM_KeyPress);
            this.txtXHTM.LostFocus += new System.EventHandler(this.txtXHTM_LostFocus);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.Text = "箱号条码";
            // 
            // txtClbh
            // 
            this.txtClbh.Location = new System.Drawing.Point(84, 147);
            this.txtClbh.Name = "txtClbh";
            this.txtClbh.ReadOnly = true;
            this.txtClbh.Size = new System.Drawing.Size(145, 23);
            this.txtClbh.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.Text = "材料编号";
            // 
            // txtLLPC
            // 
            this.txtLLPC.Location = new System.Drawing.Point(84, 171);
            this.txtLLPC.Name = "txtLLPC";
            this.txtLLPC.ReadOnly = true;
            this.txtLLPC.Size = new System.Drawing.Size(145, 23);
            this.txtLLPC.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.Text = "来料批次";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(84, 219);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(145, 23);
            this.txtQty.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.Text = "数量";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.Text = "制造批次";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 246);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 26);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(124, 246);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 26);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtzzpc
            // 
            this.txtzzpc.Location = new System.Drawing.Point(84, 195);
            this.txtzzpc.Name = "txtzzpc";
            this.txtzzpc.Size = new System.Drawing.Size(145, 23);
            this.txtzzpc.TabIndex = 42;
            // 
            // frm_InputMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.txtzzpc);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLLPC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtClbh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtXHTM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCPBH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLotNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdno);
            this.Controls.Add(this.label1);
            this.Name = "frm_InputMateriel";
            this.Text = "物料投入";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdno;
        private System.Windows.Forms.TextBox txtLotNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXHTM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClbh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLLPC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtzzpc;
    }
}