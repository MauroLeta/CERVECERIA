using DAL;
using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINAMICA_DE_ENTIDADES
{
    public class Estilos_bll
    {
        Estilos_dal estilos_dal = new Estilos_dal();
        DataSet ds = new DataSet();
        public DataSet cargarEstilos()
        {
            ds = estilos_dal.getEstilos();
            return ds;
        }
        public bool agregarEstilo(Estilo estilo)
        {
            bool insert = estilos_dal.insertEstilo(estilo);
            return insert;
        }
        public int getLastId()
        {
            int lastId = estilos_dal.selectLastId();
            return lastId;
        }
        public void agregarDetalle(int id, int Insumo, float Cantidad)
        {
            estilos_dal.insertDetalleEstilo(id, Insumo, Cantidad);
        }

    }
}
