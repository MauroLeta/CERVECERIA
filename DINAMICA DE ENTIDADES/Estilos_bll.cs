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

        public List<Estilo> Listar()
        {
            List<Estilo> estilos = new List<Estilo>();
            DataSet ds = estilos_dal.getOnlyEstilos();

            estilos.Clear();
            var i = 0;
            foreach (DataRow drow in ds.Tables[0].Rows)
            {
                Estilo estilo = new Estilo(
                    Int32.Parse(ds.Tables[0].Rows[i]["id"].ToString()),
                    ds.Tables[0].Rows[i]["Estilo"].ToString(),
                    Int32.Parse(ds.Tables[0].Rows[i]["BrewMaster"].ToString()));

                estilos.Add(estilo);

                i++;
            }
            return estilos;
        }

    }
}
