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
            txtSearch = new TextBox();
            label1 = new Label();
            btnDoiTra = new Label();
            gbMenu = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            dgv_DoiTra = new DataGridView();
            btn_Exits = new Button();
            label4 = new Label();
            btn_Xem = new Button();
            groupBox2 = new GroupBox();
            btnAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnQLHoaDon = new Button();
            btnQLSanPham = new Button();
            btnKhuyenMai = new Button();
            btnQLNhanVien = new Button();
            button1 = new Button();
            gbMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DoiTra).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(22, 42);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Vui lòng nhập mã hóa đơn";
            txtSearch.Size = new Size(292, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Location = new Point(286, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 186);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_DoiTra);
            groupBox3.Location = new Point(286, 254);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(813, 433);
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
            dgv_DoiTra.Size = new Size(748, 359);
            dgv_DoiTra.TabIndex = 0;
            // 
            // btn_Exits
            // 
            btn_Exits.Location = new Point(980, 697);
            btn_Exits.Name = "btn_Exits";
            btn_Exits.Size = new Size(94, 46);
            btn_Exits.TabIndex = 9;
            btn_Exits.Text = "Thoát";
            btn_Exits.UseVisualStyleBackColor = true;
            btn_Exits.Click += btn_Exits_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(912, 9);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "User : ";
            // 
            // btn_Xem
            // 
            btn_Xem.Location = new Point(854, 697);
            btn_Xem.Name = "btn_Xem";
            btn_Xem.Size = new Size(94, 46);
            btn_Xem.TabIndex = 11;
            btn_Xem.Text = "Xem";
            btn_Xem.UseVisualStyleBackColor = true;
            btn_Xem.Click += btn_Xem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(663, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(383, 186);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(266, 137);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 43);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã sản phẩm";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 0;
            // 
            // btnQLHoaDon
            // 
            btnQLHoaDon.Location = new Point(21, 54);
            btnQLHoaDon.Name = "btnQLHoaDon";
            btnQLHoaDon.Size = new Size(209, 54);
            btnQLHoaDon.TabIndex = 0;
            btnQLHoaDon.Text = "Quản lý Hóa Đơn";
            btnQLHoaDon.UseVisualStyleBackColor = true;
            btnQLHoaDon.Click += btnQLHoaDon_Click;
            // 
            // btnQLSanPham
            // 
            btnQLSanPham.Location = new Point(21, 133);
            btnQLSanPham.Name = "btnQLSanPham";
            btnQLSanPham.Size = new Size(209, 54);
            btnQLSanPham.TabIndex = 1;
            btnQLSanPham.Text = "Quản lý Sản Phẩm";
            btnQLSanPham.UseVisualStyleBackColor = true;
            btnQLSanPham.Click += btnQLSanPham_Click;
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
            // button1
            // 
            button1.Location = new Point(21, 297);
            button1.Name = "button1";
            button1.Size = new Size(209, 54);
            button1.TabIndex = 10;
            button1.Text = "Quản lý Đổi Trả";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnQLNhanVien
            // 
            btnQLNhanVien.Location = new Point(21, 393);
            btnQLNhanVien.Name = "btnQLNhanVien";
            btnQLNhanVien.Size = new Size(209, 54);
            btnQLNhanVien.TabIndex = 11;
            btnQLNhanVien.Text = "Quản lý Nhân Viên";
            btnQLNhanVien.UseVisualStyleBackColor = true;
            btnQLNhanVien.Click += btnQLNhanVien_Click;
            // 
            // QLDoiHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 755);
            Controls.Add(groupBox2);
            Controls.Add(btn_Xem);
            Controls.Add(label4);
            Controls.Add(btn_Exits);
            Controls.Add(groupBox3);
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
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DoiTra).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private Label btnDoiTra;
        private GroupBox gbMenu;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView dgv_DoiTra;
        private Button btn_Exits;
        private Label label4;
        private Button btn_Xem;
        private GroupBox groupBox2;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnQLNhanVien;
        private Button btnKhuyenMai;
        private Button btnQLSanPham;
        private Button btnQLHoaDon;
    }
}