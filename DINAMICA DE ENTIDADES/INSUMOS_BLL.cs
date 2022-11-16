using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    
   public class Insumos_bll
    {
        Insumos_dal insumos_dal = new Insumos_dal();
        List<Insumo> insumos = new List<Insumo>();
        DataSet ds = new DataSet();

        public void getDataSet() 
        {
            ds = insumos_dal.getTablesInfo();
        }
        public List<Insumo> ListarInsumos(int tabla)
        {
            List<Insumo> insumos = new List<Insumo>();
            DataTable dataTable = new DataTable();
            dataTable = ds.Tables[tabla];
            insumos = Listar(dataTable);
            return insumos;
        }
        public bool AgregarInsumo(string medida, Rubro rubro, string nombre, string marca, float cantidad, float precio, Proveedor proveedor)
        {
            Insumo insumo = new Insumo(0, rubro, nombre, marca, cantidad,precio, proveedor);
            if(medida == "Gr")
            {
                insumo.Cantidad = insumo.Cantidad / 1000;
            }
            bool insert = insumos_dal.insertInsumo(insumo);

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
        public bool EditarInsumo(string medida, int id, Rubro rubro, string nombre, string marca, float cantidad, float precio, Proveedor proveedor)
        {
            Insumo insumo = new Insumo(id, rubro, nombre, marca,cantidad, precio, proveedor);
            if (medida == "Gr")
            {
                insumo.Cantidad = insumo.Cantidad / 1000;
            }
            bool edit = insumos_dal.editInsumo(insumo);

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
            bool delete = insumos_dal.deleteInsumo(id);

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
        public void BuscarInsumos(string busqueda)
        {
            ds = insumos_dal.search(busqueda);           
        }
        public List<Insumo> Listar(DataTable tabla)
        {
            insumos.Clear();
            var i = 0;
            foreach (DataRow drow in tabla.Rows)
            {
                Rubro rubro = new Rubro(Int32.Parse(tabla.Rows[i]["id"].ToString()), tabla.Rows[i]["rubro"].ToString());
                Proveedor proveedor = new Proveedor(Int32.Parse(tabla.Rows[i]["idProv"].ToString()), tabla.Rows[i]["NombreProv"].ToString(), Int32.Parse(tabla.Rows[i]["Telefono"].ToString()), tabla.Rows[i]["Mail"].ToString());

                Insumo insumo = new Insumo(
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
        public bool ActualizarPrecio(int id, double precio)
        {
            bool actualizar = insumos_dal.actualizarPrecio(id, precio);
            return actualizar;
        }
        public bool ActualizarCantidad(int id, float cantidad)
        {
            bool actualizar = insumos_dal.actualizarCantidad(id, cantidad);
            return actualizar;
        }
    }
}
