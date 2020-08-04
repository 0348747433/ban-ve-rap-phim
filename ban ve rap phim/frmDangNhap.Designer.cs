namespace ban_ve_rap_phim
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.Location = new System.Drawing.Point(274, 165);
            this.lbtaikhoan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(130, 25);
            this.lbtaikhoan.TabIndex = 0;
            this.lbtaikhoan.Text = "TÀI KHOẢN:";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Location = new System.Drawing.Point(272, 229);
            this.lbmatkhau.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(127, 25);
            this.lbmatkhau.TabIndex = 1;
            this.lbmatkhau.Text = "MẬT KHẨU:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(439, 159);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(196, 31);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(439, 229);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(196, 31);
            this.txtPassword.TabIndex = 3;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(439, 308);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(6);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndangnhap.Size = new System.Drawing.Size(150, 44);
            this.btndangnhap.TabIndex = 4;
            this.btndangnhap.Text = "ĐĂNG NHẬP";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(439, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(169, 29);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 386);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.lbtaikhoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDangNhap";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtaikhoan;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

