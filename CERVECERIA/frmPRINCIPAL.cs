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
    public partial class frmPRINCIPAL : Form
    {
        IDIOMAS_BDE idiomasBDE = new IDIOMAS_BDE();
        USUARIOLOG user = new USUARIOLOG();

        public string Idioma = "Español";

        public frmPRINCIPAL(USUARIOLOG usuario)
        {
            InitializeComponent();
            user = usuario; 
        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ChangeLanguaje(user.Idioma);
           
            lblApellido.Text = user.Apellido;
            lblSector.Text = user.Sector;
        }

        public void ChangeLanguaje(string idiomaN)
        {
            if (Idioma != idiomaN)
            {
                idiomasBDE.CambiarIdioma(this, idiomaN, Idioma, MenuVertical);
                Idioma = user.Idioma;
            }
            else
            {
                return;
            }
        }

        private void AbrirFormHijo(Form form_hijo)
        {
            form_hijo.TopLevel = false;
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(form_hijo);
            form_hijo.Show();
        }


        private void btnReportes_Click(object sender, EventArgs e)
        {
            /*/submenuReportes.Visible = true;
            if(submenuReportes.Visible == false)
            {
                submenuReportes.Visible = true;
            }
            else if (submenuReportes.Visible == true)
            {
                submenuReportes.Visible = false;
            }*/
        }

        internal void Show(string sector, string apellido)
        {
            throw new NotImplementedException();
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
           // submenuReportes.Visible = false;
        }

        private void btnrptcompras_Click(object sender, EventArgs e)
        {
           // submenuReportes.Visible = false;
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
           // submenuReportes.Visible = false;
        }



        private void btnInsumos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmINSUMOS(user));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmEMPLEADOS());
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmEMPLEADOS());
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmPRODUCTOS());
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmVENTAS());
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmCLIENTES());
        }
        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmCOMPRAS(user));
        }
        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmPAGOS());
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmINICIO());
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmCONFIG config = new frmCONFIG(user);
            AddOwnedForm(config);
            config.Show();
        }

        private void btnLupa_Click(object sender, EventArgs e)
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm");
            lblAmPm.Text = DateTime.Now.ToString("tt", System.Globalization.CultureInfo.InvariantCulture);
            lblFecha.Text = lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
