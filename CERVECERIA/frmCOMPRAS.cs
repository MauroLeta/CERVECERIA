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
using System.Text.RegularExpressions;

using System.Xml;
using IDIOMA;

namespace CERVECERIA
{
    public partial class frmCompras : Form
    {
        Compras_bll compras_bll = new Compras_bll();

        UserLog user = new UserLog();
        DataSet ds = new DataSet();
        DataTable tablaDetalle = new DataTable();
        public string Idioma = "Español";
        public frmCompras(UserLog usuario)
        {
            InitializeComponent();
            user = usuario;
            Idioma idioma = new Idioma();
            idioma.ChangeLanguaje(this, Idioma, user.Idioma, null);

            tablaDetalle.Columns.Add("Producto", typeof(string));
            tablaDetalle.Columns.Add("Precio", typeof(float));
            tablaDetalle.Columns.Add("Cantidad", typeof(float));
        }
        private void frmCompras_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCompra formCompras = new frmAgregarCompra(user);
            AddOwnedForm(formCompras);
            formCompras.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = compras_bll.Busqueda(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.Columns["Id"].Visible = false;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["Id"].Visible = false;
        }

        public void loadData()
        {
            ds = compras_bll.cargarCompras();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["Id"].Visible = false;
        }
        public void LoadDetail() //------------------------------------------------Expresiones regulares (Match)
        {
            tablaDetalle.Clear();
            dataGridView2.DataSource = null;

            foreach (DataRow dRow in ds.Tables[1].Rows) 
            {
                Match resultado = Regex.Match(dRow[0].ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());  
                
                if(resultado.Success == true) 
                {
                    DataRow row = tablaDetalle.NewRow();
                    row["Producto"] = dRow[1];
                    row["Precio"] = dRow[2];
                    row["Cantidad"] = dRow[3];

                    tablaDetalle.Rows.Add(row);
                }
            }
            dataGridView2.DataSource = tablaDetalle;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetail();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}



