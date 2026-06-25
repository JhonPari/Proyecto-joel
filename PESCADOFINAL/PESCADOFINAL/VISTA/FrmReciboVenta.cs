using Microsoft.Reporting.WinForms;
using PESCADOFINAL.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class FrmReciboVenta : Form
	{
		private int ventaCodigo;

		public FrmReciboVenta(int venCod)
		{
			InitializeComponent();
			ventaCodigo = venCod;
		}

		private void FrmReciboVenta_Load(object sender, EventArgs e)
		{
			DataTable dt = cargarReciboVenta(ventaCodigo);

			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("No se encontraron datos para el recibo.");
				this.Close();
				return;
			}

			reportViewer1.LocalReport.ReportEmbeddedResource =
				"PESCADOFINAL.REPORTES.ReciboVentas.rdlc";

			reportViewer1.LocalReport.DataSources.Clear();

			reportViewer1.LocalReport.DataSources.Add(
				new ReportDataSource("DSReciboVenta", dt));

			reportViewer1.RefreshReport();
		}

		private DataTable cargarReciboVenta(int venCod)
		{
			DataTable dt = new DataTable();
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("RECIBO_VENTA", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add(
					new SqlParameter("@codigo", SqlDbType.Int)
					{
						Value = venCod
					});

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar recibo: " + ex.Message);
			}
			finally
			{
				if (c.State == ConnectionState.Open)
					c.Close();
			}

			return dt;
		}
	}
}