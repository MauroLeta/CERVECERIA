using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class RUBRO_DAL
    {
        Conexion conection = new Conexion();
        List<RUBRO> lista_rubro = new List<RUBRO>();

        public List<RUBRO> GetRubro()
        {
            lista_rubro.Clear();
            string consulta = "select * from Rubros";
            DataTable tabla = new DataTable();
            tabla = conection.GetBdData(consulta);

            var i = 0;

            foreach (DataRow drow in tabla.Rows)
            {
                RUBRO rubro = new RUBRO(
                        Int32.Parse(tabla.Rows[i]["id"].ToString()),
                        tabla.Rows[i]["rubro"].ToString());

                lista_rubro.Add(rubro);

                i++;
            }
            return lista_rubro;
        }

    }
}
