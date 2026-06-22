using PESCADOFINAL.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace PESCADOFINAL.MODELO
{
    public class M_Usuario
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string rol { get; set; }

        public M_Usuario() { }

        public int autonumericoModelo()
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("USUARIO_AUTONUMERICO", c);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) r = rd.GetInt32(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        public int existeModelo(string usuario)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("USUARIO_EXISTE", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar, 40) { Value = usuario });
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) r = rd.GetInt32(0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        // ---- LOGIN: devuelve USU_CODIGO, USU_NOMBRE, USU_ROL ----
        public DataTable loginModelo(string usuario, string contrasena)
        {
            DataTable dt = new DataTable();
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("USUARIO_LOGIN", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar, 40) { Value = usuario });
                cmd.Parameters.Add(new SqlParameter("@contrasena", SqlDbType.VarChar, 40) { Value = contrasena });
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return dt;
        }

        public int registrarModelo(int codigo, string nombre, string usuario, string contrasena, string rol)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("USUARIO_REGISTRAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 80) { Value = nombre });
                cmd.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar, 40) { Value = usuario });
                cmd.Parameters.Add(new SqlParameter("@contrasena", SqlDbType.VarChar, 40) { Value = contrasena });
                cmd.Parameters.Add(new SqlParameter("@rol", SqlDbType.VarChar, 20) { Value = rol });
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return r;
        }

        public int editarModelo(int codigo, string nombre, string usuario, string contrasena, string rol)
        {
            int r = 0;
            SqlConnection c = ConexionBD.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("USUARIO_EDITAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int) { Value = codigo });
                cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar, 80) { Value = nombre });
                cmd.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar, 40) { Value = usuario });
                cmd.Parameters.Add(new SqlParameter("@contrasena", SqlDbType.VarChar, 40) { Value = contrasena });
                cmd.Parameters.Add(new SqlParameter("@rol", SqlDbType.VarChar, 20) { Value = rol });
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
                SqlCommand cmd = new SqlCommand("USUARIO_ELIMINAR", c);
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
                SqlCommand cmd = new SqlCommand("USUARIO_LISTAR", c);
                cmd.CommandType = CommandType.StoredProcedure;
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (c.State == ConnectionState.Open) c.Close(); }
            return dt;
        }
    }

}
