using BE;
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
    public partial class frmAbmAgenda : Form
    {
        Agenda_bll agenda_bll = new Agenda_bll();
        UserLog usuario = new UserLog();
        DataRow data;
        DataSet dataSet = new DataSet();

        public string Idioma = "Español";
        public string ABM = "";
        public int tabla = 0;

        public frmAbmAgenda(DataSet ds,string modo,int tab,UserLog user, DataRow drow)
        {
            InitializeComponent();
            ABM = modo;
            usuario = user;
            tabla = tab;
            data = drow;
            dataSet = ds;
        }

        private void frmAbmAgenda_Load(object sender, EventArgs e)
        {
           
            Idioma idioma = new Idioma();           
            
            if (ABM == "ALTA")   //--------------------------------------acondicinamiento de labels y texbox
            {
                if (tabla == 0)
                {
                    lblABM.Text = "ALTA DE CLIENTE";
                    lblPuesto.Visible = false;
                    cbPuesto.Visible = false;
                }
                else if (tabla == 1) 
                {
                    lblABM.Text = "ALTA DE EMPLEADO";
                }
                else if (tabla == 2) 
                {
                    lblABM.Text = "ALTA DE PROVEEDOR";
                    lblPuesto.Visible = false;
                    cbPuesto.Visible = false;
                    lblApellido.Visible = false;
                    textBoxApellido.Visible = false;
                }
            } 
            else if (ABM == "EDITAR")
            {
                btnGuardar.Text = "EDITAR";
                if (tabla == 0)
                {
                    lblABM.Text = "EDITAR CLIENTE";
                    lblPuesto.Visible = false;
                    cbPuesto.Visible = false;
                }
                else if (tabla == 1)
                {
                    lblABM.Text = "EDITAR DE EMPLEADO";
                }
                else if (tabla == 2)
                {
                    lblABM.Text = "EDITAR DE PROVEEDOR";
                    lblPuesto.Visible = false;
                    cbPuesto.Visible = false;
                    lblApellido.Visible = false;
                    textBoxApellido.Visible = false;
                }
            }

            idioma.ChangeLanguaje(this, Idioma, usuario.Idioma, null);

            agenda_bll.getDataSet();
            cbPuesto.DataSource = dataSet.Tables[3];
            cbPuesto.DisplayMember = "Descripcion";
            cbPuesto.ValueMember = "Id";

            if (ABM == "EDITAR") { getInfo(); }

        }
        public void getInfo()
        {
            switch (tabla)
            {
                case 0:
                    textBoxApellido.Text = data.ItemArray[2].ToString();
                    textBoxNombre.Text = data.ItemArray[1].ToString();
                    textBoxTelefono.Text = data.ItemArray[3].ToString();
                    textBoxMail.Text = data.ItemArray[4].ToString();
                    break;
                case 1:
                    textBoxApellido.Text = data.ItemArray[2].ToString();
                    textBoxNombre.Text = data.ItemArray[1].ToString();
                    textBoxTelefono.Text = data.ItemArray[5].ToString();
                    textBoxMail.Text = data.ItemArray[6].ToString();
                    cbPuesto.Text = data.ItemArray[4].ToString();
                    break;
                case 2:
                    textBoxNombre.Text = data.ItemArray[1].ToString();
                    textBoxTelefono.Text = data.ItemArray[2].ToString();
                    textBoxMail.Text = data.ItemArray[3].ToString();
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tabla == 0)
            {
                if (textBoxApellido.Text == "" || textBoxNombre.Text == "")
                {
                    MessageBox.Show("Faltan Completar Campos");
                }
                else
                {
                    action_ABM(ABM);
                }
            }
            else if (tabla == 1)
            {
                if (textBoxApellido.Text == "" || textBoxNombre.Text == "" || cbPuesto.SelectedValue == null)
                {
                    MessageBox.Show("Faltan Completar Campos");
                }
                else
                {
                    action_ABM(ABM);
                }
            }
            else if (tabla == 2)
            {
                if (textBoxNombre.Text == "")
                {
                    MessageBox.Show("Faltan Completar Campos");
                }
                else
                {
                    action_ABM(ABM);
                }
            }
        }
        public void action_ABM(string abm)
        {
            if(abm == "ALTA") 
            {
               bool add= agenda_bll.AgregarRow(dataSet, tabla, textBoxApellido.Text, textBoxNombre.Text, textBoxTelefono.Text, textBoxMail.Text,cbPuesto.Text ,Int32.Parse(cbPuesto.SelectedValue.ToString()));   
               if(add== true)
               {
                    MessageBox.Show("Agregado correctamente");
               }                    
            }
            else if(abm == "EDITAR")
            {
                agenda_bll.ModificarRow(data,tabla, textBoxApellido.Text, textBoxNombre.Text, textBoxTelefono.Text, textBoxMail.Text,cbPuesto.Text ,Int32.Parse(cbPuesto.SelectedValue.ToString()));
                MessageBox.Show("Modificado correctamente");
            }

            frmAgenda Pform = Owner as frmAgenda;
            Pform.cambiosEnTabla();
            this.Close();
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }
        public void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
