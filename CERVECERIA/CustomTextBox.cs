using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CERVECERIA
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBox : UserControl
    {
        // -----------------------------------------------------Campos
        private Color borderColor = Color.Red;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.Red;
        private bool isFocused = false;
        
        public CustomTextBox()
        {
            InitializeComponent();
        }
        // -------------------------------------------------------------------Eventos
        public event EventHandler _TextChanged;//evento predeterminado
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);

            validar();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        //---------------------------------------------------Propiedades
        [Category("CustomTextBox")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("CustomTextBox")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("CustomTextBox")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        [Category("CustomTextBox")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        [Category("CustomTextBox")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("CustomTextBox")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("CustomTextBox")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("CustomTextBoxe")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("CustomTextBox")]
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        [Category("CustomTextBox")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }
        [Category("CustomTextBox")]

        //-------------------------------------------------------------------------------------Invalidar Metodos de evento
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;//Set Border color in focus. Otherwise, normal border color
                if (underlinedStyle) //Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else //Normal Style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
            validar();
        }

        private void UpdateControlHeight() //--establecer alto
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        //----------------------------------------------------------------Cambiar cuando enfoca
        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            isFocused = true;
            underlinedStyle = true;
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size +3.0F, textBox1.Font.Style, textBox1.Font.Unit);
            this.Invalidate();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size - 3.0F, textBox1.Font.Style, textBox1.Font.Unit);
            validar();
            this.Invalidate();
        }

        public void validar() 
        {
            if(textBox1.Text =="")
            {
                borderColor = Color.Red;
                underlinedStyle = false;
            }
            else if(textBox1.Text !="") 
            {
                borderColor = Color.LightGreen;
                underlinedStyle = true;
            }
                
        }

    }
}
