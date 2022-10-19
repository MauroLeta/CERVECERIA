using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINAMICA_DE_ENTIDADES
{
    
   public class INSUMOS_BDE
    {
        INSUMOS_DAL insumos_DAL = new INSUMOS_DAL();
        List<INSUMO> insumos = new List<INSUMO>();
        public List<INSUMO> getInsumos(string text)
        {
            DataTable tabla = new DataTable();
            insumos.Clear();
            tabla = insumos_DAL.getInsumo(text);
            var i = 0;

            foreach (DataRow drow in tabla.Rows)
            {
                RUBRO rubro = new RUBRO(Int32.Parse(tabla.Rows[i]["id"].ToString()), tabla.Rows[i]["rubro"].ToString());
                PROVEEDOR proveedor = new PROVEEDOR(Int32.Parse(tabla.Rows[i]["idProv"].ToString()), tabla.Rows[i]["Nombre"].ToString(), Int32.Parse(tabla.Rows[i]["Telefono"].ToString()), tabla.Rows[i]["Mail"].ToString());

                INSUMO insumo = new INSUMO(
                        Int32.Parse(tabla.Rows[i]["idInsumo"].ToString()),
                        rubro,
                        tabla.Rows[i]["Nombre"].ToString(),
                        tabla.Rows[i]["Marca"].ToString(),
                        Int32.Parse(tabla.Rows[i]["Cantidad"].ToString()), proveedor);

                insumos.Add(insumo);

                i++;
            }
            return insumos;
        }


    }
}
