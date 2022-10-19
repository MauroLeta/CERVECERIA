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
    public partial class frmINSUMOS : Form
    {
        IDIOMAS_BDE idiomasBDE = new IDIOMAS_BDE();
        USUARIOLOG user = new USUARIOLOG();
        INSUMOS_BDE insumos_bde = new INSUMOS_BDE();
        public string Idioma = "Español";
        public frmINSUMOS(USUARIOLOG usuario)
        {
            InitializeComponent();
            user = usuario;
            ChangeLanguaje(user.Idioma);
        }
        private void frmINSUMOS_Load(object sender, EventArgs e)
        {
            LoadDatagrid();
        }
        public void LoadDatagrid() 
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = insumos_bde.getInsumos(tabInsumos.SelectedTab.Text);
            dataGridView1.Columns["Rubro"].Visible = false;
            dataGridView1.Columns["Proveedor"].Visible = false;
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabInsumos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDatagrid();
        }



        private void tabInsumos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadDatagrid();

        }

        private void tabInsumos_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadDatagrid();
        }
    }
}
