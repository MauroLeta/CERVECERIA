using BE;
using BLL;
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

namespace CERVECERIA
{
    public partial class frmRecetas : Form
    {
        UserLog user = new UserLog();

        public string Idioma = "Español";
        public frmRecetas(UserLog usuario)
        {
            InitializeComponent();

            user = usuario;
            
            
        }

        private void frmRecetas_Load(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();
            idioma.ChangeLanguaje(this, Idioma, user.Idioma, null);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
