using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CERVECERIA
{
    public partial class frmWatcher : Form
    {
        string Path = @"C:\Users\lucas\Documents\GitHub\CERVECERIA\CarpetaHeldig";
        public frmWatcher()
        {
            InitializeComponent();
        }

        private void frmWatcher_Load(object sender, EventArgs e)
        {
            fileSystemWatcher1.Path = Path;
            
            GetFiles();
        }

        private void GetFiles()
        {
            string[] lista = Directory.GetFiles(Path);

            textBox1.Text = "";
            foreach (var sFile in lista)
            {
                textBox1.Text += sFile + Environment.NewLine;
            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            GetFiles();
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            GetFiles();
        }
    }
}
