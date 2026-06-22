using PESCADOFINAL.CONTROLADOR;
using System;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class FrmUsuarios : Form
	{
		private int codigoSeleccionado = 0;

		public FrmUsuarios()
		{
			InitializeComponent();
		}

		private void FrmUsuarios_Load(object sender, EventArgs e)
		{
			ToolTip tip = new ToolTip();

			tip.SetToolTip(txtNombre, "Nombre completo. Solo letras, sin numeros.");
			tip.SetToolTip(txtUsuario, "Usuario alfanumerico. Sin caracteres especiales.");
			tip.SetToolTip(txtContrasena, "Contrasena alfanumerica. Sin caracteres especiales.");
			tip.SetToolTip(cmbRol, "Seleccione el rol: ADMIN o CAJERO.");
			tip.SetToolTip(btnNuevo, "Preparar el formulario para un nuevo usuario.");
			tip.SetToolTip(btnGuardar, "Registrar un nuevo usuario.");
			tip.SetToolTip(btnEditar, "Guardar cambios del usuario seleccionado.");
			tip.SetToolTip(btnEliminar, "Eliminar el usuario seleccionado.");
			tip.SetToolTip(btnCancelar, "Limpiar los campos.");
			tip.SetToolTip(btnVolver, "Cerrar y volver al menu principal.");

			cmbRol.Items.Clear();
			cmbRol.Items.Add("ADMIN");
			cmbRol.Items.Add("CAJERO");

			listar();
			estadoInicial();

			dgvUsuarios.AllowUserToAddRows = false;
		}

		private void listar()
		{
			dgvUsuarios.DataSource = C_Usuario.listar();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FrmMenuPrincipal menu = new FrmMenuPrincipal();
			menu.Show();
			this.Close();
		}

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

		private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetterOrDigit(e.KeyChar) &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;

				MessageBox.Show(
					"El usuario solo admite letras y numeros.",
					"VALIDACION",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
		}

		private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetterOrDigit(e.KeyChar) &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;

				MessageBox.Show(
					"La contrasena solo admite letras y numeros.",
					"VALIDACION",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
			}
		}

		private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow f = dgvUsuarios.Rows[e.RowIndex];

			if (f.Cells["CODIGO"].Value == null ||
				f.Cells["CODIGO"].Value == DBNull.Value)
			{
				return;
			}

			codigoSeleccionado =
				Convert.ToInt32(f.Cells["CODIGO"].Value);

			txtNombre.Text =
				f.Cells["NOMBRE"].Value?.ToString() ?? "";

			txtUsuario.Text =
				f.Cells["USUARIO"].Value?.ToString() ?? "";

			txtContrasena.Clear();

			cmbRol.SelectedItem =
				f.Cells["ROL"].Value?.ToString() ?? "";

			btnGuardar.Enabled = false;
			btnEditar.Enabled = true;
			btnEliminar.Enabled = true;
		}

		private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			limpiar();

			btnGuardar.Enabled = true;
			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;

			txtNombre.Focus();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (!validar(true))
				return;

			if (C_Usuario.existe(txtUsuario.Text.Trim()) > 0)
			{
				MessageBox.Show("Ese nombre de usuario ya existe.");
				return;
			}

			int resultado =
				C_Usuario.registrar(
					txtNombre.Text.Trim(),
					txtUsuario.Text.Trim(),
					txtContrasena.Text.Trim(),
					cmbRol.SelectedItem.ToString());

			if (resultado > 0)
			{
				MessageBox.Show("Usuario registrado.", "EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al registrar usuario.");
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (codigoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un usuario de la lista.");
				return;
			}

			if (!validar(false))
				return;

			int resultado =
				C_Usuario.editar(
					codigoSeleccionado,
					txtNombre.Text.Trim(),
					txtUsuario.Text.Trim(),
					txtContrasena.Text.Trim(),
					cmbRol.SelectedItem.ToString());

			if (resultado > 0)
			{
				MessageBox.Show("Usuario actualizado.", "EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al actualizar usuario.");
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (codigoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un usuario de la lista.");
				return;
			}

			DialogResult rta =
				MessageBox.Show(
					"¿Eliminar el usuario seleccionado?",
					"CONFIRMAR",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

			if (rta != DialogResult.Yes)
				return;

			int resultado =
				C_Usuario.eliminar(codigoSeleccionado);

			if (resultado > 0)
			{
				MessageBox.Show("Usuario eliminado.", "EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al eliminar usuario.");
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			limpiar();
			estadoInicial();
		}

		private bool validar(bool pideClave)
		{
			if (txtNombre.Text.Trim() == "" ||
				txtUsuario.Text.Trim() == "" ||
				cmbRol.SelectedItem == null)
			{
				MessageBox.Show("Complete nombre, usuario y rol.");
				return false;
			}

			if (pideClave &&
				txtContrasena.Text.Trim() == "")
			{
				MessageBox.Show("Ingrese la contrasena.");
				txtContrasena.Focus();
				return false;
			}

			return true;
		}

		private void limpiar()
		{
			codigoSeleccionado = 0;

			txtNombre.Clear();
			txtUsuario.Clear();
			txtContrasena.Clear();

			cmbRol.SelectedIndex = -1;

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