using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBS;

namespace QuanLyBanSach
{
    

    public partial class DangNhap : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangky = new DangKy();
            this.Hide();
            dangky.Show();
            
        }

        public static string TenDangNhap { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentaikhoan = txbUserName.Text;
            string matkhau = txbPass.Text;
            if (txbUserName.Text != "" && txbPass.Text != "")
            {
                if(busTaiKhoan.dangNhap(tentaikhoan, matkhau))
                {
                    TenDangNhap = tentaikhoan;
                    TrangChu.username = txbUserName.Text;
                    DoiMatKhau.username = txbUserName.Text;
                    TrangChu trangchu = new TrangChu();
                    trangchu.Hide();
                    this.Hide();
                    trangchu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    txbUserName.ResetText();
                    txbPass.ResetText();
                    txbUserName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo");
                txbUserName.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ckbDisplayPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbDisplayPass.Checked == true)
            {
                txbPass.UseSystemPasswordChar = false;
            }
            else
            {
                txbPass.UseSystemPasswordChar = true;
            }
        }
    }
}
