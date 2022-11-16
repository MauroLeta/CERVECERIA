using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Proveedor_bll
    {
        Proveedor_dal prov_dal = new Proveedor_dal();

        public List<Proveedor> ListProveedor()
        {
            return prov_dal.GetProveedor();
        }

    }
}
