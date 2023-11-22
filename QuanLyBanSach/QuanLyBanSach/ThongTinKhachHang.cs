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
            try
            {
                int maSach = this.maSach;
                string tenKhachHang = txbNameClient.Text;
                string diaChi = txbAddress.Text;
                int soDienThoai = int.Parse(txbPhoneNumber.Text);
                string tenSach = this.tenSach;
                float giaSach = this.giaSach;

                DTO_DonHang donHangItem = new DTO_DonHang(0, maSach, tenKhachHang, diaChi, soDienThoai, tenSach, giaSach, DateTime.Now, "Chờ Thanh Toán");
                BUS_DonHang busDonHang = new BUS_DonHang();

                bool themDonHang = busDonHang.themVaoDonHang(donHangItem);

                if (themDonHang)
                {

                    TrangChu trangchu = new TrangChu();
                    trangchu.Show();
                    MessageBox.Show("Đặt hàng thành công.");

            
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đặt hàng không thành công. Vui lòng thử lại hoặc liên hệ hỗ trợ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

    }
}
