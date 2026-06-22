using System;
using PESCADOFINAL.Conexion;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PESCADOFINAL.MODELO
{
    public class M_ProductoElaborado
    {
        public int codigo { get; set; }
        public int prdCodigo { get; set; }      // insumo base
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precioVenta { get; set; }
        public decimal cantidad { get; set; }    // rendimiento
        public decimal stock { get; set; }

        public M_ProductoElaborado() { }

        public int autonumericoModelo()
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PELABORADO_AUTONUMERICO", c);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) r = rd.GetInt32(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        public int existeModelo(string nombre)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PELABORADO_EXISTE", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 80) { Value = nombre });
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) r = rd.GetInt32(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        public int registrarModelo(int codigo, int prdCodigo, string nombre,
                                   string descripcion, decimal precioVenta, decimal cantidad)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PELABORADO_REGISTRAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@prdCodigo", SqlDbType.Int) { Value = prdCodigo });
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 80) { Value = nombre });
                cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar, 120) { Value = (object)descripcion ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@precioVenta", SqlDbType.Decimal) { Value = precioVenta });
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Decimal) { Value = cantidad });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- EDITAR: actualiza precio de venta sin tocar ventas ya procesadas ----
        public int editarModelo(int codigo, int prdCodigo, string nombre,
                                string descripcion, decimal precioVenta, decimal cantidad)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PELABORADO_EDITAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@prdCodigo", SqlDbType.Int) { Value = prdCodigo });
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 80) { Value = nombre });
                cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar, 120) { Value = (object)descripcion ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@precioVenta", SqlDbType.Decimal) { Value = precioVenta });
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Decimal) { Value = cantidad });
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
                SqlCommand cmd = new SqlCommand("PELABORADO_ELIMINAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- Aumenta el stock propio del plato (al producirlo) ----
        public int aumentarStockModelo(int codigo, decimal cantidad)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PELABORADO_AUMENTAR_STOCK", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Decimal) { Value = cantidad });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- LISTAR: alias que consume FrmVentas ----
        //  CODIGO, PLATO, PRECIO, STOCK_DISP, PRD_BASE, CANTIDAD, CAT_CODIGO, INSUMO_BASE
        public DataTable listarModelo()
        {
            DataTable dt = new DataTable();
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("PELABORADO_LISTAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return dt;
        }
    }

}
