using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Pagos_dal
    {
        Conexion conection = new Conexion();
        public string consulta = "";
        public List<TipoPago> getPagos()
        {
            consulta = @"select * from FormasDePago";

            return conection.GetBdDataList<TipoPago>(consulta);
        }
    }
}
