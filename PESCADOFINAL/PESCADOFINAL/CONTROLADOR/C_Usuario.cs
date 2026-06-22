using PESCADOFINAL.MODELO;
using System.Data;

namespace PESCADOFINAL.CONTROLADOR
{
	public class C_Usuario
	{
		public static int existe(string usuario)
		{
			return new M_Usuario()
				.existeModelo(usuario);
		}

		public static DataTable login(string usuario, string contrasena)
		{
			return new M_Usuario()
				.loginModelo(usuario, contrasena);
		}

		public static int registrar(
			string nombre,
			string usuario,
			string contrasena,
			string rol)
		{
			return new M_Usuario()
				.registrarModelo(
					nombre,
					usuario,
					contrasena,
					rol);
		}

		public static int editar(
			int codigo,
			string nombre,
			string usuario,
			string contrasena,
			string rol)
		{
			return new M_Usuario()
				.editarModelo(
					codigo,
					nombre,
					usuario,
					contrasena,
					rol);
		}

		public static int eliminar(int codigo)
		{
			return new M_Usuario()
				.eliminarModelo(codigo);
		}

		public static DataTable listar()
		{
			return new M_Usuario()
				.listarModelo();
		}
	}
}