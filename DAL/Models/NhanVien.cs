using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string TenNhanVien { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string GioiTinh { get; set; } = null!;

    public DateTime NgaySinh { get; set; }

    public string DiaChi { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public bool TrangThai { get; set; }

    public string? MaChucVu { get; set; }

    public string? MaCa { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual CaLamViec? MaCaNavigation { get; set; }

    public virtual ChucVu? MaChucVuNavigation { get; set; }

    public virtual ICollection<Thongke> Thongkes { get; set; } = new List<Thongke>();
}
