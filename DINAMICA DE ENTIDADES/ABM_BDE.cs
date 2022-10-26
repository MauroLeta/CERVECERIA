using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINAMICA_DE_ENTIDADES
{
    public class ABM_BDE
    {
        RUBRO_DAL rubro_dal = new RUBRO_DAL();
        PROVEEDOR_DAL prov_dal = new PROVEEDOR_DAL();
        public void CargarCombo(string combo, ComboBox box)
        {
            if (combo == "RUBRO")
            {
                List<RUBRO> lista_rubro = new List<RUBRO>();
                lista_rubro = rubro_dal.GetRubro();

                box.DataSource = lista_rubro;
                box.DisplayMember = "rubro";
                box.ValueMember = "id";
            }
            if (combo == "PROVEEDOR")
            {
                List<PROVEEDOR> lista_proveedor = new List<PROVEEDOR>();
                lista_proveedor = prov_dal.GetProveedor();

                box.DataSource = lista_proveedor;
                box.DisplayMember = "Nombre";
                box.ValueMember = "id";
            }
        }    
    }
}
