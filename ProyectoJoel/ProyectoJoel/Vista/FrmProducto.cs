using ProyectoJoel.Controlador;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoJoel.Vista
{
	public partial class FrmProducto : Form
	{
		private int idProductoSeleccionado = 0;
		private string rutaImagen = "";

		public FrmProducto()
		{
			InitializeComponent();
		}

		private void FrmProducto_Load(object sender, EventArgs e)
		{
			ListarProductos();
			CargarCategorias();

			bntEditar.Enabled = false;
			bntEliminar.Enabled = false;

			dgvProductos.AllowUserToAddRows = false;
			txtNombre.KeyPress += CerrarSiEsNumero_KeyPress;
			txtMarca.KeyPress += CerrarSiEsNumero_KeyPress;
			txtColor.KeyPress += CerrarSiEsNumero_KeyPress;

			toolTipProducto.SetToolTip(txtNombre, "Ingrese solo letras. No se permiten números.");
			toolTipProducto.SetToolTip(txtMarca, "Ingrese solo letras. No se permiten números.");
			toolTipProducto.SetToolTip(txtColor, "Ingrese solo letras. No se permiten números.");

			toolTipProducto.SetToolTip(txtTalla, "Ingrese solo números mayores a 1.");
			toolTipProducto.SetToolTip(txtPrecio, "Ingrese un precio mayor a 1.");
			toolTipProducto.SetToolTip(txtStock, "Ingrese stock igual o mayor a 0.");
			toolTipProducto.SetToolTip(btnImagen, "Seleccione una imagen del producto.");
		}
		private ToolTip toolTipProducto = new ToolTip();

		private void CerrarSiEsNumero_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				MessageBox.Show("No se permiten números. Se cerrará la ventana.");
				this.Close(); 
			}
		}

		private void ListarProductos()
		{
			dgvProductos.DataSource =
				C_Producto.ListarProductoControlador();
		}

		private void CargarCategorias()
		{
			cmbCategoria.DataSource =
				C_Categoria.ListarCategoriaControlador();

			cmbCategoria.DisplayMember = "Nombre";
			cmbCategoria.ValueMember = "IdCategoria";
		}

		private void Limpiar()
		{
			txtNombre.Clear();
			txtMarca.Clear();
			txtTalla.Clear();
			txtColor.Clear();
			txtPrecio.Clear();
			txtStock.Clear();

			if (cmbCategoria.Items.Count > 0)
				cmbCategoria.SelectedIndex = 0;

			idProductoSeleccionado = 0;

			bntEditar.Enabled = false;
			bntEliminar.Enabled = false;

			txtNombre.Focus();
			pbImagen.Image = null;
			rutaImagen = "";
		}

		private bool ContieneNumeros(string texto)
		{
			foreach (char c in texto)
			{
				if (char.IsDigit(c))
					return true;
			}

			return false;
		}

		private bool ValidarCampos()
		{
			if (string.IsNullOrWhiteSpace(txtNombre.Text))
			{
				MessageBox.Show("Ingrese el nombre");
				txtNombre.Focus();
				return false;
			}

			if (txtNombre.Text.Trim().Length < 3)
			{
				MessageBox.Show("El nombre debe tener mínimo 3 caracteres");
				txtNombre.Focus();
				return false;
			}

			if (ContieneNumeros(txtNombre.Text))
			{
				MessageBox.Show("El nombre no puede contener números");
				txtNombre.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtMarca.Text))
			{
				MessageBox.Show("Ingrese la marca");
				txtMarca.Focus();
				return false;
			}

			if (txtMarca.Text.Trim().Length < 3)
			{
				MessageBox.Show("La marca debe tener mínimo 3 caracteres");
				txtMarca.Focus();
				return false;
			}

			if (ContieneNumeros(txtMarca.Text))
			{
				MessageBox.Show("La marca no puede contener números");
				txtMarca.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtTalla.Text))
			{
				MessageBox.Show("Ingrese la talla");
				txtTalla.Focus();
				return false;
			}

			if (!int.TryParse(txtTalla.Text, out int talla))
			{
				MessageBox.Show("La talla debe ser numérica");
				txtTalla.Focus();
				return false;
			}

			if (talla <= 1)
			{
				MessageBox.Show("La talla debe ser mayor a 1");
				txtTalla.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPrecio.Text))
			{
				MessageBox.Show("Ingrese el precio");
				txtPrecio.Focus();
				return false;
			}

			if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
			{
				MessageBox.Show("El precio debe ser numérico");
				txtPrecio.Focus();
				return false;
			}

			if (precio <= 1)
			{
				MessageBox.Show("El precio debe ser mayor a 1");
				txtPrecio.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtStock.Text))
			{
				MessageBox.Show("Ingrese el stock");
				txtStock.Focus();
				return false;
			}

			if (!int.TryParse(txtStock.Text, out int stock))
			{
				MessageBox.Show("El stock debe ser numérico");
				txtStock.Focus();
				return false;
			}

			if (stock < 0)
			{
				MessageBox.Show("El stock no puede ser negativo");
				txtStock.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtColor.Text))
			{
				MessageBox.Show("Ingrese el color");
				txtColor.Focus();
				return false;
			}

			if (txtColor.Text.Trim().Length < 3)
			{
				MessageBox.Show("El color debe tener mínimo 3 caracteres");
				txtColor.Focus();
				return false;
			}

			if (ContieneNumeros(txtColor.Text))
			{
				MessageBox.Show("El color no puede contener números");
				txtColor.Focus();
				return false;
			}
			return true;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (!ValidarCampos())
				return;

			if (string.IsNullOrWhiteSpace(rutaImagen))
			{
				MessageBox.Show("Seleccione una imagen");
				return;
			}

			int resultado =
				C_Producto.RegistrarProductoControlador(
					txtNombre.Text.Trim(),
					txtMarca.Text.Trim(),
					Convert.ToInt32(txtTalla.Text),
					txtColor.Text.Trim(),
					Convert.ToDecimal(txtPrecio.Text),
					Convert.ToInt32(txtStock.Text),
					Convert.ToInt32(cmbCategoria.SelectedValue),
					rutaImagen
				);

			if (resultado > 0)
			{
				MessageBox.Show("Producto registrado");

				Limpiar();
				ListarProductos();
			}
			else
			{
				MessageBox.Show("Error al registrar");
			}
		}

		private void bntEditar_Click(object sender, EventArgs e)
		{
			if (idProductoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un producto");
				return;
			}

			if (!ValidarCampos())
				return;

			if (string.IsNullOrWhiteSpace(rutaImagen))
			{
				MessageBox.Show("Seleccione una imagen");
				return;
			}

			int resultado =
				C_Producto.EditarProductoControlador(
					idProductoSeleccionado,
					txtNombre.Text.Trim(),
					txtMarca.Text.Trim(),
					Convert.ToInt32(txtTalla.Text),
					txtColor.Text.Trim(),
					Convert.ToDecimal(txtPrecio.Text),
					Convert.ToInt32(txtStock.Text),
					Convert.ToInt32(cmbCategoria.SelectedValue),
					rutaImagen
				);

			if (resultado > 0)
			{
				MessageBox.Show("Producto actualizado");

				Limpiar();
				ListarProductos();
			}
			else
			{
				MessageBox.Show("Error al actualizar");
			}
		}

		private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0)
					return;

				DataGridViewRow fila =
					dgvProductos.Rows[e.RowIndex];

				if (fila.Cells["IdProducto"].Value == DBNull.Value)
					return;

				idProductoSeleccionado =
					Convert.ToInt32(
						fila.Cells["IdProducto"].Value);

				txtNombre.Text =
					fila.Cells["Nombre"].Value?.ToString() ?? "";

				txtMarca.Text =
					fila.Cells["Marca"].Value?.ToString() ?? "";

				txtTalla.Text =
					fila.Cells["Talla"].Value?.ToString() ?? "";

				txtColor.Text =
					fila.Cells["Color"].Value?.ToString() ?? "";

				txtPrecio.Text =
					fila.Cells["Precio"].Value?.ToString() ?? "";

				txtStock.Text =
					fila.Cells["Stock"].Value?.ToString() ?? "";

				rutaImagen =
					fila.Cells["Imagen"].Value?.ToString() ?? "";

				if (!string.IsNullOrEmpty(rutaImagen)
					&& System.IO.File.Exists(rutaImagen))
				{
					pbImagen.ImageLocation =
						rutaImagen;

					pbImagen.SizeMode =
						PictureBoxSizeMode.StretchImage;
				}
				else
				{
					pbImagen.Image = null;
				}

				bntEditar.Enabled = true;
				bntEliminar.Enabled = true;
			}
			catch
			{
			}
		}

		private void bntEliminar_Click(object sender, EventArgs e)
		{
			if (idProductoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un producto");
				return;
			}

			DialogResult r =
				MessageBox.Show(
					"¿Desea eliminar el producto?",
					"Confirmar",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

			if (r == DialogResult.No)
				return;

			int resultado =
				C_Producto.EliminarProductoControlador(
					idProductoSeleccionado);

			if (resultado > 0)
			{
				MessageBox.Show("Producto eliminado");

				Limpiar();
				ListarProductos();
			}
		}

		private void btnImagen_Click(object sender, EventArgs e)
		{
			OpenFileDialog abrir = new OpenFileDialog();

			abrir.Filter =
				"Imagenes|*.jpg;*.jpeg;*.png;*.bmp";

			if (abrir.ShowDialog() == DialogResult.OK)
			{
				string carpeta =
					Application.StartupPath + @"\Imagenes\";

				if (!System.IO.Directory.Exists(carpeta))
				{
					System.IO.Directory.CreateDirectory(carpeta);
				}

				string nombreArchivo =
					Guid.NewGuid().ToString() +
					System.IO.Path.GetExtension(abrir.FileName);

				string destino =
					System.IO.Path.Combine(
						carpeta,
						nombreArchivo);

				System.IO.File.Copy(
					abrir.FileName,
					destino,
					true);

				rutaImagen = destino;

				pbImagen.ImageLocation = destino;
				pbImagen.SizeMode =
					PictureBoxSizeMode.StretchImage;
			}
		}
		private void BuscarProducto()
		{
			string texto = txtProductos.Text.Trim();

			if (string.IsNullOrWhiteSpace(texto))
			{
				ListarProductos();
				return;
			}

			DataTable tabla = C_Producto.ListarProductoControlador();

			DataView vista = tabla.DefaultView;

			vista.RowFilter =
				$"Nombre LIKE '%{texto}%' OR " +
				$"Marca LIKE '%{texto}%' OR " +
				$"Color LIKE '%{texto}%' OR " +
				$"Convert(Talla, 'System.String') LIKE '%{texto}%' OR " +
				$"Convert(Precio, 'System.String') LIKE '%{texto}%' OR " +
				$"Convert(Stock, 'System.String') LIKE '%{texto}%'";

			dgvProductos.DataSource = vista;
		}
		private void txtProductos_TextChanged(object sender, EventArgs e)
		{
			BuscarProducto();
		}
	}
}