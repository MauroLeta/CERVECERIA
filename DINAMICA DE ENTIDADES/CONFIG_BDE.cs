using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DINAMICA_DE_ENTIDADES
{
    public class CONFIG_BDE
    {
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
    }
}
