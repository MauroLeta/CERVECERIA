
namespace CERVECERIA
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.instaImage = new System.Windows.Forms.PictureBox();
            this.webImage = new System.Windows.Forms.PictureBox();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnBarriles = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnCoccion = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnLupa = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmPm = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SECTOR = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.lblCPU);
            this.MenuVertical.Controls.Add(this.instaImage);
            this.MenuVertical.Controls.Add(this.webImage);
            this.MenuVertical.Controls.Add(this.btnAgenda);
            this.MenuVertical.Controls.Add(this.btnBarriles);
            this.MenuVertical.Controls.Add(this.btnCompras);
            this.MenuVertical.Controls.Add(this.btnProductos);
            this.MenuVertical.Controls.Add(this.btnVentas);
            this.MenuVertical.Controls.Add(this.btnRecetas);
            this.MenuVertical.Controls.Add(this.btnCoccion);
            this.MenuVertical.Controls.Add(this.btnLogOut);
            this.MenuVertical.Controls.Add(this.btnInsumos);
            this.MenuVertical.Controls.Add(this.btnConfig);
            this.MenuVertical.Controls.Add(this.btnLupa);
            this.MenuVertical.Controls.Add(this.btnSalir);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(223, 611);
            this.MenuVertical.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(159, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "USO DE CPU:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCPU.Location = new System.Drawing.Point(158, 142);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(36, 13);
            this.lblCPU.TabIndex = 39;
            this.lblCPU.Text = "lblCpu";
            // 
            // instaImage
            // 
            this.instaImage.BackgroundImage = global::CERVECERIA.Properties.Resources.instagram;
            this.instaImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.instaImage.Location = new System.Drawing.Point(164, 54);
            this.instaImage.Name = "instaImage";
            this.instaImage.Size = new System.Drawing.Size(51, 44);
            this.instaImage.TabIndex = 38;
            this.instaImage.TabStop = false;
            this.instaImage.Click += new System.EventHandler(this.instaImage_Click);
            // 
            // webImage
            // 
            this.webImage.BackgroundImage = global::CERVECERIA.Properties.Resources.WEB;
            this.webImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.webImage.Location = new System.Drawing.Point(164, 3);
            this.webImage.Name = "webImage";
            this.webImage.Size = new System.Drawing.Size(51, 45);
            this.webImage.TabIndex = 37;
            this.webImage.TabStop = false;
            this.webImage.Click += new System.EventHandler(this.webImage_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.Location = new System.Drawing.Point(11, 458);
            this.btnAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(202, 37);
            this.btnAgenda.TabIndex = 36;
            this.btnAgenda.Text = "AGENDA";
            this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnBarriles
            // 
            this.btnBarriles.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBarriles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBarriles.FlatAppearance.BorderSize = 0;
            this.btnBarriles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBarriles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBarriles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarriles.Image = ((System.Drawing.Image)(resources.GetObject("btnBarriles.Image")));
            this.btnBarriles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarriles.Location = new System.Drawing.Point(11, 337);
            this.btnBarriles.Margin = new System.Windows.Forms.Padding(2);
            this.btnBarriles.Name = "btnBarriles";
            this.btnBarriles.Size = new System.Drawing.Size(202, 37);
            this.btnBarriles.TabIndex = 35;
            this.btnBarriles.Text = "BARRILES";
            this.btnBarriles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarriles.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(11, 213);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(202, 37);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.PeachPuff;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(11, 378);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(202, 35);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.PeachPuff;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(11, 417);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(202, 37);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnRecetas
            // 
            this.btnRecetas.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRecetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecetas.FlatAppearance.BorderSize = 0;
            this.btnRecetas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecetas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecetas.Image = global::CERVECERIA.Properties.Resources.estilos;
            this.btnRecetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecetas.Location = new System.Drawing.Point(11, 254);
            this.btnRecetas.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(202, 37);
            this.btnRecetas.TabIndex = 34;
            this.btnRecetas.Text = "RECETAS";
            this.btnRecetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecetas.UseVisualStyleBackColor = false;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            // 
            // btnCoccion
            // 
            this.btnCoccion.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCoccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoccion.FlatAppearance.BorderSize = 0;
            this.btnCoccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCoccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCoccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoccion.Image = ((System.Drawing.Image)(resources.GetObject("btnCoccion.Image")));
            this.btnCoccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoccion.Location = new System.Drawing.Point(11, 297);
            this.btnCoccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCoccion.Name = "btnCoccion";
            this.btnCoccion.Size = new System.Drawing.Size(202, 37);
            this.btnCoccion.TabIndex = 33;
            this.btnCoccion.Text = "COCCIONES ";
            this.btnCoccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCoccion.UseVisualStyleBackColor = false;
            this.btnCoccion.Click += new System.EventHandler(this.btnCoccion_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(7, 523);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(206, 33);
            this.btnLogOut.TabIndex = 32;
            this.btnLogOut.Text = "CERRAR SESIÓN";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnInsumos
            // 
            this.btnInsumos.BackColor = System.Drawing.Color.PeachPuff;
            this.btnInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsumos.FlatAppearance.BorderSize = 0;
            this.btnInsumos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsumos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsumos.Image = global::CERVECERIA.Properties.Resources.lupulo;
            this.btnInsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsumos.Location = new System.Drawing.Point(11, 172);
            this.btnInsumos.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(202, 37);
            this.btnInsumos.TabIndex = 31;
            this.btnInsumos.Text = "INSUMOS";
            this.btnInsumos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsumos.UseVisualStyleBackColor = false;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSize = true;
            this.btnConfig.BackColor = System.Drawing.Color.PeachPuff;
            this.btnConfig.BackgroundImage = global::CERVECERIA.Properties.Resources.ajustes;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfig.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfig.Location = new System.Drawing.Point(141, 561);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(33, 33);
            this.btnConfig.TabIndex = 30;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnLupa
            // 
            this.btnLupa.AutoSize = true;
            this.btnLupa.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLupa.BackgroundImage = global::CERVECERIA.Properties.Resources.pngwing_com__6_;
            this.btnLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLupa.FlatAppearance.BorderSize = 0;
            this.btnLupa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLupa.ForeColor = System.Drawing.Color.Transparent;
            this.btnLupa.Location = new System.Drawing.Point(180, 562);
            this.btnLupa.Name = "btnLupa";
            this.btnLupa.Size = new System.Drawing.Size(33, 33);
            this.btnLupa.TabIndex = 29;
            this.btnLupa.UseVisualStyleBackColor = false;
            this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(7, 562);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 33);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblAmPm);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.SECTOR);
            this.panel1.Controls.Add(this.lblSector);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 46);
            this.panel1.TabIndex = 3;
            // 
            // lblAmPm
            // 
            this.lblAmPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmPm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmPm.Location = new System.Drawing.Point(753, 15);
            this.lblAmPm.Name = "lblAmPm";
            this.lblAmPm.Size = new System.Drawing.Size(37, 20);
            this.lblAmPm.TabIndex = 18;
            this.lblAmPm.Text = "am";
            this.lblAmPm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(683, 14);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(68, 20);
            this.lblHora.TabIndex = 17;
            this.lblHora.Text = "HORA";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFecha.Location = new System.Drawing.Point(581, 14);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(103, 20);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "FECHA";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SECTOR
            // 
            this.SECTOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SECTOR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SECTOR.Location = new System.Drawing.Point(251, 15);
            this.SECTOR.Name = "SECTOR";
            this.SECTOR.Size = new System.Drawing.Size(103, 20);
            this.SECTOR.TabIndex = 12;
            this.SECTOR.Text = "SECTOR:";
            this.SECTOR.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSector.Location = new System.Drawing.Point(360, 15);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(56, 20);
            this.lblSector.TabIndex = 15;
            this.lblSector.Text = "Sector";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApellido.Location = new System.Drawing.Point(25, 14);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 20);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Location = new System.Drawing.Point(220, 50);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(805, 560);
            this.panelContenedor.TabIndex = 2;
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Procesador";
            this.performanceCounter1.CounterName = "% de tiempo de procesador";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heldig";
            this.Load += new System.EventHandler(this.PRINCIPAL_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label SECTOR;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnLupa;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAmPm;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCoccion;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.PictureBox webImage;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnBarriles;
        private System.Windows.Forms.PictureBox instaImage;
        private System.Windows.Forms.Label lblCPU;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Label label1;
    }
}