using PESCADOFINAL.Conexion;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class FrmReporteVents : Form
	{
		private DateTime fechaInicio;
		private DateTime fechaFin;

		public FrmReporteVents()
		{
			InitializeComponent();

			fechaInicio = DateTime.Now.Date;
			fechaFin = DateTime.Now.Date;
		}

		public FrmReporteVents(DateTime inicio, DateTime fin)
		{
			InitializeComponent();

			fechaInicio = inicio.Date;
			fechaFin = fin.Date;
		}

		private DataTable CargarReporteVentas(DateTime inicio, DateTime fin)
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				ConexionBD.ObtenerConexion();

			SqlCommand cmd =
				new SqlCommand("REPORTE_VENTAS_FECHAS", conexion);

			cmd.CommandType =
				CommandType.StoredProcedure;

			cmd.Parameters.AddWithValue("@FechaInicio", inicio.Date);
			cmd.Parameters.AddWithValue("@FechaFin", fin.Date);

			SqlDataAdapter da =
				new SqlDataAdapter(cmd);

			da.Fill(dt);

			if (conexion.State == ConnectionState.Open)
				conexion.Close();

			return dt;
		}

		private void FrmReporteVents_Load(object sender, EventArgs e)
		{
			btnBuscar.Text = "Buscar";

			dtInicio.Value = fechaInicio;
			dtFin.Value = fechaFin;

			CargarReporte(fechaInicio, fechaFin);
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (dtInicio.Value.Date > dtFin.Value.Date)
			{
				MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.");
				return;
			}

			CargarReporte(
				dtInicio.Value.Date,
				dtFin.Value.Date);
		}

		private void CargarReporte(DateTime inicio, DateTime fin)
		{
			DataTable dt =
				CargarReporteVentas(inicio, fin);

			if (dt.Rows.Count == 0)
			{
				reportViewer1.LocalReport.DataSources.Clear();
				reportViewer1.RefreshReport();

				MessageBox.Show("No existen ventas en ese rango de fechas.");
				return;
			}

			reportViewer1.LocalReport.DataSources.Clear();

			reportViewer1.LocalReport.DataSources.Add(
				new ReportDataSource("DSReporte", dt));

			reportViewer1.RefreshReport();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}