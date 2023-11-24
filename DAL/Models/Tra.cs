using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Tra
{
    public string MaTra { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public DateTime NgayDoi { get; set; }

    public string LyDo { get; set; } = null!;

    public string? MaHdct { get; set; }

    public virtual HoaDonChiTiet? MaHdctNavigation { get; set; }
}
