using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Cargos_dal
    {
        Conexion conection = new Conexion();
        public string consulta = "";
        public List<Cargo> getCargo()
        {
            consulta = @"select * from Cargos";

            return conection.GetBdDataList<Cargo>(consulta);
        }
    }
}
