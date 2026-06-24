using PESCADOFINAL.MODELO;
using System;
using System.Data;

namespace PESCADOFINAL.CONTROLADOR
{
	public class C_Venta
	{
		public static int registrarVenta(
			decimal total,
			decimal monto,
			decimal cambio,
			int usuCod,
			string cliente,
			string nit)
		{
			return new M_Venta()
				.registrarVentaModelo(
					total,
					monto,
					cambio,
					usuCod,
					cliente,
					nit);
		}

		public static int registrarDetalle(
			int venCod,
			int pelCod,
			int cantidad,
			decimal precio,
			decimal subtotal)
		{
			return new M_Venta()
				.registrarDetalleModelo(
					venCod,
					pelCod,
					cantidad,
					precio,
					subtotal);
		}

		public static DataTable comprobanteCabecera(int venCod)
		{
			return new M_Venta()
				.comprobanteCabeceraModelo(venCod);
		}

		public static DataTable comprobanteDetalle(int venCod)
		{
			return new M_Venta()
				.comprobanteDetalleModelo(venCod);
		}

		public static DataTable reportePeriodo(DateTime desde, DateTime hasta)
		{
			return new M_Venta()
				.reportePeriodoModelo(desde, hasta);
		}

		public static DataTable reporteDia()
		{
			return new M_Venta()
				.reporteDiaModelo();
		}

		public static DataTable reporteMes(int mes, int anio)
		{
			return new M_Venta()
				.reporteMesModelo(mes, anio);
		}

		public static DataTable reporteCategoria(
			int catCodigo,
			DateTime desde,
			DateTime hasta)
		{
			return new M_Venta()
				.reporteCategoriaModelo(
					catCodigo,
					desde,
					hasta);
		}

		public static DataTable masVendidos()
		{
			return new M_Venta()
				.masVendidosModelo();
		}

		public static DataTable ingresosCategoria()
		{
			return new M_Venta()
				.ingresosCategoriaModelo();
		}
		public static DataTable buscarCliente(string dato)
		{
			M_Venta obj = new M_Venta();
			return obj.buscarClienteModelo(dato);
		}
		public static DataTable listarTodasVentas()
		{
			return new M_Venta()
				.listarTodasVentasModelo();
		}

		public static DataTable historialVentasFecha(DateTime inicio, DateTime fin)
		{
			return new M_Venta()
				.historialVentasFechaModelo(inicio, fin);
		}
	}
}