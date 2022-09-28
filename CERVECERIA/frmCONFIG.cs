using DINAMICA_DE_ENTIDADES;
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
        String Idioma = "Español";
        IDIOMAS_BDE idiomasBDE = new IDIOMAS_BDE() ;

        public frmCONFIG(string idiomaUser)
        {
            InitializeComponent();
            ChangeLanguaje(idiomaUser);
            Idioma = idiomaUser;
        }
        private void frmCONFIG_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            comboBox1.Items.Clear();

            if (Idioma == "Español")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Español;
                comboBox1.Items.Add("Español");
                comboBox1.Items.Add("Ingles");
                comboBox1.Items.Add("Portugues");
                comboBox1.Text = "Español";
            }
            if (Idioma == "Ingles")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Ingles;
                comboBox1.Items.Add("Spanish");
                comboBox1.Items.Add("English");
                comboBox1.Items.Add("Portuguese");
                comboBox1.Text = "English";
            }
            if (Idioma == "Portugues")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Portugues;
                comboBox1.Items.Add("Espanhol");
                comboBox1.Items.Add("Ingles");
                comboBox1.Items.Add("Português");
                comboBox1.Text = "Português";
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

        }
        private void comboBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            string nIdioma = "";

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
