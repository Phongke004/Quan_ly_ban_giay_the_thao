using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Context;
using DAL.DomainClass;


using DAL.Models;

namespace BUS.IServiecs
{
    public interface IDoiTraSv
    {
        public List<HoaDon> GetHoaDons(string find);
        public List<HoaDonChiTiet> GetHoaDonChiTiet();
    }
}
