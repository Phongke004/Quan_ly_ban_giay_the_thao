using DAL.IRepoistories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repoistories
{
    public class DoiTraReps : IDoiTraReps
    {
        QlbanGiayTheThaoContext _qlBanGiay;
        public DoiTraReps()
        {
            _qlBanGiay = new QlbanGiayTheThaoContext();
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
