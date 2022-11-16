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
    public partial class frmAbmInsumos : Form
    {    
        Insumos_bll insumo_bll = new Insumos_bll();
        Rubros_bll rubro_bll = new Rubros_bll();
        Proveedor_bll proveedor_bll = new Proveedor_bll();

        UserLog user = new UserLog();
        Insumo selectedInsumo;

        public string Idioma = "Español";
        public string ABM = "";
        public string Medida = "Kg";
        public frmAbmInsumos(string abm, UserLog usuario, Insumo insumo)
        {
            InitializeComponent();          
            user = usuario;           
            ABM = abm;
            selectedInsumo = insumo;
        }

        private void frmABM_INSUMOS_Load(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();

            cbRubro.DataSource = rubro_bll.ListRubros();
            cbRubro.DisplayMember = "rubro";
            cbRubro.ValueMember = "id";

            cbProveedor.DataSource = proveedor_bll.ListProveedor();
            cbProveedor.DisplayMember = "NombreProv";
            cbProveedor.ValueMember = "idProv";

            if (ABM == "ALTA") 
            {
                lblABM.Text = "AGREGAR INSUMOS";
                btnGuardar.Text = "AGREGAR";        
            }
            if (ABM == "EDITAR")
            {
                lblABM.Text = "EDITAR INSUMOS";
                btnGuardar.Text = "EDITAR";

                cbRubro.Text = selectedInsumo.Rubro.rubro;
                textBoxNombre.Text = selectedInsumo.Nombre;
                textBoxMarca.Text = selectedInsumo.Marca;
                textBoxCantidad.Text = selectedInsumo.Cantidad.ToString();
                textBoxPrecio.Text = selectedInsumo.Precio.ToString();
                cbProveedor.Text = selectedInsumo.Proveedor.NombreProv;
            }

            idioma.ChangeLanguaje(this, Idioma, user.Idioma, null);
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
                    bool insert = insumo_bll.AgregarInsumo(Medida, cbRubro.SelectedItem as Rubro, textBoxNombre.Text, textBoxMarca.Text,
                        float.Parse(textBoxCantidad.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en")),
                        float.Parse(textBoxPrecio.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en")),cbProveedor.SelectedItem as Proveedor);
                    if (insert == true)
                    {
                        textBoxNombre.Text = "";
                        textBoxMarca.Text = "";
                        textBoxCantidad.Text = "";

                        frmInsumos Pform = Owner as frmInsumos;
                        Pform.Reload();
                    }
                }
                if (ABM == "EDITAR")
                {
                    bool edit = insumo_bll.EditarInsumo(Medida, selectedInsumo.Id,cbRubro.SelectedItem as Rubro, textBoxNombre.Text, textBoxMarca.Text, 
                        float.Parse(textBoxCantidad.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en")),
                        float.Parse(textBoxPrecio.Text, System.Globalization.NumberStyles.Float, new System.Globalization.CultureInfo("en")), cbProveedor.SelectedItem as Proveedor);
                    if (edit == true)
                    {
                        frmInsumos Pform = Owner as frmInsumos;
                        Pform.Reload();
                        Pform.Focus();
                        this.Close();
                    }
                }
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {           
            if (textBoxCantidad.Text != "")
            {
                textBoxCantidad.Text = (double.Parse(textBoxCantidad.Text.ToString()) / 1000).ToString();      
            }
            btnG.BackColor = Color.PeachPuff;
            btnG.Enabled = true;
            btnK.BackColor = Color.SandyBrown;
            btnK.Enabled = false;
            Medida = "Kg";
        }
        private void btnG_Click(object sender, EventArgs e)
        {    
            if (textBoxCantidad.Text != "")
            {
                textBoxCantidad.Text = (double.Parse(textBoxCantidad.Text.ToString()) * 1000).ToString();               
            }
            btnG.BackColor = Color.SandyBrown;
            btnG.Enabled = false;
            btnK.BackColor = Color.PeachPuff;
            btnK.Enabled = true;
            Medida = "Gr";
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
        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
