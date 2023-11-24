namespace PRL.View
{
    partial class QLKhuyenMai
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
            Button button1;
            gbMenu = new GroupBox();
            btnQLNhanVien = new Button();
            btnKhuyenMai = new Button();
            btnQLSanPham = new Button();
            btnQLHoaDon = new Button();
            label1 = new Label();
            cb_maspkm = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtGiaGoc = new TextBox();
            txtSoPT = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtGiaSau = new TextBox();
            btnUpdate = new Button();
            btnThoat = new Button();
            button1 = new Button();
            gbMenu.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 297);
            button1.Name = "button1";
            button1.Size = new Size(209, 54);
            button1.TabIndex = 10;
            button1.Text = "Quản lý Đổi Trả";
            button1.UseVisualStyleBackColor = true;
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(btnQLNhanVien);
            gbMenu.Controls.Add(button1);
            gbMenu.Controls.Add(btnKhuyenMai);
            gbMenu.Controls.Add(btnQLSanPham);
            gbMenu.Controls.Add(btnQLHoaDon);
            gbMenu.Location = new Point(12, 12);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(250, 666);
            gbMenu.TabIndex = 6;
            gbMenu.TabStop = false;
            gbMenu.Text = "Menu";
            // 
            // btnQLNhanVien
            // 
            btnQLNhanVien.Location = new Point(21, 393);
            btnQLNhanVien.Name = "btnQLNhanVien";
            btnQLNhanVien.Size = new Size(209, 54);
            btnQLNhanVien.TabIndex = 11;
            btnQLNhanVien.Text = "Quản lý Nhân Viên";
            btnQLNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnKhuyenMai
            // 
            btnKhuyenMai.Location = new Point(21, 213);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Size = new Size(209, 54);
            btnKhuyenMai.TabIndex = 2;
            btnKhuyenMai.Text = "Quản lý Khuyến Mại";
            btnKhuyenMai.UseVisualStyleBackColor = true;
            btnKhuyenMai.Click += btnKhuyenMai_Click;
            // 
            // btnQLSanPham
            // 
            btnQLSanPham.Location = new Point(21, 133);
            btnQLSanPham.Name = "btnQLSanPham";
            btnQLSanPham.Size = new Size(209, 54);
            btnQLSanPham.TabIndex = 1;
            btnQLSanPham.Text = "Quản lý Sản Phẩm";
            btnQLSanPham.UseVisualStyleBackColor = true;
            // 
            // btnQLHoaDon
            // 
            btnQLHoaDon.Location = new Point(21, 54);
            btnQLHoaDon.Name = "btnQLHoaDon";
            btnQLHoaDon.Size = new Size(209, 54);
            btnQLHoaDon.TabIndex = 0;
            btnQLHoaDon.Text = "Quản lý Hóa Đơn";
            btnQLHoaDon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 24);
            label1.Name = "label1";
            label1.Size = new Size(297, 41);
            label1.TabIndex = 7;
            label1.Text = "Quản lý khuyến mại";
            // 
            // cb_maspkm
            // 
            cb_maspkm.FormattingEnabled = true;
            cb_maspkm.Location = new Point(400, 107);
            cb_maspkm.Name = "cb_maspkm";
            cb_maspkm.Size = new Size(213, 28);
            cb_maspkm.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 115);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 9;
            label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 163);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 10;
            label3.Text = "Giá gốc";
            // 
            // txtGiaGoc
            // 
            txtGiaGoc.Location = new Point(400, 156);
            txtGiaGoc.Name = "txtGiaGoc";
            txtGiaGoc.Size = new Size(213, 27);
            txtGiaGoc.TabIndex = 11;
            // 
            // txtSoPT
            // 
            txtSoPT.Location = new Point(400, 204);
            txtSoPT.Name = "txtSoPT";
            txtSoPT.Size = new Size(213, 27);
            txtSoPT.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 259);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 13;
            label4.Text = "Giá sau";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(283, 207);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 14;
            label5.Text = "Số phần trăm ";
            // 
            // txtGiaSau
            // 
            txtGiaSau.Location = new Point(400, 252);
            txtGiaSau.Name = "txtGiaSau";
            txtGiaSau.Size = new Size(213, 27);
            txtGiaSau.TabIndex = 15;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(337, 529);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 52);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Cập nhật khuyến mại";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(617, 529);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(113, 52);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // QLKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 612);
            Controls.Add(btnThoat);
            Controls.Add(btnUpdate);
            Controls.Add(txtGiaSau);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSoPT);
            Controls.Add(txtGiaGoc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cb_maspkm);
            Controls.Add(label1);
            Controls.Add(gbMenu);
            Name = "QLKhuyenMai";
            Text = "QLKhuyenMai";
            gbMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbMenu;
        private Button btnQLNhanVien;
        private Button btnKhuyenMai;
        private Button btnQLSanPham;
        private Button btnQLHoaDon;
        private Label label1;
        private ComboBox cb_maspkm;
        private Label label2;
        private Label label3;
        private TextBox txtGiaGoc;
        private TextBox txtSoPT;
        private Label label4;
        private Label label5;
        private TextBox txtGiaSau;
        private Button btnUpdate;
        private Button btnThoat;
    }
}