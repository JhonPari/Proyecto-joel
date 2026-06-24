using ProyectoJoel.Controlador;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoJoel.Vista
{
	public partial class FrmUsuarios : Form
	{
		private int idUsuarioSeleccionado = 0;

		public FrmUsuarios()
		{
			InitializeComponent();
		}

		private void FrmUsuarios_Load_1(object sender, EventArgs e)
		{
			ListarUsuarios();

			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;

			dgvUsuarios.AllowUserToAddRows = false;
		}

		private void ListarUsuarios()
		{
			dgvUsuarios.DataSource =
				C_Usuario.ListarUsuarioControlador();
		}

		private void Limpiar()
		{
			txtUsuario.Clear();
			txtContrasena.Clear();
			txtRol.Clear();

			idUsuarioSeleccionado = 0;

			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;

			txtUsuario.Focus();
		}

		private bool ValidarDatos()
		{
			if (string.IsNullOrWhiteSpace(txtUsuario.Text))
			{
				MessageBox.Show("El usuario es obligatorio");
				txtUsuario.Focus();
				return false;
			}

			if (txtUsuario.Text.Trim().Length < 3)
			{
				MessageBox.Show("El usuario debe tener al menos 3 caracteres");
				txtUsuario.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtContrasena.Text))
			{
				MessageBox.Show("La contraseña es obligatoria");
				txtContrasena.Focus();
				return false;
			}

			if (txtContrasena.Text.Length < 8)
			{
				MessageBox.Show("La contraseña debe tener al menos 8 caracteres");
				txtContrasena.Focus();
				return false;
			}

			if (!txtContrasena.Text.Any(char.IsUpper))
			{
				MessageBox.Show("La contraseña debe contener al menos una letra mayúscula");
				txtContrasena.Focus();
				return false;
			}

			int cantidadNumeros =
				txtContrasena.Text.Count(char.IsDigit);

			if (cantidadNumeros < 2)
			{
				MessageBox.Show("La contraseña debe contener al menos 2 números");
				txtContrasena.Focus();
				return false;
			}

			if (!Regex.IsMatch(
				txtContrasena.Text,
				@"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]"))
			{
				MessageBox.Show("La contraseña debe contener al menos un carácter especial");
				txtContrasena.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtRol.Text))
			{
				MessageBox.Show("El rol es obligatorio");
				txtRol.Focus();
				return false;
			}

			string rol =
				txtRol.Text.Trim().ToLower();

			if (rol != "admin" &&
				rol != "cajero")
			{
				MessageBox.Show("El rol solo puede ser admin o cajero");
				txtRol.Focus();
				return false;
			}

			return true;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (!ValidarDatos())
				return;

			int resultado =
				C_Usuario.RegistrarUsuarioControlador(
					txtUsuario.Text,
					txtContrasena.Text,
					txtRol.Text.ToLower());

			if (resultado > 0)
			{
				MessageBox.Show("Usuario registrado correctamente");

				Limpiar();
				ListarUsuarios();
			}
			else
			{
				MessageBox.Show("Error al registrar usuario");
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (idUsuarioSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un usuario");
				return;
			}

			if (!ValidarDatos())
				return;

			int resultado =
				C_Usuario.EditarUsuarioControlador(
					idUsuarioSeleccionado,
					txtUsuario.Text,
					txtContrasena.Text,
					txtRol.Text.ToLower());

			if (resultado > 0)
			{
				MessageBox.Show("Usuario actualizado correctamente");

				Limpiar();
				ListarUsuarios();
			}
			else
			{
				MessageBox.Show("Error al actualizar usuario");
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (idUsuarioSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un usuario");
				return;
			}

			DialogResult r =
				MessageBox.Show(
					"¿Desea eliminar este usuario?",
					"Confirmar",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

			if (r == DialogResult.No)
				return;

			int resultado =
				C_Usuario.EliminarUsuarioControlador(
					idUsuarioSeleccionado);

			if (resultado > 0)
			{
				MessageBox.Show("Usuario eliminado correctamente");

				Limpiar();
				ListarUsuarios();
			}
			else
			{
				MessageBox.Show("Error al eliminar usuario");
			}
		}

		private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0)
					return;

				DataGridViewRow fila =
					dgvUsuarios.Rows[e.RowIndex];

				if (fila.Cells["IdUsuario"].Value == DBNull.Value)
					return;

				idUsuarioSeleccionado =
					Convert.ToInt32(
						fila.Cells["IdUsuario"].Value);

				txtUsuario.Text =
					fila.Cells["Usuario"].Value?.ToString() ?? "";

				txtContrasena.Text =
					fila.Cells["Contrasena"].Value?.ToString() ?? "";

				txtRol.Text =
					fila.Cells["Rol"].Value?.ToString() ?? "";

				btnEditar.Enabled = true;
				btnEliminar.Enabled = true;
			}
			catch
			{
			}
		}

		private void BuscarUsuario()
		{
			string texto = txtBuscarUsuario.Text.Trim();

			if (string.IsNullOrWhiteSpace(texto))
			{
				ListarUsuarios();
				return;
			}

			DataTable tabla = C_Usuario.ListarUsuarioControlador();

			DataView vista = tabla.DefaultView;

			vista.RowFilter =
				$"Usuario LIKE '%{texto}%' OR " +
				$"Contrasena LIKE '%{texto}%' OR " +
				$"Rol LIKE '%{texto}%'";

			dgvUsuarios.DataSource = vista;
		}

		private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
		{
			BuscarUsuario();
		}
	}
}