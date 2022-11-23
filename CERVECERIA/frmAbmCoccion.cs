using BE;
using DINAMICA_DE_ENTIDADES;
using ENTIDADES;
using IDIOMA;
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
    public partial class frmAbmCoccion : Form
    {
        Estilos_bll estilos_bll = new Estilos_bll();
        Barriles_bll barriles_bll = new Barriles_bll();

        UserLog user = new UserLog();
        
        public string Idioma = "Español";
        public string ABM = "";
        public frmAbmCoccion(string tipo, BE.UserLog usuario)
        {
            InitializeComponent();
            ABM = tipo;
            user = usuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbmCoccion_Load(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();

            if (ABM == "ALTA")
            {
                lblABM.Text = "AGREGAR COCCIÓN";
                btnGuardar.Text = "AGREGAR";
            }
            else if (ABM == "EDITAR")
            {
                lblABM.Text = "EDITAR COCCIÓN";
                btnGuardar.Text = "EDITAR";
            }

            idioma.ChangeLanguaje(this, Idioma, user.Idioma, null);

            lblName.Text = user.Apellido;
            //lblBatch.Text = 

            cbEstilo.DataSource = estilos_bll.Listar();
            cbEstilo.DisplayMember = "Estilo_";
            cbEstilo.ValueMember = "Id";

            cbBarril.DataSource = barriles_bll.getFreeBarriles();
            cbBarril.DisplayMember = "Id";
            cbBarril.ValueMember = "Id";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
