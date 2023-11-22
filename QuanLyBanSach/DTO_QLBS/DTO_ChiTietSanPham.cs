using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBS
{
    public class DTO_ChiTietSanPham
    {
        private int _MaChiTietSanPham;
        private int _MaSach;
        private string _TenSach;
        private float _GiaSach;
        private string _TacGia;
        private string _MoTa;

        public int MaChiTietSanPham
        {
            get
            {
                return _MaChiTietSanPham;
            }
            set
            {
                _MaChiTietSanPham = value;
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

        public string TacGia
        {
            get
            {
                return _TacGia;
            }
            set
            {
                _TacGia = value;
            }
        }

        public string MoTa
        {
            get
            {
                return _MoTa;
            }
            set
            {
                _MoTa = value;
            }
        }

        public DTO_ChiTietSanPham()
        {

        }

        public DTO_ChiTietSanPham(int mctsp, int ms, string ts, float gs, string tg, string mt)
        {
            this.MaChiTietSanPham = mctsp;
            this.MaSach = ms;
            this.TenSach = ts;
            this.GiaSach = gs;
            this.MoTa = tg;
            this.MoTa = mt;
        }
    }
}
