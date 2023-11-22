using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBS
{
    internal class DTO_ChiTietHoaDon
    {
        private int _MaChiTiet;
        private int _MaHoaDon;
        private int _MaSach;
        private int _SoLuong;
        private float _GiaSach;
        private float _ThanhTien;

        public int MaChiTiet
        {
            get
            {
                return _MaChiTiet;
            }
            set
            {
                _MaChiTiet = value;
            }
        }

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

        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }
            set
            {
                _SoLuong = value;
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

        public float ThanhTien
        {
            get
            {
                return _ThanhTien;
            }
            set
            {
                _ThanhTien = value;
            }
        }

        public DTO_ChiTietHoaDon()
        {

        }

        public DTO_ChiTietHoaDon(int mact, int mahd, int masach, int sl, float giasach, float thanhtien)
        {
            this.MaChiTiet = mact;
            this.MaHoaDon = mahd;
            this.MaSach = masach;
            this.SoLuong = sl;
            this.GiaSach = giasach;
            this.ThanhTien = thanhtien;
        }
    }
}
