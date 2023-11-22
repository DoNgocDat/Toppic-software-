using BUS_QLBS;
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
    public partial class ThongTinChiTiet : Form
    {
        BUS_ChiTietSanPham busChiTietSanPham = new BUS_ChiTietSanPham();
        public ThongTinChiTiet()
        {
            InitializeComponent();
        }

        private void btnComBack_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn quay lại.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ThongTinChiTiet_Load(object sender, EventArgs e)
        {
            dtgDetailBook.DataSource = busChiTietSanPham.getChiTietSanPham();
        }
    }
}
