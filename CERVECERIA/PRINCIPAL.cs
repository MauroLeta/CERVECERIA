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
    public partial class PRINCIPAL : Form
    {
        public PRINCIPAL()
        {
            InitializeComponent();
        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {

        }
        public void AgregarFormulario(Form f)
        {
            f.TopLevel = false;
            this.panelCentral.Controls.Clear();
            this.panelCentral.Controls.Add(f);
            f.Show();
        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            ABM formABM = new ABM();
            AgregarFormulario(formABM);
        }
    }
}
