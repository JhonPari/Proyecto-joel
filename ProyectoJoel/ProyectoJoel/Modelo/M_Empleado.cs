using ProyectoJoel.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoJoel.Modelo
{
	internal class M_Empleado
	{
		public int IdEmpleado { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Cargo { get; set; }
		public string Telefono { get; set; }
		public string Email { get; set; }

		public int RegistrarEmpleadoModelo(M_Empleado empleado)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"EMPLEADO_REGISTRAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
				cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
				cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
				cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
				cmd.Parameters.AddWithValue("@Email", empleado.Email);

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

		public DataTable ListarEmpleadoModelo()
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"EMPLEADO_LISTAR",
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

		public int EditarEmpleadoModelo(M_Empleado empleado)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"EMPLEADO_EDITAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
				cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
				cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
				cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
				cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
				cmd.Parameters.AddWithValue("@Email", empleado.Email);

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

		public int EliminarEmpleadoModelo(M_Empleado empleado)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"EMPLEADO_ELIMINAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);

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