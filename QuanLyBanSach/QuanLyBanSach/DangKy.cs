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
    public partial class DangKy : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txbEmail.Text != "" && txbUserName.Text != "" && txbDisplayName.Text != "" && txbPass.Text != "" && txbChangePass.Text != "")
            {
                if (txbPass.Text == txbChangePass.Text)
                {
                    string ltk = "0";
                    DTO_TaiKhoan tk = new DTO_TaiKhoan(txbUserName.Text, txbEmail.Text, txbDisplayName.Text, txbPass.Text, ltk);
                    if (busTaiKhoan.themTaiKhoan(tk))
                    {
                        MessageBox.Show("Đăng ký thành công.", "Thông báo.");
                        DangNhap dangnhap = new DangNhap();
                        this.Hide();
                        dangnhap.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký không thành công.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không chính xát.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để đăng ký", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                DangNhap dangnhap = new DangNhap();
                dangnhap.Show();
            }
        }
    }
}
