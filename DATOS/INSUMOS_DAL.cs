using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Insumos_dal
    {
        Conexion conection = new Conexion();
        public List<Insumo> insumos = new List<Insumo>();
        public string consulta = @"select Insumos.idInsumo, Rubros.id, rubros.rubro, Insumos.nombre, Insumos.Marca, Insumos.Cantidad,Insumos.Precio, Proveedores.idProv,
                              Proveedores.NombreProv,  Proveedores.Telefono,  Proveedores.Mail from Insumos inner join Rubros on Rubros.id = 
                              Insumos.Rubro inner join Proveedores on Proveedores.idProv = Insumos.Proveedor";

        public DataSet getTablesInfo() 
        {
            DataSet ds = new DataSet();
            string query = consulta + " where Rubros.rubro = 'Malta'" + consulta + " where Rubros.rubro = 'Lupulo'" + consulta + " where Rubros.rubro = 'Levadura'" + consulta + " where Rubros.rubro = 'Adiciones'";
            ds = conection.GetDataSet(query);
            return ds; //0-Malta, 1-Lupulo, 2-Levadura, 3-Adiciones
        }
        public DataSet search(string busqueda)
        {
            DataSet ds = new DataSet();
            string query = consulta + @" where Rubros.rubro = 'Malta' and Insumos.nombre like '" +busqueda+"%'" + 
                            consulta + " where Rubros.rubro = 'Lupulo' and Insumos.nombre like '" + busqueda + "%'" + 
                            consulta + " where Rubros.rubro = 'Levadura' and Insumos.nombre like '" + busqueda + "%'" +
                            consulta + " where Rubros.rubro = 'Adiciones' and Insumos.nombre like '" + busqueda + "%'";

            ds = conection.GetDataSet(query);
            return ds; //0-Malta, 1-Lupulo, 2-Levadura, 3-Adiciones
        }

        public bool insertInsumo(Insumo insumo)
        {
            CultureInfo ci = new CultureInfo("en");
            ci = new CultureInfo("en");
            CultureInfo.CurrentCulture = ci;

            string query = @"INSERT INTO Insumos values (" + insumo.Rubro.id + ",'" + insumo.Nombre + "','" + insumo.Marca + "',"
                           + insumo.Cantidad + "," + insumo.Proveedor.idProv + "," + insumo.Precio + ")";
            bool insert = conection.CRUD_BdData(query);
            return insert;
        }
        public bool deleteInsumo(int ID)
        {
            string query = "delete from Insumos where idInsumo =" + ID;
            bool delete = conection.CRUD_BdData(query);
            return delete;
        }
        public bool editInsumo(Insumo insumo)
        {
            CultureInfo ci = new CultureInfo("en");
            ci = new CultureInfo("en");
            CultureInfo.CurrentCulture = ci;

            string query = "Update Insumos Set Rubro=" + insumo.Rubro.id + ", Nombre='" + insumo.Nombre + "', Marca='" + insumo.Marca + "'," +
                           "Cantidad=" + insumo.Cantidad + ", Proveedor=" + insumo.Proveedor.idProv + " where idInsumo =" + insumo.Id;
            bool edit = conection.CRUD_BdData(query);
            return edit;
        }

        public bool actualizarPrecio(int id, double precio) 
        {
            string query = "Update Insumos Set Precio=" + precio + " where idInsumo =" + id;
            bool change = conection.CRUD_BdData(query);
            return change;
        }
        public bool actualizarCantidad(int id, double cantidad)
        {
            string query = "Update Insumos Set Cantidad = Cantidad +" + cantidad + " where idInsumo =" + id;
            bool change = conection.CRUD_BdData(query);
            return change;
        }
    }
}
