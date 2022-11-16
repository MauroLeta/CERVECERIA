using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace IDIOMA
{
    public class Idioma
    {
        Idiomas_bll idiomas_bll = new Idiomas_bll();
        public void ChangeLanguaje(Form form,string idioma, string idiomaN, Panel panel)
        {
            if (idioma != idiomaN)
            {
                idiomas_bll.CambiarIdioma(form, idiomaN, idioma, panel);
            }
            else
            {
                return;
            }
        }
        public void SaveLanguaje(string nIdioma, UserLog usuario) 
        {
            idiomas_bll.GuardarIdioma(nIdioma, usuario);            
        }
    }
}
