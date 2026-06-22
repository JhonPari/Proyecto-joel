using PESCADOFINAL.CONTROLADOR;
using System;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class FrmProducto : Form
	{
		private int codigoSeleccionado = 0;

		public FrmProducto()
		{
			InitializeComponent();
		}

		private void FrmProducto_Load(object sender, EventArgs e)
		{
			ToolTip tip = new ToolTip();

			tip.SetToolTip(txtNombre, "Nombre del insumo. Solo letras.");
			tip.SetToolTip(txtTamano, "Tamano. Alfanumerico (Ej: Pequeno, Grande).");
			tip.SetToolTip(txtPrecioCosto, "Precio de costo. Admite decimales.");
			tip.SetToolTip(cmbCategoria, "Categoria del insumo.");
			tip.SetToolTip(botonGuardar, "Registrar un nuevo insumo.");
			tip.SetToolTip(btnEditar, "Guardar los cambios del insumo seleccionado.");
			tip.SetToolTip(botonEliminar, "Activar / Desactivar el insumo.");
			tip.SetToolTip(botonCancelar, "Limpiar los campos.");
			tip.SetToolTip(btnVolver, "Cerrar y volver al menu principal.");

			cargarCategorias();
			listar();
			estadoInicial();

			dgvProductos.AllowUserToAddRows = false;
		}

		private void cargarCategorias()
		{
			cmbCategoria.DataSource = C_Categoria.listar();
			cmbCategoria.DisplayMember = "NOMBRE";
			cmbCategoria.ValueMember = "CODIGO";
			cmbCategoria.SelectedIndex = -1;
		}

		private void listar()
		{
			dgvProductos.DataSource = C_Producto.listar();
		}

		private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow f = dgvProductos.Rows[e.RowIndex];

			if (f.Cells["CODIGO"].Value == null ||
				f.Cells["CODIGO"].Value == DBNull.Value)
				return;

			codigoSeleccionado =
				Convert.ToInt32(f.Cells["CODIGO"].Value);

			txtNombre.Text =
				f.Cells["NOMBRE"].Value?.ToString() ?? "";

			txtTamano.Text =
				f.Cells["TAMANO"].Value?.ToString() ?? "";

			txtPrecioCosto.Text =
				f.Cells["PRECIO"].Value?.ToString() ?? "";

			cmbCategoria.SelectedValue =
				f.Cells["CATEGORIA_CODIGO"].Value;

			botonGuardar.Enabled = false;
			btnEditar.Enabled = true;
			botonEliminar.Enabled = true;
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (codigoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un producto de la lista.");
				return;
			}

			if (!validar())
				return;

			int resultado =
				C_Producto.editar(
					codigoSeleccionado,
					Convert.ToInt32(cmbCategoria.SelectedValue),
					txtNombre.Text.Trim(),
					txtTamano.Text.Trim(),
					Convert.ToDecimal(txtPrecioCosto.Text));

			if (resultado > 0)
			{
				MessageBox.Show("Producto actualizado.", "EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al actualizar producto.");
			}
		}

		private void botonEliminar_Click(object sender, EventArgs e)
		{
			if (codigoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un producto.");
				return;
			}

			DialogResult rta =
				MessageBox.Show(
					"¿Cambiar el estado (Activo/Inactivo) del producto?",
					"CONFIRMAR",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

			if (rta != DialogResult.Yes)
				return;

			int resultado =
				C_Producto.cambiarEstado(codigoSeleccionado);

			if (resultado > 0)
			{
				MessageBox.Show("Estado actualizado.", "EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al cambiar el estado.");
			}
		}

		private void botonCancelar_Click(object sender, EventArgs e)
		{
			limpiar();
			estadoInicial();
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
			}
		}

		private void txtTamano_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetterOrDigit(e.KeyChar) &&
				e.KeyChar != ' ' &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) &&
				e.KeyChar != '.' &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			if (e.KeyChar == '.' &&
				txtPrecioCosto.Text.Contains("."))
			{
				e.Handled = true;
			}
		}

		private void botonGuardar_Click(object sender, EventArgs e)
		{
			if (!validar())
				return;

			if (C_Producto.existe(
				txtNombre.Text.Trim(),
				txtTamano.Text.Trim()) > 0)
			{
				MessageBox.Show("Ese insumo (nombre + tamano) ya existe.");
				return;
			}

			int resultado =
				C_Producto.registrar(
					Convert.ToInt32(cmbCategoria.SelectedValue),
					txtNombre.Text.Trim(),
					txtTamano.Text.Trim(),
					Convert.ToDecimal(txtPrecioCosto.Text));

			if (resultado > 0)
			{
				MessageBox.Show("Insumo registrado.", "EXITO");

				limpiar();
				listar();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al registrar insumo.");
			}
		}

		private bool validar()
		{
			if (txtNombre.Text.Trim() == "")
			{
				MessageBox.Show("Ingrese el nombre.");
				txtNombre.Focus();
				return false;
			}

			if (cmbCategoria.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione la categoria.");
				return false;
			}

			if (!decimal.TryParse(txtPrecioCosto.Text.Trim(), out _))
			{
				MessageBox.Show("Precio de costo invalido.");
				txtPrecioCosto.Focus();
				return false;
			}

			return true;
		}

		private void limpiar()
		{
			codigoSeleccionado = 0;

			txtNombre.Clear();
			txtTamano.Clear();
			txtPrecioCosto.Clear();
			cmbCategoria.SelectedIndex = -1;

			txtNombre.Focus();
		}

		private void estadoInicial()
		{
			botonGuardar.Enabled = true;
			btnEditar.Enabled = false;
			botonEliminar.Enabled = false;
		}
	}
}