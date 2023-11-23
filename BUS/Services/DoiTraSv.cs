using BUS.IServiecs;
using DAL.Models;
using DAL.Repoistories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS.Services
{
    public class DoiTraSv : IDoiTraSv
    {
        DoiTraReps _doiTraReps;
        public DoiTraSv()
        {
            _doiTraReps = new DoiTraReps();
        }
        public List<HoaDonChiTiet> GetHoaDonChiTiet()
        {
           return _doiTraReps.GetHoaDonChiTiet();
        }

        public List<HoaDon> GetHoaDons(string find)
        {
         return _doiTraReps.GetHoaDons(find);
        }
    }
}
