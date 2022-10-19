using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
   public class RUBRO
    {
        private int id;
        private string rubro;

        public RUBRO(int id, string rubro)
        {
            this.Id = id;
            this.Rubro = rubro;
        }

        public int Id { get => id; set => id = value; }
        public string Rubro { get => rubro; set => rubro = value; }
    }

    
}
