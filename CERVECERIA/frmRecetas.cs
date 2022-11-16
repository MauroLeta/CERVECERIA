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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CERVECERIA
{
    public partial class frmRecetas : Form
    {
        Estilos_bll estilos_bll = new Estilos_bll();
        DataSet ds = new DataSet();
        UserLog user = new UserLog();
        DataTable tablaDetalle = new DataTable();
        public string Idioma = "Español";
        public frmRecetas(UserLog usuario)
        {
            InitializeComponent();

            user = usuario;

            tablaDetalle.Columns.Add("Producto", typeof(string));
            tablaDetalle.Columns.Add("Cantidad", typeof(float));
        }

        private void frmRecetas_Load(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma();
            idioma.ChangeLanguaje(this, Idioma, user.Idioma, null);
            loadData();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void loadData()
        {
            ds = estilos_bll.cargarEstilos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["Id"].Visible = false;
        }
        public void LoadDetail() //------------------------------------------------Expresiones regulares (Match)
        {
            tablaDetalle.Clear();
            dataGridView2.DataSource = null;

            if(dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataRow dRow in ds.Tables[1].Rows)
                {

                    Match resultado = Regex.Match(dRow[0].ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    if (resultado.Success == true)
                    {
                        DataRow row = tablaDetalle.NewRow();
                        row["Producto"] = dRow[1];
                        row["Cantidad"] = dRow[2];

                        tablaDetalle.Rows.Add(row);
                    }
                }
                dataGridView2.DataSource = tablaDetalle;
            }

           
        }
        private void btnDiseñar_Click(object sender, EventArgs e)
        {
            frmDiseñarEstilo abm = new frmDiseñarEstilo(user);
            AddOwnedForm(abm);
            abm.Show();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetail();
        }
    }
}
