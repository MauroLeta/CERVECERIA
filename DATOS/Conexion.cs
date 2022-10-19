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
        //Data Source = MAURO\\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True
        //Data Source = DESKTOP - 8UATE5V\\SQLEXPRESS;Initial Catalog = CERVECERIA; Integrated Security = True

        public string conectionString = "Data Source = DESKTOP-8UATE5V\\SQLEXPRESS;Initial Catalog = CERVECERIA; Integrated Security = True";
        public SqlConnection conectBd = new SqlConnection();

        public Conexion()
        {
            conectBd.ConnectionString = conectionString;
        }
        public void openBD()
        {
            try
            {
                conectBd.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD " + ex.Message);
            }
        }
        public void closeBD()
        {
            conectBd.Close();
        }


        ///////-------------------------------------------------------------------------------------------------------//////////
        public DataTable GetBdData(string _query)
        {
            openBD();
            string query = _query;
            SqlCommand command = new SqlCommand(query, conectBd);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeBD();
            return table;
        }

        public int GetInt(string _query,string column)
        {
            openBD();
            string query = _query;
            int valor = 0;
            SqlCommand command = new SqlCommand(query, conectBd);
            SqlDataReader lector;
            lector = command.ExecuteReader();
            if(lector.Read())
            {
                valor = Int32.Parse(lector[column].ToString());
            }
            closeBD();
            return valor;
        }

        public string GetString(string _query, string column)
        {
            openBD();
            string query = _query;
            string valor = "";
            SqlCommand command = new SqlCommand(query, conectBd);
            SqlDataReader lector;
            lector = command.ExecuteReader();
            if (lector.Read())
            {
                valor = lector[column].ToString();
            }
            closeBD();
            return valor;
        }
        public bool CRUD_BdData(string _query)
        {
            openBD();
            string query = _query;
            SqlCommand command = new SqlCommand(query, conectBd);
            int cant;
            cant = command.ExecuteNonQuery();
            closeBD();
            if (cant >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
