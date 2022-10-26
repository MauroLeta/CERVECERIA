
namespace CERVECERIA
{
    partial class frmPRINCIPAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRINCIPAL));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.submenuReportes = new System.Windows.Forms.Panel();
            this.btnrptpagos = new System.Windows.Forms.Button();
            this.btnrptcompras = new System.Windows.Forms.Button();
            this.btnrptventa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmPm = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SECTOR = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCoccion = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnLupa = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.submenuReportes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuVertical.Controls.Add(this.btnCoccion);
            this.MenuVertical.Controls.Add(this.btnLogOut);
            this.MenuVertical.Controls.Add(this.btnInsumos);
            this.MenuVertical.Controls.Add(this.btnConfig);
            this.MenuVertical.Controls.Add(this.btnLupa);
            this.MenuVertical.Controls.Add(this.submenuReportes);
            this.MenuVertical.Controls.Add(this.btnSalir);
            this.MenuVertical.Controls.Add(this.btnReportes);
            this.MenuVertical.Controls.Add(this.btnPagos);
            this.MenuVertical.Controls.Add(this.btnCompras);
            this.MenuVertical.Controls.Add(this.btnClientes);
            this.MenuVertical.Controls.Add(this.btnVentas);
            this.MenuVertical.Controls.Add(this.btnProductos);
            this.MenuVertical.Controls.Add(this.btnEmpleados);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(223, 885);
            this.MenuVertical.TabIndex = 1;
            // 
            // submenuReportes
            // 
            this.submenuReportes.Controls.Add(this.btnrptpagos);
            this.submenuReportes.Controls.Add(this.btnrptcompras);
            this.submenuReportes.Controls.Add(this.btnrptventa);
            this.submenuReportes.Location = new System.Drawing.Point(52, 623);
            this.submenuReportes.Margin = new System.Windows.Forms.Padding(2);
            this.submenuReportes.Name = "submenuReportes";
            this.submenuReportes.Size = new System.Drawing.Size(132, 100);
            this.submenuReportes.TabIndex = 8;
            this.submenuReportes.Visible = false;
            // 
            // btnrptpagos
            // 
            this.btnrptpagos.BackColor = System.Drawing.Color.DarkGray;
            this.btnrptpagos.FlatAppearance.BorderSize = 0;
            this.btnrptpagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnrptpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptpagos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptpagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptpagos.Location = new System.Drawing.Point(0, 70);
            this.btnrptpagos.Margin = new System.Windows.Forms.Padding(2);
            this.btnrptpagos.Name = "btnrptpagos";
            this.btnrptpagos.Size = new System.Drawing.Size(132, 30);
            this.btnrptpagos.TabIndex = 9;
            this.btnrptpagos.Text = "REPORTE PAGOS";
            this.btnrptpagos.UseVisualStyleBackColor = false;
            this.btnrptpagos.Click += new System.EventHandler(this.btnrptpagos_Click);
            // 
            // btnrptcompras
            // 
            this.btnrptcompras.BackColor = System.Drawing.Color.DarkGray;
            this.btnrptcompras.FlatAppearance.BorderSize = 0;
            this.btnrptcompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnrptcompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptcompras.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptcompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptcompras.Location = new System.Drawing.Point(-1, 35);
            this.btnrptcompras.Margin = new System.Windows.Forms.Padding(2);
            this.btnrptcompras.Name = "btnrptcompras";
            this.btnrptcompras.Size = new System.Drawing.Size(132, 30);
            this.btnrptcompras.TabIndex = 8;
            this.btnrptcompras.Text = "REPORTE COMPRAS";
            this.btnrptcompras.UseVisualStyleBackColor = false;
            this.btnrptcompras.Click += new System.EventHandler(this.btnrptcompras_Click);
            // 
            // btnrptventa
            // 
            this.btnrptventa.BackColor = System.Drawing.Color.DarkGray;
            this.btnrptventa.FlatAppearance.BorderSize = 0;
            this.btnrptventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnrptventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptventa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptventa.Location = new System.Drawing.Point(0, 0);
            this.btnrptventa.Margin = new System.Windows.Forms.Padding(2);
            this.btnrptventa.Name = "btnrptventa";
            this.btnrptventa.Size = new System.Drawing.Size(132, 30);
            this.btnrptventa.TabIndex = 7;
            this.btnrptventa.Text = "REPORTE VENTAS";
            this.btnrptventa.UseVisualStyleBackColor = false;
            this.btnrptventa.Click += new System.EventHandler(this.btnrptventa_Click);
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
            this.panel1.Size = new System.Drawing.Size(1082, 46);
            this.panel1.TabIndex = 3;
            // 
            // lblAmPm
            // 
            this.lblAmPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmPm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmPm.Location = new System.Drawing.Point(1010, 15);
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
            this.lblHora.Location = new System.Drawing.Point(940, 14);
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
            this.lblFecha.Location = new System.Drawing.Point(838, 14);
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
            this.SECTOR.Location = new System.Drawing.Point(469, 15);
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
            this.lblSector.Location = new System.Drawing.Point(578, 15);
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
            this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContenedor.Location = new System.Drawing.Point(220, 50);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1082, 837);
            this.panelContenedor.TabIndex = 2;
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
            this.btnCoccion.Location = new System.Drawing.Point(20, 283);
            this.btnCoccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCoccion.Name = "btnCoccion";
            this.btnCoccion.Size = new System.Drawing.Size(175, 41);
            this.btnCoccion.TabIndex = 33;
            this.btnCoccion.Text = "COCCIONES ";
            this.btnCoccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCoccion.UseVisualStyleBackColor = false;
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
            this.btnLogOut.Location = new System.Drawing.Point(9, 790);
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
            this.btnInsumos.Location = new System.Drawing.Point(20, 229);
            this.btnInsumos.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(175, 41);
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
            this.btnConfig.Location = new System.Drawing.Point(143, 840);
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
            this.btnLupa.Location = new System.Drawing.Point(182, 841);
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
            this.btnSalir.Location = new System.Drawing.Point(9, 841);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 33);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.DarkGray;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(20, 588);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(164, 30);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.DarkGray;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagos.Image")));
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(20, 553);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(164, 30);
            this.btnPagos.TabIndex = 6;
            this.btnPagos.Text = "PAGOS";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.DarkGray;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(20, 518);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(164, 30);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.DarkGray;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(20, 483);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(164, 30);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.DarkGray;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(20, 448);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(164, 30);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.DarkGray;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(18, 414);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(164, 30);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(20, 378);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(164, 30);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "EMPLEADOS";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 885);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPRINCIPAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PRINCIPAL_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.submenuReportes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel submenuReportes;
        private System.Windows.Forms.Button btnrptpagos;
        private System.Windows.Forms.Button btnrptcompras;
        private System.Windows.Forms.Button btnrptventa;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnClientes;
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
    }
}