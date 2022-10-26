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
    public partial class frmABM_INSUMOS : Form
    {
        IDIOMAS_BDE idiomasBDE = new IDIOMAS_BDE();
        USUARIOLOG user = new USUARIOLOG();
        INSUMOS_BDE insumo_bde = new INSUMOS_BDE();
        ABM_BDE abm_bde = new ABM_BDE();
        INSUMO selectedInsumo;

        public string Idioma = "Español";
        public string ABM = "";
        public string Medida = "Kg";
        public frmABM_INSUMOS(string abm, USUARIOLOG usuario, INSUMO insumo)
        {
            InitializeComponent();          
            user = usuario;           
            ABM = abm;
            selectedInsumo = insumo;
        }

        private void frmABM_INSUMOS_Load(object sender, EventArgs e)
        {
            if (ABM == "ALTA") 
            {
                lblABM.Text = "AGREGAR INSUMOS";
                btnGuardar.Text = "AGREGAR";
                ChangeLanguaje(user.Idioma);
                abm_bde.CargarCombo("RUBRO",cbRubro);
                abm_bde.CargarCombo("PROVEEDOR", cbProveedor);
            }
            if (ABM == "EDITAR")
            {
                lblABM.Text = "EDITAR INSUMOS";
                btnGuardar.Text = "EDITAR";
                ChangeLanguaje(user.Idioma);
                abm_bde.CargarCombo("RUBRO", cbRubro);
                abm_bde.CargarCombo("PROVEEDOR", cbProveedor);

                cbRubro.Text = selectedInsumo.Rubro.Rubro;
                textBoxNombre.Text = selectedInsumo.Nombre;
                textBoxMarca.Text = selectedInsumo.Marca;
                textBoxCantidad.Text = selectedInsumo.Cantidad.ToString();
                cbProveedor.Text = selectedInsumo.Proveedor.Nombre;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxMarca.Text == "" || textBoxCantidad.Text == "")
            {
                MessageBox.Show("¡Faltan ingresar datos!");
                return;
            }
            else
            {
                if (ABM == "ALTA")
                {
                    bool insert = insumo_bde.AgregarInsumo(Medida, cbRubro.SelectedItem as RUBRO, textBoxNombre.Text, textBoxMarca.Text,
                        float.Parse(textBoxCantidad.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en")), cbProveedor.SelectedItem as PROVEEDOR);
                    if (insert == true)
                    {
                        textBoxNombre.Text = "";
                        textBoxMarca.Text = "";
                        textBoxCantidad.Text = "";

                        frmINSUMOS Pform = Owner as frmINSUMOS;
                        Pform.LoadDatagrid();
                    }
                }
                if (ABM == "EDITAR")
                {
                    bool edit = insumo_bde.EditarInsumo(Medida, selectedInsumo.Id,cbRubro.SelectedItem as RUBRO, textBoxNombre.Text, textBoxMarca.Text, 
                        float.Parse(textBoxCantidad.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en")), cbProveedor.SelectedItem as PROVEEDOR);
                    if (edit == true)
                    {
                        frmINSUMOS Pform = Owner as frmINSUMOS;
                        Pform.LoadDatagrid();
                        Pform.Focus();
                        this.Close();
                    }
                }
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            medidaA_KG();
            textBoxCantidad.Text= (double.Parse(textBoxCantidad.Text.ToString()) / 1000).ToString();               
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            medidaA_GR();
            textBoxCantidad.Text = (double.Parse(textBoxCantidad.Text.ToString()) * 1000).ToString();
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
        public void medidaA_GR()
        {
            btnG.BackColor = Color.SandyBrown;
            btnG.Enabled = false;
            btnK.BackColor = Color.PeachPuff;
            btnK.Enabled = true;
            Medida = "Gr";
        }
        public void medidaA_KG()
        {
            btnG.BackColor = Color.PeachPuff;
            btnG.Enabled = true;
            btnK.BackColor = Color.SandyBrown;
            btnK.Enabled = false;
            Medida = "Kg";
        }
        public void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
