using BE;
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
    public class Agenda_bll
    {
        Agenda_dal agenda_dal = new Agenda_dal();

        public DataSet getDataSet()
        {
            return agenda_dal.getTablesInfo();          
        }

        public void BorrarFila(DataRow Drow)
        {
            Drow.Delete();            
        }
        public bool AgregarRow(DataSet ds,int tabla, string tb1, string tb2, string tb3, string tb4, string Puesto,int idPuesto)  
        {
            DataRow newDr;
            newDr = ds.Tables[tabla].NewRow();

            llenarCampos(newDr, tabla, tb1, tb2, tb3, tb4, Puesto, idPuesto);

            try
            {
                ds.Tables[tabla].Rows.Add(newDr);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
                return false;
            }
        }
        public void ModificarRow(DataRow row, int tabla, string tb1, string tb2, string tb3, string tb4, string Puesto, int idPuesto)
        {
            llenarCampos(row, tabla, tb1, tb2, tb3, tb4, Puesto, idPuesto);
        }

        public bool GuardarCambios(DataSet ds)
        {
            ds.AcceptChanges();

            bool b1 = agenda_dal.UpdateDataSet(0, "Clientes", ds);
            bool b2 = agenda_dal.UpdateDataSet(1, "Empleados", ds);           
            bool b3 = agenda_dal.UpdateDataSet(2, "Proveedores", ds);

            if(b1 == true && b2 == true && b3 == true) 
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
        public void DescartarCambios(DataSet ds)
        {
            ds.RejectChanges();
        }

        public void llenarCampos(DataRow newDr, int tabla, string tb1, string tb2, string tb3, string tb4, string Puesto, int idPuesto)
        {
            if (tabla == 0)
            {
                newDr["Nombre"] = tb2;
                newDr["Apellido"] = tb1;
                newDr["Telefono"] = tb3;
                newDr["Mail"] = tb4;
            }
            else if (tabla == 1)
            {
                newDr["Nombre"] = tb2;
                newDr["Apellido"] = tb1;
                newDr["Cargo"] = idPuesto;
                newDr["Telefono"] = tb3;
                newDr["Mail"] = tb4;
                newDr["Puesto"] = Puesto;
            }
            else if (tabla == 2)
            {
                newDr["NombreProv"] = tb2;
                newDr["Telefono"] = tb3;
                newDr["Mail"] = tb4;
            }
        }

        public bool GenerarUsuario(string nombre, string apellido,int cargo, string usuario, string contraseña)
        {
           bool generar = agenda_dal.GenerarUsuario(nombre, apellido,cargo, usuario, contraseña);
           return generar;
        }

        public bool getChanges(DataSet ds)
        {
            bool state = false;
            if(ds.GetChanges() != null)
            {
                state = true;
            }       
            return state;
        }

    }
}
