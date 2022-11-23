namespace CERVECERIA
{
    partial class frmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.lblClave = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.btnGenerarUsuario = new System.Windows.Forms.Button();
            this.btnDescartarCambio = new System.Windows.Forms.Button();
            this.btnGuardarCambio = new System.Windows.Forms.Button();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblTieneUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(45, 99);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(164, 37);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(209, 99);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(164, 37);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "EMPLEADOS";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // lblClave
            // 
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClave.Location = new System.Drawing.Point(40, 59);
            this.lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(121, 27);
            this.lblClave.TabIndex = 43;
            this.lblClave.Text = "BUSCAR";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(166, 59);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(371, 26);
            this.textBoxSearch.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(285, 470);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 32);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(165, 470);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 32);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(45, 470);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 32);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView1.Location = new System.Drawing.Point(45, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 332);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Location = new System.Drawing.Point(659, 517);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(135, 32);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.PeachPuff;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(373, 99);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(164, 37);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // lblAcceso
            // 
            this.lblAcceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcceso.BackColor = System.Drawing.Color.Black;
            this.lblAcceso.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcceso.Location = new System.Drawing.Point(-1, 2);
            this.lblAcceso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(812, 32);
            this.lblAcceso.TabIndex = 61;
            this.lblAcceso.Text = "AGENDA";
            this.lblAcceso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGenerarUsuario
            // 
            this.btnGenerarUsuario.BackColor = System.Drawing.Color.PeachPuff;
            this.btnGenerarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerarUsuario.Location = new System.Drawing.Point(44, 510);
            this.btnGenerarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarUsuario.Name = "btnGenerarUsuario";
            this.btnGenerarUsuario.Size = new System.Drawing.Size(356, 32);
            this.btnGenerarUsuario.TabIndex = 62;
            this.btnGenerarUsuario.Text = "GENERAR USUARIO";
            this.btnGenerarUsuario.UseVisualStyleBackColor = false;
            this.btnGenerarUsuario.Visible = false;
            this.btnGenerarUsuario.Click += new System.EventHandler(this.btnGenerarUsuario_Click);
            // 
            // btnDescartarCambio
            // 
            this.btnDescartarCambio.BackColor = System.Drawing.Color.Tomato;
            this.btnDescartarCambio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDescartarCambio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDescartarCambio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDescartarCambio.Location = new System.Drawing.Point(565, 99);
            this.btnDescartarCambio.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescartarCambio.Name = "btnDescartarCambio";
            this.btnDescartarCambio.Size = new System.Drawing.Size(200, 32);
            this.btnDescartarCambio.TabIndex = 63;
            this.btnDescartarCambio.Text = "DESCARTAR CAMBIOS";
            this.btnDescartarCambio.UseVisualStyleBackColor = false;
            this.btnDescartarCambio.Visible = false;
            this.btnDescartarCambio.Click += new System.EventHandler(this.btnDescartarCambio_Click);
            // 
            // btnGuardarCambio
            // 
            this.btnGuardarCambio.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardarCambio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCambio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarCambio.Location = new System.Drawing.Point(565, 54);
            this.btnGuardarCambio.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCambio.Name = "btnGuardarCambio";
            this.btnGuardarCambio.Size = new System.Drawing.Size(200, 32);
            this.btnGuardarCambio.TabIndex = 64;
            this.btnGuardarCambio.Text = "GUARDAR CAMBIOS";
            this.btnGuardarCambio.UseVisualStyleBackColor = false;
            this.btnGuardarCambio.Visible = false;
            this.btnGuardarCambio.Click += new System.EventHandler(this.btnGuardarCambio_Click);
            // 
            // lblUs
            // 
            this.lblUs.BackColor = System.Drawing.Color.Transparent;
            this.lblUs.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUs.Location = new System.Drawing.Point(404, 471);
            this.lblUs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(121, 27);
            this.lblUs.TabIndex = 65;
            this.lblUs.Text = "USUARIO:";
            this.lblUs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblUs.Visible = false;
            // 
            // lblTieneUsuario
            // 
            this.lblTieneUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTieneUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieneUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTieneUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieneUsuario.Location = new System.Drawing.Point(529, 471);
            this.lblTieneUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieneUsuario.Name = "lblTieneUsuario";
            this.lblTieneUsuario.Size = new System.Drawing.Size(223, 27);
            this.lblTieneUsuario.TabIndex = 66;
            this.lblTieneUsuario.Text = "-";
            this.lblTieneUsuario.Visible = false;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 560);
            this.Controls.Add(this.lblTieneUsuario);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.btnGuardarCambio);
            this.Controls.Add(this.btnDescartarCambio);
            this.Controls.Add(this.btnGenerarUsuario);
            this.Controls.Add(this.lblAcceso);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgenda";
            this.Text = "fmrAdm";
            this.Load += new System.EventHandler(this.fmrAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.Button btnGenerarUsuario;
        private System.Windows.Forms.Button btnDescartarCambio;
        private System.Windows.Forms.Button btnGuardarCambio;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblTieneUsuario;
    }
}