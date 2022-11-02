using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINAMICA_DE_ENTIDADES
{
    
   public class INSUMOS_BDE
    {
        INSUMOS_DAL insumos_DAL = new INSUMOS_DAL();
        List<INSUMO> insumos = new List<INSUMO>();
        public List<INSUMO> getInsumos(string text,bool search, string buscador)
        {
            DataTable tabla = new DataTable();
            tabla = insumos_DAL.getInsumo(text,search,buscador);

            List<INSUMO> insumos = Listar(tabla);
            return insumos;
        }
        public bool AgregarInsumo(string medida, RUBRO rubro, string nombre, string marca, float cantidad,float precio, PROVEEDOR proveedor)
        {
            INSUMO insumo = new INSUMO(0, rubro, nombre, marca, cantidad,precio, proveedor);
            if(medida == "Gr")
            {
                insumo.Cantidad = insumo.Cantidad * 1000;
            }
            bool insert = insumos_DAL.InsertInsumo(insumo);

            if (insert == true)
            {
                MessageBox.Show("Registro Insertado");
                return insert;
            }
            else
            {
                MessageBox.Show("No se pudo insertar el Registro");
                return insert;
            }
        }
        public bool EditarInsumo(string medida, int id, RUBRO rubro, string nombre, string marca, float cantidad,float precio, PROVEEDOR proveedor)
        {
            INSUMO insumo = new INSUMO(id, rubro, nombre, marca, cantidad,precio, proveedor);
            if (medida == "Gr")
            {
                insumo.Cantidad = insumo.Cantidad * 1000;
            }
            bool edit = insumos_DAL.editInsumo(insumo);

            if (edit == true)
            {
                MessageBox.Show("Registro Editado");
                return edit;
            }
            else
            {
                MessageBox.Show("No se pudo insertar el Editado");
                return edit;
            }
        }
        public bool EliminarInsumo(int id)
        {
            bool delete = insumos_DAL.deleteInsumo(id);

            if (delete == true)
            {
                MessageBox.Show("Registro Eliminado");
                return delete;
            }
            else
            {
                MessageBox.Show("No se pudo Eliminar el Registro");
                return delete;
            }
        }

        public List<INSUMO> getAllInsumos()
        {
            DataTable tabla = new DataTable();
            tabla = insumos_DAL.getAllInsumos();

            List<INSUMO> insumos = Listar(tabla);
            return insumos;
        }
        public List<INSUMO> Listar(DataTable tabla)
        {
            insumos.Clear();
            var i = 0;
            foreach (DataRow drow in tabla.Rows)
            {
                RUBRO rubro = new RUBRO(Int32.Parse(tabla.Rows[i]["id"].ToString()), tabla.Rows[i]["rubro"].ToString());
                PROVEEDOR proveedor = new PROVEEDOR(Int32.Parse(tabla.Rows[i]["idProv"].ToString()), tabla.Rows[i]["NombreProv"].ToString(), Int32.Parse(tabla.Rows[i]["Telefono"].ToString()), tabla.Rows[i]["Mail"].ToString());

                INSUMO insumo = new INSUMO(
                        Int32.Parse(tabla.Rows[i]["idInsumo"].ToString()),
                        rubro,
                        tabla.Rows[i]["Nombre"].ToString(),
                        tabla.Rows[i]["Marca"].ToString(),
                        float.Parse(tabla.Rows[i]["Cantidad"].ToString()),
                        float.Parse(tabla.Rows[i]["Precio"].ToString()), proveedor);

                insumos.Add(insumo);

                i++;
            }
            return insumos;
        }
    }
}
