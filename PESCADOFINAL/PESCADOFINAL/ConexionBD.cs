using PESCADOFINAL.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PESCADOFINAL.Conexion

{
    public class ConexionBD
    {
    public static string ObtenerString()
    {
        return Settings.Default.BD_pescadoFinalConnectionString;

    }

    public static SqlConnection ObtenerConexion()
    {
        SqlConnection Conexion = new SqlConnection(ObtenerString());
        try
        {
            Conexion.Open();
        }
        catch
        {
            MessageBox.Show("ERROR en la cadena de conexion al servidor",
                "SISTEMA PESCADERIA",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        return Conexion;
    }
}
}
