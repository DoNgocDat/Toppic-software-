using DAL_QLBS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBS
{
    public class BUS_ChiTietSanPham
    {
        DAL_ChiTietSanPham dalChiTietSanPham = new DAL_ChiTietSanPham();

        public DataTable getChiTietSanPham()
        {
            return dalChiTietSanPham.getChiTietSanPham();
        }
    }
}
