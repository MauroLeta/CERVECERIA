using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TipoPago
    {
        private int id;
        private string tipo;

        public TipoPago() { }
        public TipoPago(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }

        public int Id { get => id; set => id = value; }
        public string Pago { get => tipo; set => tipo = value; }
    }
}
