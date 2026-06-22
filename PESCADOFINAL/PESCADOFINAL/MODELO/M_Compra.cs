using PESCADOFINAL.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PESCADOFINAL.MODELO
{
	public class M_Compra
	{
		public int codigo { get; set; }
		public int proCodigo { get; set; }

		public M_Compra() { }

		public int registrarCompraModelo(int proCodigo, decimal total)
		{
			int r = 0;
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd =
					new SqlCommand("COMPRA_REGISTRAR", c);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.Add(
					new SqlParameter("@proCodigo", SqlDbType.Int)
					{
						Value = proCodigo
					});

				cmd.Parameters.Add(
					new SqlParameter("@total", SqlDbType.Decimal)
					{
						Value = total
					});

				object resultado =
					cmd.ExecuteScalar();

				if (resultado != null &&
					resultado != DBNull.Value)
				{
					r = Convert.ToInt32(resultado);
				}
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

		public int registrarDetalleModelo(
			int comCodigo,
			int prdCodigo,
			int cantidad,
			decimal precioUnit,
			decimal subtotal)
		{
			int r = 0;
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd =
					new SqlCommand("DCOMPRA_REGISTRAR", c);

				cmd.CommandType =
					CommandType.StoredProcedure;

				cmd.Parameters.Add(
					new SqlParameter("@comCodigo", SqlDbType.Int)
					{
						Value = comCodigo
					});

				cmd.Parameters.Add(
					new SqlParameter("@prdCodigo", SqlDbType.Int)
					{
						Value = prdCodigo
					});

				cmd.Parameters.Add(
					new SqlParameter("@cantidad", SqlDbType.Int)
					{
						Value = cantidad
					});

				cmd.Parameters.Add(
					new SqlParameter("@precioUnit", SqlDbType.Decimal)
					{
						Value = precioUnit
					});

				cmd.Parameters.Add(
					new SqlParameter("@subtotal", SqlDbType.Decimal)
					{
						Value = subtotal
					});

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
				SqlCommand cmd =
					new SqlCommand("COMPRA_LISTAR", c);

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
				if (c.State == ConnectionState.Open)
					c.Close();
			}

			return dt;
		}
	}
}