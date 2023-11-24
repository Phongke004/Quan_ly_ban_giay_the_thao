using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CaLamViec
{
    public string MaCa { get; set; } = null!;

    public DateTime ThoiGian { get; set; }

    public string TrangThai { get; set; } = null!;

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
