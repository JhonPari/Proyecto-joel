using ProyectoJoel.Modelo;
using System.Data;

namespace ProyectoJoel.Controlador
{
	internal class C_Empleado
	{
		public static int RegistrarEmpleadoControlador(
			string nombre,
			string apellido,
			string cargo,
			string telefono,
			string email)
		{
			M_Empleado empleado = new M_Empleado();

			empleado.Nombre = nombre;
			empleado.Apellido = apellido;
			empleado.Cargo = cargo;
			empleado.Telefono = telefono;
			empleado.Email = email;

			return empleado.RegistrarEmpleadoModelo(empleado);
		}

		public static DataTable ListarEmpleadoControlador()
		{
			return new M_Empleado().ListarEmpleadoModelo();
		}

		public static int EditarEmpleadoControlador(
			int idEmpleado,
			string nombre,
			string apellido,
			string cargo,
			string telefono,
			string email)
		{
			M_Empleado empleado = new M_Empleado();

			empleado.IdEmpleado = idEmpleado;
			empleado.Nombre = nombre;
			empleado.Apellido = apellido;
			empleado.Cargo = cargo;
			empleado.Telefono = telefono;
			empleado.Email = email;

			return empleado.EditarEmpleadoModelo(empleado);
		}

		public static int EliminarEmpleadoControlador(
			int idEmpleado)
		{
			M_Empleado empleado = new M_Empleado();

			empleado.IdEmpleado = idEmpleado;

			return empleado.EliminarEmpleadoModelo(empleado);
		}
	}
}