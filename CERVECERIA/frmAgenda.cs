using BE;
using BLL;
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

namespace CERVECERIA
{
    public partial class frmAgenda : Form
    {
        Agenda_bll agenda_bll = new Agenda_bll();
        UserLog user = new UserLog();
        public DataSet ds = new DataSet();

        public string Idioma = "Español";
        int nTabla = 0;
        public bool changes = false;
        public frmAgenda(UserLog usuario)
        {
            InitializeComponent();
            user = usuario;
            Idioma idioma = new Idioma();
            idioma.ChangeLanguaje(this, Idioma, user.Idioma, null);
            ds = agenda_bll.getDataSet();
        }

        private void fmrAgenda_Load(object sender, EventArgs e)
        {
            LoadDatagrid();
        }
        public void LoadDatagrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[nTabla];

            switch (nTabla)
            {
                case 0:
                    dataGridView1.Columns["id"].Visible = false;
                    break;
                case 1:
                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns["Cargo"].Visible = false;
                    break;
                case 2:
                    dataGridView1.Columns["idProv"].Visible = false;
                    break;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.SandyBrown;
            btnEmpleados.BackColor = Color.PeachPuff;
            btnProveedores.BackColor = Color.PeachPuff;
            nTabla = 0;
            LoadDatagrid();
            btnGenerarUsuario.Visible = false;
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.PeachPuff;
            btnEmpleados.BackColor = Color.SandyBrown;
            btnProveedores.BackColor = Color.PeachPuff;
            nTabla = 1;
            LoadDatagrid();
            btnGenerarUsuario.Visible = true;
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.PeachPuff;
            btnEmpleados.BackColor = Color.PeachPuff;
            btnProveedores.BackColor = Color.SandyBrown;
            nTabla = 2;
            LoadDatagrid();
            btnGenerarUsuario.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAbmAgenda abm = new frmAbmAgenda(ds,"ALTA",nTabla, user, null);
            AddOwnedForm(abm);
            abm.Show();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Seleccione una fila con datos");
            }
            else
            {
                DataRow drow = ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row;
                frmAbmAgenda abm = new frmAbmAgenda(ds, "EDITAR", nTabla, user, drow);
                AddOwnedForm(abm);
                abm.Show();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            if ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Seleccione una fila con datos");
            }
            else
            {
                DialogResult resul = MessageBox.Show("¿Seguro que quiere eliminar la fila seleccionada? ", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    agenda_bll.BorrarFila(((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row);

                    frmAgenda Pform = Owner as frmAgenda;
                    Pform.cambiosEnTabla();
                }
            }           
        }

        private void btnGenerarUsuario_Click(object sender, EventArgs e)
        {
            DataRow drow = ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row;
            frmAltaUser altaUser = new frmAltaUser(user, drow);
            AddOwnedForm(altaUser);
            altaUser.Show();
        }

        private void btnDescartarCambio_Click(object sender, EventArgs e)
        {
            agenda_bll.DescartarCambios(ds);
            cambiosEnTabla();
        }
        private void btnGuardarCambio_Click(object sender, EventArgs e)
        {
            bool guardar = agenda_bll.GuardarCambios(ds);
            cambiosEnTabla();

            if (guardar == true)
            {
                MessageBox.Show("Guardado Correctamente");
            }
        }

        public void cambiosEnTabla()
        {
            bool cambios = agenda_bll.getChanges(ds);
            changes = cambios;

            if (cambios == true)
            {
                btnGuardarCambio.Visible = true;
                btnDescartarCambio.Visible = true;
            }
            else
            {
                btnGuardarCambio.Visible = false;
                btnDescartarCambio.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(changes == true)
            {
                DialogResult resul = MessageBox.Show("Hay cambios sin guardar, ¿desea cerrar de todos modos?", "Cerrar", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else 
            {
                this.Close();
            }
        }

 
    }
}
