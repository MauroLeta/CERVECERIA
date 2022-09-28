using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class USUARIOLOG
    {
        private int id;
        private string nombre;
        private string apellido;
        private string sector;
        private string idioma;

        public USUARIOLOG()
        { }
        public USUARIOLOG(int id, string nombre, string apellido, string sector, string idioma)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sector = sector;
            this.idioma = idioma;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sector { get => sector; set => sector = value; }
        public string Idioma { get => idioma; set => idioma = value; }
    }
}
