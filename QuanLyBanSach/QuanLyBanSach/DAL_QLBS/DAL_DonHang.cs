using DTO_QLBS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBS
{
    public class DAL_DonHang : DataProvider
    {
        public DataTable getDonHang()
        {
            SqlDataAdapter dh = new SqlDataAdapter("select  madonhang as N'Mã Đơn Hàng', tenkhachhang as N'Tên Khách Hàng',diachi as N'Địa Chỉ',sodienthoai as N'Số Điện Thoại'  , masach as N'Mã Sách', tensach as N'Tên Sách', giasach as N'Giá Sách',ngaymua as N'Ngày Mua ', tinhtrang as N'Tình Trạng' from donhang", connection);
            DataTable dtDonHang = new DataTable();
            dh.Fill(dtDonHang);
            return dtDonHang;
        }
        public bool themVaoDonHang(DTO_DonHang donHangItem)
        {
            try
            {
                connection.Open();
                string sql = "INSERT INTO donhang ( tenkhachhang, diachi, sodienthoai, masach, tensach, giasach, ngaymua, tinhtrang) VALUES ( @tenkhachhang, @diachi, @sodienthoai, @masach, @tensach, @giasach, @ngaymua, @tinhtrang)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@tenkhachhang", donHangItem.TenKhachHang);
                cmd.Parameters.AddWithValue("@diachi", donHangItem.DiaChi);
                cmd.Parameters.AddWithValue("@sodienthoai", donHangItem.SoDienThoai);
                cmd.Parameters.AddWithValue("@masach", donHangItem.MaSach);
                cmd.Parameters.AddWithValue("@tensach", donHangItem.TenSach);
                cmd.Parameters.AddWithValue("@giasach", donHangItem.GiaSach);
                cmd.Parameters.AddWithValue("@ngaymua", DateTime.Now);
                cmd.Parameters.AddWithValue("@tinhtrang", "Chờ Thanh Toán");

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }


        public bool xoaKhoiDonHang(int maDonHang)
        {
            try
            {
                connection.Open();
                string sql = string.Format("delete from  donhang where madonhang = {0}", maDonHang);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool suaDonHang(DTO_DonHang donhangItem)
        {
            try
            {

                connection.Open();

                string sql = "UPDATE donhang SET tenkhachhang = @tenkhachhang, diachi = @diachi, sodienthoai = @sodienthoai, masach = @masach, tensach = @tensach, giasach = @giasach, ngaymua = @ngaymua, tinhtrang = @tinhtrang WHERE madonhang = @madonhang";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@tenkhachhang", donhangItem.TenKhachHang);
                    cmd.Parameters.AddWithValue("@diachi", donhangItem.DiaChi);
                    cmd.Parameters.AddWithValue("@sodienthoai", donhangItem.SoDienThoai);
                    cmd.Parameters.AddWithValue("@masach", donhangItem.MaSach);
                    cmd.Parameters.AddWithValue("@tensach", donhangItem.TenSach);
                    cmd.Parameters.AddWithValue("@giasach", donhangItem.GiaSach);
                    cmd.Parameters.AddWithValue("@ngaymua", donhangItem.NgayMua);
                    cmd.Parameters.AddWithValue("@tinhtrang", donhangItem.TinhTrang);
                    cmd.Parameters.AddWithValue("@madonhang", donhangItem.MaDonHang);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }

            }
            catch (Exception)
            {

            }

            return false;
        }
    }
}
