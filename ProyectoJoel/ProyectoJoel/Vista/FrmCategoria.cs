using ProyectoJoel.Controlador;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoJoel.Vista
{
	public partial class FrmCategoria : Form
	{
		private int idCategoriaSeleccionada = 0;

		public FrmCategoria()
		{
			InitializeComponent();
		}

		private void FrmCategoria_Load(object sender, EventArgs e)
		{
			ListarCategorias();

			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;
		}

		private void ListarCategorias()
		{
			dgvCategorias.DataSource =
				C_Categoria.ListarCategoriaControlador();
		}

		private void Limpiar()
		{
			txtNombre.Clear();
			txtDescripcion.Clear();

			idCategoriaSeleccionada = 0;

			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;

			txtNombre.Focus();
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
				MessageBox.Show("Ingrese el nombre de la categoría");
				txtNombre.Focus();
				return false;
			}

			if (txtNombre.Text.Trim().Length < 3)
			{
				MessageBox.Show("El nombre debe tener al menos 3 caracteres");
				txtNombre.Focus();
				return false;
			}

			if (ContieneNumeros(txtNombre.Text))
			{
				MessageBox.Show("El nombre no puede contener números");
				txtNombre.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
			{
				MessageBox.Show("Ingrese una descripción");
				txtDescripcion.Focus();
				return false;
			}

			if (txtDescripcion.Text.Trim().Length < 3)
			{
				MessageBox.Show("La descripción debe tener al menos 3 caracteres");
				txtDescripcion.Focus();
				return false;
			}

			if (ContieneNumeros(txtDescripcion.Text))
			{
				MessageBox.Show("La descripción no puede contener números");
				txtDescripcion.Focus();
				return false;
			}

			return true;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (!ValidarCampos())
				return;

			int resultado =
				C_Categoria.RegistrarCategoriaControlador(
					txtNombre.Text.Trim(),
					txtDescripcion.Text.Trim()
				);

			if (resultado > 0)
			{
				MessageBox.Show("Categoría registrada correctamente");

				Limpiar();
				ListarCategorias();
			}
			else
			{
				MessageBox.Show("Error al registrar categoría");
			}
		}

		private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow fila =
				dgvCategorias.Rows[e.RowIndex];

			if (fila.Cells["IdCategoria"].Value == null ||
				fila.Cells["IdCategoria"].Value == DBNull.Value)
			{
				return;
			}

			idCategoriaSeleccionada =
				Convert.ToInt32(
					fila.Cells["IdCategoria"].Value);

			txtNombre.Text =
				fila.Cells["Nombre"].Value?.ToString() ?? "";

			txtDescripcion.Text =
				fila.Cells["Descripcion"].Value?.ToString() ?? "";

			btnEditar.Enabled = true;
			btnEliminar.Enabled = true;
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (idCategoriaSeleccionada == 0)
			{
				MessageBox.Show("Seleccione una categoría");
				return;
			}

			if (!ValidarCampos())
				return;

			int resultado =
				C_Categoria.EditarCategoriaControlador(
					idCategoriaSeleccionada,
					txtNombre.Text.Trim(),
					txtDescripcion.Text.Trim());

			if (resultado > 0)
			{
				MessageBox.Show("Categoría actualizada");

				Limpiar();
				ListarCategorias();
			}
			else
			{
				MessageBox.Show("Error al actualizar categoría");
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (idCategoriaSeleccionada == 0)
			{
				MessageBox.Show("Seleccione una categoría");
				return;
			}

			DialogResult respuesta =
				MessageBox.Show(
					"¿Desea eliminar esta categoría?",
					"Confirmar",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

			if (respuesta == DialogResult.Yes)
			{
				int resultado =
					C_Categoria.EliminarCategoriaControlador(
						idCategoriaSeleccionada);

				if (resultado > 0)
				{
					MessageBox.Show("Categoría eliminada");

					Limpiar();
					ListarCategorias();
				}
				else
				{
					MessageBox.Show("Error al eliminar categoría");
				}
			}
		}
		private void BuscarCategoria()
		{
			string texto = txtCategoria.Text.Trim();

			if (string.IsNullOrWhiteSpace(texto))
			{
				ListarCategorias();
				return;
			}

			DataTable tabla = C_Categoria.ListarCategoriaControlador();

			DataView vista = tabla.DefaultView;

			vista.RowFilter =
				$"Nombre LIKE '%{texto}%' OR " +
				$"Descripcion LIKE '%{texto}%'";

			dgvCategorias.DataSource = vista;
		}



		private void txtCategoria_TextChanged(object sender, EventArgs e)
		{
			BuscarCategoria();
		}
	}
}