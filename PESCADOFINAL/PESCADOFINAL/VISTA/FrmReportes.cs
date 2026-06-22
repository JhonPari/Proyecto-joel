using PESCADOFINAL.Conexion;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class FrmReportes : Form
	{
		public FrmReportes()
		{
			InitializeComponent();
		}

		private DataTable CargarReportePeriodo(DateTime inicio, DateTime fin)
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				ConexionBD.ObtenerConexion();

			SqlCommand cmd =
				new SqlCommand(
					"REPORTE_VENTAS_FECHAS",
					conexion);

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

		private void FrmReportes_Load(object sender, EventArgs e)
		{
			ToolTip tip = new ToolTip();

			tip.SetToolTip(cmbMes, "Seleccione el mes para el reporte.");
			tip.SetToolTip(cmbAnio, "Seleccione el año para el reporte.");
			tip.SetToolTip(btnReporteDia, "Muestra las ventas del día actual.");
			tip.SetToolTip(btnReporteMes, "Muestra las ventas del mes seleccionado.");
			tip.SetToolTip(button1, "Cerrar y volver al menú principal.");

			cmbMes.SelectedIndex = DateTime.Now.Month - 1;
			cmbAnio.Text = DateTime.Now.Year.ToString();

			limpiarTotales();

			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.RefreshReport();
		}

		private void btnReporteDia_Click(object sender, EventArgs e)
		{
			DateTime hoy = DateTime.Now.Date;

			DataTable dt =
				CargarReportePeriodo(
					hoy,
					hoy);

			CargarReporte(dt);
		}

		private void btnReporteMes_Click(object sender, EventArgs e)
		{
			if (cmbMes.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione el mes.");
				return;
			}

			if (cmbAnio.Text.Trim() == "")
			{
				MessageBox.Show("Seleccione el año.");
				return;
			}

			if (!int.TryParse(cmbAnio.Text.Trim(), out int anio))
			{
				MessageBox.Show("Año inválido.");
				return;
			}

			int mes =
				cmbMes.SelectedIndex + 1;

			DateTime inicio =
				new DateTime(anio, mes, 1);

			DateTime fin =
				inicio.AddMonths(1).AddDays(-1);

			DataTable dt =
				CargarReportePeriodo(
					inicio,
					fin);

			CargarReporte(dt);
		}

		private void CargarReporte(DataTable dt)
		{
			if (dt.Rows.Count == 0)
			{
				limpiarTotales();

				reportViewer1.LocalReport.DataSources.Clear();
				reportViewer1.RefreshReport();

				MessageBox.Show("No existen ventas en ese rango de fechas.");
				return;
			}

			calcularTotales(dt);

			reportViewer1.LocalReport.DataSources.Clear();

			reportViewer1.LocalReport.DataSources.Add(
				new ReportDataSource("DSReportePedido", dt));

			reportViewer1.RefreshReport();
		}

		private void calcularTotales(DataTable dt)
		{
			decimal total = 0;

			foreach (DataRow fila in dt.Rows)
			{
				if (dt.Columns.Contains("SUBTOTAL") &&
					fila["SUBTOTAL"] != DBNull.Value)
				{
					total += Convert.ToDecimal(fila["SUBTOTAL"]);
				}
				else if (dt.Columns.Contains("TOTAL") &&
						 fila["TOTAL"] != DBNull.Value)
				{
					total += Convert.ToDecimal(fila["TOTAL"]);
				}
			}

			lblTotalReporte.Text =
				"TOTAL: Bs " + total.ToString("N2");

			lblCantReportes.Text =
				"CANTIDAD VENTAS  : " + dt.Rows.Count;
		}

		private void limpiarTotales()
		{
			lblTotalReporte.Text =
				"TOTAL: Bs 0.00";

			lblCantReportes.Text =
				"CANTIDAD VENTAS  : 0";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmMenuPrincipal menu =
				new FrmMenuPrincipal();

			menu.Show();
			this.Close();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}
	}
}