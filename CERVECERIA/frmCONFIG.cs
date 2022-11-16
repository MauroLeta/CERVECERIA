using BLL;
using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDIOMA;

namespace CERVECERIA
{
    public partial class frmConfig : Form
    {
        UserLog user = new UserLog();
        Config_bll config_bde = new Config_bll();

        string Idioma = "Español";
        string nIdioma = "";
        string vIdioma = "";
        Idioma idioma = new Idioma();
        public frmConfig(UserLog usuario)
        {
            InitializeComponent();
            user = usuario;
            ChangeLanguaje(usuario.Idioma);
            Idioma = usuario.Idioma;
            vIdioma = usuario.Idioma;
        }
        private void frmCONFIG_Load(object sender, EventArgs e)
        {
            load();
        }
        public void ChangeLanguaje(string idiomaN)
        {
            
            idioma.ChangeLanguaje(this, Idioma, idiomaN, null);
        }
        public void load()
        {
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

        private void comboBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    ChangeLanguaje("Español");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmPrincipal Pform = Owner as frmPrincipal;
            Pform.ChangeLanguaje(nIdioma);
            config_bde.ActualizarForm(nIdioma, vIdioma);               
            idioma.SaveLanguaje(nIdioma, user);
            MessageBox.Show("Cambios realizados");
            Pform.Focus();
            this.Close();         
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
