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
    public class BUS_Sach
    {
        DAL_Sach dalSach = new DAL_Sach();

        public DataTable getSach()
        {
            return dalSach.getSach();
        }

        public bool themSach(DTO_Sach s)
        {
            return dalSach.themSach(s);
        }

        public bool suaSach(DTO_Sach s)
        {
            return dalSach.suaSach(s);
        }

        public bool xoaSach(int masach)
        {
            return dalSach.xoaSach(masach);
        }
    }
}
