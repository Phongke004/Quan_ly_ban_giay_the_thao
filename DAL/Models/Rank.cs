using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Rank
{
    public string RankId { get; set; } = null!;

    public string DieuKien { get; set; } = null!;

    public string MucUuDai { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public string MoTa { get; set; } = null!;

    public string? MaKh { get; set; }

    public virtual KhachHang? MaKhNavigation { get; set; }
}
