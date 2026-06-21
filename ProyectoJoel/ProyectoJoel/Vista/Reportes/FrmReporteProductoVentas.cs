using ProyectoJoel.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoJoel.Vista.Reportes
{
	public partial class FrmReporteProductoVentas : Form
	{
		public FrmReporteProductoVentas()
		{
			InitializeComponent();
		}

		private DataTable CargarProductosVendidos(DateTime inicio, DateTime fin)
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			conexion.Open();

			SqlCommand cmd =
				new SqlCommand(
					"REPORTE_PRODUCTOS_VENDIDOS",
					conexion);

			cmd.CommandType =
				CommandType.StoredProcedure;

			cmd.Parameters.AddWithValue("@FechaInicio", inicio.Date);
			cmd.Parameters.AddWithValue("@FechaFin", fin.Date);

			SqlDataAdapter da =
				new SqlDataAdapter(cmd);

			da.Fill(dt);

			conexion.Close();

			return dt;
		}

		private void FrmReporteProductoVentas_Load(object sender, EventArgs e)
		{
			DataTable dt =
				CargarProductosVendidos(
					DateTime.Now.AddYears(-1),
					DateTime.Now);

			reportViewer1.LocalReport.DataSources.Clear();

			reportViewer1.LocalReport.DataSources.Add(
				new ReportDataSource("DSProductosVendidos", dt));

			reportViewer1.RefreshReport();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (dtpInicio.Value.Date > dtpFin.Value.Date)
			{
				MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final");
				return;
			}

			DataTable dt =
				CargarProductosVendidos(
					dtpInicio.Value.Date,
					dtpFin.Value.Date);

			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("No existen productos vendidos en ese rango de fechas");
				return;
			}

			reportViewer1.LocalReport.DataSources.Clear();

			reportViewer1.LocalReport.DataSources.Add(
				new ReportDataSource("DSProductosVendidos", dt));

			reportViewer1.RefreshReport();
		}
	}
}