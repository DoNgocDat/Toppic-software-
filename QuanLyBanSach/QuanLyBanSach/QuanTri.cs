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
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
namespace QuanLyBanSach
{
    public partial class QuanTri : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        BUS_DanhMuc busDanhMuc = new BUS_DanhMuc();
        BUS_Sach busSach = new BUS_Sach();
        BUS_ChiTietHoaDon busChiTietHoaDon = new BUS_ChiTietHoaDon();
        BUS_DonHang busDonHang = new BUS_DonHang();
        public QuanTri()
        {
            InitializeComponent();
        }

        private void QuanTri_Load(object sender, EventArgs e)
        {
            dtgAccount.DataSource = busTaiKhoan.getTaiKhoan();
            dtgCategory.DataSource = busDanhMuc.getDanhMuc();
            dtgProduct.DataSource = busSach.getSach();
            dtgStatistical.DataSource = busDonHang.getDonHang();
            dtgOder.DataSource = busDonHang.getDonHang();
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


        private void btnDeleteOder_Click(object sender, EventArgs e)
        {

            if (dtgOder.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgOder.SelectedRows[0];
                int mdh = Convert.ToInt16(row.Cells[0].Value.ToString());
                if (busDonHang.xoaKhoiDonHang(mdh))
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo");
                    dtgOder.DataSource = busDonHang.getDonHang();
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

        private void btnFixOder_Click(object sender, EventArgs e)
        {
            if (dtgOder.Rows.Count > 0)
            {
                if (txbCodeProduct2.Text != "" && txbNameP.Text != "" && txbAdress.Text != "" && txbPhone.Text != "" && txbNameProduct2.Text != "" && numPriceProduct2.Text != "" && dtpDateOder.Text != "" && txbStatus.Text != "")
                {
                    int i = dtgOder.CurrentCell.RowIndex;
                    int maDonHang = Convert.ToInt32(dtgOder.Rows[i].Cells[0].Value.ToString());
                    DTO_DonHang donhangItem = new DTO_DonHang
                    (maDonHang, int.Parse(txbCodeProduct2.Text), txbNameP.Text, txbAdress.Text, int.Parse(txbPhone.Text), txbNameProduct2.Text, float.Parse(numPriceProduct2.Text), dtpDateOder.Value, txbStatus.Text);
                    if (busDonHang.suaDonHang(donhangItem))
                    {
                        MessageBox.Show("Sửa thành công.", "Thông báo");
                        dtgOder.DataSource = busDonHang.getDonHang();
                        dtgOder.Refresh();
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

        private void btnNewOder_Click(object sender, EventArgs e)
        {
            txbCodeOder.ResetText();
            txbNameP.ResetText();
            txbAdress.ResetText();
            txbPhone.ResetText();
            txbCodeProduct2.ResetText();
            txbNameProduct2.ResetText();
            numPriceProduct2.ResetText();
            dtpDateOder.ResetText();
            txbStatus.ResetText();
        }

        private void dtgOder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dtgOder.CurrentCell.RowIndex;
            txbCodeOder.Text = dtgOder.Rows[i].Cells[0].Value.ToString();
            txbCodeProduct2.Text = dtgOder.Rows[i].Cells[1].Value.ToString();
            txbNameP.Text = dtgOder.Rows[i].Cells[2].Value.ToString();
            txbAdress.Text = dtgOder.Rows[i].Cells[3].Value.ToString();
            txbPhone.Text = dtgOder.Rows[i].Cells[4].Value.ToString();
            txbNameProduct2.Text = dtgOder.Rows[i].Cells[5].Value.ToString();
            numPriceProduct2.Value = Convert.ToDecimal(dtgOder.Rows[i].Cells[6].Value);
            dtpDateOder.Text = dtgOder.Rows[i].Cells[7].Value.ToString();
            txbStatus.Text = dtgOder.Rows[i].Cells[8].Value.ToString();
        }

        private void ExportExcel(string Path)
        {
            Excel.Application application = new Excel.Application();
            application.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)application.ActiveSheet;

            string[] columnHeaders = { "Mã Đơn Hàng  ", "Mã Sách", "Tên Khách Hàng ", "Địa Chỉ ", "Ngày Mua", "Tên Sách", "Giá Sách", "Ngày Mua ", "Tình Trạng" };
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                worksheet.Cells[1, i + 1] = columnHeaders[i];
            }
            for (int i = 0; i < dtgOder.Rows.Count; i++)
            {
                for (int j = 0; j < columnHeaders.Length; j++)
                {
                    object cellValue = dtgOder.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j + 1] = cellValue;
                }
            }
            worksheet.UsedRange.Columns.AutoFit();
            application.ActiveWorkbook.SaveAs(Path);
            application.ActiveWorkbook.Saved = true;
            application.Quit();
           
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DateTime tungay = dtpSince.Value;
            DateTime denngay = dtpToDate.Value;
            dtgStatistical.DataSource = busDonHang.xemThongKe(tungay, denngay);
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            if (txbSearchAccount.Text != "")
            {
                if (busTaiKhoan.timTaiKhoan(txbSearchAccount.Text) != null)
                {
                    dtgAccount.DataSource = busTaiKhoan.timTaiKhoan(txbSearchAccount.Text);
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

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            if (txbSearchCategory.Text != "")
            {
                if (busDanhMuc.timDanhMuc(txbSearchCategory.Text) != null)
                {
                    dtgCategory.DataSource = busDanhMuc.timDanhMuc(txbSearchCategory.Text);
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

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (txbProduct.Text != "")
            {
                if (busSach.timSach(txbProduct.Text) != null)
                {
                    dtgProduct.DataSource = busSach.timSach(txbProduct.Text);
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

        private void btnOder_Click(object sender, EventArgs e)
        {
            if (txbOder.Text != "")
            {
                if (busDonHang.timDonHang(txbOder.Text) != null)
                {
                    dtgOder.DataSource = busDonHang.timDonHang(txbOder.Text);
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
    }
}
