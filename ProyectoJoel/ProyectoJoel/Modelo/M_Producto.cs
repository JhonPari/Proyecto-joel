using ProyectoJoel.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoJoel.Modelo
{
	internal class M_Producto
	{
		public int IdProducto { get; set; }
		public string Nombre { get; set; }
		public string Marca { get; set; }
		public int Talla { get; set; }
		public string Color { get; set; }
		public decimal Precio { get; set; }
		public int Stock { get; set; }
		public int IdCategoria { get; set; }
		public string Imagen { get; set; }

		// REGISTRAR
		public int RegistrarProductoModelo(M_Producto producto)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"PRODUCTO_REGISTRAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
				cmd.Parameters.AddWithValue("@Marca", producto.Marca);
				cmd.Parameters.AddWithValue("@Talla", producto.Talla);
				cmd.Parameters.AddWithValue("@Color", producto.Color);
				cmd.Parameters.AddWithValue("@Precio", producto.Precio);
				cmd.Parameters.AddWithValue("@Stock", producto.Stock);
				cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
				cmd.Parameters.AddWithValue("@Imagen", producto.Imagen);

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

		// LISTAR
		public DataTable ListarProductoModelo()
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"PRODUCTO_LISTAR",
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

		// EDITAR
		public int EditarProductoModelo(M_Producto producto)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"PRODUCTO_EDITAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
				cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
				cmd.Parameters.AddWithValue("@Marca", producto.Marca);
				cmd.Parameters.AddWithValue("@Talla", producto.Talla);
				cmd.Parameters.AddWithValue("@Color", producto.Color);
				cmd.Parameters.AddWithValue("@Precio", producto.Precio);
				cmd.Parameters.AddWithValue("@Stock", producto.Stock);
				cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
				cmd.Parameters.AddWithValue("@Imagen", producto.Imagen);

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

		// ELIMINAR
		public int EliminarProductoModelo(M_Producto producto)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"PRODUCTO_ELIMINAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue(
					"@IdProducto",
					producto.IdProducto);

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