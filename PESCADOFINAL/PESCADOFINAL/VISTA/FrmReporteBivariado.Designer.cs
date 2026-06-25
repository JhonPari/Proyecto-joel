namespace PESCADOFINAL.VISTA
{
	partial class FrmReporteBivariado
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
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.btnMenu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "PESCADOFINAL.REPORTES.ReportesBivariados.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 68);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(800, 382);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// btnMenu
			// 
			this.btnMenu.Location = new System.Drawing.Point(656, 12);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(132, 23);
			this.btnMenu.TabIndex = 10;
			this.btnMenu.Text = "Volver Menu";
			this.btnMenu.UseVisualStyleBackColor = true;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// FrmReporteBivariado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnMenu);
			this.Controls.Add(this.reportViewer1);
			this.Name = "FrmReporteBivariado";
			this.Text = "FrmReporteBivariado";
			this.Load += new System.EventHandler(this.FrmReporteBivariado_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.Button btnMenu;
	}
}