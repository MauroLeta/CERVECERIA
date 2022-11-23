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
using System.Diagnostics; //espacio de nombre para Process
using IDIOMA;
using DINAMICA_DE_ENTIDADES;
using ENTIDADES;

namespace CERVECERIA
{
    public partial class frmPrincipal : Form
    {
        UserLog user = new UserLog();
        Cargos_bll cargos = new Cargos_bll();
        public string Idioma = "Español";

        public frmPrincipal(UserLog usuario)
        {
            InitializeComponent();
            user = usuario;
            
        }
        private void PRINCIPAL_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            ChangeLanguaje(user.Idioma);
                      
            lblApellido.Text = user.Apellido;
            lblSector.Text = getCargo();
            Permisos();
        }
        public void ChangeLanguaje(string idiomaN)
        {
            Idioma idioma = new Idioma();
            idioma.ChangeLanguaje(this, Idioma, idiomaN, MenuVertical);
            Idioma = user.Idioma;
        }
        public void Permisos()
        {
            int cargo = user.Cargo;

            switch(cargo)
            {
                case 2:
                    btnInsumos.Enabled = false;
                    btnCompras.Enabled = false;
                    btnVentas.Enabled = false;
                    btnAgenda.Enabled = false;
                    break;
                case 3:
                    btnRecetas.Enabled = false;
                    btnCoccion.Enabled = false;
                    btnBarriles.Enabled = false;
                    btnVentas.Enabled = false;
                    btnAgenda.Enabled = false;
                    btnProductos.Enabled = false;
                    break;
                case 4:
                    btnInsumos.Enabled = false;
                    btnCompras.Enabled = false;
                    btnRecetas.Enabled = false;
                    btnCoccion.Enabled = false;
                    btnBarriles.Enabled = false;
                    btnAgenda.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void AbrirFormHijo(Form form_hijo)
        {
            form_hijo.TopLevel = false;
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(form_hijo);
            form_hijo.Show();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmInsumos(user));
        }
        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmCompras(user));
        }
        private void btnRecetas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmRecetas(user));
        }
        private void btnCoccion_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmCoccion(user));
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmProductos());
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmVentas());
        }
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmAgenda(user));
        }

        private void webImage_Click(object sender, EventArgs e)  //----------------------------------------   process
        {
            ProcessStartInfo process = new ProcessStartInfo("chrome.exe", "https://cervezaheldig.com/");
            Process.Start(process);
        }
        private void instaImage_Click(object sender, EventArgs e)
        {
            ProcessStartInfo process = new ProcessStartInfo("chrome.exe", "https://www.instagram.com/cerveza.heldig/");
            Process.Start(process);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig config = new frmConfig(user);
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
                frmLupa Lupa = new frmLupa();
                AddOwnedForm(Lupa);
                Lupa.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
            performanceCounter1.CategoryName = "Procesador";
            performanceCounter1.CounterName = "% de tiempo de procesador";
            performanceCounter1.InstanceName = "_Total";
            try
            {
                lblCPU.Text = performanceCounter1.NextValue().ToString() + "%";
            }
            catch { }

            lblHora.Text = DateTime.Now.ToString("hh:mm");
            lblAmPm.Text = DateTime.Now.ToString("tt", System.Globalization.CultureInfo.InvariantCulture);
            lblFecha.Text = lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        public string getCargo() 
        {
           List<Cargo> listaCargos = cargos.getCargos();
            foreach(Cargo ca in listaCargos)
            {
                if(ca.Id == user.Cargo)
                {
                    return ca.Descripcion;
                }               
            }
            return "";
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
