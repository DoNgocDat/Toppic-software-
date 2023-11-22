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
    public partial class DoiMatKhau : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();

        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                this.Close();
            }
        }

        public static string username = string.Empty;
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txbOldPass.Text != "" && txbNewPass.Text != "" && txbRetypePass.Text != "")
            {
                if (txbNewPass.Text == txbRetypePass.Text)
                {
                    DTO_TaiKhoan tk = new DTO_TaiKhoan();
                    tk.TenTaiKhoan = username;
                    tk.MatKhau = txbNewPass.Text;
                    if (busTaiKhoan.doiMatKhau(tk))
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công.", "Thông báo");
                        txbOldPass.ResetText();
                        txbNewPass.ResetText();
                        txbRetypePass.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi mật khẩu không thành công.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu mới không đúng", "Thông báo");
                    txbRetypePass.ResetText();
                    txbRetypePass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui điền đầy đủ thông tin để thay đổi mật khẩu.", "Thông báo");
            }
        }
    }
}
