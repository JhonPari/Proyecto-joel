using ProyectoJoel.Modelo;
using System.Data;

namespace ProyectoJoel.Controlador
{
	internal class C_Producto
	{
		public static int RegistrarProductoControlador(
			string nombre,
			string marca,
			int talla,
			string color,
			decimal precio,
			int stock,
			int idCategoria,
			string imagen)
		{
			M_Producto p = new M_Producto();

			p.Nombre = nombre;
			p.Marca = marca;
			p.Talla = talla;
			p.Color = color;
			p.Precio = precio;
			p.Stock = stock;
			p.IdCategoria = idCategoria;
			p.Imagen = imagen;

			return p.RegistrarProductoModelo(p);
		}

		public static DataTable ListarProductoControlador()
		{
			return new M_Producto().ListarProductoModelo();
		}

		public static int EditarProductoControlador(
			int idProducto,
			string nombre,
			string marca,
			int talla,
			string color,
			decimal precio,
			int stock,
			int idCategoria,
			string imagen)
		{
			M_Producto p = new M_Producto();

			p.IdProducto = idProducto;
			p.Nombre = nombre;
			p.Marca = marca;
			p.Talla = talla;
			p.Color = color;
			p.Precio = precio;
			p.Stock = stock;
			p.IdCategoria = idCategoria;
			p.Imagen = imagen;

			return p.EditarProductoModelo(p);
		}

		public static int EliminarProductoControlador(
			int idProducto)
		{
			M_Producto p = new M_Producto();

			p.IdProducto = idProducto;

			return p.EliminarProductoModelo(p);
		}
	}
}