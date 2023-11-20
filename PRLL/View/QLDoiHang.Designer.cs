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
            txtSoLuongMua = new TextBox();
            txtPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dtpNgayTao = new DateTimePicker();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnThem = new Button();
            txtSoLuongDoi = new TextBox();
            txtMaSP = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnBack = new Button();
            button1 = new Button();
            gbMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            txtSearchSDTKH.Location = new Point(112, 35);
            txtSearchSDTKH.Name = "txtSearchSDTKH";
            txtSearchSDTKH.PlaceholderText = "Vui lòng nhập mã hóa đơn";
            txtSearchSDTKH.Size = new Size(250, 27);
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
            groupBox1.Controls.Add(txtSoLuongMua);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSearchSDTKH);
            groupBox1.Location = new Point(286, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 234);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtSoLuongMua
            // 
            txtSoLuongMua.Location = new Point(112, 171);
            txtSoLuongMua.Name = "txtSoLuongMua";
            txtSoLuongMua.Size = new Size(250, 27);
            txtSoLuongMua.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(112, 126);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 27);
            txtPrice.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 178);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Số Lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 133);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 3;
            label4.Text = "Giá";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Cursor = Cursors.AppStarting;
            dtpNgayTao.CustomFormat = "dd/MM/yyyy";
            dtpNgayTao.Format = DateTimePickerFormat.Short;
            dtpNgayTao.Location = new Point(112, 80);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(250, 27);
            dtpNgayTao.TabIndex = 2;
            dtpNgayTao.Value = new DateTime(2023, 11, 7, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 85);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày tạo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtSoLuongDoi);
            groupBox2.Controls.Add(txtMaSP);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(720, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 234);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(173, 126);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 43);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
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
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(292, 361);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(813, 330);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Hóa Đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(748, 247);
            dataGridView1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(980, 697);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 46);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // QLDoiHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 755);
            Controls.Add(btnBack);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbMenu);
            Controls.Add(btnDoiTra);
            Controls.Add(label1);
            Name = "QLDoiHang";
            Text = "QLDoiHang";
            gbMenu.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchSDTKH;
        private Label label1;
        private Label btnDoiTra;
        private GroupBox gbMenu;
        private GroupBox groupBox1;
        private Label label4;
        private DateTimePicker dtpNgayTao;
        private Label label3;
        private TextBox txtSoLuongMua;
        private TextBox txtPrice;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox txtSoLuongDoi;
        private TextBox txtMaSP;
        private Label label7;
        private Label label6;
        private Button btnQLSanPham;
        private Button btnQLHoaDon;
        private Button btnThem;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button btnBack;
        private Button button1;
        private Button btnKhuyenMai;
        private Button btnQLNhanVien;
    }
}