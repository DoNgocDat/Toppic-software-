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
            SqlDataAdapter dh = new SqlDataAdapter("select  madonhang as N'Mã Đơn Hàng',masach as N'Mã Sách', tenkhachhang as N'Tên Khách Hàng',diachi as N'Địa Chỉ',sodienthoai as N'Số Điện Thoại'  , tensach as N'Tên Sách', giasach as N'Giá Sách',ngaymua as N'Ngày Mua ', tinhtrang as N'Tình Trạng' from donhang", connection);
            DataTable dtDonHang = new DataTable();
            dh.Fill(dtDonHang);
            return dtDonHang;
        }
        public bool themVaoDonHang(DTO_DonHang donHangItem)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO donhang (masach, tenkhachhang, diachi, sodienthoai, tensach, giasach, ngaymua, tinhtrang) VALUES (@masach, @tenkhachhang, @diachi, @sodienthoai, @tensach, @giasach, @ngaymua, @tinhtrang)", connection))
                {
                    cmd.Parameters.AddWithValue("@masach", donHangItem.MaSach);
                    cmd.Parameters.AddWithValue("@tenkhachhang", donHangItem.TenKhachHang);
                    cmd.Parameters.AddWithValue("@diachi", donHangItem.DiaChi);
                    cmd.Parameters.AddWithValue("@sodienthoai", donHangItem.SoDienThoai);
                    cmd.Parameters.AddWithValue("@tensach", donHangItem.TenSach);
                    cmd.Parameters.AddWithValue("@giasach", donHangItem.GiaSach);
                    cmd.Parameters.AddWithValue("@ngaymua", DateTime.Now);
                    cmd.Parameters.AddWithValue("@tinhtrang", "Chờ Thanh Toán");

                    connection.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
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

        public DataTable xemThongKe(DateTime tungay, DateTime denngay)
        {
            string sql = string.Format("select * from donhang where ngaymua >= '{0}' and ngaymua <= '{1}'", tungay.ToString("yyyy-MM-dd"), denngay.ToString("yyyy-MM-dd"));
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtThongKe = new DataTable();
            adapter.Fill(dtThongKe);
            return dtThongKe;
        }

        public DataTable timDonHang(string tensach)
        {
            try
            {
                connection.Open();
                string sql = string.Format("select * from donhang where tensach like N'%{0}%'", tensach);
                SqlDataAdapter cmd = new SqlDataAdapter(sql, connection);
                DataTable data = new DataTable();
                cmd.Fill(data);
                return data;
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return null;
        }
    }
}
