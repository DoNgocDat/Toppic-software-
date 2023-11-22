using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBS;

namespace DAL_QLBS
{
    public class DAL_Sach : DataProvider
    {
        public DataTable getSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("select masach as N'Mã Sách', madanhmuc as N'Mã Danh Mục', tensach as N'Tên Sách', giasach as N'Giá Sách', tacgia as N'Tác Giả', ngayxuatban as N'Ngày Xuất Bản' from sach", connection);
            DataTable dtSach = new DataTable();
            da.Fill(dtSach);
            return dtSach;
        }

        public bool themSach(DTO_Sach s)
        {
            try
            {
                connection.Open();
                string sql = string.Format("insert into sach values('{0}', N'{1}', '{2}', N'{3}', N'{4}')", s.MaDanhMuc, s.TenSach, s.GiaSach, s.TacGia, s.NgayXuatBan);
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

        public bool suaSach(DTO_Sach s)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update sach set madanhmuc = {0}, tensach = N'{1}', giasach = {2}, tacgia = N'{3}', ngayxuatban = N'{4}' where masach = {4}", s.MaDanhMuc, s.TenSach, s.GiaSach, s.TacGia, s.NgayXuatBan, s.MaSach);
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

        public bool xoaSach(int masach)
        {
            try
            {
                connection.Open();
                string sql = string.Format("delete from sach where masach = {0}", masach);
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

        public DataTable timSach(string tensach)
        {
            try
            {
                connection.Open();
                string sql = string.Format("select * from sach where tensach like N'%{0}%'", tensach);
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
