using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class IDIOMAS_DAL
    {
        Conexion conection = new Conexion();

        public string GetString(string cadena, string idiomaNuevo, string idiomaActual)
        {
            string consultaCadena = "Select " + idiomaNuevo + " from Idiomas where " + idiomaActual + " = '" + cadena + "'";
            string cadenaNueva = conection.GetString(consultaCadena, idiomaNuevo);

            return cadenaNueva;
        }

        public void UpdateIdioma(string nIdioma, int idUser)
        {
             string updateIdioma = "Update Usuarios Set Idioma ='" + nIdioma + "'  where ID = " + idUser;
             conection.CRUD_BdData(updateIdioma);
        } 
    }
}
