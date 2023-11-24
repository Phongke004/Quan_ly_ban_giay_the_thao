using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDon
{
    public string MaHd { get; set; } = null!;

    public DateTime NgayTao { get; set; }

    public string TrangThai { get; set; }

    public double TongTien { get; set; }

    public double TongTienSauVoucher { get; set; }

    public string? MaSp { get; set; }

    public string? MaVoucher { get; set; }

    public string? MaNv { get; set; }

    public string? MaKh { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual NhanVien? MaNvNavigation { get; set; }

    public virtual SanPham? MaSpNavigation { get; set; }

    public virtual VouCher? MaVoucherNavigation { get; set; }

    public virtual ICollection<Thongke> Thongkes { get; set; } = new List<Thongke>();
}
