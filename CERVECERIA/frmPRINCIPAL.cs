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
        public frmPRINCIPAL()
        {
            InitializeComponent();
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


        private void PRINCIPAL_Load(object sender, EventArgs e)
        {

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
    }
}
