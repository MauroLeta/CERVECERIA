using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Proveedor
    {
        private int _id;
        private string nombre;
        private int telefono;
        private string mail;

        public Proveedor()
        {

        }
        public Proveedor(int _id, string nombre, int telefono, string mail)
        {
            this.idProv = _id;
            this.NombreProv = nombre;
            this.Telefono = telefono;
            this.Mail = mail;
        }

        public int idProv { get => _id; set => _id = value; }
        public string NombreProv { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
