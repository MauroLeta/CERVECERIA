using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CERVECERIA
{
    public partial class frmLUPA : Form
    {
        public bool Active = false;
        Graphics GraficoCaptura;
        Bitmap ImagenTemporal;
        Point frmMover;
        Boolean MoverMouse;
        int Zoom = 1;
        public frmLUPA()
        {
            InitializeComponent();
            
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            this.TopMost = true;
            Zoom++;          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int AnchoImagen = pictureBox1.Width;
            int AltoImagen = pictureBox1.Height;
            int MouseX = MousePosition.X;
            int MouseY = MousePosition.Y;

            //captura de pantalla
            ImagenTemporal = new Bitmap(AnchoImagen / Zoom, AltoImagen / Zoom, System.Drawing.Imaging.PixelFormat.Format64bppArgb);
            GraficoCaptura = this.CreateGraphics();
            GraficoCaptura = Graphics.FromImage(ImagenTemporal);

            //copia de pantalla
            GraficoCaptura.CopyFromScreen(MouseX - AnchoImagen / (Zoom*2 ), MouseY - AltoImagen/ (Zoom*2), 0, 0, pictureBox1.Size);
            
            //aumentar tamaño
            Bitmap NuevaImagen = new Bitmap(AnchoImagen, AltoImagen);
            GraficoCaptura = Graphics.FromImage(NuevaImagen);
            GraficoCaptura.SmoothingMode = SmoothingMode.HighQuality;
            GraficoCaptura.DrawImage(ImagenTemporal, new Rectangle(0, 0, AnchoImagen, AltoImagen));
            pictureBox1.Image = NuevaImagen;

            //forma circular
            Rectangle rect = new Rectangle(0, 0, AnchoImagen, AltoImagen);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            pictureBox1.Region = new Region(path);

            Rectangle rectp = new Rectangle(0, 0, panel1.Width, panel1.Height);
            GraphicsPath pathp = new GraphicsPath();
            pathp.AddEllipse(rectp);
            panel1.Region = new Region(pathp);

            //seguir mouse
            this.Location = new Point(Cursor.Position.X+1, Cursor.Position.Y+1);
        }
        private void frmLUPA_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            Active = true;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(MoverMouse)
            {
                Location = new Point(Cursor.Position.X - frmMover.X, Cursor.Position.Y - frmMover.Y);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MoverMouse)
            {
                frmMover = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
                MoverMouse = true;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoverMouse = false;
        }
    }
}
