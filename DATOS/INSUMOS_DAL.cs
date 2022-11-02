using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class INSUMOS_DAL
    {
        Conexion conection = new Conexion();
        public List<INSUMO> insumos = new List<INSUMO>();
        public string consulta = @"select Insumos.idInsumo, Rubros.id, rubros.rubro, Insumos.nombre, Insumos.Marca, Insumos.Cantidad,Insumos.Precio, Proveedores.idProv,
                              Proveedores.NombreProv,  Proveedores.Telefono,  Proveedores.Mail from Insumos inner join Rubros on Rubros.id = 
                              Insumos.Rubro inner join Proveedores on Proveedores.idProv = Insumos.Proveedor";

        public DataTable getInsumo(string text,bool search, string buscador)
        {
            insumos.Clear();
            consulta = consulta + " where Rubros.rubro = '" + text + "'";
            if (search == true) 
            {
                consulta = consulta + " and Insumos.Nombre like '" + buscador + "%'";
            }

            DataTable tabla = new DataTable();
            return conection.GetBdData(consulta);

        }
        public DataTable getAllInsumos()
        {
            DataTable tabla = new DataTable();
            return conection.GetBdData(consulta);
        }
        public bool InsertInsumo(INSUMO insumo)
        {
            CultureInfo ci = new CultureInfo("en");
            ci = new CultureInfo("en");
            CultureInfo.CurrentCulture = ci;

            string query = @"INSERT INTO Insumos values (" + insumo.Rubro.Id + ",'" + insumo.Nombre + "','" + insumo.Marca + "',"
                           + insumo.Cantidad + "," + insumo.Proveedor.Id + ")";
            bool insert = conection.CRUD_BdData(query);
            return insert;
        }
        public bool deleteInsumo(int ID)
        {
            string query = "delete from Insumos where idInsumo =" + ID;
            bool delete = conection.CRUD_BdData(query);
            return delete;
        }
        public bool editInsumo(INSUMO insumo)
        {
            CultureInfo ci = new CultureInfo("en");
            ci = new CultureInfo("en");
            CultureInfo.CurrentCulture = ci;
            string query = "Update Insumos Set Rubro=" + insumo.Rubro.Id + ", Nombre='" + insumo.Nombre + "', Marca='" + insumo.Marca + "'," +
                           "Cantidad=" + insumo.Cantidad + ", Proveedor=" + insumo.Proveedor.Id + " where idInsumo =" + insumo.Id;
            bool edit = conection.CRUD_BdData(query);
            return edit;
        }
    }
}
