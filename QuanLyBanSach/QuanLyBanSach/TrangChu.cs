
using BUS_QLBS;
using DTO_QLBS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
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
            if (MessageBox.Show("Bạn thật sự muốn đăng xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isLoggedIn = false;
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
            QuanTri quantri = new QuanTri();
            quantri.Show();
        }
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn cần đăng nhập trước khi thêm vào giỏ hàng.");
                return;
            }
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
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn cần đăng nhập trước khi mua hàng.");
                return;
            }
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
        private bool isLoggedIn = false;

        private void btnLoginHome_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.ShowDialog();
            if (!string.IsNullOrEmpty(username))
            {
                this.btnLoginHome.Text = username;
                isLoggedIn = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn cần đăng nhập trước khi thanh toán.");
                return;
            }
            if (dtgCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để thêm vào giỏ hàng.");
                return;
            }

     
            int maSach = Convert.ToInt32(dtgCart.SelectedRows[0].Cells["Mã Sách"].Value);
            string tenSach = dtgCart.SelectedRows[0].Cells["Tên Sách"].Value.ToString();
            float giaSach = Convert.ToSingle(dtgCart.SelectedRows[0].Cells["Giá Sách"].Value);

            ThongTinKhachHang thongtinkhachhang = new ThongTinKhachHang(maSach, tenSach, giaSach);
            thongtinkhachhang.Show();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn cần đăng nhập trước khi hủy đơn hàng.");
                return;
            }
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

        private void dtgCart_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgCart.Rows[e.RowIndex];
                txbMoney.Text = row.Cells[4].Value.ToString();

            }
            catch (Exception)
            {


            }
        }

        private void dtgOder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgOder.Rows[e.RowIndex];
                txbNameBill.Text = row.Cells[2].Value.ToString();
                txbStatus.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnSearchHome_Click(object sender, EventArgs e)
        {
            if (txbSearchHome.Text != "")
            {
                if (busSach.timSach(txbSearchHome.Text) != null)
                {
                    dtgHome.DataSource = busSach.timSach(txbSearchHome.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập phòng cần tìm kiếm.", "Thông báo");
            }
        }

        private void btnSearchCart_Click(object sender, EventArgs e)
        {
            if (txbSearchCart.Text != "")
            {
                if (busGioHang.timGioHang(txbSearchCart.Text) != null)
                {
                    dtgCart.DataSource = busGioHang.timGioHang(txbSearchCart.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập phòng cần tìm kiếm.", "Thông báo");
            }
        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            if (txbSearchBill.Text != "")
            {
                if (busDonHang.timDonHang(txbSearchBill.Text) != null)
                {
                    dtgOder.DataSource = busDonHang.timDonHang(txbSearchBill.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập phòng cần tìm kiếm.", "Thông báo");
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            ThongTinChiTiet thongtinchitiet = new ThongTinChiTiet();
            thongtinchitiet.Show();
        }
    }
}
