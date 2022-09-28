using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DINAMICA_DE_ENTIDADES
{
    public class IDIOMAS_BDE
    {
        IDIOMAS_DAL idiomasDal = new IDIOMAS_DAL();
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
  
    }
}
