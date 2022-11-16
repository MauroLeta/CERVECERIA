using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BE;

namespace DAL
{ 
    public class Login_dal
    {
        Conexion conection = new Conexion();

        public UserLog ValidarUsuario(string user, string pass) 
        {
            string consulta = @"Select * from Usuarios where Usuario = '"+ user +"' and  " +
                                 "CONVERT(nvarchar(30),DECRYPTBYPASSPHRASE('password',Contraseña)) = '"+ pass +"'";

            UserLog usuario = conection.GetBdDataObjet<UserLog>(consulta);
            return usuario;
        }

        public UserLog GetUsuario(string user)
        {
            string consulta = @"Select * from Usuarios where Usuario = '" + user + "'";

            UserLog usuario = conection.GetBdDataObjet<UserLog>(consulta);
            return usuario;
        }

        public void UpdateIntentos(UserLog user, int intentos)
        {
            string updateIntentos = "Update Usuarios Set Intentos ="+ intentos + "  where ID = " + user.Id;
            conection.CRUD_BdData(updateIntentos);     
        }

        public void Bloquear(UserLog user)
        {
            string bloquear = "Update Usuarios set Bloqueado = 1 where ID =" + user.Id ;
            conection.CRUD_BdData(bloquear);
        }

    }
}
