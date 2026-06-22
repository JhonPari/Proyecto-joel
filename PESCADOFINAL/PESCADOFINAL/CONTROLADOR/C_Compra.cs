using PESCADOFINAL.MODELO;
using System.Data;

namespace PESCADOFINAL.CONTROLADOR
{
	public class C_Compra
	{
		public static int registrarCompra(int proCodigo, decimal total)
		{
			return new M_Compra()
				.registrarCompraModelo(proCodigo, total);
		}

		public static int registrarDetalle(
			int comCodigo,
			int prdCodigo,
			int cantidad,
			decimal precioUnit,
			decimal subtotal)
		{
			return new M_Compra()
				.registrarDetalleModelo(
					comCodigo,
					prdCodigo,
					cantidad,
					precioUnit,
					subtotal);
		}

		public static DataTable listar()
		{
			return new M_Compra()
				.listarModelo();
		}
	}
}