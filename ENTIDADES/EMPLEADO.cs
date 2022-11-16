using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Empleado
    {
        private int id;
        private string nombre;
        private string apellido;
        private Cargo cargo;
        private int telefono;
        private string mail;

        public Empleado() { }
        public Empleado(int id, string nombre, string apellido, Cargo cargo,int telefono,string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
            this.telefono = telefono;
            this.mail = mail;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public Cargo Cargo { get => cargo; set => cargo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }

        //funcion generar usuario

    }
}

