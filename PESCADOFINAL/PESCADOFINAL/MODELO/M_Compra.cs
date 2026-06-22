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

        // ---- Autonumerico cabecera COMPRA ----
        public int autonumericoComModelo()
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("COMPRA_AUTONUMERICO", c);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) r = rd.GetInt32(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- Autonumerico detalle BDC_COMPRA_DETALLE ----
        public int autonumericoDComModelo()
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("DCOMPRA_AUTONUMERICO", c);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) r = rd.GetInt32(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- Registra cabecera de compra ----
        public int registrarCompraModelo(int codigo, int proCodigo)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("COMPRA_REGISTRAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@proCodigo", SqlDbType.Int) { Value = proCodigo });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- Registra UNA linea de detalle (incluye @prdCodigo = FK PRODUCTO) ----
        public int registrarDetalleModelo(int codigo, int comCodigo, int prdCodigo,
                                          int cantidad, decimal precioUnit)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("DCOMPRA_REGISTRAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@comCodigo", SqlDbType.Int) { Value = comCodigo });
                cmd.Parameters.Add(new SqlParameter("@prdCodigo", SqlDbType.Int) { Value = prdCodigo });   // <-- FK PRODUCTO
                cmd.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int) { Value = cantidad });
                cmd.Parameters.Add(new SqlParameter("@precioUnit", SqlDbType.Decimal) { Value = precioUnit });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- Listado de compras (cabecera con proveedor + total) ----
        public DataTable listarModelo()
        {
            DataTable dt = new DataTable();
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("COMPRA_LISTAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return dt;
        }
    }

}
