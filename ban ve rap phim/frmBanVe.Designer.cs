namespace ban_ve_rap_phim
{
    partial class frmBanVe
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTenPhim = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMuaVe = new System.Windows.Forms.Button();
            this.cbNgayChieu = new System.Windows.Forms.ComboBox();
            this.cbGioChieu = new System.Windows.Forms.ComboBox();
            this.cbPhongChieu = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Chiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giờ chiếu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phòng chiếu :";
            // 
            // cbTenPhim
            // 
            this.cbTenPhim.FormattingEnabled = true;
            this.cbTenPhim.Location = new System.Drawing.Point(214, 39);
            this.cbTenPhim.Name = "cbTenPhim";
            this.cbTenPhim.Size = new System.Drawing.Size(188, 33);
            this.cbTenPhim.TabIndex = 7;
            this.cbTenPhim.SelectedIndexChanged += new System.EventHandler(this.cbTenPhim_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpSeat);
            this.groupBox1.Location = new System.Drawing.Point(512, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 678);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flpSeat
            // 
            this.flpSeat.AutoScroll = true;
            this.flpSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSeat.Location = new System.Drawing.Point(3, 27);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(826, 648);
            this.flpSeat.TabIndex = 0;
            this.flpSeat.Paint += new System.Windows.Forms.PaintEventHandler(this.flpSeat_Paint);
            // 
            // btnMuaVe
            // 
            this.btnMuaVe.Location = new System.Drawing.Point(214, 211);
            this.btnMuaVe.Name = "btnMuaVe";
            this.btnMuaVe.Size = new System.Drawing.Size(140, 61);
            this.btnMuaVe.TabIndex = 12;
            this.btnMuaVe.Text = "Mua ve";
            this.btnMuaVe.UseVisualStyleBackColor = true;
            this.btnMuaVe.Click += new System.EventHandler(this.btnMuaVe_Click);
            // 
            // cbNgayChieu
            // 
            this.cbNgayChieu.FormattingEnabled = true;
            this.cbNgayChieu.Location = new System.Drawing.Point(214, 78);
            this.cbNgayChieu.Name = "cbNgayChieu";
            this.cbNgayChieu.Size = new System.Drawing.Size(188, 33);
            this.cbNgayChieu.TabIndex = 16;
            // 
            // cbGioChieu
            // 
            this.cbGioChieu.FormattingEnabled = true;
            this.cbGioChieu.Location = new System.Drawing.Point(214, 117);
            this.cbGioChieu.Name = "cbGioChieu";
            this.cbGioChieu.Size = new System.Drawing.Size(188, 33);
            this.cbGioChieu.TabIndex = 17;
            // 
            // cbPhongChieu
            // 
            this.cbPhongChieu.FormattingEnabled = true;
            this.cbPhongChieu.Location = new System.Drawing.Point(214, 156);
            this.cbPhongChieu.Name = "cbPhongChieu";
            this.cbPhongChieu.Size = new System.Drawing.Size(188, 33);
            this.cbPhongChieu.TabIndex = 18;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(408, 42);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(50, 25);
            this.lbID.TabIndex = 19;
            this.lbID.Text = "ID : ";
            // 
            // frmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.cbPhongChieu);
            this.Controls.Add(this.cbGioChieu);
            this.Controls.Add(this.cbNgayChieu);
            this.Controls.Add(this.btnMuaVe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTenPhim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBanVe";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmBanVe_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTenPhim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpSeat;
        private System.Windows.Forms.Button btnMuaVe;
        private System.Windows.Forms.ComboBox cbNgayChieu;
        private System.Windows.Forms.ComboBox cbGioChieu;
        private System.Windows.Forms.ComboBox cbPhongChieu;
        private System.Windows.Forms.Label lbID;
    }
}