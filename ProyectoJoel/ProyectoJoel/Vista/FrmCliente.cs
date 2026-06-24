using ProyectoJoel.Controlador;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoJoel.Vista
{
	public partial class FrmCliente : Form
	{
		private int idClienteSeleccionado = 0;

		public FrmCliente()
		{
			InitializeComponent();
		}

		private void FrmCliente_Load(object sender, EventArgs e)
		{
			ListarClientes();

			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;

			dgvClientes.AllowUserToAddRows = false;
		}

		private void ListarClientes()
		{
			dgvClientes.DataSource =
				C_Cliente.ListarClienteControlador();
		}

		private void Limpiar()
		{
			txtNombre.Clear();
			txtApellido.Clear();
			txtDni.Clear();
			txtTelefono.Clear();
			txtDireccion.Clear();

			idClienteSeleccionado = 0;

			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;

			txtNombre.Focus();
		}

		private bool ValidarDatos()
		{
			if (string.IsNullOrWhiteSpace(txtNombre.Text))
			{
				MessageBox.Show("El nombre es obligatorio");
				txtNombre.Focus();
				return false;
			}

			if (txtNombre.Text.Trim().Length < 3)
			{
				MessageBox.Show("El nombre debe tener al menos 3 caracteres");
				txtNombre.Focus();
				return false;
			}

			if (!txtNombre.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
			{
				MessageBox.Show("El nombre solo puede contener letras");
				txtNombre.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtApellido.Text))
			{
				MessageBox.Show("El apellido es obligatorio");
				txtApellido.Focus();
				return false;
			}

			if (txtApellido.Text.Trim().Length < 3)
			{
				MessageBox.Show("El apellido debe tener al menos 3 caracteres");
				txtApellido.Focus();
				return false;
			}

			if (!txtApellido.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
			{
				MessageBox.Show("El apellido solo puede contener letras");
				txtApellido.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtDni.Text))
			{
				MessageBox.Show("El DNI es obligatorio");
				txtDni.Focus();
				return false;
			}

			if (!txtDni.Text.All(char.IsDigit))
			{
				MessageBox.Show("El DNI solo puede contener números");
				txtDni.Focus();
				return false;
			}

			if (txtDni.Text.Length < 8)
			{
				MessageBox.Show("El DNI debe tener al menos 8 dígitos");
				txtDni.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtTelefono.Text))
			{
				MessageBox.Show("El teléfono es obligatorio");
				txtTelefono.Focus();
				return false;
			}

			if (!txtTelefono.Text.All(char.IsDigit))
			{
				MessageBox.Show("El teléfono solo puede contener números");
				txtTelefono.Focus();
				return false;
			}

			if (txtTelefono.Text.Length < 8)
			{
				MessageBox.Show("El teléfono debe tener al menos 8 dígitos");
				txtTelefono.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtDireccion.Text))
			{
				MessageBox.Show("La dirección es obligatoria");
				txtDireccion.Focus();
				return false;
			}

			if (txtDireccion.Text.Trim().Length < 3)
			{
				MessageBox.Show("La dirección debe tener al menos 3 caracteres");
				txtDireccion.Focus();
				return false;
			}

			return true;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (!ValidarDatos())
				return;

			int resultado =
				C_Cliente.RegistrarClienteControlador(
					txtNombre.Text,
					txtApellido.Text,
					txtDni.Text,
					txtTelefono.Text,
					txtDireccion.Text);

			if (resultado > 0)
			{
				MessageBox.Show("Cliente registrado correctamente");

				Limpiar();
				ListarClientes();
			}
			else
			{
				MessageBox.Show("Error al registrar cliente");
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (idClienteSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un cliente");
				return;
			}

			if (!ValidarDatos())
				return;

			int resultado =
				C_Cliente.EditarClienteControlador(
					idClienteSeleccionado,
					txtNombre.Text,
					txtApellido.Text,
					txtDni.Text,
					txtTelefono.Text,
					txtDireccion.Text);

			if (resultado > 0)
			{
				MessageBox.Show("Cliente actualizado correctamente");

				Limpiar();
				ListarClientes();
			}
			else
			{
				MessageBox.Show("Error al actualizar cliente");
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (idClienteSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un cliente");
				return;
			}

			DialogResult r = MessageBox.Show(
				"¿Desea eliminar este cliente?",
				"Confirmar",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (r == DialogResult.No)
				return;

			int resultado =
				C_Cliente.EliminarClienteControlador(
					idClienteSeleccionado);

			if (resultado > 0)
			{
				MessageBox.Show("Cliente eliminado correctamente");

				Limpiar();
				ListarClientes();
			}
			else
			{
				MessageBox.Show("Error al eliminar cliente");
			}
		}

		private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0)
					return;

				DataGridViewRow fila =
					dgvClientes.Rows[e.RowIndex];

				if (fila.Cells["IdCliente"].Value == DBNull.Value)
					return;

				idClienteSeleccionado =
					Convert.ToInt32(
						fila.Cells["IdCliente"].Value);

				txtNombre.Text =
					fila.Cells["Nombre"].Value?.ToString() ?? "";

				txtApellido.Text =
					fila.Cells["Apellido"].Value?.ToString() ?? "";

				txtDni.Text =
					fila.Cells["DNI"].Value?.ToString() ?? "";

				txtTelefono.Text =
					fila.Cells["Telefono"].Value?.ToString() ?? "";

				txtDireccion.Text =
					fila.Cells["Direccion"].Value?.ToString() ?? "";

				btnEditar.Enabled = true;
				btnEliminar.Enabled = true;
			}
			catch
			{
			}
		}
		private void BuscarClientes()
		{
			string texto = txtCliente.Text.Trim();

			if (string.IsNullOrWhiteSpace(texto))
			{
				ListarClientes();
				return;
			}

			DataTable tabla = C_Cliente.ListarClienteControlador();

			DataView vista = tabla.DefaultView;

			vista.RowFilter =
				$"Nombre LIKE '%{texto}%' OR " +
				$"Apellido LIKE '%{texto}%' OR " +
				$"DNI LIKE '%{texto}%' OR " +
				$"Telefono LIKE '%{texto}%'";

			dgvClientes.DataSource = vista;
		}



		private void txtCliente_TextChanged(object sender, EventArgs e)
		{
			BuscarClientes();
		}
	}
}