using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ChiTietSanPham
{
    public string Maspct { get; set; } = null!;

    public double Gia { get; set; }

    public int SoLuong { get; set; }

    public string? MaSp { get; set; }

    public string? MaMau { get; set; }

    public string? MaSize { get; set; }

    public string? MaChatLieu { get; set; }

    public string? MaTh { get; set; }

    public virtual ChatLieu? MaChatLieuNavigation { get; set; }

    public virtual MauSac? MaMauNavigation { get; set; }

    public virtual Size? MaSizeNavigation { get; set; }

    public virtual SanPham? MaSpNavigation { get; set; }

    public virtual ThuongHieu? MaThNavigation { get; set; }
}
