using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBS;

namespace DAL_QLBS
{
    public class DAL_DanhMuc : DataProvider
    {
        public DataTable getDanhMuc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select madanhmuc as N'Mã Danh Mục', tendanhmuc as N'Tên Danh Mục' from danhmuc", connection);
            DataTable dtDanhMuc = new DataTable();
            da.Fill(dtDanhMuc);
            return dtDanhMuc;
        }

        public bool themDanhMuc(DTO_DanhMuc dm)
        {
            try
            {
                connection.Open();
                string sql = string.Format("insert into danhmuc values(N'{0}')", dm.TenDanhMuc);
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

        public bool suaDanhMuc(DTO_DanhMuc dm)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update danhmuc set tendanhmuc = N'{0}' where madanhmuc = {1}", dm.TenDanhMuc, dm.MaDanhMuc);
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

        public bool xoaDanhMuc(int madanhmuc)
        {
            try
            {
                connection.Open();
                string sql = string.Format("delete from danhmuc where madanhmuc = {0}", madanhmuc);
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
