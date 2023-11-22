using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBS
{
    public class DTO_TaiKhoan
    {
        private string _TenTaiKhoan;
        private string _Email;
        private string _TenHienThi;
        private string _MatKhau;
        private string _LoaiTaiKhoan;

        public string TenTaiKhoan
        {
            get
            {
                return _TenTaiKhoan;
            }
            set
            {
                _TenTaiKhoan = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        public string TenHienThi
        {
            get
            {
                return _TenHienThi;
            }
            set
            {
                _TenHienThi = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }
            set
            {
                _MatKhau = value;
            }
        }
        public string LoaiTaiKhoan
        {
            get
            {
                return _LoaiTaiKhoan;
            }
            set
            {
                _LoaiTaiKhoan = value;
            }
        }

        public DTO_TaiKhoan()
        {

        }

        public DTO_TaiKhoan(string tendn, string email, string tenht, string mk, string loaitk)
        {
            this.TenTaiKhoan = tendn;
            this.Email = email;
            this.TenHienThi = tenht;
            this.MatKhau = mk;
            this.LoaiTaiKhoan = loaitk;
        }
    }
}
