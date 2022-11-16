using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Compra
    {
        private int id;
        private DateTime fecha;
        private Proveedor proveedor;
        private float monto;
        private TipoPago pago;

        public Compra(int id, DateTime fecha, Proveedor proveedor, float monto, TipoPago pago)
        {
            this.id = id;
            this.fecha = fecha;
            this.proveedor = proveedor;
            this.monto = monto;
            this.pago = pago;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Proveedor Proveedor { get => proveedor; set => proveedor = value; }
        public float Monto { get => monto; set => monto = value; }
        public TipoPago Pago { get => pago; set => pago = value; }
    }
}
