using DAL.IRepoistories;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DomainClass;

namespace DAL.Repoistories
{
    public class DoiTraReps : IDoiTraReps
    {
        MyContext _qlBanGiay;
        public DoiTraReps()
        {
            _qlBanGiay = new MyContext();
        }
        public List<HoaDonChiTiet> GetHoaDonChiTiet()
        {
            return _qlBanGiay.HoaDonChiTiets.ToList();
        }

        public List<HoaDon> GetHoaDons(string find)
        {
            return _qlBanGiay.HoaDons.ToList();
        }
    }
}
