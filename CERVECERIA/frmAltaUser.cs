using BE;
using DINAMICA_DE_ENTIDADES;
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
using Microsoft.Win32; // espacio de nombre para registry

namespace CERVECERIA
{
    public partial class frmAltaUser : Form
    {
        Agenda_bll agenda_bll = new Agenda_bll();
        UserLog usuario = new UserLog();
        DataRow data;

        static RegistryKey BaseFolderPath = Registry.CurrentUser;
        static string subFolderPath = "Usuarios_CerveceriaHeldig";

        public string Idioma = "Español";
        public frmAltaUser(UserLog user, DataRow drow)
        {
            InitializeComponent();
            usuario = user;
            data = drow;
        }

        private void frmAltaUser_Load(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();
            idioma.ChangeLanguaje(this, Idioma, usuario.Idioma, null);
            lblApellido.Text = data.ItemArray[2].ToString();
            lblNombre.Text = data.ItemArray[1].ToString();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(textBoxUsuario.Text == "" || textBoxClave.Text == "" || textBoxClave2.Text == "")
            {
                MessageBox.Show("Faltan Completar Datos");
            }
            else if(textBoxClave.Text != textBoxClave2.Text)
            {
                MessageBox.Show("Las Contraseñas no coinciden");
            }
            else
            {
                bool generar = agenda_bll.GenerarUsuario(data.ItemArray[1].ToString(), data.ItemArray[2].ToString(), Int32.Parse(data.ItemArray[3].ToString()), textBoxUsuario.Text, textBoxClave.Text);

                if (generar == true)
                {
                    Registry_write(data.ItemArray[0].ToString(), textBoxUsuario.Text);
                    MessageBox.Show("Usuario Agregado");
                    this.Close();
                }
            }
        }
        public static void Registry_write(string idEmpleado, string usuario)   //------Registry Write
        {
            RegistryKey RegKey = BaseFolderPath;
            RegistryKey subKey = RegKey.CreateSubKey(subFolderPath);
            subKey.SetValue(idEmpleado, usuario); 
        } 

        public void mostrarContraseña(TextBox texboxPass,PictureBox ojo)
        {
            if (texboxPass.PasswordChar == '*')
            {
                ojo.BackgroundImage = Properties.Resources.ojoTachado;
                texboxPass.PasswordChar = '\0';
            }
            else
            {
                texboxPass.PasswordChar = '*';
                ojo.BackgroundImage = Properties.Resources.ojo1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mostrarContraseña(textBoxClave, pictureBox1);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mostrarContraseña(textBoxClave2, pictureBox2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
