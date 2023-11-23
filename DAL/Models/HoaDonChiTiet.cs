using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDonChiTiet
{
    public string MaHdct { get; set; } = null!;

    public int SoLuong { get; set; }

    public double DonGia { get; set; }

    public string GhiChu { get; set; } = null!;

    public string? MaHd { get; set; }

    public virtual ICollection<Doi> Dois { get; set; } = new List<Doi>();

    public virtual HoaDon? MaHdNavigation { get; set; }

    public virtual ICollection<Tra> Tras { get; set; } = new List<Tra>();
}
