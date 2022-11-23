using BE;
using DINAMICA_DE_ENTIDADES;
using IDIOMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; //*---------------------------------------
using System.Diagnostics; //--espacio de nombre para EventLog
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public bool mailOk = false;

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
                    lblABM.Text = "EDITAR EMPLEADO";
                }
                else if (tabla == 2)
                {
                    lblABM.Text = "EDITAR PROVEEDOR";
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

                    //EventLogCerveceria();
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
                if(mailOk != true)
                {
                    MessageBox.Show("El eMail no es valido");
                }
                else
                {
                    bool add = agenda_bll.AgregarRow(dataSet, tabla, textBoxApellido.Text, textBoxNombre.Text, textBoxTelefono.Text, textBoxMail.Text, cbPuesto.Text, Int32.Parse(cbPuesto.SelectedValue.ToString()));
                    if (add == true)
                    {
                        MessageBox.Show("Agregado correctamente");
                    }
                }                  
            }
            else if(abm == "EDITAR")
            {
                if (mailOk != true)
                {
                    MessageBox.Show("El eMail no es valido");
                }
                else
                {
                    agenda_bll.ModificarRow(data, tabla, textBoxApellido.Text, textBoxNombre.Text, textBoxTelefono.Text, textBoxMail.Text, cbPuesto.Text, Int32.Parse(cbPuesto.SelectedValue.ToString()));
                    MessageBox.Show("Modificado correctamente");
                }
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

        private void textBoxMail_TextChanged(object sender, EventArgs e) // ------------Uso expresiones regulares para validar el mail
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            if (emailRegex.IsMatch(textBoxMail.Text) == false)
            {
                textBoxMail.BackColor = Color.IndianRed;
            }
            else
            {
                textBoxMail.BackColor = Color.LightGreen;
                mailOk = true;
            }
        }

        static void EventLogCerveceria()  //------------------------------Event Log
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\lucas\\Desktop\\EventosCerveceria\\Registro.txt");

            if (EventLog.Exists("EventLog"))
            {
                EventLog.CreateEventSource("Aplicacion de Registro", "EventLogCerveceria");
            }

            DateTime dt = DateTime.Now;
            string fecha = dt.ToString("dd/MM/YYYY");

            EventLog eventLog = new EventLog("EventLogCerveceria");
            eventLog.Source = "Aplicacion de Registro";
            eventLog.WriteEntry(fecha + "Error!!!");

            Console.WriteLine("EventLog Enviado");
            Console.ReadKey();
            Console.Clear();

            foreach (EventLogEntry entry in eventLog.Entries)
            {
                sw.WriteLine(entry.Message);
                sw.Close();
            }

        } 
    }
}
