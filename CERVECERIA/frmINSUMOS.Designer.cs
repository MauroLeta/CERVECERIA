namespace CERVECERIA
{
    partial class frmInsumos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsumos));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMalta = new System.Windows.Forms.Button();
            this.btnLupulo = new System.Windows.Forms.Button();
            this.btnLevadura = new System.Windows.Forms.Button();
            this.btnAdiciones = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.btnInforme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(630, 506);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "CERRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(45, 169);
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
            this.dataGridView1.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(45, 506);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 32);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(184, 506);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 32);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(323, 506);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 32);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMalta
            // 
            this.btnMalta.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMalta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMalta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnMalta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMalta.Location = new System.Drawing.Point(45, 139);
            this.btnMalta.Margin = new System.Windows.Forms.Padding(2);
            this.btnMalta.Name = "btnMalta";
            this.btnMalta.Size = new System.Drawing.Size(120, 32);
            this.btnMalta.TabIndex = 2;
            this.btnMalta.Text = "MALTA";
            this.btnMalta.UseVisualStyleBackColor = false;
            this.btnMalta.Click += new System.EventHandler(this.btnMalta_Click);
            // 
            // btnLupulo
            // 
            this.btnLupulo.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLupulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLupulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLupulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLupulo.Location = new System.Drawing.Point(163, 139);
            this.btnLupulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnLupulo.Name = "btnLupulo";
            this.btnLupulo.Size = new System.Drawing.Size(120, 32);
            this.btnLupulo.TabIndex = 3;
            this.btnLupulo.Text = "LUPULO";
            this.btnLupulo.UseVisualStyleBackColor = false;
            this.btnLupulo.Click += new System.EventHandler(this.btnLupulo_Click);
            // 
            // btnLevadura
            // 
            this.btnLevadura.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLevadura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLevadura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevadura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLevadura.Location = new System.Drawing.Point(281, 139);
            this.btnLevadura.Margin = new System.Windows.Forms.Padding(2);
            this.btnLevadura.Name = "btnLevadura";
            this.btnLevadura.Size = new System.Drawing.Size(120, 32);
            this.btnLevadura.TabIndex = 4;
            this.btnLevadura.Text = "LEVADURA";
            this.btnLevadura.UseVisualStyleBackColor = false;
            this.btnLevadura.Click += new System.EventHandler(this.btnLevadura_Click);
            // 
            // btnAdiciones
            // 
            this.btnAdiciones.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAdiciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdiciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdiciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdiciones.Location = new System.Drawing.Point(400, 139);
            this.btnAdiciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdiciones.Name = "btnAdiciones";
            this.btnAdiciones.Size = new System.Drawing.Size(120, 32);
            this.btnAdiciones.TabIndex = 5;
            this.btnAdiciones.Text = "ADICIONES";
            this.btnAdiciones.UseVisualStyleBackColor = false;
            this.btnAdiciones.Click += new System.EventHandler(this.btnAdiciones_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.SandyBrown;
            this.btnK.Enabled = false;
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnK.Location = new System.Drawing.Point(721, 139);
            this.btnK.Margin = new System.Windows.Forms.Padding(2);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(43, 32);
            this.btnK.TabIndex = 6;
            this.btnK.TabStop = false;
            this.btnK.Text = "Kg";
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnGr_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.PeachPuff;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnG.Location = new System.Drawing.Point(684, 139);
            this.btnG.Margin = new System.Windows.Forms.Padding(2);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(43, 32);
            this.btnG.TabIndex = 7;
            this.btnG.TabStop = false;
            this.btnG.Text = "Gr";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnKg_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(166, 88);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(405, 26);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lblClave
            // 
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClave.Location = new System.Drawing.Point(40, 88);
            this.lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(121, 27);
            this.lblClave.TabIndex = 12;
            this.lblClave.Text = "BUSCAR";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAcceso
            // 
            this.lblAcceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcceso.BackColor = System.Drawing.Color.Black;
            this.lblAcceso.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcceso.Location = new System.Drawing.Point(-3, -1);
            this.lblAcceso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(812, 32);
            this.lblAcceso.TabIndex = 13;
            this.lblAcceso.Text = "INSUMOS";
            this.lblAcceso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.PeachPuff;
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInforme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnInforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInforme.Location = new System.Drawing.Point(630, 88);
            this.btnInforme.Margin = new System.Windows.Forms.Padding(2);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(135, 32);
            this.btnInforme.TabIndex = 14;
            this.btnInforme.Text = "INFORME";
            this.btnInforme.UseVisualStyleBackColor = false;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // frmInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 560);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.lblAcceso);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnAdiciones);
            this.Controls.Add(this.btnLevadura);
            this.Controls.Add(this.btnLupulo);
            this.Controls.Add(this.btnMalta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInsumos";
            this.Text = "frmINSUMOS";
            this.Load += new System.EventHandler(this.frmINSUMOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMalta;
        private System.Windows.Forms.Button btnLupulo;
        private System.Windows.Forms.Button btnLevadura;
        private System.Windows.Forms.Button btnAdiciones;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.Button btnInforme;
    }
}