using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBS
{
    internal class DTO_HoaDon
    {
        private int _MaHoaDon;
        private DateTime _NgayGiao;
        private string _TenKhachHang;
        private string _DiaChi;
        private string _SoDienThoai;

        public int MaHoaDon
        {
            get
            {
                return _MaHoaDon;
            }
            set
            {
                _MaHoaDon = value;
            }
        }

        public DateTime NgayGiao
        {
            get
            {
                return _NgayGiao;
            }
            set
            {
                _NgayGiao = value;
            }
        }
        public string TenKhachHang
        {
            get
            {
                return _TenKhachHang;
            }
            set
            {
                _TenKhachHang = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }
            set
            {
                _DiaChi = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return _SoDienThoai;
            }
            set
            {
                _SoDienThoai = value;
            }
        }

        public DTO_HoaDon()
        {

        }

        public DTO_HoaDon(int mahoadon, DateTime ngaygiao, string tenkh, string diachi, string sdt)
        {
            this.MaHoaDon = mahoadon;
            this.NgayGiao = ngaygiao;
            this.TenKhachHang = tenkh;
            this.DiaChi = diachi;
            this.SoDienThoai= sdt;
        }
    }

    
}
