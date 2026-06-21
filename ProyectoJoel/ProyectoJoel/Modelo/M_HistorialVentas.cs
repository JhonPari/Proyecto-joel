using ProyectoJoel.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoJoel.Modelo
{
	internal class M_HistorialVentas
	{
		public DataTable ListarVentasModelo()
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"HISTORIAL_VENTAS_LISTAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				SqlDataAdapter da =
					new SqlDataAdapter(cmd);

				da.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conexion.Close();
			}

			return dt;
		}
	}
}