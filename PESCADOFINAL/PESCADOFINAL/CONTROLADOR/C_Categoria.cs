using PESCADOFINAL.MODELO;
using System.Data;

namespace PESCADOFINAL.CONTROLADOR
{
	public class C_Categoria
	{
		public static int existe(string nombre)
		{
			return new M_Categoria()
				.existeModelo(nombre);
		}

		public static int registrar(string nombre)
		{
			return new M_Categoria()
				.registrarModelo(nombre);
		}

		public static int editar(int codigo, string nombre)
		{
			return new M_Categoria()
				.editarModelo(codigo, nombre);
		}

		public static int eliminar(int codigo)
		{
			return new M_Categoria()
				.eliminarModelo(codigo);
		}

		public static DataTable listar()
		{
			return new M_Categoria()
				.listarModelo();
		}
	}
}