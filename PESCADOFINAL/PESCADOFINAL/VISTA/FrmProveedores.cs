using System;
using PESCADOFINAL.CONTROLADOR;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class FrmProveedores : Form
	{
		private int codigoSeleccionado = 0;

		public FrmProveedores()
		{
			InitializeComponent();
		}

		private void FrmProveedores_Load(object sender, EventArgs e)
		{
			ToolTip tip = new ToolTip();

			tip.SetToolTip(txtNombre, "Nombre del proveedor. Solo letras, sin numeros.");
			tip.SetToolTip(txtTelefono, "Telefono de 8 digitos (Bolivia). Solo numeros.");
			tip.SetToolTip(txtDireccion, "Direccion. Solo letras (sin numeros).");
			tip.SetToolTip(btnNuevo, "Preparar el formulario para un nuevo proveedor.");
			tip.SetToolTip(btnGuardar, "Registrar un nuevo proveedor.");
			tip.SetToolTip(btnEditar, "Guardar cambios del proveedor seleccionado.");
			tip.SetToolTip(btnEliminar, "Eliminar el proveedor seleccionado.");
			tip.SetToolTip(btnCancelar, "Limpiar los campos.");
			tip.SetToolTip(btnVolver, "Cerrar y volver al menu principal.");

			txtTelefono.MaxLength = 8;

			listar();
			estadoInicial();
			dgvProveedores.AllowUserToAddRows = false;
		}

		private void listar()
		{
			dgvProveedores.DataSource =
				C_Proveedor.listar();
		}

		// SOLO LETRAS
		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) &&
				e.KeyChar != ' ' &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;

				MessageBox.Show(
					"El nombre solo admite letras.",
					"VALIDACION",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
		}

		// SOLO NUMEROS
		private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;

				MessageBox.Show(
					"El telefono solo admite numeros.",
					"VALIDACION",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
		}

		// SIN NUMEROS
		private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;

				MessageBox.Show(
					"La direccion no admite numeros.",
					"VALIDACION",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
		}

		private void txtTelefono_Validating(
			object sender,
			System.ComponentModel.CancelEventArgs e)
		{
			int len = txtTelefono.Text.Trim().Length;

			if (len > 0 && len != 8)
			{
				MessageBox.Show(
					"El telefono debe tener exactamente 8 digitos.",
					"VALIDACION",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);

				e.Cancel = true;
			}
		}

		// SELECCIONAR FILA
		private void dgvProveedores_CellClick(
			object sender,
			DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow f =
				dgvProveedores.Rows[e.RowIndex];

			if (f.Cells["CODIGO"].Value == null ||
				f.Cells["CODIGO"].Value == DBNull.Value)
			{
				return;
			}

			codigoSeleccionado =
				Convert.ToInt32(f.Cells["CODIGO"].Value);

			txtNombre.Text =
				f.Cells["NOMBRE"].Value?.ToString() ?? "";

			txtTelefono.Text =
				f.Cells["TELEFONO"].Value?.ToString() ?? "";

			txtDireccion.Text =
				f.Cells["DIRECCION"].Value?.ToString() ?? "";

			btnGuardar.Enabled = false;
			btnEditar.Enabled = true;
			btnEliminar.Enabled = true;
		}

		// NUEVO
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			limpiar();

			btnGuardar.Enabled = true;
			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;

			txtNombre.Focus();
		}

		// GUARDAR
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (!validar())
				return;

			if (C_Proveedor.existe(
				txtNombre.Text.Trim()) > 0)
			{
				MessageBox.Show(
					"Ese proveedor ya existe.");

				return;
			}

			int resultado =
				C_Proveedor.registrar(
					txtNombre.Text.Trim(),
					txtTelefono.Text.Trim(),
					txtDireccion.Text.Trim());

			if (resultado > 0)
			{
				MessageBox.Show(
					"Proveedor registrado.",
					"EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show(
					"Error al registrar proveedor.");
			}
		}

		// EDITAR
		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (codigoSeleccionado == 0)
			{
				MessageBox.Show(
					"Seleccione un proveedor.");

				return;
			}

			if (!validar())
				return;

			int resultado =
				C_Proveedor.editar(
					codigoSeleccionado,
					txtNombre.Text.Trim(),
					txtTelefono.Text.Trim(),
					txtDireccion.Text.Trim());

			if (resultado > 0)
			{
				MessageBox.Show(
					"Proveedor actualizado.",
					"EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show(
					"Error al actualizar proveedor.");
			}
		}

		// ELIMINAR
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (codigoSeleccionado == 0)
			{
				MessageBox.Show(
					"Seleccione un proveedor.");

				return;
			}

			DialogResult rta =
				MessageBox.Show(
					"¿Eliminar el proveedor seleccionado?",
					"CONFIRMAR",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

			if (rta != DialogResult.Yes)
				return;

			int resultado =
				C_Proveedor.eliminar(
					codigoSeleccionado);

			if (resultado > 0)
			{
				MessageBox.Show(
					"Proveedor eliminado.",
					"EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show(
					"Error al eliminar proveedor.");
			}
		}

		private void btnCancelar_Click(
			object sender,
			EventArgs e)
		{
			limpiar();
			estadoInicial();
		}

		private void btnVolver_Click(
			object sender,
			EventArgs e)
		{
			FrmMenuPrincipal menu =
				new FrmMenuPrincipal();

			menu.Show();
			this.Close();
		}

		private bool validar()
		{
			if (txtNombre.Text.Trim() == "")
			{
				MessageBox.Show(
					"Ingrese el nombre.");

				txtNombre.Focus();

				return false;
			}

			if (txtTelefono.Text.Trim().Length != 8)
			{
				MessageBox.Show(
					"El telefono debe tener 8 digitos.");

				txtTelefono.Focus();

				return false;
			}

			return true;
		}

		private void limpiar()
		{
			codigoSeleccionado = 0;

			txtNombre.Clear();
			txtTelefono.Clear();
			txtDireccion.Clear();

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