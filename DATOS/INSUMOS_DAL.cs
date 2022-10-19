using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class INSUMOS_DAL
    {
        Conexion conection = new Conexion();
        public List<INSUMO> insumos = new List<INSUMO>();

        public DataTable getInsumo(string text)
        {
            insumos.Clear();
            string consulta = @"select Insumos.idInsumo, Rubros.id, rubros.rubro, Insumos.nombre, Insumos.Marca, Insumos.Cantidad, Proveedores.idProv,
                              Proveedores.Nombre,  Proveedores.Telefono,  Proveedores.Mail from Insumos inner join Rubros on Rubros.id = 
                              Insumos.Rubro inner join Proveedores on Proveedores.idProv = Insumos.Proveedor where Rubros.rubro = '" + text +"'";

            DataTable tabla = new DataTable();
            return conection.GetBdData(consulta);

        }
    }
}
