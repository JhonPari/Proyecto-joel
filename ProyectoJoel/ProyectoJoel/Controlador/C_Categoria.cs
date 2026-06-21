using ProyectoJoel.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoJoel.Controlador
{
	internal class C_Categoria
	{
		public static int RegistrarCategoriaControlador(string nombre,string descripcion)
		{
			M_Categoria categoria = new M_Categoria();

			categoria.Nombre = nombre;
			categoria.Descripcion = descripcion;

			return categoria.RegistrarCategoriaModelo(categoria);
		}

		public static DataTable ListarCategoriaControlador()
		{
			return new M_Categoria().ListarCategoriaModelo();
		}
		public static int EditarCategoriaControlador(int idCategoria,string nombre,string descripcion)
		{
			M_Categoria categoria = new M_Categoria();

			categoria.IdCategoria = idCategoria;
			categoria.Nombre = nombre;
			categoria.Descripcion = descripcion;

			return categoria.EditarCategoriaModelo(categoria);
		}

		public static int EliminarCategoriaControlador(int idCategoria)
		{
			M_Categoria categoria = new M_Categoria();

			categoria.IdCategoria = idCategoria;

			return categoria.EliminarCategoriaModelo(categoria);
		}
	}
}
