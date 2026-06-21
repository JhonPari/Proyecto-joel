using ProyectoJoel.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoJoel.Modelo
{
	internal class M_Usuario
	{
		public int IdUsuario { get; set; }
		public string Usuario { get; set; }
		public string Contrasena { get; set; }
		public string Rol { get; set; }

		public int RegistrarUsuarioModelo(M_Usuario usuario)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"USUARIO_REGISTRAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@Usuario", usuario.Usuario);
				cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
				cmd.Parameters.AddWithValue("@Rol", usuario.Rol);

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

		public DataTable ListarUsuarioModelo()
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"USUARIO_LISTAR",
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

		public int EditarUsuarioModelo(M_Usuario usuario)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"USUARIO_EDITAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
				cmd.Parameters.AddWithValue("@Usuario", usuario.Usuario);
				cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
				cmd.Parameters.AddWithValue("@Rol", usuario.Rol);

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

		public int EliminarUsuarioModelo(M_Usuario usuario)
		{
			int resultado = 0;

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				SqlCommand cmd =
					new SqlCommand(
						"USUARIO_ELIMINAR",
						conexion);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);

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