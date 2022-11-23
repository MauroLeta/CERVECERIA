using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINAMICA_DE_ENTIDADES
{
    public class Barriles_bll
    {
        Barriles_dal barriles_dal = new Barriles_dal();

        public List<Barril> getFreeBarriles()
        {
            List<Barril> barriles = new List<Barril>();
            barriles = barriles_dal.GetBarril();
            foreach (Barril barril in barriles)
            {
                if (barril.disponible == false)
                {
                    barriles.Remove(barril);
                }
            }
            return barriles;
        }
    }
}
