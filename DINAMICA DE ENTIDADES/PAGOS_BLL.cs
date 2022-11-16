using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Pagos_bll
    {
        Pagos_dal pagos_dal = new Pagos_dal();
        public List<TipoPago> GetPagos() 
        {       
            return pagos_dal.getPagos();
        }
    }
}
