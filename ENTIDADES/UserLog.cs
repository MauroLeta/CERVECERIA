using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UserLog
    {
        private int id;
        private string nombre;
        private string apellido;
        private int cargo;
        private string idioma;
        private bool locked;
        private int chance;
        public UserLog()
        { }
        public UserLog(int id, string nombre, string apellido, int cargo, string idioma, bool locked, int chance)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
            this.idioma = idioma;
            this.locked = locked;
            this.chance = chance;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Cargo { get => cargo; set => cargo = value; }
        public string Idioma { get => idioma; set => idioma = value; }
        public bool Bloqueado { get => locked; set => locked = value; }
        public int Intentos { get => chance; set => chance = value; }

    }
}
