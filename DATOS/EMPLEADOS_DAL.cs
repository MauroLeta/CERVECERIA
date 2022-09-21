using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class EMPLEADOS_DAL
    {
        Conexion conection = new Conexion();
        public List<EMPLEADO> empleados = new List<EMPLEADO>();
        public List<EMPLEADO> GetEmpleados()
        {
            empleados.Clear();
            string consulta = "select * from Empleados";
            DataTable tabla = new DataTable();
            tabla = conection.GetBdData(consulta);

            var i = 0;

            foreach (DataRow drow in tabla.Rows)
            {
                EMPLEADO empleado = new EMPLEADO(
                        Int32.Parse(tabla.Rows[i]["Codigo"].ToString()),
                        tabla.Rows[i]["Nombre"].ToString(),
                        tabla.Rows[i]["Apellido"].ToString(),
                        tabla.Rows[i]["Cargo"].ToString());

                empleados.Add(empleado);

                i++;
            }
            return empleados;
        }  
    }
  
    }
