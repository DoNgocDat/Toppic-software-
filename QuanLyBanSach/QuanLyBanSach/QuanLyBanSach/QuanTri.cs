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
    public partial class QuanTri : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        BUS_DanhMuc busDanhMuc = new BUS_DanhMuc();
        BUS_Sach busSach = new BUS_Sach();
        BUS_ChiTietHoaDon busChiTietHoaDon = new BUS_ChiTietHoaDon();
        public QuanTri()
        {
            InitializeComponent();
        }

        private void QuanTri_Load(object sender, EventArgs e)
        {
            dtgAccount.DataSource = busTaiKhoan.getTaiKhoan();
            dtgCategory.DataSource = busDanhMuc.getDanhMuc();
            dtgProduct.DataSource = busSach.getSach();
            dtgStatistical.DataSource = busChiTietHoaDon.getChiTietHoaDon();
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {
            if (txbNameAccount.Text != "" && txbEmail.Text != "" && txbDisplayName.Text != "" && txbPass.Text != "" && txbTypeAccount.Text != "")
            {
                DTO_TaiKhoan tk = new DTO_TaiKhoan(txbNameAccount.Text, txbEmail.Text, txbDisplayName.Text, txbPass.Text, txbTypeAccount.Text);
                if (busTaiKhoan.themTaiKhoan(tk))
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo.");
                    dtgAccount.DataSource = busTaiKhoan.getTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để thêm", "Thông báo");
            }
        }

        private void btnFixAccount_Click(object sender, EventArgs e)
        {
            if(dtgAccount.SelectedRows.Count > 0)
            {
                if(txbNameAccount.Text != "" && txbEmail.Text != "" && txbDisplayName.Text != "" && txbPass.Text != "" && txbTypeAccount.Text != "")
                {
                    int i = dtgAccount.CurrentCell.RowIndex;
                    string ttk = dtgAccount.Rows[i].Cells[0].Value.ToString();
                    DTO_TaiKhoan tk = new DTO_TaiKhoan(ttk, txbEmail.Text, txbDisplayName.Text, txbPass.Text, txbTypeAccount.Text);
                    if (busTaiKhoan.suaTaiKhoan(tk))
                    {
                        MessageBox.Show("Sửa thành công.", "Thông báo.");
                        dtgAccount.DataSource = busTaiKhoan.getTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần sửa", "Thông báo");
                }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dtgAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgAccount.SelectedRows[0];
                string ttk = row.Cells[0].Value.ToString();
                if (busTaiKhoan.xoaTaiKhoan(ttk))
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    dtgAccount.DataSource = busTaiKhoan.getTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản muốn xóa.", "Thông báo");
            }
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            txbNameAccount.ResetText();
            txbEmail.ResetText();
            txbDisplayName.ResetText();
            txbPass.ResetText();
            txbTypeAccount.ResetText();
        }

        private void dtgAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgAccount.CurrentCell.RowIndex;
            txbNameAccount.Text = dtgAccount.Rows[i].Cells[0].Value.ToString();
            txbEmail.Text = dtgAccount.Rows[i].Cells[1].Value.ToString();
            txbDisplayName.Text = dtgAccount.Rows[i].Cells[2].Value.ToString();
            txbPass.Text = dtgAccount.Rows[i].Cells[3].Value.ToString();
            txbTypeAccount.Text = dtgAccount.Rows[i].Cells[4].Value.ToString();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txbNameCategory.Text != "")
            {
                DTO_DanhMuc dm = new DTO_DanhMuc(0, txbNameCategory.Text);
                if (busDanhMuc.themDanhMuc(dm))
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo");
                    dtgCategory.DataSource = busDanhMuc.getDanhMuc();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo");
            }
        }

        private void btnFixCategory_Click(object sender, EventArgs e)
        {
            if (dtgCategory.Rows.Count > 0)
            {
                if (txbNameCategory.Text != "")
                {
                    int i = dtgCategory.CurrentCell.RowIndex;
                    int mdm = Convert.ToInt16(dtgCategory.Rows[i].Cells[0].Value.ToString());
                    DTO_DanhMuc dm = new DTO_DanhMuc(mdm, txbNameCategory.Text);
                    if (busDanhMuc.suaDanhMuc(dm))
                    {
                        MessageBox.Show("Sửa thành công.", "Thông báo");
                        dtgCategory.DataSource = busDanhMuc.getDanhMuc();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn danh mục muốn sửa.", "Thông báo");
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dtgCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgCategory.SelectedRows[0];
                int mdm = Convert.ToInt16(row.Cells[0].Value.ToString());
                if (busDanhMuc.xoaDanhMuc(mdm))
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    dtgCategory.DataSource = busDanhMuc.getDanhMuc();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục muốn xóa.", "Thông báo");
            }
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            txbIdCategory.ResetText();
            txbNameCategory.ResetText();
        }

        private void dtgCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgCategory.CurrentCell.RowIndex;
            txbIdCategory.Text = dtgCategory.Rows[i].Cells[0].Value.ToString();
            txbNameCategory.Text = dtgCategory.Rows[i].Cells[1].Value.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (numIdCategory.Text != "" && txbNameProduct.Text != "" && numPriceProduct.Text != "" && txbAuthor.Text != "" && dtpDatePublication.Text != "")
            {
                DTO_Sach s = new DTO_Sach(0, (int)numIdCategory.Value, txbNameProduct.Text, (float)numPriceProduct.Value, txbAuthor.Text, dtpDatePublication.Value);
                if (busSach.themSach(s))
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo.");
                    dtgProduct.DataSource = busSach.getSach();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để thêm", "Thông báo");
            }
        }

        private void btnFixProduct_Click(object sender, EventArgs e)
        {
            if (dtgProduct.Rows.Count > 0)
            {
                if (numIdCategory.Text != "" && txbNameProduct.Text != "" && numPriceProduct.Text != "" && txbAuthor.Text != "" && dtpDatePublication.Text != "")
                {
                    int i = dtgProduct.CurrentCell.RowIndex;
                    int ms = Convert.ToInt16(dtgProduct.Rows[i].Cells[0].Value.ToString());
                    DTO_Sach s = new DTO_Sach(ms, (int)numIdCategory.Value, txbNameProduct.Text, (float)numPriceProduct.Value, txbAuthor.Text, dtpDatePublication.Value);
                    if (busSach.suaSach(s))
                    {
                        MessageBox.Show("Sửa thành công.", "Thông báo");
                        dtgProduct.DataSource = busSach.getSach();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn danh mục muốn sửa.", "Thông báo");
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dtgProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgProduct.SelectedRows[0];
                int ms = Convert.ToInt16(row.Cells[0].Value.ToString());
                if (busSach.xoaSach(ms))
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    dtgProduct.DataSource = busSach.getSach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh mục muốn xóa.", "Thông báo");
            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            txbIdProduct.ResetText();
            numIdCategory.ResetText();
            txbNameProduct.ResetText();
            numPriceProduct.ResetText();
            txbAuthor.ResetText();
            dtpDatePublication.ResetText();
        }

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgProduct.CurrentCell.RowIndex;
            txbIdProduct.Text = dtgProduct.Rows[i].Cells[0].Value.ToString();
            numIdCategory.Value = Convert.ToInt16(dtgProduct.Rows[i].Cells[1].Value);
            txbNameProduct.Text = dtgProduct.Rows[i].Cells[2].Value.ToString();
            numPriceProduct.Value = Convert.ToDecimal(dtgProduct.Rows[i].Cells[3].Value);
            txbAuthor.Text = dtgProduct.Rows[i].Cells[4].Value.ToString();
            dtpDatePublication.Text = dtgProduct.Rows[i].Cells[5].Value.ToString();
        }

       

    }
}
