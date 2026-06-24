using Microsoft.Reporting.WinForms;
using PESCADOFINAL.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class FrmReporteBivariado : Form
	{
		public FrmReporteBivariado()
		{
			InitializeComponent();
		}

		private void FrmReporteBivariado_Load(object sender, EventArgs e)
		{
			CargarReporte();

			this.reportViewer1.RefreshReport();
		}

		private void CargarReporte()
		{
			DataTable dt = new DataTable();

			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd =
					new SqlCommand(
						"REPORTE_BIVARIADO_CATEGORIA",
						c);

				cmd.CommandType =
					CommandType.StoredProcedure;

				SqlDataAdapter da =
					new SqlDataAdapter(cmd);

				da.Fill(dt);

				reportViewer1.LocalReport.DataSources.Clear();

				reportViewer1.LocalReport.DataSources.Add(
					new ReportDataSource("DSReporteBivariado", dt));

				reportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Error al cargar reporte:\n" +
					ex.Message);
			}
			finally
			{
				if (c.State == ConnectionState.Open)
					c.Close();
			}
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}