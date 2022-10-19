using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class INSUMO
    {
        private int id;
        private RUBRO rubro;
        private string nombre;
        private string marca;
        private int cantidad_Kg;
        private PROVEEDOR proveedor;

        public INSUMO(int id, RUBRO rubro, string nombre, string marca, int cantidad_Kg, PROVEEDOR proveedor)
        {
            this.Id = id;
            this.Rubro = rubro;
            this.Nombre = nombre;
            this.Marca = marca;
            this.Cantidad_Kg = cantidad_Kg;
            this.Proveedor = proveedor;
        }

        public int Id { get => id; set => id = value; }
        public RUBRO Rubro { get => rubro; set => rubro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Cantidad_Kg { get => cantidad_Kg; set => cantidad_Kg = value; }
        public PROVEEDOR Proveedor { get => proveedor; set => proveedor = value; }
    }
}
