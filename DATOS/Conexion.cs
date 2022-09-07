using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DATOS
{
    public class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source = MAURO\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True");
            conexion.Open();
            return conexion;
        }

        // SE PODRIA HACER ESTO?
        /*
        public void conectar()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source = MAURO\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True");
            conexion.Open();
        }
        /*/

        public static void cerrar()
        {
            if (conectar().State == ConnectionState.Open)
            {
                conectar().Close();
            }
        }
    }
}
