using ProyectoJoel.Modelo;

namespace ProyectoJoel.Controlador
{
	internal class C_Venta
	{
		public static int RegistrarVentaControlador(
			int idCliente,
			int idEmpleado,
			decimal total)
		{
			M_Venta venta = new M_Venta();

			venta.IdCliente = idCliente;
			venta.IdEmpleado = idEmpleado;
			venta.Total = total;

			return venta.RegistrarVentaModelo(venta);
		}
	}
}