namespace PRL.View
{
    partial class MenuQL
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
            groupBox1 = new GroupBox();
            btn_QLKhuyenMai = new Button();
            btn_QLDoiTra = new Button();
            btn_QlSanPham = new Button();
            btn_QLNhanVien = new Button();
            btn_QLHoaDon = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_QLKhuyenMai);
            groupBox1.Controls.Add(btn_QLDoiTra);
            groupBox1.Controls.Add(btn_QlSanPham);
            groupBox1.Controls.Add(btn_QLNhanVien);
            groupBox1.Controls.Add(btn_QLHoaDon);
            groupBox1.Location = new Point(17, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 611);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btn_QLKhuyenMai
            // 
            btn_QLKhuyenMai.Location = new Point(19, 406);
            btn_QLKhuyenMai.Name = "btn_QLKhuyenMai";
            btn_QLKhuyenMai.Size = new Size(231, 47);
            btn_QLKhuyenMai.TabIndex = 4;
            btn_QLKhuyenMai.Text = "Quản lý Khuyến Mại";
            btn_QLKhuyenMai.UseVisualStyleBackColor = true;
            // 
            // btn_QLDoiTra
            // 
            btn_QLDoiTra.Location = new Point(19, 325);
            btn_QLDoiTra.Name = "btn_QLDoiTra";
            btn_QLDoiTra.Size = new Size(231, 47);
            btn_QLDoiTra.TabIndex = 3;
            btn_QLDoiTra.Text = "Quản Lý Đổi Trả";
            btn_QLDoiTra.UseVisualStyleBackColor = true;
            btn_QLDoiTra.Click += btn_QLDoiTra_Click;
            // 
            // btn_QlSanPham
            // 
            btn_QlSanPham.Location = new Point(19, 244);
            btn_QlSanPham.Name = "btn_QlSanPham";
            btn_QlSanPham.Size = new Size(231, 47);
            btn_QlSanPham.TabIndex = 2;
            btn_QlSanPham.Text = "Quản lý Sản Phẩm";
            btn_QlSanPham.UseVisualStyleBackColor = true;
            // 
            // btn_QLNhanVien
            // 
            btn_QLNhanVien.Location = new Point(19, 163);
            btn_QLNhanVien.Name = "btn_QLNhanVien";
            btn_QLNhanVien.Size = new Size(231, 47);
            btn_QLNhanVien.TabIndex = 1;
            btn_QLNhanVien.Text = "Quản lý Nhân Viên";
            btn_QLNhanVien.UseVisualStyleBackColor = true;
            // 
            // btn_QLHoaDon
            // 
            btn_QLHoaDon.Location = new Point(19, 82);
            btn_QLHoaDon.Name = "btn_QLHoaDon";
            btn_QLHoaDon.Size = new Size(231, 47);
            btn_QLHoaDon.TabIndex = 0;
            btn_QLHoaDon.Text = "Quản lý Hóa Đơn";
            btn_QLHoaDon.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chon_giay_the_thao_theo_vi_tri_choi_bong;
            pictureBox1.Location = new Point(295, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(766, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(917, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "User : ";
            // 
            // MenuQL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1086, 630);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "MenuQL";
            Text = "MenuQL";
            Load += MenuQL_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btn_QLKhuyenMai;
        private Button btn_QLDoiTra;
        private Button btn_QlSanPham;
        private Button btn_QLNhanVien;
        private Button btn_QLHoaDon;
        private PictureBox pictureBox1;
        private Label label1;
    }
}