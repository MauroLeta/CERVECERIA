using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Insumo
    {
        private int id;
        private Rubro rubro;
        private string nombre;
        private string marca;
        private float cantidad;
        private float precio;
        private Proveedor proveedor;

        public Insumo(int id, Rubro rubro, string nombre, string marca, float cantidad, float precio, Proveedor proveedor)
        {
            this.Id = id;
            this.Rubro = rubro;
            this.Nombre = nombre;
            this.Marca = marca;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Proveedor = proveedor;
        }

        public int Id { get => id; set => id = value; }
        public Rubro Rubro { get => rubro; set => rubro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public Proveedor Proveedor { get => proveedor; set => proveedor = value; }
    }
}
