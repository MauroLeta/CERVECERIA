using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Rubro
    {
        private int _id;
        private string _rubro;
        public Rubro()
        {

        }
        public Rubro(int _id, string rubro)
        {
            this.id = _id;
            this.rubro = rubro;
        }

        public int id { get => _id; set => _id = value; }
        public string rubro { get => _rubro; set => _rubro = value; }
    }

    
}
