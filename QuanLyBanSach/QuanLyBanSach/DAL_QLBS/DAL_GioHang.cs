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
    public class DAL_GioHang : DataProvider
    {
        public DataTable getGioHang()
        {
            SqlDataAdapter dh = new SqlDataAdapter("select magiohang as N'Mã Giỏ Hàng', masach as N'Mã Sách', madanhmuc as N'Mã Danh Mục', tensach as N'Tên Sách', giasach as N'Giá Sách', tacgia as N'Tác Giả', ngayxuatban as N'Ngày Xuất Bản' from giohang", connection);
            DataTable dtGioHang = new DataTable();
            dh.Fill(dtGioHang);
            return dtGioHang;
        }

        public bool themVaoGioHang(DTO_GioHang gioHangItem)
        {
            try
            {
                connection.Open();
                string sql = string.Format("insert into giohang (masach, madanhmuc, tensach, giasach, tacgia, ngayxuatban) values ({0}, {1}, N'{2}', {3}, N'{4}', '{5}')",
                    gioHangItem.MaSach, gioHangItem.MaDanhMuc, gioHangItem.TenSach, gioHangItem.GiaSach, gioHangItem.TacGia, gioHangItem.NgayXuatBan.ToString("yyyy-MM-dd"));
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool xoaKhoiGioHang(int maGioHang)
        {
            try
            {
                connection.Open();
                string sql = string.Format("delete from giohang where magiohang = {0}", maGioHang);
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
    }
}
