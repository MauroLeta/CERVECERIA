using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Login_bll
    {
        Login_dal login_dal = new Login_dal();
        UserLog usuario = new UserLog();
        
        public UserLog login(string user, string pass)
        {
            usuario = login_dal.ValidarUsuario(user,pass);

            if (usuario.Id != 0)
            {
                login_dal.UpdateIntentos(usuario, 4);
                return usuario;
            }
            else
            {
                UserFail(user);
                return null;
            }
        }
        public void UserFail(string user)
        {
            usuario = login_dal.GetUsuario(user);
            if (usuario.Id == 0)
            {
                MessageBox.Show("¡ El Usuario no existe !");
            }
            else
            {
                usuario.Intentos = usuario.Intentos - 1;
                if(usuario.Intentos == 0)
                {
                    MessageBox.Show("Usuario Bloqueado, comuniquese con soporte");
                    login_dal.Bloquear(usuario);
                }
                else 
                {
                    login_dal.UpdateIntentos(usuario, (usuario.Intentos));
                    MessageBox.Show("Te quedan " + (usuario.Intentos) + " intentos");
                }
            }
        }                  
    }
}
