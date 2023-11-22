using BUS_QLBS;
using DTO_QLBS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class ThongTinKhachHang : Form
    {      
        BUS_DonHang busDonHang = new BUS_DonHang();
        BUS_GioHang busGioHang = new BUS_GioHang();
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

 
        private int maSach;
        private string tenSach;
        private float giaSach;


        public ThongTinKhachHang(int maSach, string tenSach, float giaSach)
        {
            InitializeComponent();
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.giaSach = giaSach;
        }

        private void btnOderGood_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txbNameClient.Text;
            string diaChi = txbAddress.Text;
            int soDienThoai = int.Parse(txbPhoneNumber.Text);


            int maSach = this.maSach;
            string tenSach = this.tenSach;
            float giaSach = this.giaSach;


            DTO_DonHang donHangItem = new DTO_DonHang(0, maSach, tenKhachHang, diaChi, soDienThoai, tenSach, giaSach, DateTime.Now, "Chờ Thanh Toán");
            BUS_DonHang busDonHang = new BUS_DonHang();

            bool themKetQua = busDonHang.themVaoDonHang(donHangItem);

            if (themKetQua)
            {
                MessageBox.Show("Đặt hàng thành công.");

                TrangChu trangchu = new TrangChu();
                trangchu.Show();
            }
            else
            {

                MessageBox.Show("Đặt hàng không thành công. Vui lòng thử lại hoặc liên hệ hỗ trợ.");
            }
        }
    }
}
