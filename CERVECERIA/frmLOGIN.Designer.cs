
namespace CERVECERIA
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnIngles = new System.Windows.Forms.Button();
            this.btnPortugues = new System.Windows.Forms.Button();
            this.btnEspañol = new System.Windows.Forms.Button();
            this.btnLupa = new System.Windows.Forms.Button();
            this.lblEspañol = new System.Windows.Forms.Label();
            this.lblIngles = new System.Windows.Forms.Label();
            this.lblPortugues = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new CERVECERIA.CustomTextBox();
            this.txtUser = new CERVECERIA.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.BackColor = System.Drawing.Color.Black;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(37, 88);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(96, 27);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblClave
            // 
            this.lblClave.BackColor = System.Drawing.Color.Black;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClave.Location = new System.Drawing.Point(37, 147);
            this.lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(96, 27);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(143, 199);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(173, 32);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblAcceso
            // 
            this.lblAcceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcceso.BackColor = System.Drawing.Color.Black;
            this.lblAcceso.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcceso.Location = new System.Drawing.Point(71, 35);
            this.lblAcceso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(341, 32);
            this.lblAcceso.TabIndex = 1;
            this.lblAcceso.Text = "ACCESO";
            this.lblAcceso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(474, 440);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::CERVECERIA.Properties.Resources.ojo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(370, 140);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdioma.BackColor = System.Drawing.Color.Black;
            this.lblIdioma.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdioma.Location = new System.Drawing.Point(458, 55);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(134, 27);
            this.lblIdioma.TabIndex = 9;
            this.lblIdioma.Text = "Idioma";
            this.lblIdioma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIngles
            // 
            this.btnIngles.AutoSize = true;
            this.btnIngles.BackColor = System.Drawing.Color.Black;
            this.btnIngles.BackgroundImage = global::CERVECERIA.Properties.Resources.Ingles;
            this.btnIngles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngles.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnIngles.FlatAppearance.BorderSize = 0;
            this.btnIngles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnIngles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngles.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngles.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnIngles.Location = new System.Drawing.Point(502, 217);
            this.btnIngles.Name = "btnIngles";
            this.btnIngles.Size = new System.Drawing.Size(50, 50);
            this.btnIngles.TabIndex = 5;
            this.btnIngles.UseVisualStyleBackColor = false;
            this.btnIngles.Click += new System.EventHandler(this.btnIngles_Click);
            // 
            // btnPortugues
            // 
            this.btnPortugues.AutoSize = true;
            this.btnPortugues.BackColor = System.Drawing.Color.Black;
            this.btnPortugues.BackgroundImage = global::CERVECERIA.Properties.Resources.Portugues;
            this.btnPortugues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPortugues.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnPortugues.FlatAppearance.BorderSize = 0;
            this.btnPortugues.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnPortugues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortugues.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortugues.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPortugues.Location = new System.Drawing.Point(502, 321);
            this.btnPortugues.Name = "btnPortugues";
            this.btnPortugues.Size = new System.Drawing.Size(50, 50);
            this.btnPortugues.TabIndex = 6;
            this.btnPortugues.UseVisualStyleBackColor = false;
            this.btnPortugues.Click += new System.EventHandler(this.btnPortugues_Click);
            // 
            // btnEspañol
            // 
            this.btnEspañol.AutoSize = true;
            this.btnEspañol.BackColor = System.Drawing.Color.Black;
            this.btnEspañol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEspañol.BackgroundImage")));
            this.btnEspañol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEspañol.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnEspañol.FlatAppearance.BorderSize = 0;
            this.btnEspañol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnEspañol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspañol.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspañol.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnEspañol.Location = new System.Drawing.Point(502, 115);
            this.btnEspañol.Name = "btnEspañol";
            this.btnEspañol.Size = new System.Drawing.Size(50, 50);
            this.btnEspañol.TabIndex = 4;
            this.btnEspañol.UseVisualStyleBackColor = false;
            this.btnEspañol.Click += new System.EventHandler(this.btnEspañol_Click);
            // 
            // btnLupa
            // 
            this.btnLupa.AutoSize = true;
            this.btnLupa.BackColor = System.Drawing.Color.Transparent;
            this.btnLupa.BackgroundImage = global::CERVECERIA.Properties.Resources.pngwing_com__6_;
            this.btnLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLupa.FlatAppearance.BorderSize = 0;
            this.btnLupa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.btnLupa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.btnLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupa.ForeColor = System.Drawing.Color.Transparent;
            this.btnLupa.Location = new System.Drawing.Point(12, 483);
            this.btnLupa.Name = "btnLupa";
            this.btnLupa.Size = new System.Drawing.Size(45, 40);
            this.btnLupa.TabIndex = 28;
            this.btnLupa.UseVisualStyleBackColor = false;
            this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
            // 
            // lblEspañol
            // 
            this.lblEspañol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEspañol.BackColor = System.Drawing.Color.Black;
            this.lblEspañol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspañol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEspañol.Location = new System.Drawing.Point(463, 165);
            this.lblEspañol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspañol.Name = "lblEspañol";
            this.lblEspañol.Size = new System.Drawing.Size(129, 27);
            this.lblEspañol.TabIndex = 29;
            this.lblEspañol.Text = "Español";
            this.lblEspañol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIngles
            // 
            this.lblIngles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngles.BackColor = System.Drawing.Color.Black;
            this.lblIngles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngles.Location = new System.Drawing.Point(464, 268);
            this.lblIngles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngles.Name = "lblIngles";
            this.lblIngles.Size = new System.Drawing.Size(128, 27);
            this.lblIngles.TabIndex = 30;
            this.lblIngles.Text = "Inglés";
            this.lblIngles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPortugues
            // 
            this.lblPortugues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPortugues.BackColor = System.Drawing.Color.Black;
            this.lblPortugues.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortugues.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPortugues.Location = new System.Drawing.Point(461, 371);
            this.lblPortugues.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortugues.Name = "lblPortugues";
            this.lblPortugues.Size = new System.Drawing.Size(131, 27);
            this.lblPortugues.TabIndex = 31;
            this.lblPortugues.Text = "Portugués";
            this.lblPortugues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(454, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 426);
            this.label1.TabIndex = 33;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 188);
            this.label2.TabIndex = 34;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPass.BorderColor = System.Drawing.Color.Red;
            this.txtPass.BorderFocusColor = System.Drawing.Color.PeachPuff;
            this.txtPass.BorderSize = 2;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPass.Location = new System.Drawing.Point(143, 140);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(7);
            this.txtPass.PasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(207, 36);
            this.txtPass.TabIndex = 3;
            this.txtPass.Texts = "";
            this.txtPass.UnderlinedStyle = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtUser.BorderColor = System.Drawing.Color.Red;
            this.txtUser.BorderFocusColor = System.Drawing.Color.PeachPuff;
            this.txtUser.BorderSize = 2;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUser.Location = new System.Drawing.Point(139, 81);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(7);
            this.txtUser.PasswordChar = false;
            this.txtUser.Size = new System.Drawing.Size(211, 34);
            this.txtUser.TabIndex = 2;
            this.txtUser.Texts = "";
            this.txtUser.UnderlinedStyle = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 528);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPortugues);
            this.Controls.Add(this.lblIngles);
            this.Controls.Add(this.lblEspañol);
            this.Controls.Add(this.btnLupa);
            this.Controls.Add(this.btnEspañol);
            this.Controls.Add(this.btnPortugues);
            this.Controls.Add(this.btnIngles);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAcceso);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heldig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnIngles;
        private System.Windows.Forms.Button btnPortugues;
        private System.Windows.Forms.Button btnEspañol;
        private System.Windows.Forms.Button btnLupa;
        private System.Windows.Forms.Label lblEspañol;
        private System.Windows.Forms.Label lblIngles;
        private System.Windows.Forms.Label lblPortugues;
        private CustomTextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomTextBox txtPass;
    }
}

