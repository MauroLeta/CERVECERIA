using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Compras_bll
    {
        Compras_dal compras_dal = new Compras_dal();
        DataSet ds = new DataSet();
        public DataSet cargarCompras()
        {
            ds = compras_dal.getCompras();
            return ds;
        }
        public bool agregarCompra(Compra compra)
        {
            bool insert = compras_dal.insertCompra(compra);
            return insert;
        }
        public int getLastId()
        {
            int lastId = compras_dal.selectLastId();
            return lastId;
        }
        public void agregarDetalle(int id, int Insumo, float Precio, float Cantidad )
        {
            compras_dal.insertDetalle(id, Insumo, Precio, Cantidad);
        }

        public DataTable Busqueda(DateTime date1, DateTime date2) 
        {
            DataTable busqueda = compras_dal.getCompraForDate(date1, date2);
            return busqueda;
        }
    }
}
