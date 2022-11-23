using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
   public class Barril
    {
        private int Id;
        private int Litros;
        private string Marca;
        private bool Disponible;

        public Barril() { }

        public Barril(int id, int litros, string marca, bool disponible)
        {
            this.id = id;
            this.litros = litros;
            this.marca = marca;
            this.disponible = disponible;
        }

        public int id { get => Id; set => Id = value; }
        public int litros { get => Litros; set => Litros = value; }
        public string marca { get => Marca; set => Marca = value; }
        public bool disponible { get => Disponible; set => Disponible = value; }
    }
}
