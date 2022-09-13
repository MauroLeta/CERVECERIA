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
using DINAMICA_DE_ENTIDADES;
using ENTIDADES;

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
            LOGIN_BDE login = new LOGIN_BDE();
            USUARIOLOG usuario = new USUARIOLOG();

            usuario = login.login(txtUser.Text, txtPass.Text);

            if(usuario != null)
            {
                PRINCIPAL form = new PRINCIPAL();
                AddOwnedForm(form);
                form.Show();
                this.Visible = false;
            }
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
