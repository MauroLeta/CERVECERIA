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
    public class LOGIN_BDE
    {
        LOGIN_DAL loginDal = new LOGIN_DAL();
        USUARIOLOG usuario = new USUARIOLOG();
        
        public USUARIOLOG login(string user, string pass)
        {
            usuario = loginDal.GetUsuario(user,pass);

            if (usuario.Id != 0)
            {
                loginDal.UpdateIntentos(user, 4);
                return usuario;
            }
            else
            {
                UserFail(user);
                return usuario;
            }
        }
        public void UserFail(string user)
        {
            int intentos = loginDal.GetIntentos(user);

            if (intentos == 0)
            {
                MessageBox.Show("¡ El Usuario no existe !");
            }
            else
            {
                intentos = intentos - 1;
                if(intentos == 0)
                {
                    MessageBox.Show("Usuario Bloqueado, comuniquese con soporte");
                    loginDal.Bloquear(user);
                }
                else 
                {
                    loginDal.UpdateIntentos(user, (intentos));
                    MessageBox.Show("Te quedan " + (intentos) + " intentos");
                }
            }
        }                  
    }
}
