using BUS_QLBS;
using DTO_QLBS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class TrangChu : Form
    {
        BUS_Sach busSach = new BUS_Sach();
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        BUS_GioHang busGioHang = new BUS_GioHang();
        BUS_DonHang busDonHang = new BUS_DonHang();
        public TrangChu()
        {
            InitializeComponent();
        }

        private void menuitemLogOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn đăng xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuitemChangePass_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.Show();
        }

        private void menuAdmin_Click(object sender, EventArgs e)
        {
            QuanTri quanTri = new QuanTri();
            quanTri.Show();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
            if (dtgHome.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để thêm vào giỏ hàng.");
                return;
            }

            int maSach = Convert.ToInt32(dtgHome.SelectedRows[0].Cells["Mã Sách"].Value);
            int maDanhMuc = Convert.ToInt32(dtgHome.SelectedRows[0].Cells["Mã Danh Mục"].Value);
            string tenSach = dtgHome.SelectedRows[0].Cells["Tên Sách"].Value.ToString();
            float giaSach = Convert.ToSingle(dtgHome.SelectedRows[0].Cells["Giá Sách"].Value);
            string tacGia = dtgHome.SelectedRows[0].Cells["Tác Giả"].Value.ToString();
            DateTime ngayXuatBan = Convert.ToDateTime(dtgHome.SelectedRows[0].Cells["Ngày Xuất Bản"].Value);

            DTO_GioHang gioHangItem = new DTO_GioHang
            {
                MaSach = maSach,
                MaDanhMuc = maDanhMuc,
                TenSach = tenSach,
                GiaSach = giaSach,
                TacGia = tacGia,
                NgayXuatBan = ngayXuatBan
            };

            if (busGioHang.themVaoGioHang(gioHangItem))
            {
                MessageBox.Show("Thêm vào giỏ hàng thành công.");

                dtgCart.DataSource = busGioHang.getGioHang();

            }
            else
            {
                MessageBox.Show("Thêm vào giỏ hàng thất bại.");
            }
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
            if (dtgHome.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để thêm vào giỏ hàng.");
                return;
            }

            int maSach = Convert.ToInt32(dtgHome.SelectedRows[0].Cells["Mã Sách"].Value);
            int maDanhMuc = Convert.ToInt32(dtgHome.SelectedRows[0].Cells["Mã Danh Mục"].Value);
            string tenSach = dtgHome.SelectedRows[0].Cells["Tên Sách"].Value.ToString();
            float giaSach = Convert.ToSingle(dtgHome.SelectedRows[0].Cells["Giá Sách"].Value);
            string tacGia = dtgHome.SelectedRows[0].Cells["Tác Giả"].Value.ToString();
            DateTime ngayXuatBan = Convert.ToDateTime(dtgHome.SelectedRows[0].Cells["Ngày Xuất Bản"].Value);

            DTO_GioHang gioHangItem = new DTO_GioHang
            {
                MaSach = maSach,
                MaDanhMuc = maDanhMuc,
                TenSach = tenSach,
                GiaSach = giaSach,
                TacGia = tacGia,
                NgayXuatBan = ngayXuatBan
            };

            if (busGioHang.themVaoGioHang(gioHangItem))
            {
                MessageBox.Show("Thêm vào giỏ hàng thành công.");

                dtgCart.DataSource = busGioHang.getGioHang();
                tabBill.SelectedTab = tabPage2;
            }
            else
            {
                MessageBox.Show("Thêm vào giỏ hàng thất bại.");
            }
        }

        private int quyen;

        private void TrangChu_Load(object sender, EventArgs e)
        {
            dtgHome.DataSource = busSach.getSach();
            dtgOder.DataSource = busDonHang.getDonHang();
            dtgCart.DataSource = busGioHang.getGioHang();
            quyen = busTaiKhoan.getQuyen(DangNhap.TenDangNhap);
            quyen = busTaiKhoan.getQuyen(DangNhap.TenDangNhap);
            if (quyen == 0)
            {
                menuAdmin.Enabled = false;
            }
        }

        public static string username = string.Empty;
        
        private void btnLoginHome_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
            if(!string.IsNullOrEmpty(username))
            {
                this.btnLoginHome.Text = username;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dtgCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để thêm vào giỏ hàng.");
            }
            int maSach = Convert.ToInt32(dtgCart.SelectedRows[0].Cells["Mã Sách"].Value);
            string tenSach = dtgCart.SelectedRows[0].Cells["Tên Sách"].Value.ToString();
            float giaSach = Convert.ToSingle(dtgCart.SelectedRows[0].Cells["Giá Sách"].Value);
            ThongTinKhachHang thongtinkhachhang = new ThongTinKhachHang();
            thongtinkhachhang.Show();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (dtgOder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng mà bạn muốn hủy.");
                return;
            }
            if (dtgOder.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgOder.SelectedRows[0];
                string tinhTrang = row.Cells["Tình Trạng"].Value.ToString();

                if (tinhTrang == "Chờ Thanh Toán")
                {
                    int xdh = Convert.ToInt16(row.Cells[0].Value.ToString());
                    if (busDonHang.xoaKhoiDonHang(xdh))
                    {
                        MessageBox.Show("Hủy đơn thành công.", "Thông báo");
                        dtgOder.DataSource = busDonHang.getDonHang();
                    }
                    else
                    {
                        MessageBox.Show("Hủy đơn không thành công.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể hủy đơn vì đơn của bạn đã vận chuyển", "Thông báo");
                }
            }
        }
    }
}
