using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     
    public class Rubros_bll
    {
        Rubro_dal rubro_dal = new Rubro_dal();

        public List<Rubro> ListRubros()
        {
            return rubro_dal.GetRubro();
        }

    }
}
