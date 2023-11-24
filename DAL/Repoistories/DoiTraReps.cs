using DAL.IRepoistories;

using DAL.Context;

using DAL.Models;

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

        QlbanGiayTheThaoContext _qlBanGiay;
        public DoiTraReps()
        {
            _qlBanGiay = new QlbanGiayTheThaoContext();
        }
        public List<HoaDonChiTiet> GetHoaDonChiTiet()
        {
          return _qlBanGiay.HoaDonChiTiets.ToList();    
        }

        public List<HoaDon> GetHoaDons()

        {
            return _qlBanGiay.HoaDons.ToList();
        }
    }
}
