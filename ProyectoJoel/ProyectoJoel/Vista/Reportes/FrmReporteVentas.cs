using Microsoft.Reporting.WinForms;
using ProyectoJoel.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJoel.Vista.Reportes
{
	public partial class FrmReporteVentas : Form
	{
		public FrmReporteVentas()
		{
			InitializeComponent();
		}

		private void FrmReporteVentas_Load(object sender, EventArgs e)
		{
			DataTable dt =
				CargarReporte(
					DateTime.Now.AddYears(-1),
					DateTime.Now);

			reportViewer1.LocalReport.DataSources.Clear();

			reportViewer1.LocalReport.DataSources.Add(
				new ReportDataSource("DSReporteVentas", dt));

			reportViewer1.RefreshReport();
		}



		private void reportViewer1_Load_1(object sender, EventArgs e)
		{

		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (dtpInicio.Value.Date > dtpFin.Value.Date)
			{
				MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final");
				return;
			}

			DataTable dt =
				CargarReporte(
					dtpInicio.Value.Date,
					dtpFin.Value.Date);

			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("No existen ventas en ese rango de fechas");
				return;
			}

			reportViewer1.LocalReport.DataSources.Clear();

			reportViewer1.LocalReport.DataSources.Add(
				new ReportDataSource("DSReporteVentas", dt));

			reportViewer1.RefreshReport();
		}
		private DataTable CargarReporte(DateTime inicio, DateTime fin)
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			conexion.Open();

			SqlCommand cmd =
				new SqlCommand("REPORTE_VENTAS", conexion);

			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.AddWithValue("@FechaInicio", inicio.Date);
			cmd.Parameters.AddWithValue("@FechaFin", fin.Date);

			SqlDataAdapter da =
				new SqlDataAdapter(cmd);

			da.Fill(dt);

			conexion.Close();

			return dt;
		}
	}
}
