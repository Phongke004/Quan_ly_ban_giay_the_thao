
﻿using DAL.Context;
using DAL.DomainClass;

﻿using DAL.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepoistories
{
    internal interface IHoaDonReps
    {
        public List<HoaDon> GetHoaDons();
        public List<HoaDonChiTiet> GetHoaDonChiTiet();
    }
}
