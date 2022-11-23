using BE;
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
    public partial class frmCoccion : Form
    {
        UserLog user = new UserLog();
        public string Idioma = "Español";
        public frmCoccion(BE.UserLog usuario)
        {
            InitializeComponent();
            user = usuario;
            Idioma idioma = new Idioma();
            idioma.ChangeLanguaje(this, Idioma, user.Idioma, null);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAbmCoccion abm = new frmAbmCoccion("ALTA",user);
            AddOwnedForm(abm);
            abm.Show();
        }
    }
}
