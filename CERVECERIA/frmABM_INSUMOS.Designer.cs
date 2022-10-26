namespace CERVECERIA
{
    partial class frmABM_INSUMOS
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
            this.cbRubro = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMARCA = new System.Windows.Forms.Label();
            this.lblCANTIDAD = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblABM = new System.Windows.Forms.Label();
            this.btnG = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbRubro
            // 
            this.cbRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRubro.FormattingEnabled = true;
            this.cbRubro.Location = new System.Drawing.Point(155, 103);
            this.cbRubro.Name = "cbRubro";
            this.cbRubro.Size = new System.Drawing.Size(196, 28);
            this.cbRubro.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(155, 150);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(196, 26);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(155, 193);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(196, 26);
            this.textBoxMarca.TabIndex = 9;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(155, 236);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(79, 26);
            this.textBoxCantidad.TabIndex = 11;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // cbProveedor
            // 
            this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(155, 279);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(196, 28);
            this.cbProveedor.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(304, 411);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 28);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(188, 337);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 26);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "AGREGAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblRubro
            // 
            this.lblRubro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRubro.BackColor = System.Drawing.Color.Transparent;
            this.lblRubro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRubro.Location = new System.Drawing.Point(19, 103);
            this.lblRubro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(131, 27);
            this.lblRubro.TabIndex = 16;
            this.lblRubro.Text = "RUBRO";
            this.lblRubro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(19, 149);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(131, 27);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "NOMBRE";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMARCA
            // 
            this.lblMARCA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMARCA.BackColor = System.Drawing.Color.Transparent;
            this.lblMARCA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMARCA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMARCA.Location = new System.Drawing.Point(19, 192);
            this.lblMARCA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMARCA.Name = "lblMARCA";
            this.lblMARCA.Size = new System.Drawing.Size(131, 27);
            this.lblMARCA.TabIndex = 18;
            this.lblMARCA.Text = "MARCA";
            this.lblMARCA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCANTIDAD
            // 
            this.lblCANTIDAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCANTIDAD.BackColor = System.Drawing.Color.Transparent;
            this.lblCANTIDAD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCANTIDAD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCANTIDAD.Location = new System.Drawing.Point(19, 235);
            this.lblCANTIDAD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCANTIDAD.Name = "lblCANTIDAD";
            this.lblCANTIDAD.Size = new System.Drawing.Size(131, 27);
            this.lblCANTIDAD.TabIndex = 19;
            this.lblCANTIDAD.Text = "CANTIDAD";
            this.lblCANTIDAD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProveedor.Location = new System.Drawing.Point(19, 279);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(131, 27);
            this.lblProveedor.TabIndex = 20;
            this.lblProveedor.Text = "PROVEEDOR";
            this.lblProveedor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblABM
            // 
            this.lblABM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblABM.BackColor = System.Drawing.Color.Black;
            this.lblABM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblABM.Location = new System.Drawing.Point(86, 33);
            this.lblABM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblABM.Name = "lblABM";
            this.lblABM.Size = new System.Drawing.Size(265, 27);
            this.lblABM.TabIndex = 21;
            this.lblABM.Text = "AGREGAR INSUMOS";
            this.lblABM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.PeachPuff;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnG.Location = new System.Drawing.Point(239, 232);
            this.btnG.Margin = new System.Windows.Forms.Padding(2);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(43, 32);
            this.btnG.TabIndex = 22;
            this.btnG.Text = "Gr";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.SandyBrown;
            this.btnK.Enabled = false;
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnK.Location = new System.Drawing.Point(275, 232);
            this.btnK.Margin = new System.Windows.Forms.Padding(2);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(43, 32);
            this.btnK.TabIndex = 23;
            this.btnK.Text = "Kg";
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // frmABM_INSUMOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.lblABM);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblCANTIDAD);
            this.Controls.Add(this.lblMARCA);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.cbRubro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmABM_INSUMOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmABM_INSUMOS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbRubro;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMARCA;
        private System.Windows.Forms.Label lblCANTIDAD;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblABM;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnK;
    }
}