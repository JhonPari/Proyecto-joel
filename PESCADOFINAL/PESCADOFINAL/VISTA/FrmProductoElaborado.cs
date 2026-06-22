using PESCADOFINAL.CONTROLADOR;
using System;
using System.Data;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class FrmProductoElaborado : Form
	{
		private int codigoSeleccionado = 0;

		public FrmProductoElaborado()
		{
			InitializeComponent();
		}

		private void FrmProductoElaborado_Load(object sender, EventArgs e)
		{
			ToolTip tip = new ToolTip();

			tip.SetToolTip(cmbProductoBase, "Insumo base original.");
			tip.SetToolTip(txtNombrePlato, "Nombre del plato / elaborado. Solo letras.");
			tip.SetToolTip(txtPrecioVenta, "Precio de venta. Decimales.");
			tip.SetToolTip(txtCantidad, "Cantidad de elaborados a producir. Solo enteros.");
			tip.SetToolTip(cmbElaboradoExistente, "Plato YA registrado para aumentar su stock.");
			tip.SetToolTip(txtStockAgregar, "Cantidad a producir del plato seleccionado.");
			tip.SetToolTip(btnAumentarStock, "Sube el stock del plato seleccionado y descuenta su insumo base.");
			tip.SetToolTip(btnNuevo, "Preparar el formulario para un nuevo plato.");
			tip.SetToolTip(btnGuardar, "Registrar el elaborado.");
			tip.SetToolTip(btnEditar, "Actualizar datos del plato seleccionado.");
			tip.SetToolTip(btnEliminar, "Eliminar el plato seleccionado.");
			tip.SetToolTip(btnCancelar, "Limpiar los campos.");
			tip.SetToolTip(btnVolver, "Cerrar y volver al menu principal.");

			cargarInsumos();
			cargarElaborados();
			listar();
			estadoInicial();

			dgvElaborados.AllowUserToAddRows = false;
		}

		private void cargarInsumos()
		{
			DataTable dt = C_Producto.listar();

			cmbProductoBase.DataSource = dt;
			cmbProductoBase.DisplayMember = "NOMBRE";
			cmbProductoBase.ValueMember = "CODIGO";
			cmbProductoBase.SelectedIndex = -1;
		}

		private void cargarElaborados()
		{
			DataTable dt = C_ProductoElaborado.listar();

			cmbElaboradoExistente.DataSource = dt;
			cmbElaboradoExistente.DisplayMember = "PLATO";
			cmbElaboradoExistente.ValueMember = "CODIGO";
			cmbElaboradoExistente.SelectedIndex = -1;
		}

		private void listar()
		{
			dgvElaborados.DataSource = C_ProductoElaborado.listar();
		}

		private void txtNombrePlato_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) &&
				e.KeyChar != ' ' &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) &&
				e.KeyChar != '.' &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			if (e.KeyChar == '.' &&
				txtPrecioVenta.Text.Contains("."))
			{
				e.Handled = true;
			}
		}

		private void txtCantidad_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtStockAgregar_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void dgvElaborados_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow f = dgvElaborados.Rows[e.RowIndex];

			if (f.Cells["CODIGO"].Value == null ||
				f.Cells["CODIGO"].Value == DBNull.Value)
			{
				return;
			}

			codigoSeleccionado =
				Convert.ToInt32(f.Cells["CODIGO"].Value);

			txtNombrePlato.Text =
				f.Cells["PLATO"].Value?.ToString() ?? "";

			txtPrecioVenta.Text =
				f.Cells["PRECIO"].Value?.ToString() ?? "";

			cmbProductoBase.SelectedValue =
				f.Cells["PRD_BASE"].Value;

			btnGuardar.Enabled = false;
			btnEditar.Enabled = true;
			btnEliminar.Enabled = true;
		}

		private decimal rendimientoDe(string nombreInsumo, string categoriaInsumo)
		{
			string n = (nombreInsumo ?? "").ToUpper();
			string c = (categoriaInsumo ?? "").ToUpper();

			if (n.Contains("PESCADO") ||
				n.Contains("TAMBAQUI") ||
				c.Contains("PESCADO"))
			{
				return 2m;
			}

			return 1m;
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			limpiar();

			btnGuardar.Enabled = true;
			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;

			cmbProductoBase.Focus();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (cmbProductoBase.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione el insumo base.");
				return;
			}

			if (txtNombrePlato.Text.Trim() == "")
			{
				MessageBox.Show("Ingrese el nombre del plato.");
				txtNombrePlato.Focus();
				return;
			}

			if (C_ProductoElaborado.existe(txtNombrePlato.Text.Trim()) > 0)
			{
				MessageBox.Show("Ese plato ya existe.");
				return;
			}

			if (!decimal.TryParse(txtPrecioVenta.Text.Trim(), out decimal precio))
			{
				MessageBox.Show("Precio de venta invalido.");
				txtPrecioVenta.Focus();
				return;
			}

			if (!int.TryParse(txtCantidad.Text.Trim(), out int cantProducir) ||
				cantProducir <= 0)
			{
				MessageBox.Show("Cantidad invalida.");
				txtCantidad.Focus();
				return;
			}

			DataRowView baseRow =
				(DataRowView)cmbProductoBase.SelectedItem;

			int prdBase =
				Convert.ToInt32(baseRow["CODIGO"]);

			string nombreInsumo =
				baseRow["NOMBRE"].ToString();

			string categoriaInsumo = "";

			if (baseRow.Row.Table.Columns.Contains("CATEGORIA"))
			{
				categoriaInsumo =
					baseRow["CATEGORIA"].ToString();
			}

			decimal rendimiento =
				rendimientoDe(nombreInsumo, categoriaInsumo);

			decimal descuentoInsumo =
				cantProducir / rendimiento;

			int pelCod =
				C_ProductoElaborado.registrar(
					prdBase,
					txtNombrePlato.Text.Trim(),
					"",
					precio,
					rendimiento);

			if (pelCod <= 0)
			{
				MessageBox.Show("Error al registrar el elaborado.");
				return;
			}

			C_ProductoElaborado.aumentarStock(
				pelCod,
				cantProducir);

			C_Producto.descontarStock(
				prdBase,
				descuentoInsumo);

			MessageBox.Show(
				"Elaborado registrado.\nProducidos: " + cantProducir +
				"\nInsumo descontado: " + descuentoInsumo.ToString("N2") +
				" (" + nombreInsumo + ")",
				"EXITO");

			limpiar();
			listar();
			cargarInsumos();
			cargarElaborados();
			estadoInicial();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (codigoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un elaborado de la lista.");
				return;
			}

			if (!decimal.TryParse(txtPrecioVenta.Text.Trim(), out decimal precio))
			{
				MessageBox.Show("Precio invalido.");
				txtPrecioVenta.Focus();
				return;
			}

			if (cmbProductoBase.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione el insumo base.");
				return;
			}

			int prdBase =
				Convert.ToInt32(cmbProductoBase.SelectedValue);

			int resultado =
				C_ProductoElaborado.editar(
					codigoSeleccionado,
					prdBase,
					txtNombrePlato.Text.Trim(),
					"",
					precio,
					1);

			if (resultado > 0)
			{
				MessageBox.Show("Precio actualizado.", "EXITO");

				limpiar();
				listar();
				cargarElaborados();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al actualizar elaborado.");
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (codigoSeleccionado == 0)
			{
				MessageBox.Show("Seleccione un elaborado de la lista.");
				return;
			}

			DialogResult rta =
				MessageBox.Show(
					"¿Eliminar el plato seleccionado?",
					"CONFIRMAR",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

			if (rta != DialogResult.Yes)
				return;

			int resultado =
				C_ProductoElaborado.eliminar(
					codigoSeleccionado);

			if (resultado > 0)
			{
				MessageBox.Show("Plato eliminado.", "EXITO");

				limpiar();
				listar();
				cargarElaborados();
				estadoInicial();
			}
			else
			{
				MessageBox.Show("Error al eliminar elaborado.");
			}
		}

		private void btnAumentarStock_Click(object sender, EventArgs e)
		{
			if (cmbElaboradoExistente.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione un plato ya registrado.");
				return;
			}

			if (!int.TryParse(txtStockAgregar.Text.Trim(), out int cant) ||
				cant <= 0)
			{
				MessageBox.Show("Cantidad a producir invalida.");
				txtStockAgregar.Focus();
				return;
			}

			DataRowView row =
				(DataRowView)cmbElaboradoExistente.SelectedItem;

			int pelCod =
				Convert.ToInt32(row["CODIGO"]);

			int prdBase =
				Convert.ToInt32(row["PRD_BASE"]);

			decimal rend =
				Convert.ToDecimal(row["CANTIDAD"]);

			if (rend <= 0)
				rend = 1m;

			decimal descuentoInsumo =
				cant / rend;

			C_ProductoElaborado.aumentarStock(
				pelCod,
				cant);

			if (prdBase > 0)
			{
				C_Producto.descontarStock(
					prdBase,
					descuentoInsumo);
			}

			MessageBox.Show(
				"Stock aumentado en " + cant + " unidades.\nInsumo descontado: " +
				descuentoInsumo.ToString("N2"),
				"EXITO");

			txtStockAgregar.Clear();
			cmbElaboradoExistente.SelectedIndex = -1;

			listar();
			cargarInsumos();
			cargarElaborados();
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

			txtNombrePlato.Clear();
			txtPrecioVenta.Clear();
			txtCantidad.Clear();
			txtStockAgregar.Clear();

			cmbProductoBase.SelectedIndex = -1;
			cmbElaboradoExistente.SelectedIndex = -1;
		}

		private void estadoInicial()
		{
			btnGuardar.Enabled = true;
			btnEditar.Enabled = false;
			btnEliminar.Enabled = false;
		}
	}
}