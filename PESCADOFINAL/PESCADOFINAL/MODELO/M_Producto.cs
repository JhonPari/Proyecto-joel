using PESCADOFINAL.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PESCADOFINAL.MODELO
{
    public class M_Producto
    {
        public int codigo { get; set; }
        public int catCodigo { get; set; }
        public string nombre { get; set; }
        public string tamano { get; set; }
        public decimal precioCosto { get; set; }
        public decimal stock { get; set; }

        public M_Producto() { }

        public int autonumericoModelo()
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_AUTONUMERICO", c);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) r = rd.GetInt32(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        public int existeModelo(string nombre, string tamano)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_EXISTE", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 80) { Value = nombre });
                cmd.Parameters.Add(new SqlParameter("@tamano", SqlDbType.VarChar, 40) { Value = (object)tamano ?? DBNull.Value });
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) r = rd.GetInt32(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        public int registrarModelo(int codigo, int catCodigo, string nombre, string tamano, decimal precioCosto)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_REGISTRAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@catCodigo", SqlDbType.Int) { Value = catCodigo });
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 80) { Value = nombre });
                cmd.Parameters.Add(new SqlParameter("@tamano", SqlDbType.VarChar, 40) { Value = (object)tamano ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@precioCosto", SqlDbType.Decimal) { Value = precioCosto });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        public int editarModelo(int codigo, int catCodigo, string nombre, string tamano, decimal precioCosto)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_EDITAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@catCodigo", SqlDbType.Int) { Value = catCodigo });
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 80) { Value = nombre });
                cmd.Parameters.Add(new SqlParameter("@tamano", SqlDbType.VarChar, 40) { Value = (object)tamano ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@precioCosto", SqlDbType.Decimal) { Value = precioCosto });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        public int eliminarModelo(int codigo)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_ELIMINAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        public DataTable listarModelo()
        {
            DataTable dt = new DataTable();
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_LISTAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return dt;
        }

        // ---- STOCK ----
        public int aumentarStockModelo(int codigo, decimal cantidad)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_AUMENTAR_STOCK", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Decimal) { Value = cantidad });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        public int descontarStockModelo(int codigo, decimal cantidad)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_DESCONTAR_STOCK", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Decimal) { Value = cantidad });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- REPORTE: stock critico (insumos por debajo del minimo) ----
        public DataTable stockCriticoModelo(decimal minimo)
        {
            DataTable dt = new DataTable();
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_REPORTE_STOCK_CRITICO", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@STOCK_MINIMO", SqlDbType.Decimal) { Value = minimo });
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return dt;
        }

        // ---- BORRADO LOGICO: alterna Activo/Inactivo ----
        public int cambiarEstadoModelo(int codigo)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_CAMBIAR_ESTADO", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- Lista solo productos ACTIVOS (combos de venta/compra) ----
        public DataTable listarActivosModelo()
        {
            DataTable dt = new DataTable();
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PRODUCTO_LISTAR_ACTIVOS", c);
                cmd.CommandType = CommandType.StoredProcedure;
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return dt;
        }
    }

}
