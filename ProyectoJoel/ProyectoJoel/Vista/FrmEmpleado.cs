using ProyectoJoel.Controlador;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoJoel.Vista
{
	public partial class FrmEmpleado : Form
	{
		private int idEmpleadoSeleccionado = 0;

		public FrmEmpleado()
		{
			InitializeComponent();
		}

		private void FrmEmpleado_Load_1(object sender, EventArgs e)
		{
			ListarEmpleados();

			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;

			dgvEmpleados.AllowUserToAddRows = false;
		}

		private void ListarEmpleados()
		{
			dgvEmpleados.DataSource =
				C_Empleado.ListarEmpleadoControlador();
		}

		private void Limpiar()
		{
			txtNombre.Clear();
			txtApellido.Clear();
			txtCargo.Clear();
			txtTelefono.Clear();
			txtEmail.Clear();

			idEmpleadoSeleccionado = 0;

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

			if (string.IsNullOrWhiteSpace(txtCargo.Text))
			{
				MessageBox.Show("El cargo es obligatorio");
				txtCargo.Focus();
				return false;
			}

			string cargo = txtCargo.Text.Trim().ToLower();

			if (cargo != "cajero" && cargo != "encargado")
			{
				MessageBox.Show("El cargo solo puede ser Cajero o Encargado");
				txtCargo.Focus();
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

			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				MessageBox.Show("El email es obligatorio");
				txtEmail.Focus();
				return false;
			}

			if (!txtEmail.Text.Trim().ToLower().EndsWith("@gmail.com"))
			{
				MessageBox.Show("El email debe terminar en @gmail.com");
				txtEmail.Focus();
				return false;
			}

			return true;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (!ValidarDatos())
				return;

			int resultado =
				C_Empleado.RegistrarEmpleadoControlador(
					txtNombre.Text,
					txtApellido.Text,
					txtCargo.Text,
					txtTelefono.Text,
					txtEmail.Text);

			if (resultado > 0)
			{
				MessageBox.Show("Empleado registrado correctamente");

				Limpiar();
				ListarEmpleados();
			}
			else
			{
				MessageBox.Show("Error al registrar empleado");
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (idEmpleadoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un empleado");
				return;
			}

			if (!ValidarDatos())
				return;

			int resultado =
				C_Empleado.EditarEmpleadoControlador(
					idEmpleadoSeleccionado,
					txtNombre.Text,
					txtApellido.Text,
					txtCargo.Text,
					txtTelefono.Text,
					txtEmail.Text);

			if (resultado > 0)
			{
				MessageBox.Show("Empleado actualizado correctamente");

				Limpiar();
				ListarEmpleados();
			}
			else
			{
				MessageBox.Show("Error al actualizar empleado");
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (idEmpleadoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un empleado");
				return;
			}

			DialogResult r =
				MessageBox.Show(
					"¿Desea eliminar este empleado?",
					"Confirmar",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

			if (r == DialogResult.No)
				return;

			int resultado =
				C_Empleado.EliminarEmpleadoControlador(
					idEmpleadoSeleccionado);

			if (resultado > 0)
			{
				MessageBox.Show("Empleado eliminado correctamente");

				Limpiar();
				ListarEmpleados();
			}
			else
			{
				MessageBox.Show("Error al eliminar empleado");
			}
		}


		private void dgvEmpleados_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow fila =
				dgvEmpleados.Rows[e.RowIndex];

			if (fila.Cells["IdEmpleado"].Value == null ||
				fila.Cells["IdEmpleado"].Value == DBNull.Value)
			{
				return;
			}

			idEmpleadoSeleccionado =
				Convert.ToInt32(fila.Cells["IdEmpleado"].Value);

			txtNombre.Text =
				fila.Cells["Nombre"].Value?.ToString() ?? "";

			txtApellido.Text =
				fila.Cells["Apellido"].Value?.ToString() ?? "";

			txtCargo.Text =
				fila.Cells["Cargo"].Value?.ToString() ?? "";

			txtTelefono.Text =
				fila.Cells["Telefono"].Value?.ToString() ?? "";

			txtEmail.Text =
				fila.Cells["Email"].Value?.ToString() ?? "";

			btnEditar.Enabled = true;
			btnEliminar.Enabled = true;
		}
		private void BuscarEmpleado()
		{
			string texto = txtEmpelado.Text.Trim();

			if (string.IsNullOrWhiteSpace(texto))
			{
				ListarEmpleados();
				return;
			}

			DataTable tabla = C_Empleado.ListarEmpleadoControlador();

			DataView vista = tabla.DefaultView;

			vista.RowFilter =
				$"Nombre LIKE '%{texto}%' OR " +
				$"Apellido LIKE '%{texto}%' OR " +
				$"Cargo LIKE '%{texto}%' OR " +
				$"Telefono LIKE '%{texto}%' OR " +
				$"Email LIKE '%{texto}%'";

			dgvEmpleados.DataSource = vista;
		}
		private void txtEmpelado_TextChanged(object sender, EventArgs e)
		{
			BuscarEmpleado();
		}
	}
}