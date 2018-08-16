namespace BarCode
{
    partial class frm_login
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnNX = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.Text = "用户名：";
            // 
            // txtUser
            // 
            this.txtUser.HideSelection = false;
            this.txtUser.Location = new System.Drawing.Point(96, 46);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(121, 23);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "sa";
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 79);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "iced_lotus";
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.Text = "密   码：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(25, 164);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(79, 27);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "外销";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnNX
            // 
            this.btnNX.Location = new System.Drawing.Point(134, 164);
            this.btnNX.Name = "btnNX";
            this.btnNX.Size = new System.Drawing.Size(79, 27);
            this.btnNX.TabIndex = 6;
            this.btnNX.Text = "内销";
            this.btnNX.Click += new System.EventHandler(this.btnNX_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.Text = "更新日期：2018.08.16";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNX);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Name = "frm_login";
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnNX;
        private System.Windows.Forms.Label label3;
    }
}