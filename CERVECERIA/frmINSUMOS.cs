using BLL;
using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDIOMA;

namespace CERVECERIA
{
    public partial class frmInsumos : Form
    {
        Insumos_bll insumos_bll = new Insumos_bll();

        UserLog user = new UserLog();

        public string idio = "Español";
        public string Medida = "Kg";
        public int nActual = 0;
        public frmInsumos(UserLog usuario)
        {
            InitializeComponent();
            user = usuario;
            Idioma idioma = new Idioma();
            idioma.ChangeLanguaje(this, idio, user.Idioma, null);
            insumos_bll.getDataSet();
        }

        private void frmINSUMOS_Load(object sender, EventArgs e)
        {
            insumos_bll.getDataSet();
            LoadDatagrid(nActual);
        }
        public void LoadDatagrid(int tab)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = insumos_bll.ListarInsumos(tab);
           dataGridView1.Columns["rubro"].Visible = false;
           dataGridView1.Columns["Proveedor"].Visible = false;
           dataGridView1.Columns["id"].Visible = false;
        }
        public void Reload()
        {
            if (textBoxSearch.Text == "")
            {
                insumos_bll.getDataSet();
                LoadDatagrid(nActual);
            }
            else
            {
                LoadDatagrid(nActual);
            }
        }

        private void btnLupulo_Click(object sender, EventArgs e)
        {
            btnMalta.BackColor = Color.PeachPuff;
            btnLupulo.BackColor = Color.SandyBrown;
            btnLevadura.BackColor = Color.PeachPuff;
            btnAdiciones.BackColor = Color.PeachPuff;
            LoadDatagrid(1);
            nActual = 1;

            if (Medida == "Gr")
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
            LoadDatagrid(0);
            nActual = 0;

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
            LoadDatagrid(2);
            nActual = 2;

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
             LoadDatagrid(3);
            nActual = 3;

            if (Medida == "Gr")
            {
                medidaA_GR();
            }
        }

        private void btnKg_Click(object sender, EventArgs e)
        {
            medidaA_GR();
        }
        private void btnGr_Click(object sender, EventArgs e)
        {
            medidaA_KG();
        }
        public void medidaA_GR()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Cantidad"].Value != null)
                {
                    row.Cells["Cantidad"].Value = double.Parse(row.Cells["Cantidad"].Value.ToString()) * 1000;
                }                
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
                if (row.Cells["Cantidad"].Value != null)
                {
                    row.Cells["Cantidad"].Value = double.Parse(row.Cells["Cantidad"].Value.ToString()) / 1000;
                }                 
            }
            btnG.BackColor = Color.PeachPuff;
            btnG.Enabled = true;
            btnK.BackColor = Color.SandyBrown;
            btnK.Enabled = false;
            Medida = "Kg";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAbmInsumos abm = new frmAbmInsumos("ALTA", user, null);
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
                Insumo insumo = dataGridView1.SelectedRows[0].DataBoundItem as Insumo;

                frmAbmInsumos abm = new frmAbmInsumos("EDITAR", user, insumo);
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
                Insumo selectedInsumo = dataGridView1.SelectedRows[0].DataBoundItem as Insumo;          

                DialogResult resul = MessageBox.Show("¿Seguro que quiere eliminar "+ selectedInsumo.Nombre +"?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    insumos_bll.EliminarInsumo(selectedInsumo.Id);
                    Reload();
                }
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            insumos_bll.BuscarInsumos(textBoxSearch.Text);
            Reload();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
