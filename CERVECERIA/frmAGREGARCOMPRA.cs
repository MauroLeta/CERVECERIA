using DAL;
using BLL;
using BE;
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
using IDIOMA;

namespace CERVECERIA
{
    public partial class frmAgregarCompra : Form
    {
        Insumos_bll insumos_bll = new Insumos_bll();
        Proveedor_bll proveedor_bll = new Proveedor_bll();
        Pagos_bll pagos_bll = new Pagos_bll();
        Compras_bll compras_bll = new Compras_bll();

        UserLog user = new UserLog();
        List<Insumo> listaInsumo = new List<Insumo>();

        public List<DetalleCompra> nuevaCompra = new List<DetalleCompra>();
        public float total = 0;
        public int i = 0;
        public double precioViejo = 0;
        public string Idioma = "Español";
        public string Medida = "Kg";

        public frmAgregarCompra(UserLog usuario)
        {
            InitializeComponent();
            user = usuario;
            Idioma idioma = new Idioma();
            idioma.ChangeLanguaje(this, Idioma, user.Idioma, null);

            CultureInfo ci = new CultureInfo("en");
            ci = new CultureInfo("en");
            CultureInfo.CurrentCulture = ci;

            insumos_bll.getDataSet();
        }
        private void frmAGREGARCOMPRA_Load(object sender, EventArgs e)
        {
            var tablas = new List<int>{ 0,1,2,3};
            foreach (int tabla in tablas)
            {
                listaInsumo.AddRange(insumos_bll.ListarInsumos(tabla));
            }
            AutoCompleteStringCollection coleccionInsumo = new AutoCompleteStringCollection();

            comboBoxProducto.DataSource = listaInsumo;
            comboBoxProducto.DisplayMember = "Nombre";
            comboBoxProducto.ValueMember = "Id";

            foreach ( Insumo insumo in listaInsumo)
            {
                coleccionInsumo.Add(insumo.Nombre);
            }
            comboBoxProducto.AutoCompleteCustomSource = coleccionInsumo;
            comboBoxProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;

            comboBoxProv.DataSource = proveedor_bll.ListProveedor();
            comboBoxProv.DisplayMember = "NombreProv";
            comboBoxProv.ValueMember = "idProv";
        
            comboBoxPago.DataSource = pagos_bll.GetPagos();
            comboBoxPago.DisplayMember = "Pago";
            comboBoxPago.ValueMember = "Id";
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Insumo insumo in listaInsumo)
            {
                if(insumo.Id.ToString() == comboBoxProducto.SelectedValue.ToString())
                {
                    textBoxPrecio.Text = insumo.Precio.ToString();
                    precioViejo = insumo.Precio;
                }
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
                float cantidad;
                if (Medida == "Gr")
                {
                    cantidad = float.Parse(textBoxCantidad.Text) / 1000;
                }
                else
                {
                    cantidad = float.Parse(textBoxCantidad.Text);
                }

                Insumo insumo = comboBoxProducto.SelectedItem as Insumo;
                DetalleCompra detail = new DetalleCompra(insumo.Id, insumo.Nombre, float.Parse(textBoxPrecio.Text), cantidad);
                nuevaCompra.Add(detail); //agrego el detalle
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = nuevaCompra;
                dataGridView1.Columns["id"].Visible = false;
                total = total + (float.Parse(textBoxPrecio.Text) * cantidad);   //calcular precio
                lblTotal.Text = total.ToString();
                label8.Text = " TOTAL: $";
                textBoxCantidad.Text = "";

                if (lblProv.Text == "") //bloquea datos de compra
                {
                    lblProv.Text = comboBoxProv.Text;
                    lblFecha.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    comboBoxProv.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    comboBoxPago.Enabled = false;
                }
                i = i + 1;
            }
            if (double.Parse(textBoxPrecio.Text) != precioViejo)  //actualizar precio
            {
                Insumo insumo = comboBoxProducto.SelectedItem as Insumo;
                DialogResult resul = MessageBox.Show("¿Desea actualizar el precio?", "Actualizar Precio", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    bool cambioPrecio = insumos_bll.ActualizarPrecio(insumo.Id, double.Parse(textBoxPrecio.Text));

                    if (cambioPrecio == true)
                    {
                        MessageBox.Show("Cambio Realizado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar el cambio");
                    }
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
                DetalleCompra detalle = dataGridView1.CurrentRow.DataBoundItem as DetalleCompra;
                nuevaCompra.Remove(detalle);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = nuevaCompra;
                dataGridView1.Columns["id"].Visible = false;
                total = total - (detalle.Precio * detalle.Cantidad);    ////calcular precio
                lblTotal.Text = total.ToString();
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            btnG.BackColor = Color.PeachPuff;
            btnG.Enabled = true;
            btnK.BackColor = Color.SandyBrown;
            btnK.Enabled = false;
            Medida = "Kg";
            if (textBoxCantidad.Text != "")
            {
                textBoxCantidad.Text = (double.Parse(textBoxCantidad.Text) / 1000).ToString();
            }
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            btnG.BackColor = Color.SandyBrown;
            btnG.Enabled = false;
            btnK.BackColor = Color.PeachPuff;
            btnK.Enabled = true;
            Medida = "Gr";
            if (textBoxCantidad.Text != "")
            {
                textBoxCantidad.Text = (double.Parse(textBoxCantidad.Text) * 1000).ToString();
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
                Compra compra = new Compra(0, dateTimePicker1.Value, comboBoxProv.SelectedItem as Proveedor, total, comboBoxPago.SelectedItem as TipoPago);
                bool insert = compras_bll.agregarCompra(compra); //carga la compra
                if(insert == true)
                {
                    MessageBox.Show("Compra Agregada");

                    int lastId = compras_bll.getLastId();
                    if(lastId == 0)
                    {
                        lastId = 1;
                    }
                    foreach (DetalleCompra detalle in nuevaCompra) 
                    {
                        compras_bll.agregarDetalle(lastId, detalle.Id, detalle.Precio, detalle.Cantidad); //carga el detalle
                        insumos_bll.ActualizarCantidad(detalle.Id, detalle.Cantidad); //actualiza el stock

                        frmCompras Pform = Owner as frmCompras;
                        Pform.loadData();
                        this.Close();
                    }
                }   
            }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
