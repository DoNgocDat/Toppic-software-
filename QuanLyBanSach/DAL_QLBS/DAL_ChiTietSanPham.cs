using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBS
{
    public class DAL_ChiTietSanPham : DataProvider
    {
        public DataTable getChiTietSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from chitietsanpham", connection);
            DataTable dtChiTietSanPham = new DataTable();
            da.Fill(dtChiTietSanPham);
            return dtChiTietSanPham;
        }
    }
}
