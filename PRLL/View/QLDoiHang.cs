using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class QLDoiHang : Form
    {
        DoiTraSv _doiTraServiec;
        string userName;
        public QLDoiHang(string userName)
        {
            this.userName = userName;
            InitializeComponent();
            _doiTraServiec = new DoiTraSv();
            LoadDaTa();
        }
        public void LoadDaTa()
        {
            dgv_DoiTra.Rows.Clear();
            int stt = 1;
            dgv_DoiTra.ColumnCount = 8;
            dgv_DoiTra.Columns[0].Name = "STT";
            dgv_DoiTra.Columns[1].Name = "Mã Hóa Đơn";
            dgv_DoiTra.Columns[2].Name = "Mã Sản Phẩm";
            dgv_DoiTra.Columns[3].Name = "Mã Nhân Viên";
            dgv_DoiTra.Columns[4].Name = "Ngày tạo";
            dgv_DoiTra.Columns[5].Name = "Đơn giá";
            dgv_DoiTra.Columns[6].Name = "Số lượng";
            dgv_DoiTra.Columns[7].Name = "Ghi chú";
            foreach (var item in _doiTraServiec.GetHoaDons())
            {
                var query = _doiTraServiec.GetHoaDonChiTiet().FirstOrDefault(x => x.MaHd == item.MaHd);
                dgv_DoiTra.Rows.Add(stt++, item.MaHd, item.MaSp, item.MaNv, item.NgayTao, query.DonGia, query.SoLuong, query.GhiChu);
            }
        }

        private void QLDoiHang_Load(object sender, EventArgs e)
        {
            label4.Text = "User : " + userName;
        }
    }
}