using PESCADOFINAL.MODELO;
using System.Data;

namespace PESCADOFINAL.CONTROLADOR
{
	public class C_Proveedor
	{
		public static int existe(string nombre)
		{
			return new M_Proveedor()
				.existeModelo(nombre);
		}

		public static int registrar(
			string nombre,
			string telefono,
			string direccion)
		{
			return new M_Proveedor()
				.registrarModelo(
					nombre,
					telefono,
					direccion);
		}

		public static int editar(
			int codigo,
			string nombre,
			string telefono,
			string direccion)
		{
			return new M_Proveedor()
				.editarModelo(
					codigo,
					nombre,
					telefono,
					direccion);
		}

		public static int eliminar(int codigo)
		{
			return new M_Proveedor()
				.eliminarModelo(codigo);
		}

		public static DataTable listar()
		{
			return new M_Proveedor()
				.listarModelo();
		}
	}
}