using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CERVECERIA
{
    public partial class ABM : Form
    {
        public ABM()
        {
            InitializeComponent();
        }

        private void ABM_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source = MAURO\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True");
            conexion.Open();
            string consulta = "select * from Empleados";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtApellido.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtCargo.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source = MAURO\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True");
            conexion.Open();

            String consulta = "update Empleados set codigo= " + txtCodigo.Text + ", nombre= '" + txtNombre.Text + "', apellido= '" + txtApellido.Text + "', cargo= '" + txtCargo.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("El registro ha sido modificado correctamente");
            }
            llenarTabla();
            limpiarCampos();

            conexion.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source = MAURO\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True");
            conexion.Open();

            string consulta = "insert into Empleados values (" + txtCodigo.Text + " , '" + txtNombre.Text + "' , '" + txtApellido.Text + "' , '" + txtCargo.Text + "')";
            
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("El registro ha sido agregado correctamente");
            llenarTabla();
            limpiarCampos();

            conexion.Close();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source = MAURO\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True");
            conexion.Open();

            string consulta = "delete from Empleados where codigo = " + txtCodigo.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();            
            llenarTabla();
            limpiarCampos();
            MessageBox.Show("El registro ha sido eliminado correctamente");

            conexion.Close();

        }

        public void llenarTabla()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source = MAURO\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True");
            conexion.Open();
            string consulta = "select * from Empleados";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        } // ACTUALIZA LOS REGISTROS DEL DATAGRIDVIEW 

        public void limpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCargo.Clear();
            txtCodigo.Focus();
        } // LIMPIEZA DE TEXTBOXS





    }
}
