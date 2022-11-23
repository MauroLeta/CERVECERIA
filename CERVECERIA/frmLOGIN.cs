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
using BLL;
using BE;
using IDIOMA;
using System.Text.RegularExpressions;

namespace CERVECERIA
{
    public partial class frmLogin : Form
    {
        string Idioma = "Español";
        public frmLogin()
        {
            InitializeComponent();
        }
        public void ChangeLanguaje(string idiomaN)
        {
            Idioma idioma = new Idioma();
            idioma.ChangeLanguaje(this, Idioma, idiomaN, null);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Login_bll login = new Login_bll();
            UserLog usuario = login.login(txtUser.Texts, txtPass.Texts);

            if (usuario == null) { return; }
            else if (usuario.Bloqueado == false && usuario != null)
            {
                frmPrincipal form = new frmPrincipal(usuario);
                AddOwnedForm(form);
                form.Show();
                this.Visible = false;
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
 
        private void pictureBox1_Click(object sender, EventArgs e) //-------------------   Mostrar y Esconder Contra     
        {           
            if (txtPass.PasswordChar == false)
            {
                pictureBox1.BackgroundImage = Properties.Resources.ojo1;              
                txtPass.PasswordChar = true;
            }
            else if (txtPass.PasswordChar == true)
            {
                pictureBox1.BackgroundImage = Properties.Resources.ojoTachado;
                txtPass.PasswordChar = false;
            }
        } 
        private void btnLupa_Click(object sender, EventArgs e)  //-------------------------- Abrir y Cerrar lupa
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
                frmLupa Lupa = new frmLupa();
                AddOwnedForm(Lupa);
                Lupa.Show();          
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
