namespace PESCADOFINAL.VISTA
{
    partial class FrmReporteCategoria
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteCategoria));
			this.eSTADISTICAINGRESOSCATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pezFinalDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pezFinalDataSet2 = new PESCADOFINAL.PezFinalDataSet2();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.eSTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter = new PESCADOFINAL.PezFinalDataSet2TableAdapters.ESTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter();
			this.eSTADISTICA_INGRESOS_CATEGORIATableAdapter = new PESCADOFINAL.PezFinalDataSet2TableAdapters.ESTADISTICA_INGRESOS_CATEGORIATableAdapter();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.eSTADISTICAINGRESOSCATEGORIABindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet2BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// eSTADISTICAINGRESOSCATEGORIABindingSource
			// 
			this.eSTADISTICAINGRESOSCATEGORIABindingSource.DataMember = "ESTADISTICA_INGRESOS_CATEGORIA";
			this.eSTADISTICAINGRESOSCATEGORIABindingSource.DataSource = this.pezFinalDataSet2BindingSource;
			// 
			// pezFinalDataSet2BindingSource
			// 
			this.pezFinalDataSet2BindingSource.DataSource = this.pezFinalDataSet2;
			this.pezFinalDataSet2BindingSource.Position = 0;
			// 
			// pezFinalDataSet2
			// 
			this.pezFinalDataSet2.DataSetName = "PezFinalDataSet2";
			this.pezFinalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "PESCADOFINAL.REPORTES.ReporteCategoria.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(165, 10);
			this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(689, 394);
			this.reportViewer1.TabIndex = 0;
			// 
			// eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource
			// 
			this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource.DataMember = "ESTADISTICA_PRODUCTOS_MAS_VENDIDOS";
			this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource.DataSource = this.pezFinalDataSet2BindingSource;
			// 
			// eSTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter
			// 
			this.eSTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter.ClearBeforeFill = true;
			// 
			// eSTADISTICA_INGRESOS_CATEGORIATableAdapter
			// 
			this.eSTADISTICA_INGRESOS_CATEGORIATableAdapter.ClearBeforeFill = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(20, 96);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 42);
			this.button1.TabIndex = 1;
			this.button1.Text = "Volver al Menu ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(20, 159);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(126, 47);
			this.button2.TabIndex = 2;
			this.button2.Text = "Reporte Bivariado";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// FrmReporteCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(866, 432);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.reportViewer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmReporteCategoria";
			this.Text = "FrmReporteCategoria";
			this.Load += new System.EventHandler(this.FrmReporteCategoria_Load);
			((System.ComponentModel.ISupportInitialize)(this.eSTADISTICAINGRESOSCATEGORIABindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet2BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pezFinalDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PezFinalDataSet2 pezFinalDataSet2;
        private System.Windows.Forms.BindingSource pezFinalDataSet2BindingSource;
        private System.Windows.Forms.BindingSource eSTADISTICAPRODUCTOSMASVENDIDOSBindingSource;
        private PezFinalDataSet2TableAdapters.ESTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter eSTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter;
        private System.Windows.Forms.BindingSource eSTADISTICAINGRESOSCATEGORIABindingSource;
        private PezFinalDataSet2TableAdapters.ESTADISTICA_INGRESOS_CATEGORIATableAdapter eSTADISTICA_INGRESOS_CATEGORIATableAdapter;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}