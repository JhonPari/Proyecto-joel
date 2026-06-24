namespace PESCADOFINAL.VISTA
{
	partial class FrmReporteVents
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
            this.rEPORTEVENTASFECHASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pezFinalDataSet1 = new PESCADOFINAL.PezFinalDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pezFinalDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORTE_VENTAS_FECHASTableAdapter = new PESCADOFINAL.PezFinalDataSet1TableAdapters.REPORTE_VENTAS_FECHASTableAdapter();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTEVENTASFECHASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rEPORTEVENTASFECHASBindingSource
            // 
            this.rEPORTEVENTASFECHASBindingSource.DataMember = "REPORTE_VENTAS_FECHAS";
            this.rEPORTEVENTASFECHASBindingSource.DataSource = this.pezFinalDataSet1;
            // 
            // pezFinalDataSet1
            // 
            this.pezFinalDataSet1.DataSetName = "PezFinalDataSet1";
            this.pezFinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSReporte";
            reportDataSource1.Value = this.rEPORTEVENTASFECHASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PESCADOFINAL.REPORTES.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 79);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(962, 483);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // pezFinalDataSet1BindingSource
            // 
            this.pezFinalDataSet1BindingSource.DataSource = this.pezFinalDataSet1;
            this.pezFinalDataSet1BindingSource.Position = 0;
            // 
            // rEPORTE_VENTAS_FECHASTableAdapter
            // 
            this.rEPORTE_VENTAS_FECHASTableAdapter.ClearBeforeFill = true;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(14, 32);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(292, 26);
            this.dtInicio.TabIndex = 1;
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(324, 32);
            this.dtFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(292, 26);
            this.dtFin.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(636, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 40);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Volver al Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmReporteVents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReporteVents";
            this.Text = "FrmReporteVents";
            this.Load += new System.EventHandler(this.FrmReporteVents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTEVENTASFECHASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource rEPORTEVENTASFECHASBindingSource;
		private PezFinalDataSet1 pezFinalDataSet1;
		private System.Windows.Forms.BindingSource pezFinalDataSet1BindingSource;
		private PezFinalDataSet1TableAdapters.REPORTE_VENTAS_FECHASTableAdapter rEPORTE_VENTAS_FECHASTableAdapter;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.DateTimePicker dtFin;
		private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button1;
    }
}