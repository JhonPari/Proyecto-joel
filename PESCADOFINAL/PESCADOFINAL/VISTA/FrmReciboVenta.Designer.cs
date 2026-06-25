namespace PESCADOFINAL.VISTA
{
	partial class FrmReciboVenta
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
			this.pezFinalDataSet3 = new PESCADOFINAL.PezFinalDataSet3();
			this.rECIBOVENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rECIBO_VENTATableAdapter = new PESCADOFINAL.PezFinalDataSet3TableAdapters.RECIBO_VENTATableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rECIBOVENTABindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DSReciboVenta";
			reportDataSource1.Value = this.rECIBOVENTABindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "PESCADOFINAL.REPORTES.ReciboVentas.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(800, 450);
			this.reportViewer1.TabIndex = 0;
			// 
			// pezFinalDataSet3
			// 
			this.pezFinalDataSet3.DataSetName = "PezFinalDataSet3";
			this.pezFinalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// rECIBOVENTABindingSource
			// 
			this.rECIBOVENTABindingSource.DataMember = "RECIBO_VENTA";
			this.rECIBOVENTABindingSource.DataSource = this.pezFinalDataSet3;
			// 
			// rECIBO_VENTATableAdapter
			// 
			this.rECIBO_VENTATableAdapter.ClearBeforeFill = true;
			// 
			// FrmReciboVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.reportViewer1);
			this.Name = "FrmReciboVenta";
			this.Text = "FrmReciboVenta";
			this.Load += new System.EventHandler(this.FrmReciboVenta_Load);
			((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rECIBOVENTABindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource rECIBOVENTABindingSource;
		private PezFinalDataSet3 pezFinalDataSet3;
		private PezFinalDataSet3TableAdapters.RECIBO_VENTATableAdapter rECIBO_VENTATableAdapter;
	}
}