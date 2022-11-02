using DINAMICA_DE_ENTIDADES;
using ENTIDADES;
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
    public partial class frmCOMPRAS : Form
    {
        IDIOMAS_BDE idiomasBDE = new IDIOMAS_BDE();
        USUARIOLOG user = new USUARIOLOG();

        public string Idioma = "Español";
        public frmCOMPRAS(USUARIOLOG usuario)
        {
            InitializeComponent();
            user = usuario;
            ChangeLanguaje(user.Idioma);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAGREGARCOMPRA formCompras = new frmAGREGARCOMPRA(user);
            AddOwnedForm(formCompras);
            formCompras.Show();
        }
    }
}
