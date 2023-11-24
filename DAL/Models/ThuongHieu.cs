using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ThuongHieu
{
    public string MaTh { get; set; } = null!;

    public string TenThuongHieu { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
