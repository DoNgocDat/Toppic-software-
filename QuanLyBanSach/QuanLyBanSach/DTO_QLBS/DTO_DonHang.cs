using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBS
{
    public class DTO_DonHang
    {
        private int _MaDonHang;
        private int _MaSach;
        private string _TenKhachHang;
        private string _DiaChi;
        private int _SoDienThoai;
        private string _TenSach;
        private float _GiaSach;
        private DateTime _NgayMua;
        private string _TinhTrang;

        public int MaDonHang
        {
            get 
            { 
                return _MaDonHang;
            }
            set
            {
                _MaDonHang = value;
            }
        }

        public int MaSach
        {
            get
            {
                return _MaSach;
            }
            set
            {
                _MaSach = value;
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

        public int SoDienThoai
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

        public string TenSach
        {
            get
            {
                return _TenSach;
            }
            set
            {
                _TenSach = value;
            }
        }

        public float GiaSach
        {
            get
            {
                return _GiaSach;
            }
            set
            {
                _GiaSach = value;
            }
        }

        public DateTime NgayMua
        {
            get
            {
                return _NgayMua;
            }
            set
            {
                _NgayMua = value;
            }
        }

        public string TinhTrang
        {
            get
            {
                return _TinhTrang;
            }
            set
            {
                _TinhTrang = value;
            }
        }

        public DTO_DonHang()
        {

        }

        public DTO_DonHang(int madh, int mas, string tenkh, string diachi, int sdt, string ts, float gs, DateTime nm, string tt)
        {
            this.MaDonHang = madh;
            this.MaSach = mas;
            this.TenKhachHang = tenkh;
            this.DiaChi = diachi;
            this.SoDienThoai = sdt;
            this.TenSach = ts;
            this.GiaSach = gs;
            this.NgayMua = nm;
            this.TinhTrang = tt;
        }
    }
}
