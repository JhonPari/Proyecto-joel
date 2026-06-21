using ProyectoJoel.Modelo;
using System.Data;

namespace ProyectoJoel.Controlador
{
	internal class C_HistorialVentas
	{
		public static DataTable ListarVentasControlador()
		{
			return new M_HistorialVentas()
				.ListarVentasModelo();
		}
	}
}