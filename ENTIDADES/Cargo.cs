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

        public Cargo(int id, string cargo)
        {
            this.Id = id;
            this._Cargo = cargo;
        }

        public int Id { get => id; set => id = value; }
        public string _Cargo { get => cargo; set => cargo = value; }
    }
}
