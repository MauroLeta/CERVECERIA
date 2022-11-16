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
    public class Compras_dal
    {
        
        Conexion conection = new Conexion();

        public DataSet  getCompras()
        {
            DataSet ds = new DataSet();
            string query = @"select a.id,a.Fecha,b.NombreProv,a.Monto, c.Pago from Compras as a inner join Proveedores as b on a.Proveedor = b.idProv inner join FormasDePago as c on a.Pago = c.Id
                             select a.idCompra,b.Nombre,a.precio, a.cantidad from DetalleCompra as a inner join Insumos as b on a.idInsumo = b.idInsumo";
            ds = conection.GetDataSet(query);
            return ds;
        }
        public bool insertCompra(Compra compra)
        {
            string query = @"INSERT INTO Compras values ('" + compra.Fecha.ToString("yyyy/MM/dd") + "'," + compra.Proveedor.idProv + "," + compra.Monto + "," + compra.Pago.Id + ")";
            bool insert = conection.CRUD_BdData(query);
            return insert;
        }
        public void insertDetalle(int id, int Insumo, double Precio, double Cantidad)
        {
            CultureInfo ci = new CultureInfo("en");
            ci = new CultureInfo("en");
            CultureInfo.CurrentCulture = ci;

            string query = @"INSERT INTO DetalleCompra values (" + id + "," + Insumo + "," + Precio + "," + Cantidad + ")";
            bool insert = conection.CRUD_BdData(query);            
        }
        public int selectLastId()
        {
            string query = @"select max(Compras.id) from Compras";
            string lastId = conection.GetString(query,"");
            int id = Int32.Parse(lastId);
            return id;
        }

        public DataTable getCompraForDate(DateTime date1, DateTime date2)
        {
            DataSet ds = new DataSet();
            string query = @"select a.id,a.Fecha,b.NombreProv,a.Monto, c.Pago from Compras as a inner join Proveedores as b on a.Proveedor = b.idProv inner join FormasDePago as c on a.Pago = c.Id where Fecha between '" + date1.ToString("yyyy/MM/dd") + "' and '" + date2.ToString("yyyy/MM/dd") + "'";
                          
            ds = conection.GetDataSet(query);
            return ds.Tables[0];

        }
    }

}
