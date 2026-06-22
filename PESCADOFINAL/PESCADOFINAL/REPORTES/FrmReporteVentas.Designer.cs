namespace PESCADOFINAL.REPORTES
{
    partial class Form1
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
			this.productO_REPORTE_STOCK_CRITICOTableAdapter1 = new PESCADOFINAL.BD_pescadoFinalDataSetTableAdapters.PRODUCTO_REPORTE_STOCK_CRITICOTableAdapter();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.pezFinalDataSet1 = new PESCADOFINAL.PezFinalDataSet1();
			this.pezFinalDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.REPORTE_VENTAS_FECHASBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.REPORTE_VENTAS_FECHASBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// productO_REPORTE_STOCK_CRITICOTableAdapter1
			// 
			this.productO_REPORTE_STOCK_CRITICOTableAdapter1.ClearBeforeFill = true;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DSReporte";
			reportDataSource1.Value = this.pezFinalDataSet1BindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "PESCADOFINAL.REPORTES.ReportePerido.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(830, 385);
			this.reportViewer1.TabIndex = 0;
			// 
			// pezFinalDataSet1
			// 
			this.pezFinalDataSet1.DataSetName = "PezFinalDataSet1";
			this.pezFinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pezFinalDataSet1BindingSource
			// 
			this.pezFinalDataSet1BindingSource.DataSource = this.pezFinalDataSet1;
			this.pezFinalDataSet1BindingSource.Position = 0;
			// 
			// REPORTE_VENTAS_FECHASBindingSource
			// 
			this.REPORTE_VENTAS_FECHASBindingSource.DataMember = "REPORTE_VENTAS_FECHAS";
			this.REPORTE_VENTAS_FECHASBindingSource.DataSource = this.pezFinalDataSet1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 385);
			this.Controls.Add(this.reportViewer1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.REPORTE_VENTAS_FECHASBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private BD_pescadoFinalDataSetTableAdapters.PRODUCTO_REPORTE_STOCK_CRITICOTableAdapter productO_REPORTE_STOCK_CRITICOTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource pezFinalDataSet1BindingSource;
		private PezFinalDataSet1 pezFinalDataSet1;
		private System.Windows.Forms.BindingSource REPORTE_VENTAS_FECHASBindingSource;
	}
}