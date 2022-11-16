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
    public class Idiomas_bll
    {
        Idiomas_dal idiomasDal = new Idiomas_dal();
        public void CambiarIdioma(Form form,string IdiomaNuevo,string Idioma, Panel panel) 
        {
            foreach (Control componente in form.Controls)
            {
                    componente.Text = idiomasDal.GetString(componente.Text, IdiomaNuevo, Idioma);
            }
            if(panel != null)
            {
                foreach (Control componente in panel.Controls)
                {
                    componente.Text = idiomasDal.GetString(componente.Text, IdiomaNuevo, Idioma);
                }
            }
        }  
        public void GuardarIdioma(string nIdioma, UserLog user) 
        {
            idiomasDal.UpdateIdioma(nIdioma, user.Id);
        }
  
    }
}
