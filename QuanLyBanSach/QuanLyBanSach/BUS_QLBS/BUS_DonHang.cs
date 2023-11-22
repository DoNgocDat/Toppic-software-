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
    public class BUS_DonHang
    {
        DAL_DonHang dalDonHang = new DAL_DonHang();

        public DataTable getDonHang()
        {
            return dalDonHang.getDonHang();
        }
        public bool themVaoDonHang(DTO_DonHang donHangItem)
        {
            return dalDonHang.themVaoDonHang(donHangItem);
        }
        public bool xoaKhoiDonHang(int maDonHang)
        {
            return dalDonHang.xoaKhoiDonHang(maDonHang);
        }
        public bool suaDonHang(DTO_DonHang donHangItem)
        {
            return dalDonHang.suaDonHang(donHangItem);
        }
    }
}
