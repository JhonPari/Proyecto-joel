using ProyectoJoel.Modelo;
using System.Data;

namespace ProyectoJoel.Controlador
{
	internal class C_Usuario
	{
		public static int RegistrarUsuarioControlador(
			string usuario,
			string contrasena,
			string rol)
		{
			M_Usuario obj = new M_Usuario();

			obj.Usuario = usuario;
			obj.Contrasena = contrasena;
			obj.Rol = rol;

			return obj.RegistrarUsuarioModelo(obj);
		}

		public static DataTable ListarUsuarioControlador()
		{
			return new M_Usuario().ListarUsuarioModelo();
		}

		public static int EditarUsuarioControlador(
			int idUsuario,
			string usuario,
			string contrasena,
			string rol)
		{
			M_Usuario obj = new M_Usuario();

			obj.IdUsuario = idUsuario;
			obj.Usuario = usuario;
			obj.Contrasena = contrasena;
			obj.Rol = rol;

			return obj.EditarUsuarioModelo(obj);
		}

		public static int EliminarUsuarioControlador(
			int idUsuario)
		{
			M_Usuario obj = new M_Usuario();

			obj.IdUsuario = idUsuario;

			return obj.EliminarUsuarioModelo(obj);
		}
	}
}