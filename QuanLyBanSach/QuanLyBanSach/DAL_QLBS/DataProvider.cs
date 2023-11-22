using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBS
{
    public class DataProvider
    {
        protected SqlConnection connection = new SqlConnection("Data Source=DESKTOP-015OE7K\\SQLEXPRESS;Initial Catalog=qlbs;Integrated Security=True");
    }
}
