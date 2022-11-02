using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
   public class PAGOS_DAL
    {
        Conexion conection = new Conexion();
        public string consulta = "";
        public DataTable getPagos()
        {
            consulta = @"select * from FormasDePago";

            DataTable tabla = new DataTable();
            return conection.GetBdData(consulta);
        }
    }
}
