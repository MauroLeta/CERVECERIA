using DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINAMICA_DE_ENTIDADES
{
   public class PAGOS_BDE
    {
        PAGOS_DAL pagos_dal = new PAGOS_DAL();
        public DataTable GetPagos() 
        {
            DataTable tabla = new DataTable();
            tabla = pagos_dal.getPagos();
            return tabla;
        }
    }
}
