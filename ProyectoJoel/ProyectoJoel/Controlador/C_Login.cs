using ProyectoJoel.Modelo;
using System.Data;

namespace ProyectoJoel.Controlador
{
	internal class C_Login
	{
		public static DataTable IniciarSesionControlador(
			string usuario,
			string contrasena)
		{
			M_Login login = new M_Login();

			login.Usuario = usuario;
			login.Contrasena = contrasena;

			return login.IniciarSesionModelo(login);
		}
	}
}