using ProyectoJoel.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoJoel.Modelo
{
	internal class M_DetalleVenta
	{
		public int IdDetalleVenta { get; set; }
		public int IdVenta { get; set; }
		public int IdProducto { get; set; }
		public int Cantidad { get; set; }
		public decimal PrecioUnitario { get; set; }
		public decimal Subtotal { get; set; }

		public int RegistrarDetalleModelo(M_DetalleVenta detalle)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"DETALLE_VENTA_REGISTRAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IdVenta", detalle.IdVenta);
				cmd.Parameters.AddWithValue("@IdProducto", detalle.IdProducto);
				cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
				cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);
				cmd.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);

				resultado = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conexion.Close();
			}

			return resultado;
		}
	}
}