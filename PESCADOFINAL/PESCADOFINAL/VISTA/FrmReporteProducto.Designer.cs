namespace PESCADOFINAL.VISTA
{
    partial class FrmReporteProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteProducto));
            this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pezFinalDataSet2 = new PESCADOFINAL.PezFinalDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eSTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter = new PESCADOFINAL.PezFinalDataSet2TableAdapters.ESTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter();
            this.botonReportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource
            // 
            this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource.DataMember = "ESTADISTICA_PRODUCTOS_MAS_VENDIDOS";
            this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource.DataSource = this.pezFinalDataSet2;
            // 
            // pezFinalDataSet2
            // 
            this.pezFinalDataSet2.DataSetName = "PezFinalDataSet2";
            this.pezFinalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSReporteProducto";
            reportDataSource1.Value = this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PESCADOFINAL.REPORTES.ReporteProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(177, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(785, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // eSTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter
            // 
            this.eSTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter.ClearBeforeFill = true;
            // 
            // botonReportes
            // 
            this.botonReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReportes.Location = new System.Drawing.Point(12, 21);
            this.botonReportes.Name = "botonReportes";
            this.botonReportes.Size = new System.Drawing.Size(138, 65);
            this.botonReportes.TabIndex = 14;
            this.botonReportes.Text = "Volver al Menu";
            this.botonReportes.UseVisualStyleBackColor = true;
            this.botonReportes.Click += new System.EventHandler(this.botonReportes_Click);
            // 
            // FrmReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 540);
            this.Controls.Add(this.botonReportes);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteProducto";
            this.Text = "FrmReporteProducto";
            this.Load += new System.EventHandler(this.FrmReporteProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PezFinalDataSet2 pezFinalDataSet2;
        private System.Windows.Forms.BindingSource eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource;
        private PezFinalDataSet2TableAdapters.ESTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter eSTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter;
        private System.Windows.Forms.Button botonReportes;
    }
}