using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Size
{
    public string MaSize { get; set; } = null!;

    public string KichThuoc { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
