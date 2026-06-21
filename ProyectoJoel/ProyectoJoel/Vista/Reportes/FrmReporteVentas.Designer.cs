namespace ProyectoJoel.Vista.Reportes
{
	partial class FrmReporteVentas
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
			this.rEPORTEVENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tiendaZapatosDataSet = new ProyectoJoel.TiendaZapatosDataSet();
			this.rEPORTE_VENTASTableAdapter = new ProyectoJoel.TiendaZapatosDataSetTableAdapters.REPORTE_VENTASTableAdapter();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.REPORTE_VENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.rEPORTEVENTASBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tiendaZapatosDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.REPORTE_VENTASBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// rEPORTEVENTASBindingSource
			// 
			this.rEPORTEVENTASBindingSource.DataMember = "REPORTE_VENTAS";
			this.rEPORTEVENTASBindingSource.DataSource = this.tiendaZapatosDataSet;
			// 
			// tiendaZapatosDataSet
			// 
			this.tiendaZapatosDataSet.DataSetName = "TiendaZapatosDataSet";
			this.tiendaZapatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// rEPORTE_VENTASTableAdapter
			// 
			this.rEPORTE_VENTASTableAdapter.ClearBeforeFill = true;
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DSReporteVentas";
			reportDataSource1.Value = this.rEPORTEVENTASBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoJoel.Reportes.ReporteVentas.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 105);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1189, 482);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
			// 
			// REPORTE_VENTASBindingSource
			// 
			this.REPORTE_VENTASBindingSource.DataMember = "REPORTE_VENTAS";
			this.REPORTE_VENTASBindingSource.DataSource = this.tiendaZapatosDataSet;
			// 
			// dtpInicio
			// 
			this.dtpInicio.Location = new System.Drawing.Point(23, 50);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(272, 22);
			this.dtpInicio.TabIndex = 1;
			// 
			// dtpFin
			// 
			this.dtpFin.Location = new System.Drawing.Point(312, 50);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(272, 22);
			this.dtpFin.TabIndex = 2;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(625, 49);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(121, 23);
			this.btnBuscar.TabIndex = 3;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(308, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Fecha Fin";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Fecha Inicio";
			// 
			// FrmReporteVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1189, 587);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.dtpInicio);
			this.Controls.Add(this.reportViewer1);
			this.Name = "FrmReporteVentas";
			this.Text = "FrmReporteVentas";
			this.Load += new System.EventHandler(this.FrmReporteVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.rEPORTEVENTASBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tiendaZapatosDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.REPORTE_VENTASBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private TiendaZapatosDataSet tiendaZapatosDataSet;
		private System.Windows.Forms.BindingSource rEPORTEVENTASBindingSource;
		private TiendaZapatosDataSetTableAdapters.REPORTE_VENTASTableAdapter rEPORTE_VENTASTableAdapter;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource REPORTE_VENTASBindingSource;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}