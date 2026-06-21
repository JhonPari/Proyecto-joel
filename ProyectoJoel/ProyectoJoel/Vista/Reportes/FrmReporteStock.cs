using ProyectoJoel.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoJoel.Vista.Reportes
{
	public partial class FrmReporteStock : Form
	{
		//variable global
		private DataTable dtStock;
		public FrmReporteStock()
		{
			InitializeComponent();
		}

		private DataTable CargarStock()
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			conexion.Open();

			SqlCommand cmd =
				new SqlCommand("REPORTE_STOCK", conexion);

			cmd.CommandType =
				CommandType.StoredProcedure;

			SqlDataAdapter da =
				new SqlDataAdapter(cmd);

			da.Fill(dt);

			conexion.Close();

			return dt;
		}
		private void CargarCategorias()
		{
			cmbCategoria.Items.Clear();

			cmbCategoria.Items.Add("TODAS");

			foreach (DataRow fila in dtStock.Rows)
			{
				string categoria =
					fila["Categoria"].ToString();

				if (!cmbCategoria.Items.Contains(categoria))
				{
					cmbCategoria.Items.Add(categoria);
				}
			}

			cmbCategoria.SelectedIndex = 0;
		}

		private void FrmReporteStock_Load(object sender, EventArgs e)
		{
			dtStock = CargarStock();

			CargarCategorias();

			reportViewer1.LocalReport.DataSources.Clear();

			reportViewer1.LocalReport.DataSources.Add(
				new ReportDataSource(
					"ReporteStock",
					dtStock));

			reportViewer1.RefreshReport();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			DataView dv =dtStock.DefaultView;

			if (cmbCategoria.Text != "TODAS")
			{
				dv.RowFilter =
					"Categoria = '" +
					cmbCategoria.Text + "'";
			}
			else
			{
				dv.RowFilter = "";
			}

			reportViewer1.LocalReport.DataSources.Clear();

			reportViewer1.LocalReport.DataSources.Add(
				new ReportDataSource(
					"ReporteStock",
					dv.ToTable()));

			reportViewer1.RefreshReport();
		}
	}
}