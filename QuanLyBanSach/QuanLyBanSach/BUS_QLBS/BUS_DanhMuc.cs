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
    public class BUS_DanhMuc
    {
        DAL_DanhMuc dalDanhMuc = new DAL_DanhMuc();

        public DataTable getDanhMuc()
        {
            return dalDanhMuc.getDanhMuc();
        }

        public bool themDanhMuc(DTO_DanhMuc dm)
        {
            return dalDanhMuc.themDanhMuc(dm);
        }

        public bool suaDanhMuc(DTO_DanhMuc dm)
        {
            return dalDanhMuc.suaDanhMuc(dm);
        }

        public bool xoaDanhMuc(int madanhmuc)
        {
            return dalDanhMuc.xoaDanhMuc(madanhmuc);
        }
    }
}
