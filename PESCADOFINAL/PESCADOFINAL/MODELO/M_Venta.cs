using PESCADOFINAL.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PESCADOFINAL.MODELO
{
	public class M_Venta
	{
		public int codigo { get; set; }
		public decimal total { get; set; }
		public decimal monto { get; set; }
		public decimal cambio { get; set; }
		public int usuCod { get; set; }
		public string cliente { get; set; }
		public string nit { get; set; }

		public M_Venta() { }

		public int registrarVentaModelo(
			decimal total,
			decimal monto,
			decimal cambio,
			int usuCod,
			string cliente,
			string nit)
		{
			int r = 0;
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("VENTA_REGISTRAR", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add(
					new SqlParameter("@total", SqlDbType.Decimal)
					{
						Value = total
					});

				cmd.Parameters.Add(
					new SqlParameter("@monto", SqlDbType.Decimal)
					{
						Value = monto
					});

				cmd.Parameters.Add(
					new SqlParameter("@cambio", SqlDbType.Decimal)
					{
						Value = cambio
					});

				cmd.Parameters.Add(
					new SqlParameter("@usuCod", SqlDbType.Int)
					{
						Value = usuCod
					});

				cmd.Parameters.Add(
					new SqlParameter("@cliente", SqlDbType.VarChar, 80)
					{
						Value = (object)cliente ?? DBNull.Value
					});

				cmd.Parameters.Add(
					new SqlParameter("@nit", SqlDbType.VarChar, 20)
					{
						Value = (object)nit ?? DBNull.Value
					});

				object resultado = cmd.ExecuteScalar();

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
			int venCod,
			int pelCod,
			int cantidad,
			decimal precio,
			decimal subtotal)
		{
			int r = 0;
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("DVENTA_REGISTRAR", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add(
					new SqlParameter("@venCod", SqlDbType.Int)
					{
						Value = venCod
					});

				cmd.Parameters.Add(
					new SqlParameter("@pelCod", SqlDbType.Int)
					{
						Value = pelCod
					});

				cmd.Parameters.Add(
					new SqlParameter("@cantidad", SqlDbType.Int)
					{
						Value = cantidad
					});

				cmd.Parameters.Add(
					new SqlParameter("@precio", SqlDbType.Decimal)
					{
						Value = precio
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

		public DataTable comprobanteCabeceraModelo(int venCod)
		{
			DataTable dt = new DataTable();
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("VENTA_COMPROBANTE_CABECERA", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add(
					new SqlParameter("@codigo", SqlDbType.Int)
					{
						Value = venCod
					});

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener cabecera del comprobante: " + ex.Message);
			}
			finally
			{
				if (c.State == ConnectionState.Open)
					c.Close();
			}

			return dt;
		}

		public DataTable comprobanteDetalleModelo(int venCod)
		{
			DataTable dt = new DataTable();
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("VENTA_COMPROBANTE_DETALLE", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add(
					new SqlParameter("@codigo", SqlDbType.Int)
					{
						Value = venCod
					});

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener detalle del comprobante: " + ex.Message);
			}
			finally
			{
				if (c.State == ConnectionState.Open)
					c.Close();
			}

			return dt;
		}

		public DataTable reportePeriodoModelo(DateTime desde, DateTime hasta)
		{
			DataTable dt = new DataTable();
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("VENTA_REPORTE_PERIODO", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add(
					new SqlParameter("@FECHA_INICIO", SqlDbType.Date)
					{
						Value = desde.Date
					});

				cmd.Parameters.Add(
					new SqlParameter("@FECHA_FIN", SqlDbType.Date)
					{
						Value = hasta.Date
					});

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

		public DataTable reporteDiaModelo()
		{
			DataTable dt = new DataTable();
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("VENTA_REPORTE_DIA", c);
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

		public DataTable reporteMesModelo(int mes, int anio)
		{
			DataTable dt = new DataTable();
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("VENTA_REPORTE_MES", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add(
					new SqlParameter("@mes", SqlDbType.Int)
					{
						Value = mes
					});

				cmd.Parameters.Add(
					new SqlParameter("@anio", SqlDbType.Int)
					{
						Value = anio
					});

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

		public DataTable reporteCategoriaModelo(
			int catCodigo,
			DateTime desde,
			DateTime hasta)
		{
			DataTable dt = new DataTable();
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("VENTA_REPORTE_CATEGORIA", c);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add(
					new SqlParameter("@catCodigo", SqlDbType.Int)
					{
						Value = catCodigo
					});

				cmd.Parameters.Add(
					new SqlParameter("@fechaInicio", SqlDbType.Date)
					{
						Value = desde.Date
					});

				cmd.Parameters.Add(
					new SqlParameter("@fechaFin", SqlDbType.Date)
					{
						Value = hasta.Date
					});

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

		public DataTable masVendidosModelo()
		{
			DataTable dt = new DataTable();
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("ESTADISTICA_PRODUCTOS_MAS_VENDIDOS", c);
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

		public DataTable ingresosCategoriaModelo()
		{
			DataTable dt = new DataTable();
			SqlConnection c = ConexionBD.ObtenerConexion();

			try
			{
				SqlCommand cmd = new SqlCommand("ESTADISTICA_INGRESOS_CATEGORIA", c);
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