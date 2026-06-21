using ProyectoJoel.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoJoel.Modelo
{
	internal class M_Venta
	{
		public int IdVenta { get; set; }
		public int IdCliente { get; set; }
		public int IdEmpleado { get; set; }
		public decimal Total { get; set; }

		public int RegistrarVentaModelo(M_Venta venta)
		{
			int idVenta = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"VENTA_REGISTRAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IdCliente", venta.IdCliente);
				cmd.Parameters.AddWithValue("@IdEmpleado", venta.IdEmpleado);
				cmd.Parameters.AddWithValue("@Total", venta.Total);

				idVenta =
					Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conexion.Close();
			}

			return idVenta;
		}
	}
}