using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class Proveedor_dal
  {
    Conexion conection = new Conexion();
    List<Proveedor> lista_proveedor = new List<Proveedor>();
    public List<Proveedor> GetProveedor()
    {
        lista_proveedor.Clear();
        string consulta = "select * from Proveedores";
        lista_proveedor = conection.GetBdDataList<Proveedor>(consulta);
        return lista_proveedor;
    }
  }
}
