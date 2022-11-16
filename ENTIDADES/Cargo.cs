using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Cargo
    {
        private int id;
        private string cargo;

        public Cargo() { }
        public Cargo(int id, string cargo)
        {
            this.Id = id;
            this.Descripcion = cargo;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => cargo; set => cargo = value; }
    }
}
