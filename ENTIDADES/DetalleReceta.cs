using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class DetalleReceta
    {
        int id;
        string insumo;
        float cantidad;

        public DetalleReceta(int id, string insumo, float cantidad)
        {
            this.Id = id;
            this.Insumo = insumo;
            this.Cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public string Insumo { get => insumo; set => insumo = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
    }
}
