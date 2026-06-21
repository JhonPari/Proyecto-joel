
using ProyectoJoel.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoJoel.Modelo
{
	internal class M_Login
	{
		public string Usuario { get; set; }
		public string Contrasena { get; set; }

		public DataTable IniciarSesionModelo(M_Login login)
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			try
			{
				conexion.Open();

				string sql = @"
                SELECT *
                FROM Usuarios
                WHERE Usuario=@Usuario
                AND Contrasena=@Contrasena";

				SqlCommand cmd =
					new SqlCommand(sql, conexion);

				cmd.Parameters.AddWithValue(
					"@Usuario",
					login.Usuario);

				cmd.Parameters.AddWithValue(
					"@Contrasena",
					login.Contrasena);

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