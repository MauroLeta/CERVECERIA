using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class TIPOPAGO
    {
        private int id;
        private string tipo;

        public TIPOPAGO(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
