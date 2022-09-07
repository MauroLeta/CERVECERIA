using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;


namespace CERVECERIA
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            // LO PUSE ACA PARA QUE FUNCIONE, ESTA CREADO EN LA CAPA DATOS 
            SqlConnection conexion = new SqlConnection(@"Data Source = MAURO\SQLEXPRESS; Initial Catalog = CERVECERIA; Integrated Security = True");
            conexion.Open();
            //------------------------------------------------------------------------------------------------------------------------------------    
            

            string consulta = "Select * from Usuario where Usuario = '" + txtUser.Text + "' and Contraseña = '" + txtPass.Text + "' ";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                ABM frmABM = new ABM();
                this.Hide();
                frmABM.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOjo_Click(object sender, EventArgs e)
        {
            // TENGO QUE PODER MOSTRAR Y ESCONDER LA CONTRASEÑA HACIENDO CLICK ACA
            
            if(txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
            }
            else if (txtPass.PasswordChar == '\0')
            {
                txtPass.PasswordChar = '*';
            }


        }
    }
}
