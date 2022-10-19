using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class PROVEEDOR
    {
        private int id;
        private string nombre;
        private int telefono;
        private string mail;

        public PROVEEDOR(int id, string nombre, int telefono, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Mail = mail;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
