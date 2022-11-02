using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class DETALLECOMPRA
    {
        int id;
        string insumo;
        float precio;
        float cantidad;

        public DETALLECOMPRA(int id,string insumo, float precio, float cantidad)
        {
            this.Id = id;
            this.Insumo = insumo;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public string Insumo { get => insumo; set => insumo = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
    }
}
