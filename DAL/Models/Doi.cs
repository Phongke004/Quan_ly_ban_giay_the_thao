using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Doi
{
    public string MaDoi { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public DateTime NgayDoi { get; set; }

    public string LyDo { get; set; } = null!;

    public string DoiSangSp { get; set; } = null!;

    public string? MaHdct { get; set; }

    public virtual HoaDonChiTiet? MaHdctNavigation { get; set; }
}
