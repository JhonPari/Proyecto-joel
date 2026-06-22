using PESCADOFINAL.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PESCADOFINAL.MODELO
{
	public class M_Proveedor
	{
		public int codigo { get; set; }
		public string nombre { get; set; }
		public string telefono { get; set; }
		public string direccion { get; set; }

		public int existeModelo(string nombre)
		{
			int r = 0;
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("PROVEEDOR_EXISTE", c);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@nombre", nombre);

				SqlDataReader rd = cmd.ExecuteReader();

				if (rd.Read())
					r = rd.GetInt32(0);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (c.State == ConnectionState.Open)
					c.Close();
			}

			return r;
		}

		public int registrarModelo(string nombre, string telefono, string direccion)
		{
			int r = 0;
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("PROVEEDOR_REGISTRAR", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@nombre", nombre);
				cmd.Parameters.AddWithValue("@telefono", telefono);
				cmd.Parameters.AddWithValue("@direccion", direccion);

				r = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (c.State == ConnectionState.Open)
					c.Close();
			}

			return r;
		}

		public int editarModelo(int codigo, string nombre, string telefono, string direccion)
		{
			int r = 0;
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("PROVEEDOR_EDITAR", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@codigo", codigo);
				cmd.Parameters.AddWithValue("@nombre", nombre);
				cmd.Parameters.AddWithValue("@telefono", telefono);
				cmd.Parameters.AddWithValue("@direccion", direccion);

				r = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (c.State == ConnectionState.Open)
					c.Close();
			}

			return r;
		}

		public int eliminarModelo(int codigo)
		{
			int r = 0;
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("PROVEEDOR_ELIMINAR", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@codigo", codigo);

				r = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (c.State == ConnectionState.Open)
					c.Close();
			}

			return r;
		}

		public DataTable listarModelo()
		{
			DataTable dt = new DataTable();
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("PROVEEDOR_LISTAR", c);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
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