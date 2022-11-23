namespace CERVECERIA
{
    partial class frmReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cERVECERIADataSet = new CERVECERIA.CERVECERIADataSet();
            this.insumosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insumosTableAdapter = new CERVECERIA.CERVECERIADataSetTableAdapters.InsumosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cERVECERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.insumosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CERVECERIA.ReportInsumos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cERVECERIADataSet
            // 
            this.cERVECERIADataSet.DataSetName = "CERVECERIADataSet";
            this.cERVECERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insumosBindingSource
            // 
            this.insumosBindingSource.DataMember = "Insumos";
            this.insumosBindingSource.DataSource = this.cERVECERIADataSet;
            // 
            // insumosTableAdapter
            // 
            this.insumosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cERVECERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CERVECERIADataSet cERVECERIADataSet;
        private System.Windows.Forms.BindingSource insumosBindingSource;
        private CERVECERIADataSetTableAdapters.InsumosTableAdapter insumosTableAdapter;
    }
}