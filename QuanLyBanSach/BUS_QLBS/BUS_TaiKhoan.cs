using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBS;
using DTO_QLBS;

namespace BUS_QLBS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();

        public DataTable getTaiKhoan()
        {
            return dalTaiKhoan.getTaiKhoan();
        }

        public bool dangNhap(string tentaikhoan, string matkhau)
        {
            return dalTaiKhoan.dangNhap(tentaikhoan, matkhau);
        }

        public int getQuyen(string tentaikhoan)
        {
            return dalTaiKhoan.getQuyen(tentaikhoan);
        }

        public bool themTaiKhoan(DTO_TaiKhoan tk)
        {
            return dalTaiKhoan.themTaiKhoan(tk);
        }

        public bool suaTaiKhoan(DTO_TaiKhoan tk)
        {
            return dalTaiKhoan.suaTaiKhoan(tk);
        }

        public bool xoaTaiKhoan(string tentaikhoan)
        {
            return dalTaiKhoan.xoaTaiKhoan(tentaikhoan);
        }

        public bool doiMatKhau(DTO_TaiKhoan tk)
        {
            return dalTaiKhoan.doiMatKhau(tk);
        }

        public DataTable timTaiKhoan(string tentaikhoan)
        {
            return dalTaiKhoan.timTaiKhoan(tentaikhoan);
        }
    }
}
