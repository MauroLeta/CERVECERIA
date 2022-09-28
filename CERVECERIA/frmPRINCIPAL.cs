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
    public partial class frmPRINCIPAL : Form
    {
        IDIOMAS_BDE idiomasBDE = new IDIOMAS_BDE();
        public string Idioma = "Español";
        public string IdiomaUser = "";
        string _nombre;
        string _apellido;
        string _sector;
        public frmPRINCIPAL(string sector, string nombre, string apellido, string idioma)
        {
            InitializeComponent();
             _nombre = nombre;
            _apellido = apellido;
            _sector = sector;
            IdiomaUser = idioma;
        }
        private void PRINCIPAL_Load(object sender, EventArgs e)
        {
            ChangeLanguaje(IdiomaUser);
            Idioma = IdiomaUser;

            lblApellido.Text = _apellido;
            lblNombre.Text = _nombre;
            lblSector.Text = _sector;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //submenuReportes.Visible = true;
            if(submenuReportes.Visible == false)
            {
                submenuReportes.Visible = true;
            }
            else if (submenuReportes.Visible == true)
            {
                submenuReportes.Visible = false;
            }
        }

        internal void Show(string sector, string apellido)
        {
            throw new NotImplementedException();
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            submenuReportes.Visible = false;
        }

        private void btnrptcompras_Click(object sender, EventArgs e)
        {
            submenuReportes.Visible = false;
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
            submenuReportes.Visible = false;
        }

        private void Abrirformhijo (object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();                
        }

        public void ChangeLanguaje(string idiomaN)
        {
            if (Idioma != idiomaN)
            {
                idiomasBDE.CambiarIdioma(this, idiomaN, Idioma, MenuVertical);
            }
            else
            {
                return;
            }
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
           
            Abrirformhijo(new frmEMPLEADOS());

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new frmPRODUCTOS());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new frmVENTAS());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new frmCLIENTES());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new frmCOMPRAS());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new frmPAGOS());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Abrirformhijo(new frmINICIO());
        }

        private void btnCONECTADO_Click(object sender, EventArgs e)
        {

        }

        private void btnDESCONECTADO_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmCONFIG config = new frmCONFIG(IdiomaUser);
            config.Show();
        }
    }
}
