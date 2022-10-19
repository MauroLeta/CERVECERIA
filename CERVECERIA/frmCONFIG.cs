using DINAMICA_DE_ENTIDADES;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CERVECERIA
{
    public partial class frmCONFIG : Form
    {
        IDIOMAS_BDE idiomasBDE = new IDIOMAS_BDE() ;
        USUARIOLOG user = new USUARIOLOG();

        string Idioma = "Español";
        string nIdioma = "";

        public frmCONFIG(USUARIOLOG usuario)
        {
            InitializeComponent();
            user = usuario;
            ChangeLanguaje(usuario.Idioma);
            Idioma = usuario.Idioma;
        }
        private void frmCONFIG_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            CONFIG_BDE config_bde = new CONFIG_BDE();

            config_bde.ComboIdiomas(comboBox1, user.Idioma);

            if (Idioma == "Español")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Español;
            }
            if (Idioma == "Ingles")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Ingles;
            }
            if (Idioma == "Portugues")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Portugues;
            }       
        }
        public void ChangeLanguaje(string idiomaN)
        {
            if (Idioma != idiomaN)
            {
                idiomasBDE.CambiarIdioma(this, idiomaN, Idioma, null);
            }
            else
            {
                return;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            idiomasBDE.GuardarIdioma(nIdioma, user);

        }
        private void comboBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: ChangeLanguaje("Español");
                    nIdioma = "Español";
                    break;
                case 1:
                    ChangeLanguaje("Ingles");
                   nIdioma = "Ingles";
                    break;
                case 2:
                    ChangeLanguaje("Portugues");
                    nIdioma = "Portugues";
                    break;
            }
            if (Idioma != nIdioma)
            {
                user.Idioma = nIdioma;
                Idioma = nIdioma;
                load();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
