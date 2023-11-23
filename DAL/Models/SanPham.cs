using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPham
{
    public string MaSp { get; set; } = null!;

    public string TenSanPham { get; set; } = null!;

    public DateTime NgayNhap { get; set; }

    public int SoLuong { get; set; }

    public string TrangThai { get; set; } = null!;

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
