using ProyectoJoel.Modelo;

namespace ProyectoJoel.Controlador
{
	internal class C_DetalleVenta
	{
		public static int RegistrarDetalleControlador(
			int idVenta,
			int idProducto,
			int cantidad,
			decimal precioUnitario,
			decimal subtotal)
		{
			M_DetalleVenta detalle =
				new M_DetalleVenta();

			detalle.IdVenta = idVenta;
			detalle.IdProducto = idProducto;
			detalle.Cantidad = cantidad;
			detalle.PrecioUnitario = precioUnitario;
			detalle.Subtotal = subtotal;

			return detalle.RegistrarDetalleModelo(detalle);
		}
	}
}