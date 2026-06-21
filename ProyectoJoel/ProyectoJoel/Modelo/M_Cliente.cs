using ProyectoJoel.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoJoel.Modelo
{
	internal class M_Cliente
	{
		public int IdCliente { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string DNI { get; set; }
		public string Telefono { get; set; }
		public string Direccion { get; set; }

		public int RegistrarClienteModelo(M_Cliente cliente)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"CLIENTE_REGISTRAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
				cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
				cmd.Parameters.AddWithValue("@DNI", cliente.DNI);
				cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
				cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);

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

		public DataTable ListarClienteModelo()
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"CLIENTE_LISTAR",
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

		public int EditarClienteModelo(M_Cliente cliente)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"CLIENTE_EDITAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
				cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
				cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
				cmd.Parameters.AddWithValue("@DNI", cliente.DNI);
				cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
				cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);

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

		public int EliminarClienteModelo(M_Cliente cliente)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"CLIENTE_ELIMINAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);

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