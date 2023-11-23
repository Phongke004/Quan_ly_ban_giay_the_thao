using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Thongke
{
    public string MaThongKe { get; set; } = null!;

    public DateTime NgayThongKe { get; set; }

    public string TongDoanhThu { get; set; } = null!;

    public int SoLuong { get; set; }

    public string? MaHd { get; set; }

    public string? MaNv { get; set; }

    public virtual HoaDon? MaHdNavigation { get; set; }

    public virtual NhanVien? MaNvNavigation { get; set; }
}
