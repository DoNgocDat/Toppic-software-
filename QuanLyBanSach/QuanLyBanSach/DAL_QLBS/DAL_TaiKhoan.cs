using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBS;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace DAL_QLBS
{
    public class DAL_TaiKhoan : DataProvider
    {
        public DataTable getTaiKhoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("select tentaikhoan as N'Tên Tài Khoản', email as N'Email', tenhienthi as N'Tên Hiển Thị', matkhau as N'Mật Khẩu', loaitaikhoan as N'Loại Tài Khoản' from taikhoan", connection);
            DataTable dtTaiKhoan = new DataTable();
            da.Fill(dtTaiKhoan);
            return dtTaiKhoan;
        }

        public bool dangNhap(string tentaikhoan, string matkhau)
        {
            try
            {
                connection.Open();
                string sql = string.Format("select * from taikhoan where tentaikhoan = N'{0}' and matkhau = N'{1}'", tentaikhoan, matkhau);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
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

        public int getQuyen(string tentaikhoan)
        {
            int quyen = 0;
            try
            {
                connection.Open();
                string sql = string.Format("select loaitaikhoan from taikhoan where tentaikhoan = N'{0}'", tentaikhoan);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    quyen = Convert.ToInt16(dataReader["loaitaikhoan"]);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return quyen;
        }

        public bool themTaiKhoan(DTO_TaiKhoan tk)
        {
            try
            {
                connection.Open();
                string sql = string.Format("insert into taikhoan values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", tk.TenTaiKhoan, tk.Email, tk.TenHienThi, tk.MatKhau, tk.LoaiTaiKhoan);
                SqlCommand cmd = new SqlCommand (sql, connection);
                if(cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {

            }
            finally
            {
                connection.Close ();
            }
            return false;
        }

        public bool suaTaiKhoan(DTO_TaiKhoan tk)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update taikhoan set email = N'{0}', tenhienthi = N'{1}', matkhau = N'{2}', loaitaikhoan = N'{3}' where tentaikhoan = N'{4}'", tk.Email, tk.TenHienThi, tk.MatKhau, tk.LoaiTaiKhoan, tk.TenTaiKhoan);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if( cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool xoaTaiKhoan(string tendangnhap)
        {
            try
            {
                connection.Open();
                string sql = string.Format("delete from taikhoan where tentaikhoan = N'{0}'", tendangnhap);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if(cmd.ExecuteNonQuery() > 0)
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

        public bool doiMatKhau(DTO_TaiKhoan tk)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update taikhoan set matkhau = N'{0}' where tentaikhoan = N'{1}'", tk.MatKhau, tk.TenTaiKhoan);
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
