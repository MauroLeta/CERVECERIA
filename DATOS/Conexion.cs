using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class Conexion
    {
        //Data Source = MAURO\\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True
        //Data Source = DESKTOP - 8UATE5V\\SQLEXPRESS;Initial Catalog = CERVECERIA; Integrated Security = True

        static string conectionString = "Data Source = DESKTOP-8UATE5V\\SQLEXPRESS;Initial Catalog = CERVECERIA; Integrated Security = True";
        public SqlConnection connectBD = new SqlConnection(conectionString);


        //------------------------------------------------------------------------------ MODO NO CONECTADO.
        public DataSet GetDataSet(string query) //-------- Get del DataSet
        {
            DataSet Ds = new DataSet();
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(query, connectBD);   //--creo un data adapter y lleno el dataset
                Da.Fill(Ds);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return Ds;
        }

        public bool UpdateDataSet(int nTab, string tabla, DataSet Dset)  //--------- Update del DataSet
        {
            string query = "SELECT * FROM " + tabla;
            SqlDataAdapter Da = new SqlDataAdapter(query, conectionString);

            SqlCommandBuilder Cb = new SqlCommandBuilder(Da);  //--seteo de metodos para guardar en BD
            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();
            Da.InsertCommand = Cb.GetInsertCommand();
            Da.ContinueUpdateOnError = true;

            Da.Update(Dset.Tables[nTab]); //-persiste datos en la BD
            return true;
        }

        public void RejectChanges(DataSet Dset)  //---------- Descartar Cambios del DataSet
        {
            Dset.RejectChanges();
        }


        //------------------------------------------------------------------------------ MODO CONECTADO.
        public void openBD()
        {
            try
            {
                connectBD.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD " + ex.Message);
            }
        }
        public void closeBD()
        {
            connectBD.Close();
        }
      
        public bool CRUD_BdData(string _query)  //---CRUD Conectado
        {
            openBD();
            SqlCommand command = new SqlCommand(_query, connectBD);
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
        public List<T> GetBdDataList<T>(string _query)//-----GetListObject
        {
            List<T> list = new List<T>();

            openBD();
            SqlCommand command = new SqlCommand(_query, connectBD);
            SqlDataReader lector;
            lector = command.ExecuteReader();
            while (lector.Read())
            {
                var type = typeof(T);
                T obj = (T)Activator.CreateInstance(type);
                foreach (var prop in type.GetProperties())
                {
                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(lector[prop.Name].ToString(),propType));
                }
                list.Add(obj);
            }
            closeBD();
            return list;
        }
        public T GetBdDataObjet<T>(string _query)//-----GetObjet
        {
            openBD();
            SqlCommand command = new SqlCommand(_query, connectBD);
            SqlDataReader lector;
            lector = command.ExecuteReader();
            T objeto = (T)Activator.CreateInstance(typeof(T));
            while (lector.Read())
            {
                var type = typeof(T);
                T obj = (T)Activator.CreateInstance(type);
                foreach (var prop in type.GetProperties())
                {
                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(lector[prop.Name].ToString(), propType));
                }
                objeto = obj;
            }
            closeBD();
            return objeto;
        }
        public string GetString(string _query, string column) //-----------get String para Idiomas
        {
            openBD();
            string query = _query;
            string valor = "";
            SqlCommand command = new SqlCommand(query, connectBD);
            SqlDataReader lector;
            lector = command.ExecuteReader();
            if (lector.Read())
            {
                valor = lector[column].ToString();
            }
            closeBD();
            return valor;
        }
    }
}
