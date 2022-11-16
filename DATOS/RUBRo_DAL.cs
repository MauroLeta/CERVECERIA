using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Rubro_dal
    {
        Conexion conection = new Conexion();
        List<Rubro> lista_rubro = new List<Rubro>();

        public List<Rubro> GetRubro()
        {
            lista_rubro.Clear();
            string consulta = "select * from Rubros";
            lista_rubro = conection.GetBdDataList<Rubro>(consulta);

            return lista_rubro;
        }

    }
}
