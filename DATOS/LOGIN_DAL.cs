using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;
using ENTIDADES;

namespace DATOS
{
    
    public class LOGIN_DAL
    {
        Conexion conection = new Conexion();

        public USUARIOLOG GetUsuario(string user, string pass) 
        {
            USUARIOLOG usuario = new USUARIOLOG();
            string consulta = "Select * from Usuarios where Usuario = '" + user + "' and Contraseña = '" + pass + "' ";
            DataTable tabla = new DataTable();
            tabla = conection.GetBdData(consulta);

            var i = 0;
            
            foreach (DataRow drow in tabla.Rows)
            {
              bool blocked = bool.Parse(tabla.Rows[i]["Bloqueado"].ToString());

                if(blocked == true)
                {
                    usuario.Id = 0;                  
                }
                else
                {
                    USUARIOLOG us = new USUARIOLOG(
                        Int32.Parse(tabla.Rows[i]["ID"].ToString()),
                        tabla.Rows[i]["Nombre"].ToString(),
                        tabla.Rows[i]["Apellido"].ToString(),
                        tabla.Rows[i]["Sector"].ToString(),
                        tabla.Rows[i]["Idioma"].ToString());

                    usuario = us;
                }
            }
            return usuario;
        }

        public int GetIntentos(string user)
        {
            string consultaIntentos = "Select * from Usuarios where Usuario = '" + user + "'";
            int intentos = conection.GetInt(consultaIntentos, "Intentos");

            return intentos;
        }

        public void UpdateIntentos(string user, int intentos)
        {
            string updateIntentos = "Update Usuarios Set Intentos ="+ intentos + "  where Usuario = '" + user + "'";
            conection.CRUD_BdData(updateIntentos);     
        }

        public void Bloquear(string user)
        {
            string bloquear = "Update Usuarios set Bloqueado = 1 where Usuario ='" + user + "'";
            conection.CRUD_BdData(bloquear);
        }

    }
}
