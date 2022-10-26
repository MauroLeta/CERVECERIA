using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
  public  class PROVEEDOR_DAL
  {
    Conexion conection = new Conexion();
    List<PROVEEDOR> lista_proveedor = new List<PROVEEDOR>();
    public List<PROVEEDOR> GetProveedor()
    {
        lista_proveedor.Clear();
        string consulta = "select * from Proveedores";
        DataTable tabla = new DataTable();
        tabla = conection.GetBdData(consulta);

        var i = 0;

        foreach (DataRow drow in tabla.Rows)
        {
            PROVEEDOR proveedor = new PROVEEDOR(
                    Int32.Parse(tabla.Rows[i]["idProv"].ToString()),
                    tabla.Rows[i]["NombreProv"].ToString(),
                    Int32.Parse(tabla.Rows[i]["Telefono"].ToString()),
                    tabla.Rows[i]["Mail"].ToString());

            lista_proveedor.Add(proveedor);

            i++;
        }
        return lista_proveedor;
    }


    }
}
