using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBS
{
    public class DTO_Sach
    {
        private int _MaSach;
        private int _MaDanhMuc;
        private string _TenSach;
        private float _GiaSach;
        private string _TacGia;
        private DateTime _NgayXuatBan;

        public int MaSach
        {
            get 
            {
                return _MaSach; 
            }
            set { 
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

        public string  TacGia
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

        public DTO_Sach()
        {

        }

        public DTO_Sach(int masach, int madanhmuc, string tensach, float giasach, string tacgia, DateTime ngayxb)
        {
            this.MaSach = masach;
            this.MaDanhMuc = madanhmuc;
            this.TenSach = tensach;
            this.GiaSach = giasach;
            this.TacGia = tacgia;
            this.NgayXuatBan = ngayxb;
        }
    }
}
