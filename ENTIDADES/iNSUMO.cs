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
        private float cantidad;
        private float precio;
        private PROVEEDOR proveedor;

        public INSUMO(int id, RUBRO rubro, string nombre, string marca, float cantidad,float precio, PROVEEDOR proveedor)
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
        public RUBRO Rubro { get => rubro; set => rubro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public PROVEEDOR Proveedor { get => proveedor; set => proveedor = value; }
    }
}
