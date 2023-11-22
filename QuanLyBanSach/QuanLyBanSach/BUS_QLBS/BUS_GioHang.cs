using DAL_QLBS;
using DTO_QLBS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBS
{
    public class BUS_GioHang
    {
        DAL_GioHang dalGioHang = new DAL_GioHang();

        public DataTable getGioHang()
        {
            return dalGioHang.getGioHang();
        }

        public bool themVaoGioHang(DTO_GioHang gioHangItem)
        {
            return dalGioHang.themVaoGioHang(gioHangItem);
        }

        public bool xoaKhoiGioHang(int maGioHang)
        {
            return dalGioHang.xoaKhoiGioHang(maGioHang);
        }
    }
}
