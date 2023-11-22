namespace PRL.View
{
    partial class HoaDon
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
            dtpkNgayTao = new DateTimePicker();
            txtMaNV = new TextBox();
            txtMaKH = new TextBox();
            txtMaHD = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            cbbGiamgia = new ComboBox();
            txtTongTien = new TextBox();
            txtMaSp = new TextBox();
            txtDonGia = new TextBox();
            txtTenSp = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            dtgview = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnInHoaDon = new Button();
            label4 = new Label();
            txtThanhtien = new TextBox();
            btnDangXuat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpkNgayTao);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1738, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // dtpkNgayTao
            // 
            dtpkNgayTao.Location = new Point(279, 111);
            dtpkNgayTao.Name = "dtpkNgayTao";
            dtpkNgayTao.Size = new Size(495, 39);
            dtpkNgayTao.TabIndex = 2;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(1159, 116);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(495, 39);
            txtMaNV.TabIndex = 1;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(1159, 45);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(495, 39);
            txtMaKH.TabIndex = 1;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(279, 45);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(495, 39);
            txtMaHD.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(923, 119);
            label5.Name = "label5";
            label5.Size = new Size(180, 32);
            label5.TabIndex = 0;
            label5.Text = "Mã nhân viên : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(923, 48);
            label6.Name = "label6";
            label6.Size = new Size(198, 32);
            label6.TabIndex = 0;
            label6.Text = "Mã khách hàng : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 116);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 0;
            label3.Text = "Ngày tạo : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 45);
            label2.Name = "label2";
            label2.Size = new Size(156, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleTurquoise;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(576, 21);
            label1.Name = "label1";
            label1.Size = new Size(482, 62);
            label1.TabIndex = 1;
            label1.Text = "Hóa đơn bán hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(cbbGiamgia);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(txtMaSp);
            groupBox2.Controls.Add(txtDonGia);
            groupBox2.Controls.Add(txtTenSp);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(12, 296);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1738, 225);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin mặt hàng :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(280, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(497, 40);
            comboBox1.TabIndex = 4;
            // 
            // cbbGiamgia
            // 
            cbbGiamgia.FormattingEnabled = true;
            cbbGiamgia.Location = new Point(1162, 102);
            cbbGiamgia.Name = "cbbGiamgia";
            cbbGiamgia.Size = new Size(495, 40);
            cbbGiamgia.TabIndex = 3;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(1162, 166);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(495, 39);
            txtTongTien.TabIndex = 1;
            // 
            // txtMaSp
            // 
            txtMaSp.Location = new Point(1159, 45);
            txtMaSp.Name = "txtMaSp";
            txtMaSp.Size = new Size(495, 39);
            txtMaSp.TabIndex = 1;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(282, 166);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(495, 39);
            txtDonGia.TabIndex = 1;
            // 
            // txtTenSp
            // 
            txtTenSp.Location = new Point(279, 45);
            txtTenSp.Name = "txtTenSp";
            txtTenSp.Size = new Size(495, 39);
            txtTenSp.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(926, 169);
            label8.Name = "label8";
            label8.Size = new Size(136, 32);
            label8.TabIndex = 0;
            label8.Text = "Tổng tiền : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 166);
            label9.Name = "label9";
            label9.Size = new Size(117, 32);
            label9.TabIndex = 0;
            label9.Text = "Đơn giá : ";
            label9.Click += label4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(926, 105);
            label10.Name = "label10";
            label10.Size = new Size(120, 32);
            label10.TabIndex = 0;
            label10.Text = "Giảm giá :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(923, 48);
            label11.Name = "label11";
            label11.Size = new Size(128, 32);
            label11.TabIndex = 0;
            label11.Text = "Mã hàng : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 103);
            label12.Name = "label12";
            label12.Size = new Size(110, 32);
            label12.TabIndex = 0;
            label12.Text = "Số lượng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 45);
            label13.Name = "label13";
            label13.Size = new Size(175, 32);
            label13.TabIndex = 0;
            label13.Text = "Tên sản phẩm :";
            // 
            // dtgview
            // 
            dtgview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgview.Location = new Point(14, 539);
            dtgview.Name = "dtgview";
            dtgview.RowHeadersWidth = 82;
            dtgview.RowTemplate.Height = 41;
            dtgview.Size = new Size(1736, 300);
            dtgview.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(72, 919);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(193, 46);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm hóa đơn";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(291, 919);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(175, 46);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa hóa đơn ";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(515, 919);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(167, 46);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa hóa đơn";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(744, 919);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(193, 46);
            btnInHoaDon.TabIndex = 3;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(935, 859);
            label4.Name = "label4";
            label4.Size = new Size(148, 32);
            label4.TabIndex = 0;
            label4.Text = "Thành tiền : ";
            // 
            // txtThanhtien
            // 
            txtThanhtien.Location = new Point(1171, 856);
            txtThanhtien.Name = "txtThanhtien";
            txtThanhtien.Size = new Size(495, 39);
            txtThanhtien.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(1464, 919);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(193, 46);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1761, 990);
            Controls.Add(btnDangXuat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(txtThanhtien);
            Controls.Add(btnThem);
            Controls.Add(dtgview);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "HoaDon";
            Text = "HoaDon";
            FormClosing += HoaDon_FormClosing;
            FormClosed += HoaDon_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMaHD;
        private Label label2;
        private Label label1;
        private TextBox txtMaKH;
        private Label label5;
        private Label label6;
        private Label label3;
        private DateTimePicker dtpkNgayTao;
        private TextBox txtMaNV;
        private GroupBox groupBox2;
        private ComboBox cbbGiamgia;
        private TextBox txtTongTien;
        private TextBox txtMaSp;
        private TextBox txtTenSp;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView dtgview;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnInHoaDon;
        private Label label4;
        private TextBox txtThanhtien;
        private ComboBox comboBox1;
        private TextBox txtDonGia;
        private Button btnDangXuat;
    }
}