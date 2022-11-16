using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Agenda_dal
    {
        Conexion conection = new Conexion();
        string query = @"Select * from Clientes
                         Select Empleados.id,Nombre,Apellido,Cargo,Cargos.Descripcion as Puesto,Telefono,Mail from Empleados inner join Cargos on Cargo = Cargos.id
                         Select * from Proveedores
                         Select * from Cargos";
        public DataSet getTablesInfo()
        {
            DataSet ds = new DataSet();           
            ds = conection.GetDataSet(query);
            return ds; //0-Clientes, 1-Empleados, 2-Proveedores, 3 Cargos
        }
        public bool UpdateDataSet(int nTab, string tabla, DataSet Dset)  //--------------------ComandBuilder y Modo no Conectado
        {
            string query = "SELECT * FROM " + tabla;
            SqlDataAdapter Da = new SqlDataAdapter(query, conection.connectBD.ConnectionString);

            SqlCommandBuilder Cb = new SqlCommandBuilder(Da);  //--seteo de metodos para guardar en BD
            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();
            Da.InsertCommand = Cb.GetInsertCommand();
            Da.ContinueUpdateOnError = true;

            Da.Update(Dset.Tables[nTab]); //-persiste datos en la BD
            return true;
        }

        public bool GenerarUsuario(string nombre, string apellido, int cargo, string usuario, string contraseña)
        { 
           bool generar = conection.CRUD_BdData("exec RegistrarUsuario " + nombre + "," + apellido + "," + cargo + "," + usuario + "," + contraseña);
            return generar;
            
        }
    }
}
