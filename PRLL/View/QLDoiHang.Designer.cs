namespace PRL.View
{
    partial class QLDoiHang
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
            txtSearchSDTKH = new TextBox();
            label1 = new Label();
            btnDoiTra = new Label();
            gbMenu = new GroupBox();
            btnQLNhanVien = new Button();
            btnKhuyenMai = new Button();
            btnQLSanPham = new Button();
            btnQLHoaDon = new Button();
            groupBox1 = new GroupBox();
            hoadon = new ListBox();
            lb_thongtinhoadon = new ListBox();
            groupBox2 = new GroupBox();
            btn_Tra = new Button();
            label3 = new Label();
            label2 = new Label();
            rdb_Tra = new RadioButton();
            rdb_Doi = new RadioButton();
            textBox1 = new TextBox();
            btn_Doi = new Button();
            txtSoLuongDoi = new TextBox();
            txtMaSP = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            dgv_DoiTra = new DataGridView();
            btn_Exits = new Button();
            label4 = new Label();
            button1 = new Button();
            gbMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DoiTra).BeginInit();
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
            // txtSearchSDTKH
            // 
            txtSearchSDTKH.Location = new Point(22, 42);
            txtSearchSDTKH.Name = "txtSearchSDTKH";
            txtSearchSDTKH.PlaceholderText = "Vui lòng nhập mã hóa đơn";
            txtSearchSDTKH.Size = new Size(367, 27);
            txtSearchSDTKH.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 77);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // btnDoiTra
            // 
            btnDoiTra.AutoSize = true;
            btnDoiTra.Cursor = Cursors.Cross;
            btnDoiTra.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoiTra.Location = new Point(440, 9);
            btnDoiTra.Name = "btnDoiTra";
            btnDoiTra.Size = new Size(235, 41);
            btnDoiTra.TabIndex = 3;
            btnDoiTra.Text = "Quản lý Đổi Trả";
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(btnQLNhanVien);
            gbMenu.Controls.Add(button1);
            gbMenu.Controls.Add(btnKhuyenMai);
            gbMenu.Controls.Add(btnQLSanPham);
            gbMenu.Controls.Add(btnQLHoaDon);
            gbMenu.Location = new Point(12, 41);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(250, 666);
            gbMenu.TabIndex = 5;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(hoadon);
            groupBox1.Controls.Add(lb_thongtinhoadon);
            groupBox1.Controls.Add(txtSearchSDTKH);
            groupBox1.Location = new Point(286, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 293);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // hoadon
            // 
            hoadon.FormattingEnabled = true;
            hoadon.ItemHeight = 20;
            hoadon.Location = new Point(22, 82);
            hoadon.Name = "hoadon";
            hoadon.Size = new Size(367, 184);
            hoadon.TabIndex = 2;
            // 
            // lb_thongtinhoadon
            // 
            lb_thongtinhoadon.FormattingEnabled = true;
            lb_thongtinhoadon.ItemHeight = 20;
            lb_thongtinhoadon.Location = new Point(528, 87);
            lb_thongtinhoadon.Name = "lb_thongtinhoadon";
            lb_thongtinhoadon.Size = new Size(367, 184);
            lb_thongtinhoadon.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Tra);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(rdb_Tra);
            groupBox2.Controls.Add(rdb_Doi);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(btn_Doi);
            groupBox2.Controls.Add(txtSoLuongDoi);
            groupBox2.Controls.Add(txtMaSP);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(720, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 293);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // btn_Tra
            // 
            btn_Tra.Location = new Point(187, 228);
            btn_Tra.Name = "btn_Tra";
            btn_Tra.Size = new Size(106, 43);
            btn_Tra.TabIndex = 15;
            btn_Tra.Text = "Trả";
            btn_Tra.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 182);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 14;
            label3.Text = "Hình thức";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 133);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 13;
            label2.Text = "Giá";
            // 
            // rdb_Tra
            // 
            rdb_Tra.AutoSize = true;
            rdb_Tra.Location = new Point(272, 182);
            rdb_Tra.Name = "rdb_Tra";
            rdb_Tra.Size = new Size(50, 24);
            rdb_Tra.TabIndex = 12;
            rdb_Tra.TabStop = true;
            rdb_Tra.Text = "Trả";
            rdb_Tra.UseVisualStyleBackColor = true;
            // 
            // rdb_Doi
            // 
            rdb_Doi.AutoSize = true;
            rdb_Doi.Location = new Point(124, 182);
            rdb_Doi.Name = "rdb_Doi";
            rdb_Doi.Size = new Size(58, 24);
            rdb_Doi.TabIndex = 11;
            rdb_Doi.TabStop = true;
            rdb_Doi.Text = "Đổi ";
            rdb_Doi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 10;
            // 
            // btn_Doi
            // 
            btn_Doi.Location = new Point(44, 228);
            btn_Doi.Name = "btn_Doi";
            btn_Doi.Size = new Size(106, 43);
            btn_Doi.TabIndex = 9;
            btn_Doi.Text = "Đổi";
            btn_Doi.UseVisualStyleBackColor = true;
            // 
            // txtSoLuongDoi
            // 
            txtSoLuongDoi.Location = new Point(123, 80);
            txtSoLuongDoi.Name = "txtSoLuongDoi";
            txtSoLuongDoi.Size = new Size(199, 27);
            txtSoLuongDoi.TabIndex = 8;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(123, 35);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(199, 27);
            txtMaSP.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 87);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 1;
            label7.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 42);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 0;
            label6.Text = "Mã sản phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_DoiTra);
            groupBox3.Location = new Point(292, 361);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(813, 330);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Hóa Đơn";
            // 
            // dgv_DoiTra
            // 
            dgv_DoiTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DoiTra.Location = new Point(34, 38);
            dgv_DoiTra.Name = "dgv_DoiTra";
            dgv_DoiTra.RowHeadersWidth = 51;
            dgv_DoiTra.RowTemplate.Height = 29;
            dgv_DoiTra.Size = new Size(748, 247);
            dgv_DoiTra.TabIndex = 0;
            // 
            // btn_Exits
            // 
            btn_Exits.Location = new Point(980, 697);
            btn_Exits.Name = "btn_Exits";
            btn_Exits.Size = new Size(94, 46);
            btn_Exits.TabIndex = 9;
            btn_Exits.Text = "Exits";
            btn_Exits.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(939, 26);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "User : ";
            // 
            // QLDoiHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 755);
            Controls.Add(label4);
            Controls.Add(btn_Exits);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbMenu);
            Controls.Add(btnDoiTra);
            Controls.Add(label1);
            Name = "QLDoiHang";
            Text = "QLDoiHang";
            Load += QLDoiHang_Load;
            gbMenu.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DoiTra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchSDTKH;
        private Label label1;
        private Label btnDoiTra;
        private GroupBox gbMenu;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtSoLuongDoi;
        private TextBox txtMaSP;
        private Label label7;
        private Label label6;
        private Button btnQLSanPham;
        private Button btnQLHoaDon;
        private Button btn_Doi;
        private GroupBox groupBox3;
        private DataGridView dgv_DoiTra;
        private Button btn_Exits;
        private Button button1;
        private Button btnKhuyenMai;
        private Button btnQLNhanVien;
        private ListBox hoadon;
        private ListBox lb_thongtinhoadon;
        private Label label3;
        private Label label2;
        private RadioButton rdb_Tra;
        private RadioButton rdb_Doi;
        private TextBox textBox1;
        private Button btn_Tra;
        private Label label4;
    }
}