using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Estilo
    {
        private int id;
        private string estilo;
        private int brew;

        public Estilo(int id, string estilo, int brew)
        {
            this.Id = id;
            this.Estilo_ = estilo;
            this.Brew = brew;
        }

        public int Id { get => id; set => id = value; }
        public string Estilo_ { get => estilo; set => estilo = value; }
        public int Brew { get => brew; set => brew = value; }
    }
}
