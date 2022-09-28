
namespace CERVECERIA
{
    partial class frmLOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLOGIN));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnIngles = new System.Windows.Forms.Button();
            this.btnPortugues = new System.Windows.Forms.Button();
            this.btnEspañol = new System.Windows.Forms.Button();
            this.lblEspañol = new System.Windows.Forms.Label();
            this.lblIngles = new System.Windows.Forms.Label();
            this.lblPortuges = new System.Windows.Forms.Label();
            this.btnLupa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(1, 112);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(131, 27);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblClave
            // 
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.lblClave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClave.Location = new System.Drawing.Point(11, 168);
            this.lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(121, 27);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUser.Location = new System.Drawing.Point(131, 113);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(231, 26);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPass.Location = new System.Drawing.Point(131, 169);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(231, 26);
            this.txtPass.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmar.Location = new System.Drawing.Point(178, 219);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(135, 32);
            this.btnConfirmar.TabIndex = 2;
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
            this.lblAcceso.Location = new System.Drawing.Point(142, 29);
            this.lblAcceso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(334, 32);
            this.lblAcceso.TabIndex = 5;
            this.lblAcceso.Text = "ACCESO";
            this.lblAcceso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(432, 485);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::CERVECERIA.Properties.Resources.ojo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(366, 169);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdioma.BackColor = System.Drawing.Color.Transparent;
            this.lblIdioma.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.lblIdioma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdioma.Location = new System.Drawing.Point(410, 101);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(183, 27);
            this.lblIdioma.TabIndex = 9;
            this.lblIdioma.Text = "Idioma";
            this.lblIdioma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIngles
            // 
            this.btnIngles.AutoSize = true;
            this.btnIngles.BackColor = System.Drawing.Color.Transparent;
            this.btnIngles.BackgroundImage = global::CERVECERIA.Properties.Resources.Ingles;
            this.btnIngles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngles.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnIngles.FlatAppearance.BorderSize = 0;
            this.btnIngles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnIngles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngles.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngles.ForeColor = System.Drawing.Color.DeepPink;
            this.btnIngles.Location = new System.Drawing.Point(476, 245);
            this.btnIngles.Name = "btnIngles";
            this.btnIngles.Size = new System.Drawing.Size(50, 50);
            this.btnIngles.TabIndex = 22;
            this.btnIngles.UseVisualStyleBackColor = false;
            this.btnIngles.Click += new System.EventHandler(this.btnIngles_Click);
            // 
            // btnPortugues
            // 
            this.btnPortugues.AutoSize = true;
            this.btnPortugues.BackColor = System.Drawing.Color.Transparent;
            this.btnPortugues.BackgroundImage = global::CERVECERIA.Properties.Resources.Portugues;
            this.btnPortugues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPortugues.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnPortugues.FlatAppearance.BorderSize = 0;
            this.btnPortugues.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnPortugues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortugues.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortugues.ForeColor = System.Drawing.Color.DeepPink;
            this.btnPortugues.Location = new System.Drawing.Point(476, 353);
            this.btnPortugues.Name = "btnPortugues";
            this.btnPortugues.Size = new System.Drawing.Size(50, 50);
            this.btnPortugues.TabIndex = 23;
            this.btnPortugues.UseVisualStyleBackColor = false;
            this.btnPortugues.Click += new System.EventHandler(this.btnPortugues_Click);
            // 
            // btnEspañol
            // 
            this.btnEspañol.AutoSize = true;
            this.btnEspañol.BackColor = System.Drawing.Color.Transparent;
            this.btnEspañol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEspañol.BackgroundImage")));
            this.btnEspañol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEspañol.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnEspañol.FlatAppearance.BorderSize = 0;
            this.btnEspañol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnEspañol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspañol.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspañol.ForeColor = System.Drawing.Color.DeepPink;
            this.btnEspañol.Location = new System.Drawing.Point(476, 143);
            this.btnEspañol.Name = "btnEspañol";
            this.btnEspañol.Size = new System.Drawing.Size(50, 50);
            this.btnEspañol.TabIndex = 24;
            this.btnEspañol.UseVisualStyleBackColor = false;
            this.btnEspañol.Click += new System.EventHandler(this.btnEspañol_Click);
            // 
            // lblEspañol
            // 
            this.lblEspañol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEspañol.BackColor = System.Drawing.Color.Transparent;
            this.lblEspañol.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblEspañol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEspañol.Location = new System.Drawing.Point(453, 196);
            this.lblEspañol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspañol.Name = "lblEspañol";
            this.lblEspañol.Size = new System.Drawing.Size(94, 34);
            this.lblEspañol.TabIndex = 25;
            this.lblEspañol.Text = "Español";
            this.lblEspañol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIngles
            // 
            this.lblIngles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngles.BackColor = System.Drawing.Color.Transparent;
            this.lblIngles.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblIngles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngles.Location = new System.Drawing.Point(458, 298);
            this.lblIngles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngles.Name = "lblIngles";
            this.lblIngles.Size = new System.Drawing.Size(89, 33);
            this.lblIngles.TabIndex = 26;
            this.lblIngles.Text = "Inglés";
            this.lblIngles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPortuges
            // 
            this.lblPortuges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPortuges.BackColor = System.Drawing.Color.Transparent;
            this.lblPortuges.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblPortuges.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPortuges.Location = new System.Drawing.Point(439, 406);
            this.lblPortuges.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortuges.Name = "lblPortuges";
            this.lblPortuges.Size = new System.Drawing.Size(128, 32);
            this.lblPortuges.TabIndex = 27;
            this.lblPortuges.Text = "Portugués";
            this.lblPortuges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLupa
            // 
            this.btnLupa.AutoSize = true;
            this.btnLupa.BackColor = System.Drawing.Color.White;
            this.btnLupa.BackgroundImage = global::CERVECERIA.Properties.Resources.pngwing_com__6_;
            this.btnLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLupa.FlatAppearance.BorderSize = 0;
            this.btnLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupa.ForeColor = System.Drawing.Color.Transparent;
            this.btnLupa.Location = new System.Drawing.Point(12, 483);
            this.btnLupa.Name = "btnLupa";
            this.btnLupa.Size = new System.Drawing.Size(45, 40);
            this.btnLupa.TabIndex = 28;
            this.btnLupa.UseVisualStyleBackColor = false;
            this.btnLupa.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 528);
            this.Controls.Add(this.btnLupa);
            this.Controls.Add(this.lblPortuges);
            this.Controls.Add(this.lblIngles);
            this.Controls.Add(this.lblEspañol);
            this.Controls.Add(this.btnEspañol);
            this.Controls.Add(this.btnPortugues);
            this.Controls.Add(this.btnIngles);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAcceso);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnIngles;
        private System.Windows.Forms.Button btnPortugues;
        private System.Windows.Forms.Button btnEspañol;
        private System.Windows.Forms.Label lblEspañol;
        private System.Windows.Forms.Label lblIngles;
        private System.Windows.Forms.Label lblPortuges;
        private System.Windows.Forms.Button btnLupa;
    }
}

