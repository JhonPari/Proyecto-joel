using PESCADOFINAL.MODELO;
using System.Data;

namespace PESCADOFINAL.CONTROLADOR
{
	public class C_Producto
	{
		public static int existe(string nombre, string tamano)
		{
			return new M_Producto().existeModelo(nombre, tamano);
		}

		public static int registrar(
			int catCodigo,
			string nombre,
			string tamano,
			decimal precioCosto)
		{
			return new M_Producto().registrarModelo(
				catCodigo,
				nombre,
				tamano,
				precioCosto);
		}

		public static int editar(
			int codigo,
			int catCodigo,
			string nombre,
			string tamano,
			decimal precioCosto)
		{
			return new M_Producto().editarModelo(
				codigo,
				catCodigo,
				nombre,
				tamano,
				precioCosto);
		}

		public static int eliminar(int codigo)
		{
			return new M_Producto().eliminarModelo(codigo);
		}

		public static DataTable listar()
		{
			return new M_Producto().listarModelo();
		}

		public static int aumentarStock(int codigo, decimal cantidad)
		{
			return new M_Producto().aumentarStockModelo(codigo, cantidad);
		}

		public static int descontarStock(int codigo, decimal cantidad)
		{
			return new M_Producto().descontarStockModelo(codigo, cantidad);
		}

		public static DataTable stockCritico(decimal minimo)
		{
			return new M_Producto().stockCriticoModelo(minimo);
		}

		public static int cambiarEstado(int codigo)
		{
			return new M_Producto().cambiarEstadoModelo(codigo);
		}

		public static DataTable listarActivos()
		{
			return new M_Producto().listarActivosModelo();
		}
	}
}