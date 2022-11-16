using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BLL
{
    public class Config_bll
    {
        Idiomas_bll idiomas_bll = new Idiomas_bll();
        public void ComboIdiomas(ComboBox combo, string Idioma)
        {
            combo.Items.Clear();

            if (Idioma == "Español")
            {
                combo.Items.Add("Español");
                combo.Items.Add("Ingles");
                combo.Items.Add("Portugues");
                combo.Text = "Español";
            }
            if (Idioma == "Ingles")
            {
                combo.Items.Add("Spanish");
                combo.Items.Add("English");
                combo.Items.Add("Portuguese");
                combo.Text = "English";
            }
            if (Idioma == "Portugues")
            {
                combo.Items.Add("Espanhol");
                combo.Items.Add("Ingles");
                combo.Items.Add("Português");
                combo.Text = "Português";
            }           
        }

        public void ActualizarForm(string idiomaNuevo, string idioma)
        {
            foreach (Form form in Application.OpenForms)
            {
                    idiomas_bll.CambiarIdioma(form, idiomaNuevo, idioma, null);      
            }

        }
    }
}
