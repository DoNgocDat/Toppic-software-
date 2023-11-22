using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBS;
using DTO_QLBS;

namespace BUS_QLBS
{
    public class BUS_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon dalChiTietHoaDon = new DAL_ChiTietHoaDon();

        public DataTable getChiTietHoaDon()
        {
            return dalChiTietHoaDon.getChiTietHoaDon();
        }
    }
}
