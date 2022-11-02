using DATOS;
using DINAMICA_DE_ENTIDADES;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CERVECERIA
{
    public partial class frmAGREGARCOMPRA : Form
    {
        IDIOMAS_BDE idiomasBDE = new IDIOMAS_BDE();
        INSUMOS_BDE insumos_bde = new INSUMOS_BDE();
        ABM_BDE abm_bde = new ABM_BDE();
        PAGOS_BDE pagos_bde = new PAGOS_BDE();

        USUARIOLOG user = new USUARIOLOG();
        List<INSUMO> listaInsumo = new List<INSUMO>();

        public List<DETALLECOMPRA> nuevaCompra = new List<DETALLECOMPRA>();
        public float total = 0;
        public int i = 0;
        public float precioViejo = 0;
        public string Idioma = "Español";
        public frmAGREGARCOMPRA(USUARIOLOG usuario)
        {
            InitializeComponent();
            user = usuario;
            ChangeLanguaje(user.Idioma);

            CultureInfo ci = new CultureInfo("en");
            ci = new CultureInfo("en");
            CultureInfo.CurrentCulture = ci;

            listaInsumo = insumos_bde.getAllInsumos();
        }
        private void frmAGREGARCOMPRA_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection coleccionInsumo = new AutoCompleteStringCollection();

            comboBoxProducto.DataSource = listaInsumo;
            comboBoxProducto.DisplayMember = "Nombre";
            comboBoxProducto.ValueMember = "Id";

            foreach ( INSUMO insumo in listaInsumo)
            {
                coleccionInsumo.Add(insumo.Nombre);
            }
            comboBoxProducto.AutoCompleteCustomSource = coleccionInsumo;
            comboBoxProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;

            abm_bde.CargarCombo("PROVEEDOR", comboBoxProv);

            comboBoxPago.DataSource = pagos_bde.GetPagos();
            comboBoxPago.DisplayMember = "Pago";
            comboBoxPago.ValueMember = "Id";
        }
        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (INSUMO insumo in listaInsumo)
            {
                if(insumo.Id.ToString() == comboBoxProducto.SelectedValue.ToString())
                {
                    textBoxPrecio.Text = insumo.Precio.ToString();
                    precioViejo = insumo.Precio;
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            else
            {
                DETALLECOMPRA detalle = dataGridView1.CurrentRow.DataBoundItem as DETALLECOMPRA;
                nuevaCompra.Remove(detalle);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = nuevaCompra;
                dataGridView1.Columns["id"].Visible = false;
                total = total - (detalle.Precio * detalle.Cantidad);    ////bde??? calcular precio
                lblTotal.Text = total.ToString();
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "" || textBoxPrecio.Text == "")
            {
                MessageBox.Show("Faltan ingresar datos");
                return;
            }
            else
            {
                INSUMO insumo = comboBoxProducto.SelectedItem as INSUMO;
                DETALLECOMPRA detail = new DETALLECOMPRA(insumo.Id, insumo.Nombre , float.Parse(textBoxPrecio.Text), float.Parse(textBoxCantidad.Text));
                nuevaCompra.Add(detail);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = nuevaCompra;                
                dataGridView1.Columns["id"].Visible = false;
                total = total + (float.Parse(textBoxPrecio.Text) * float.Parse(textBoxCantidad.Text));   ////bde??? calcular precio
                lblTotal.Text = total.ToString();
                label8.Text = " TOTAL: $";

                if (lblProv.Text == "")
                {
                    lblProv.Text = comboBoxProv.Text;
                    lblFecha.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    comboBoxProv.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    comboBoxPago.Enabled = false;
                }
                i = i + 1;
            }
            if(Int32.Parse(textBoxPrecio.Text) != precioViejo)
            {
                DialogResult resul = MessageBox.Show("¿Desea actualizar el precio?","Actualizar Precio", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    // BDE actualiar precio
                }
            }
        }

        private void btnCargarCompra_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Faltan ingresar datos");
                return;
            }
            else
            {
                //agregar compra (lbl fecha, lbltotal, combobox prov value )
                //agregar detalle ()  id + "," + detail.Precio + "," + detail.Cantidad +
            }


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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

    }
}
