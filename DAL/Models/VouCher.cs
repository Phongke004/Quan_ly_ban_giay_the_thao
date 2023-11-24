using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class VouCher
{
    public string MaVoucher { get; set; } = null!;

    public string TenVoucher { get; set; } = null!;

    public string MoTa { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public DateTime NgayBatDau { get; set; }

    public DateTime NgayKetThuc { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
