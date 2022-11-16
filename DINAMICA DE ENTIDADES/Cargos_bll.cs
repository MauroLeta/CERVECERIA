using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINAMICA_DE_ENTIDADES
{
    public class Cargos_bll
    {
        Cargos_dal cargos_dal = new Cargos_dal();
        public List<Cargo> getCargos()
        {
            List<Cargo> cargos = cargos_dal.getCargo();
            return cargos;
        }
    }  
}
