using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJoel.Data
{
	internal class dbConexion
	{
		private string cadena = @"Server=(localdb)\MSSQLLocalDB;
              Database=TiendaZapatos;
              Trusted_Connection=True;
              TrustServerCertificate=True";
		public SqlConnection ObtenerConexion()
		{
			return new SqlConnection(cadena);
		}
	}
}
