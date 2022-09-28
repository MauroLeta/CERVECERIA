using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DINAMICA_DE_ENTIDADES;
using ENTIDADES;
using IDIOMA;

namespace CERVECERIA
{
    public partial class frmLOGIN : Form
    {
        IDIOMAS_BDE idiomasBDE = new IDIOMAS_BDE();
        string Idioma = "Español";
        public frmLOGIN()
        {
            InitializeComponent();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            LOGIN_BDE login = new LOGIN_BDE();
            USUARIOLOG usuario = new USUARIOLOG();

            usuario = login.login(txtUser.Text, txtPass.Text);

            if(usuario.Id != 0)
            {
                frmPRINCIPAL form = new frmPRINCIPAL(usuario.Sector,usuario.Nombre,usuario.Apellido, usuario.Idioma);
                AddOwnedForm(form);
                form.Show();
                this.Visible = false;
            }
        }
        private void btnOjo_Click(object sender, EventArgs e)
        {
            // TENGO QUE PODER MOSTRAR Y ESCONDER LA CONTRASEÑA HACIENDO CLICK ACA
            
            if(txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
            }
            else if (txtPass.PasswordChar == '\0')
            {
                txtPass.PasswordChar = '*';
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                pictureBox1.BackgroundImage = Properties.Resources.ojoTachado;
            }
            else if (txtPass.PasswordChar == '\0')
            {
                txtPass.PasswordChar = '*';
                pictureBox1.BackgroundImage = Properties.Resources.ojo1;
            }
        }

        public void ChangeLanguaje(string idiomaN)
        {
            if(Idioma != idiomaN)
            {
                idiomasBDE.CambiarIdioma(this, idiomaN, Idioma,null);
            }
            else
            {
                return;
            }
        }

        private void btnEspañol_Click(object sender, EventArgs e)
        {
            ChangeLanguaje("Español");
            Idioma = "Español";
        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            ChangeLanguaje("Ingles");
            Idioma = "Ingles";
        }

        private void btnPortugues_Click(object sender, EventArgs e)
        {
            ChangeLanguaje("Portugues");
            Idioma = "Portugues";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "frmLUPA").SingleOrDefault<Form>();

            if (existe != null)
            {
                btnLupa.BackgroundImage = Properties.Resources.pngwing_com__6_;
                existe.Close();
            }
            else
            {
                btnLupa.BackgroundImage = Properties.Resources.lupa_cerrar;
                frmLUPA Lupa = new frmLUPA();
                AddOwnedForm(Lupa);
                Lupa.Show();          
            }
        }
    }
}
