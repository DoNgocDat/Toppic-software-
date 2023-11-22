using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBS
{
    public class DTO_DanhMuc
    {
        private int _MaDanhMuc;
        private string _TenDanhMuc;

        public int MaDanhMuc
        {
            get
            {
                return _MaDanhMuc;
            }
            set
            {
                _MaDanhMuc = value;
            }
        }

        public string TenDanhMuc
        {
            get
            {
                return _TenDanhMuc;
            }
            set
            {
                _TenDanhMuc = value;
            }
        }

        public DTO_DanhMuc()
        {

        }

        public DTO_DanhMuc(int madm, string tendm)
        {
            this.MaDanhMuc = madm;
            this.TenDanhMuc = tendm;
        }
    }
}
