using DAL;
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
    public class Estilos_dal
    {
        Conexion conection = new Conexion();

        public DataSet getEstilos()
        {
            DataSet ds = new DataSet();
            string query = @"select a.id, a.estilo, b.Nombre as BrewMaster from Estilos as a inner join Empleados as b on b.id = a.BrewMaster
                             select b.idDetalle, a.nombre, b.cantidad from DetalleEstilo as b inner join Insumos as a on idProducto = idInsumo";
            ds = conection.GetDataSet(query);
            return ds;
        }

        public  DataSet getOnlyEstilos()
        {
            DataSet ds = new DataSet();
            string query = @"select * from Estilos";
            ds = conection.GetDataSet(query);
            return ds;
        }
        public bool insertEstilo(Estilo estilo)
        {
            string query = @"INSERT INTO Estilos values ('" + estilo.Estilo_ + "','" + estilo.Brew + "')";
            bool insert = conection.CRUD_BdData(query);
            return insert;
        }

        public void insertDetalleEstilo(int id, int Insumo, double Cantidad)
        {
            CultureInfo ci = new CultureInfo("en");
            ci = new CultureInfo("en");
            CultureInfo.CurrentCulture = ci;

            string query = @"INSERT INTO DetalleEstilo values (" + id + "," + Insumo + "," + Cantidad + ")";
            bool insert = conection.CRUD_BdData(query);
        }

        public int selectLastId()
        {
            string query = @"select max(Estilos.id) from Estilos";
            string lastId = conection.GetString(query, "");
            int id = Int32.Parse(lastId);
            return id;
        }

    }
}
