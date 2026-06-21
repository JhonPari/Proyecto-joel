using ProyectoJoel.Modelo;
using System.Data;

namespace ProyectoJoel.Controlador
{
	internal class C_Cliente
	{
		public static int RegistrarClienteControlador(
			string nombre,
			string apellido,
			string dni,
			string telefono,
			string direccion)
		{
			M_Cliente cliente = new M_Cliente();

			cliente.Nombre = nombre;
			cliente.Apellido = apellido;
			cliente.DNI = dni;
			cliente.Telefono = telefono;
			cliente.Direccion = direccion;

			return cliente.RegistrarClienteModelo(cliente);
		}

		public static DataTable ListarClienteControlador()
		{
			return new M_Cliente().ListarClienteModelo();
		}

		public static int EditarClienteControlador(
			int idCliente,
			string nombre,
			string apellido,
			string dni,
			string telefono,
			string direccion)
		{
			M_Cliente cliente = new M_Cliente();

			cliente.IdCliente = idCliente;
			cliente.Nombre = nombre;
			cliente.Apellido = apellido;
			cliente.DNI = dni;
			cliente.Telefono = telefono;
			cliente.Direccion = direccion;

			return cliente.EditarClienteModelo(cliente);
		}

		public static int EliminarClienteControlador(
			int idCliente)
		{
			M_Cliente cliente = new M_Cliente();

			cliente.IdCliente = idCliente;

			return cliente.EliminarClienteModelo(cliente);
		}
	}
}