using PESCADOFINAL.CONTROLADOR;
using System;
using System.Data;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class FrmVentas : Form
	{
		private DataTable dtProductos;
		private DataTable dtCategorias;
		private int filaSeleccionada = -1;
		private decimal totalVenta = 0;

		// Cambia este valor si usas usuario logueado
		private int usuarioCodigo = 1;

		public FrmVentas()
		{
			InitializeComponent();
		}

		private void FrmVentas_Load(object sender, EventArgs e)
		{
			txtPrecioUnit.ReadOnly = true;

			configurarGrilla();
			cargarCategorias();
			cargarProductos();

			cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;

			limpiarTodo();
			estadoInicial();
		}

		private void configurarGrilla()
		{
			dgvDetalle.Columns.Clear();
			dgvDetalle.AllowUserToAddRows = false;
			dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "PEL_COD",
				HeaderText = "PEL_COD",
				Visible = false
			});

			dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "PRODUCTO",
				HeaderText = "Producto",
				Width = 180
			});

			dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "CANTIDAD",
				HeaderText = "Cantidad",
				Width = 80
			});

			dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "PRECIO",
				HeaderText = "Precio",
				Width = 90
			});

			dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
			{
				Name = "SUBTOTAL",
				HeaderText = "Subtotal",
				Width = 90
			});
		}

		private void cargarCategorias()
		{
			dtCategorias = C_Categoria.listar();

			cmbCategoria.DataSource = dtCategorias;
			cmbCategoria.DisplayMember = "NOMBRE";
			cmbCategoria.ValueMember = "CODIGO";
			cmbCategoria.SelectedIndex = -1;
		}

		private void cargarProductos()
		{
			dtProductos = C_ProductoElaborado.listar();

			cmbProducto.DataSource = dtProductos;
			cmbProducto.DisplayMember = "PLATO";
			cmbProducto.ValueMember = "CODIGO";
			cmbProducto.SelectedIndex = -1;
		}

		private void cargarProductosPorCategoria(int categoriaCodigo)
		{
			if (dtProductos == null)
				return;

			DataView dv = dtProductos.DefaultView;

			if (dtProductos.Columns.Contains("CAT_CODIGO"))
			{
				dv.RowFilter = "CAT_CODIGO = " + categoriaCodigo;
			}
			else
			{
				dv.RowFilter = "";
			}

			cmbProducto.DataSource = dv;
			cmbProducto.DisplayMember = "PLATO";
			cmbProducto.ValueMember = "CODIGO";
			cmbProducto.SelectedIndex = -1;
		}

		private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbCategoria.SelectedIndex >= 0 &&
				cmbCategoria.SelectedValue != null &&
				int.TryParse(cmbCategoria.SelectedValue.ToString(), out int catCodigo))
			{
				cargarProductosPorCategoria(catCodigo);
			}
		}

		private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbProducto.SelectedIndex >= 0 &&
				cmbProducto.SelectedItem is DataRowView fila)
			{
				if (fila.Row.Table.Columns.Contains("PRECIO"))
				{
					txtPrecioUnit.Text =
						fila["PRECIO"].ToString();
				}

				if (fila.Row.Table.Columns.Contains("STOCK_DISP"))
				{
					lblStockDisp.Text =
						"Stock: " + fila["STOCK_DISP"].ToString();
				}
				else
				{
					lblStockDisp.Text = "Stock: -";
				}
			}
			else
			{
				txtPrecioUnit.Clear();
				lblStockDisp.Text = "Stock: -";
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (cmbProducto.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione un producto.");
				return;
			}

			if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) ||
				cantidad <= 0)
			{
				MessageBox.Show("Cantidad invalida.");
				txtCantidad.Focus();
				return;
			}

			if (!decimal.TryParse(txtPrecioUnit.Text.Trim(), out decimal precio) ||
				precio <= 0)
			{
				MessageBox.Show("Precio invalido.");
				return;
			}

			DataRowView filaProducto = (DataRowView)cmbProducto.SelectedItem;

			int pelCod = Convert.ToInt32(filaProducto["CODIGO"]);
			string producto = filaProducto["PLATO"].ToString();

			decimal stockDisponible = 0;

			if (filaProducto.Row.Table.Columns.Contains("STOCK_DISP"))
			{
				stockDisponible = Convert.ToDecimal(filaProducto["STOCK_DISP"]);
			}

			if (cantidad > stockDisponible)
			{
				MessageBox.Show("Stock insuficiente. Disponible: " + stockDisponible);
				return;
			}

			decimal subtotal = cantidad * precio;

			dgvDetalle.Rows.Add(
				pelCod,
				producto,
				cantidad,
				precio,
				subtotal);

			calcularTotal();
			limpiarLinea();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (filaSeleccionada < 0)
			{
				MessageBox.Show("Seleccione una fila del carrito.");
				return;
			}

			if (cmbProducto.SelectedIndex == -1)
			{
				MessageBox.Show("Seleccione un producto.");
				return;
			}

			if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) ||
				cantidad <= 0)
			{
				MessageBox.Show("Cantidad invalida.");
				txtCantidad.Focus();
				return;
			}

			if (!decimal.TryParse(txtPrecioUnit.Text.Trim(), out decimal precio) ||
				precio <= 0)
			{
				MessageBox.Show("Precio invalido.");
				return;
			}

			DataRowView filaProducto = (DataRowView)cmbProducto.SelectedItem;

			int pelCod = Convert.ToInt32(filaProducto["CODIGO"]);
			string producto = filaProducto["PLATO"].ToString();

			decimal stockDisponible = 0;

			if (filaProducto.Row.Table.Columns.Contains("STOCK_DISP"))
			{
				stockDisponible = Convert.ToDecimal(filaProducto["STOCK_DISP"]);
			}

			if (cantidad > stockDisponible)
			{
				MessageBox.Show("Stock insuficiente. Disponible: " + stockDisponible);
				return;
			}

			decimal subtotal = cantidad * precio;

			dgvDetalle.Rows[filaSeleccionada].Cells["PEL_COD"].Value = pelCod;
			dgvDetalle.Rows[filaSeleccionada].Cells["PRODUCTO"].Value = producto;
			dgvDetalle.Rows[filaSeleccionada].Cells["CANTIDAD"].Value = cantidad;
			dgvDetalle.Rows[filaSeleccionada].Cells["PRECIO"].Value = precio;
			dgvDetalle.Rows[filaSeleccionada].Cells["SUBTOTAL"].Value = subtotal;

			filaSeleccionada = -1;

			calcularTotal();
			limpiarLinea();
			estadoInicial();
		}

		private void btnQuitarItem_Click(object sender, EventArgs e)
		{
			if (dgvDetalle.CurrentRow == null)
			{
				MessageBox.Show("Seleccione una fila del carrito.");
				return;
			}

			dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);

			calcularTotal();
			limpiarLinea();
			estadoInicial();
		}

		private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow fila = dgvDetalle.Rows[e.RowIndex];

			if (fila.Cells["PEL_COD"].Value == null ||
				fila.Cells["PEL_COD"].Value == DBNull.Value)
			{
				return;
			}

			filaSeleccionada = e.RowIndex;

			cmbProducto.SelectedValue = Convert.ToInt32(fila.Cells["PEL_COD"].Value);
			txtCantidad.Text = fila.Cells["CANTIDAD"].Value.ToString();
			txtPrecioUnit.Text = fila.Cells["PRECIO"].Value.ToString();

			btnAgregar.Enabled = false;
			btnEditar.Enabled = true;
		}

		private void btnCobrar_Click(object sender, EventArgs e)
		{
			if (totalVenta <= 0)
			{
				MessageBox.Show("No existe total para cobrar.");
				return;
			}

			if (!decimal.TryParse(txtMonto.Text.Trim(), out decimal monto) ||
				monto <= 0)
			{
				MessageBox.Show("Ingrese el monto recibido.");
				txtMonto.Focus();
				return;
			}

			if (monto < totalVenta)
			{
				MessageBox.Show("El monto recibido no cubre el total.");
				txtMonto.Focus();
				return;
			}

			decimal cambio = monto - totalVenta;

			lblCambio.Text = "Cambio: Bs " + cambio.ToString("N2");
			lblImporte.Text = "IMPORTE : Bs " + monto.ToString("N2");

			MessageBox.Show("Cambio: Bs " + cambio.ToString("N2"), "COBRO");
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			if (dgvDetalle.Rows.Count == 0)
			{
				MessageBox.Show("Agregue productos al carrito.");
				return;
			}

			if (totalVenta <= 0)
			{
				MessageBox.Show("Total invalido.");
				return;
			}

			if (!decimal.TryParse(txtMonto.Text.Trim(), out decimal monto) ||
				monto <= 0)
			{
				MessageBox.Show("Ingrese el monto recibido.");
				txtMonto.Focus();
				return;
			}

			if (monto < totalVenta)
			{
				MessageBox.Show("El monto recibido no cubre el total.");
				txtMonto.Focus();
				return;
			}

			decimal cambio = monto - totalVenta;

			string cliente = txtCliente.Text.Trim();
			string nit = txtNit.Text.Trim();

			if (cliente == "")
				cliente = "SIN NOMBRE";

			if (nit == "")
				nit = "0";

			int venCod = C_Venta.registrarVenta(
				totalVenta,
				monto,
				cambio,
				usuarioCodigo,
				cliente,
				nit);

			if (venCod <= 0)
			{
				MessageBox.Show("Error al registrar la venta.");
				return;
			}

			foreach (DataGridViewRow fila in dgvDetalle.Rows)
			{
				if (fila.IsNewRow)
					continue;

				int pelCod = Convert.ToInt32(fila.Cells["PEL_COD"].Value);
				int cantidad = Convert.ToInt32(fila.Cells["CANTIDAD"].Value);
				decimal precio = Convert.ToDecimal(fila.Cells["PRECIO"].Value);
				decimal subtotal = Convert.ToDecimal(fila.Cells["SUBTOTAL"].Value);

				C_Venta.registrarDetalle(
					venCod,
					pelCod,
					cantidad,
					precio,
					subtotal);

				C_ProductoElaborado.aumentarStock(
					pelCod,
					cantidad * -1);
			}

			MessageBox.Show(
				"Venta registrada correctamente.\nCambio: Bs " +
				cambio.ToString("N2"),
				"EXITO");

			limpiarTodo();
			cargarProductos();
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			limpiarTodo();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			limpiarLinea();
			estadoInicial();
		}

		private void calcularTotal()
		{
			totalVenta = 0;

			foreach (DataGridViewRow fila in dgvDetalle.Rows)
			{
				if (fila.IsNewRow)
					continue;

				totalVenta += Convert.ToDecimal(fila.Cells["SUBTOTAL"].Value);
			}

			lblTotal.Text = "Total : Bs " + totalVenta.ToString("N2");
			calcularCambioAutomatico();
		}

		private void calcularCambioAutomatico()
		{
			if (decimal.TryParse(txtMonto.Text.Trim(), out decimal monto))
			{
				decimal cambio = monto - totalVenta;

				if (cambio >= 0)
					lblCambio.Text = "Cambio: Bs " + cambio.ToString("N2");
				else
					lblCambio.Text = "Cambio: Bs 0.00";

				lblImporte.Text = "IMPORTE : Bs " + monto.ToString("N2");
			}
			else
			{
				lblCambio.Text = "Cambio: Bs 0.00";
				lblImporte.Text = "IMPORTE : Bs 0.00";
			}
		}

		private void limpiarLinea()
		{
			cmbProducto.SelectedIndex = -1;
			txtCantidad.Clear();
			txtPrecioUnit.Clear();
			lblStockDisp.Text = "Stock: -";
			filaSeleccionada = -1;
			cmbProducto.Focus();
		}

		private void limpiarTodo()
		{
			dgvDetalle.Rows.Clear();

			txtCliente.Clear();
			txtNit.Clear();
			txtCantidad.Clear();
			txtPrecioUnit.Clear();
			txtMonto.Clear();

			lblTotal.Text = "Total : Bs 0.00";
			lblCambio.Text = "Cambio: Bs 0.00";
			lblImporte.Text = "IMPORTE : Bs 0.00";
			lblStockDisp.Text = "Stock: -";

			totalVenta = 0;
			filaSeleccionada = -1;

			cmbCategoria.SelectedIndex = -1;
			cmbProducto.SelectedIndex = -1;

			estadoInicial();
			cmbCategoria.Focus();
		}

		private void estadoInicial()
		{
			btnAgregar.Enabled = true;
			btnEditar.Enabled = false;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FrmMenuCajero menu = new FrmMenuCajero();
			menu.Show();
			this.Close();
		}

		private void txtMonto_TextChanged(object sender, EventArgs e)
		{

		}
	}
}