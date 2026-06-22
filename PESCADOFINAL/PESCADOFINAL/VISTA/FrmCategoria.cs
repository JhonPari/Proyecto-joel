using System;
using PESCADOFINAL.CONTROLADOR;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class FrmCategoria : Form
	{
		private int codigoSeleccionado = 0;

		public FrmCategoria()
		{
			InitializeComponent();
		}

		private void FrmCategoria_Load(object sender, EventArgs e)
		{
			ToolTip tip = new ToolTip();

			tip.SetToolTip(txtNombre, "Nombre de la categoria. Solo letras, sin numeros.");
			tip.SetToolTip(btnNuevo, "Preparar el formulario para una nueva categoria.");
			tip.SetToolTip(btnGuardar, "Registrar una nueva categoria.");
			tip.SetToolTip(btnEditar, "Guardar cambios de la categoria seleccionada.");
			tip.SetToolTip(btnEliminar, "Eliminar la categoria seleccionada.");
			tip.SetToolTip(btnCancelar, "Limpiar los campos.");
			tip.SetToolTip(btnVolver, "Cerrar y volver al menu principal.");

			dgvCategorias.AllowUserToAddRows = false;

			// Asegura que al hacer clic en cualquier parte de la fila cargue los datos
			dgvCategorias.CellClick -= dgvCategorias_CellClick;
			dgvCategorias.CellClick += dgvCategorias_CellClick;

			listar();
			estadoInicial();
		}

		private void listar()
		{
			dgvCategorias.DataSource = C_Categoria.listar();
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) &&
				e.KeyChar != ' ' &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;

				MessageBox.Show(
					"La categoria solo admite letras.",
					"VALIDACION",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
		}

		private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow f = dgvCategorias.Rows[e.RowIndex];

			if (f.Cells["CODIGO"].Value == null ||
				f.Cells["CODIGO"].Value == DBNull.Value)
			{
				return;
			}

			codigoSeleccionado =
				Convert.ToInt32(f.Cells["CODIGO"].Value);

			txtNombre.Text =
				f.Cells["NOMBRE"].Value?.ToString() ?? "";

			btnGuardar.Enabled = false;
			btnEditar.Enabled = true;
			btnEliminar.Enabled = true;
		}

		// Deja este método vacío si el Designer lo sigue llamando
		private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvCategorias_CellClick(sender, e);
		}

		private bool existeCategoriaEnGrilla(string nombre, int codigoIgnorar = 0)
		{
			string nombreComparar = nombre.Trim().ToUpper();

			foreach (DataGridViewRow fila in dgvCategorias.Rows)
			{
				if (fila.IsNewRow)
					continue;

				if (fila.Cells["CODIGO"].Value == null ||
					fila.Cells["CODIGO"].Value == DBNull.Value)
					continue;

				int codigoFila =
					Convert.ToInt32(fila.Cells["CODIGO"].Value);

				string nombreFila =
					fila.Cells["NOMBRE"].Value?.ToString().Trim().ToUpper() ?? "";

				if (codigoFila != codigoIgnorar &&
					nombreFila == nombreComparar)
				{
					return true;
				}
			}

			return false;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			string nombre = txtNombre.Text.Trim();

			if (nombre == "")
			{
				MessageBox.Show("Ingrese el nombre de la categoria.");
				txtNombre.Focus();
				return;
			}

			if (existeCategoriaEnGrilla(nombre))
			{
				MessageBox.Show("Esa categoria ya existe.");
				txtNombre.Focus();
				return;
			}

			int resultado =
				C_Categoria.registrar(nombre);

			if (resultado > 0)
			{
				MessageBox.Show("Categoria registrada.", "EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al registrar categoria.");
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (codigoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione una categoria de la lista.");
				return;
			}

			string nombre = txtNombre.Text.Trim();

			if (nombre == "")
			{
				MessageBox.Show("Ingrese el nombre.");
				txtNombre.Focus();
				return;
			}

			if (existeCategoriaEnGrilla(nombre, codigoSeleccionado))
			{
				MessageBox.Show("Ya existe otra categoria con ese nombre.");
				txtNombre.Focus();
				return;
			}

			int resultado =
				C_Categoria.editar(
					codigoSeleccionado,
					nombre);

			if (resultado > 0)
			{
				MessageBox.Show("Categoria actualizada.", "EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al actualizar categoria.");
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (codigoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione una categoria de la lista.");
				return;
			}

			DialogResult rta =
				MessageBox.Show(
					"¿Eliminar la categoria seleccionada?",
					"CONFIRMAR",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

			if (rta != DialogResult.Yes)
				return;

			int resultado =
				C_Categoria.eliminar(
					codigoSeleccionado);

			if (resultado > 0)
			{
				MessageBox.Show("Categoria eliminada.", "EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al eliminar categoria.");
			}
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			limpiar();
			estadoInicial();
			txtNombre.Focus();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			limpiar();
			estadoInicial();
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			FrmMenuPrincipal menu = new FrmMenuPrincipal();
			menu.Show();
			this.Close();
		}

		private void limpiar()
		{
			codigoSeleccionado = 0;
			txtNombre.Clear();
			txtNombre.Focus();
		}

		private void estadoInicial()
		{
			btnGuardar.Enabled = true;
			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;
		}
	}
}