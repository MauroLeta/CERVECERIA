using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DATOS
{
    public class Desconectado
    {
        public string CadenaCN = "Data Source=MAURO\\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True";
        SqlConnection CN = new SqlConnection(CadenaCN);
        CN.Open();
        string sSql = "Select * from Usuarios";
        SqlDataAdapter da = new SqlDataAdapter(sSql, CN);
        DataTable dt = new DataTable();
        da.

    }
}
