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
    public class DAL_ChiTietHoaDon : DataProvider
    {
        public DataTable getChiTietHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("select machitiet as N'Mã Chi Tiết', mahoadon as N'Mã Hóa Đơn', masach as N'Mã Sách', soluong as N'Số Lượng', giasach as N'Giá Sách', thanhtien as N'Thành Tiền' from chitiethoadon", connection);
            DataTable dtChiTietHoaDon = new DataTable();
            da.Fill(dtChiTietHoaDon);
            return dtChiTietHoaDon;
        }
    }
}
