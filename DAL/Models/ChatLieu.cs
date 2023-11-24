﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ChatLieu
{
    public string MaChatLieu { get; set; } = null!;

    public string LoaiChatLieu { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
