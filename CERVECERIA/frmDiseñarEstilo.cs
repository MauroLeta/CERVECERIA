using BE;
using BLL;
using DINAMICA_DE_ENTIDADES;
using ENTIDADES;
using IDIOMA;
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
    public partial class frmDiseñarEstilo : Form
    {
        Insumos_bll insumos_bll = new Insumos_bll();
        Estilos_bll estilos_bll = new Estilos_bll();
        UserLog user = new UserLog();

        List<Insumo> listaInsumo = new List<Insumo>();
        List<DetalleReceta> nuevaReceta = new List<DetalleReceta>();

        public string Idioma = "Español";
        public string Medida = "Kg";
        public frmDiseñarEstilo(UserLog usuario)
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

        private void frmDiseñarEstilo_Load(object sender, EventArgs e)
        {
            var tablas = new List<int> { 0, 1, 2, 3 };
            foreach (int tabla in tablas)
            {
                listaInsumo.AddRange(insumos_bll.ListarInsumos(tabla));
            }
            AutoCompleteStringCollection coleccionInsumo = new AutoCompleteStringCollection();

            comboBoxProducto.DataSource = listaInsumo;
            comboBoxProducto.DisplayMember = "Nombre";
            comboBoxProducto.ValueMember = "Id";

            foreach (Insumo insumo in listaInsumo)
            {
                coleccionInsumo.Add(insumo.Nombre);
            }
            comboBoxProducto.AutoCompleteCustomSource = coleccionInsumo;
            comboBoxProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnKg_Click(object sender, EventArgs e)
        {
            btnGr.BackColor = Color.PeachPuff;
            btnGr.Enabled = true;
            btnKg.BackColor = Color.SandyBrown;
            btnKg.Enabled = false;
            Medida = "Kg";
            if (textBoxCantidad.Text != "")
            {
                textBoxCantidad.Text = (double.Parse(textBoxCantidad.Text) / 1000).ToString();
            }
        }
        private void btnGr_Click(object sender, EventArgs e)
        {
            btnGr.BackColor = Color.SandyBrown;
            btnGr.Enabled = false;
            btnKg.BackColor = Color.PeachPuff;
            btnKg.Enabled = true;
            Medida = "Gr";
            if (textBoxCantidad.Text != "")
            {
                textBoxCantidad.Text = (double.Parse(textBoxCantidad.Text) * 1000).ToString();
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
                DetalleReceta detalle = dataGridView1.CurrentRow.DataBoundItem as DetalleReceta;
                nuevaReceta.Remove(detalle);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = nuevaReceta;
                dataGridView1.Columns["id"].Visible = false;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "")
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
                DetalleReceta detalle = new DetalleReceta(insumo.Id, insumo.Nombre, cantidad);
                nuevaReceta.Add(detalle);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = nuevaReceta;
                dataGridView1.Columns["id"].Visible = false;
                textBoxCantidad.Text = "";
            }
        }
        public void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarReceta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Faltan ingresar datos");
                return;
            }
            else
            {
                Estilo estilo = new Estilo(0, textBoxNombre.Text, user.Id);
                bool insert = estilos_bll.agregarEstilo(estilo);
                if (insert == true)
                {
                    MessageBox.Show("Estilo Agregado");

                    int lastId = estilos_bll.getLastId();
                    if (lastId == 0)
                    {
                        lastId = 1;
                    }
                    foreach (DetalleReceta detalle in nuevaReceta)
                    {
                        estilos_bll.agregarDetalle(lastId, detalle.Id, detalle.Cantidad); //carga el detalle

                        frmRecetas Pform = Owner as frmRecetas;
                        Pform.loadData();
                        this.Close();
                    }
                }
            }
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }
    }
}
