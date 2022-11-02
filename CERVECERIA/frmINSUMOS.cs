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
        public string Grilla = "MALTA";
        public string Medida = "Kg";

        public frmINSUMOS(USUARIOLOG usuario)
        {
            InitializeComponent();
            user = usuario;
            ChangeLanguaje(user.Idioma);
        }
        private void frmINSUMOS_Load(object sender, EventArgs e)
        {
            LoadDatagrid(false,"");
        }
        public void LoadDatagrid(bool search, string buscador)
        {
            string tabla = Grilla;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = insumos_bde.getInsumos(tabla, search,buscador);
            dataGridView1.Columns["Rubro"].Visible = false;
            dataGridView1.Columns["Proveedor"].Visible = false;
            dataGridView1.Columns["id"].Visible = false;
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
        private void btnLupulo_Click(object sender, EventArgs e)
        {
            btnMalta.BackColor = Color.PeachPuff;
            btnLupulo.BackColor = Color.SandyBrown;
            btnLevadura.BackColor = Color.PeachPuff;
            btnAdiciones.BackColor = Color.PeachPuff;
            Grilla = "LUPULO";
            LoadDatagrid(false, "");

            if(Medida == "Gr")
            {
                medidaA_GR();
            }
        }
        private void btnMalta_Click(object sender, EventArgs e)
        {
            btnMalta.BackColor = Color.SandyBrown;
            btnLupulo.BackColor = Color.PeachPuff;
            btnLevadura.BackColor = Color.PeachPuff;
            btnAdiciones.BackColor = Color.PeachPuff;
            Grilla = "MALTA";
            LoadDatagrid(false, "");

            if (Medida == "Gr")
            {
                medidaA_GR();
            }
        }
        private void btnLevadura_Click(object sender, EventArgs e)
        {
            btnMalta.BackColor = Color.PeachPuff;
            btnLupulo.BackColor = Color.PeachPuff;
            btnLevadura.BackColor = Color.SandyBrown;
            btnAdiciones.BackColor = Color.PeachPuff;
            Grilla = "LEVADURA";
            LoadDatagrid(false, "");

            if (Medida == "Gr")
            {
                medidaA_GR();
            }
        }
        private void btnAdiciones_Click(object sender, EventArgs e)
        {
            btnMalta.BackColor = Color.PeachPuff;
            btnLupulo.BackColor = Color.PeachPuff;
            btnLevadura.BackColor = Color.PeachPuff;
            btnAdiciones.BackColor = Color.SandyBrown;
            Grilla = "ADICIONES";
            LoadDatagrid(false, "");

            if (Medida == "Gr")
            {
                medidaA_GR();
            }
        }

        public void medidaA_GR()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Cantidad"].Value = double.Parse(row.Cells["Cantidad"].Value.ToString()) * 1000;
            }
            btnG.BackColor = Color.SandyBrown;
            btnG.Enabled = false;
            btnK.BackColor = Color.PeachPuff;
            btnK.Enabled = true;
            Medida = "Gr";
        }
        public void medidaA_KG()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Cantidad"].Value = double.Parse(row.Cells["Cantidad"].Value.ToString()) / 1000;
            }
            btnG.BackColor = Color.PeachPuff;
            btnG.Enabled = true;
            btnK.BackColor = Color.SandyBrown;
            btnK.Enabled = false;
            Medida = "Kg";
        }
        private void btnKg_Click(object sender, EventArgs e)
        {
            medidaA_GR();
        }
        private void btnGr_Click(object sender, EventArgs e)
        {
            medidaA_KG();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABM_INSUMOS abm = new frmABM_INSUMOS("ALTA", user, null);
            AddOwnedForm(abm);
            abm.Show();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            else
            {
                INSUMO insumo = dataGridView1.CurrentRow.DataBoundItem as INSUMO;
                frmABM_INSUMOS abm = new frmABM_INSUMOS("EDITAR", user, insumo);
                AddOwnedForm(abm);
                abm.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            else 
            { 
                INSUMO insumo = dataGridView1.CurrentRow.DataBoundItem as INSUMO;

                DialogResult resul = MessageBox.Show("¿Seguro que quiere eliminar " + insumo.Nombre + " ?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    insumos_bde.EliminarInsumo(insumo.Id);
                    LoadDatagrid(false, "");
                }
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDatagrid(true, textBoxSearch.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
