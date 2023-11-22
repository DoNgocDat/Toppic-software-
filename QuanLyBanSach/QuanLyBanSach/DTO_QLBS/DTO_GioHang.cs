using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBS
{
    public class DTO_GioHang
    {
        private int _MaGioHang;
        private int _MaSach;
        private int _MaDanhMuc;
        private string _TenSach;
        private float _GiaSach;
        private string _TacGia;
        private DateTime _NgayXuatBan;

        public int MaGioHang
        {
            get
            {
                return _MaGioHang;
            }
            set
            {
                _MaGioHang = value;
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

        public DateTime NgayXuatBan
        {
            get
            {
                return _NgayXuatBan;
            }
            set
            {
                _NgayXuatBan = value;
            }
        }

        public DTO_GioHang()
        {

        }

        public DTO_GioHang(int magh, int mas, int madm, string tens, float gias, string tacgia, DateTime nxb)
        {
            this.MaGioHang = magh;
            this.MaSach = mas;
            this.MaDanhMuc = madm;
            this.TenSach = tens;
            this.GiaSach = gias;
            this.TacGia = tacgia;
            this.NgayXuatBan = nxb;
        }
    }
}
