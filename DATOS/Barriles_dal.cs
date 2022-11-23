using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Barriles_dal
    {
        Conexion conection = new Conexion();
        public List<Barril> barriles = new List<Barril>();

        public List<Barril> GetBarril()
        {
            barriles.Clear();
            string consulta = "select * from Barriles";
            barriles = conection.GetBdDataList<Barril>(consulta);

            return barriles;
        }
    }
}
