using PESCADOFINAL.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PESCADOFINAL.MODELO
{
    public class M_Categoria
    {
        public int codigo { get; set; }
        public string nombre { get; set; }

        public M_Categoria() { }

        // ---- AUTONUMERICO (reusa primer hueco libre) ----
        public int autonumericoModelo()
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("CATEGORIA_AUTONUMERICO", c);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) r = rd.GetInt32(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- EXISTE ----
        public int existeModelo(string nombre)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("CATEGORIA_EXISTE", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 60) { Value = nombre });
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) r = rd.GetInt32(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- REGISTRAR ----
        public int registrarModelo(int codigo, string nombre)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("CATEGORIA_REGISTRAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 60) { Value = nombre });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- EDITAR ----
        public int editarModelo(int codigo, string nombre)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("CATEGORIA_EDITAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 60) { Value = nombre });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- ELIMINAR ----
        public int eliminarModelo(int codigo)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("CATEGORIA_ELIMINAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- LISTAR ----
        public DataTable listarModelo()
        {
            DataTable dt = new DataTable();
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("CATEGORIA_LISTAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return dt;
        }
    }
}
