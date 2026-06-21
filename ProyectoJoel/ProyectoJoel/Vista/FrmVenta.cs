using ProyectoJoel.Controlador;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoJoel.Vista
{
	public partial class FrmVenta : Form
	{
		private DataTable detalleVenta = new DataTable();
		private decimal totalVenta = 0;

		public FrmVenta()
		{
			InitializeComponent();

			this.Load += FrmVenta_Load;
		}

		private void FrmVenta_Load(object sender, EventArgs e)
		{
			CargarClientes();
			CargarEmpleados();
			CargarProductos();

			detalleVenta.Columns.Add("IdProducto");
			detalleVenta.Columns.Add("Producto");
			detalleVenta.Columns.Add("Precio");
			detalleVenta.Columns.Add("Cantidad");
			detalleVenta.Columns.Add("Subtotal");

			dgvDetalleVenta.DataSource = detalleVenta;

			txtPrecio.ReadOnly = true;
			txtTotal.ReadOnly = true;
		}

		private void CargarClientes()
		{
			DataTable dt =
				C_Cliente.ListarClienteControlador();

			cmbCliente.DataSource = dt;
			cmbCliente.DisplayMember = "Nombre";
			cmbCliente.ValueMember = "IdCliente";
		}

		private void CargarEmpleados()
		{
			DataTable dt =
				C_Empleado.ListarEmpleadoControlador();

			cmbEmpleado.DataSource = dt;
			cmbEmpleado.DisplayMember = "Nombre";
			cmbEmpleado.ValueMember = "IdEmpleado";
		}

		private void CargarProductos()
		{
			DataTable dt =
				C_Producto.ListarProductoControlador();

			cmbProducto.DataSource = dt;
			cmbProducto.DisplayMember = "Nombre";
			cmbProducto.ValueMember = "IdProducto";

			cmbProducto.SelectedIndexChanged -= cmbProducto_SelectedIndexChanged;
			cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;

			if (dt.Rows.Count > 0)
			{
				txtPrecio.Text = dt.Rows[0]["Precio"].ToString();
			}
		}

		private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (cmbProducto.SelectedItem == null)
					return;

				DataRowView fila =
					(DataRowView)cmbProducto.SelectedItem;

				txtPrecio.Text =
					fila["Precio"].ToString();
			}
			catch
			{
			}
		}

		private bool ValidarCantidad()
		{
			if (string.IsNullOrWhiteSpace(txtCantidad.Text))
			{
				MessageBox.Show("La cantidad no puede estar vacía");
				txtCantidad.Focus();
				return false;
			}

			int cantidad;

			if (!int.TryParse(txtCantidad.Text, out cantidad))
			{
				MessageBox.Show("La cantidad solo debe contener números");
				txtCantidad.Focus();
				return false;
			}

			if (cantidad < 1)
			{
				MessageBox.Show("La cantidad debe ser mayor o igual a 1");
				txtCantidad.Focus();
				return false;
			}

			return true;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (!ValidarCantidad())
				return;

			if (cmbProducto.SelectedIndex < 0)
			{
				MessageBox.Show("Seleccione un producto");
				return;
			}

			int cantidad = Convert.ToInt32(txtCantidad.Text);

			decimal precio;

			if (!decimal.TryParse(txtPrecio.Text, out precio))
			{
				MessageBox.Show("Precio inválido");
				return;
			}

			decimal subtotal =
				cantidad * precio;

			detalleVenta.Rows.Add(
				cmbProducto.SelectedValue,
				cmbProducto.Text,
				precio,
				cantidad,
				subtotal);

			totalVenta += subtotal;

			txtTotal.Text =
				totalVenta.ToString("0.00");

			txtCantidad.Clear();
		}

		private void btnQuitar_Click(object sender, EventArgs e)
		{
			if (dgvDetalleVenta.CurrentRow == null)
				return;

			decimal subtotal =
				Convert.ToDecimal(
				dgvDetalleVenta.CurrentRow.Cells["Subtotal"].Value);

			totalVenta -= subtotal;

			txtTotal.Text =
				totalVenta.ToString("0.00");

			dgvDetalleVenta.Rows.Remove(
				dgvDetalleVenta.CurrentRow);
		}

		private void btnGuardarVenta_Click(object sender, EventArgs e)
		{
			if (detalleVenta.Rows.Count == 0)
			{
				MessageBox.Show("Agregue productos");
				return;
			}

			int idVenta =
				C_Venta.RegistrarVentaControlador(
					Convert.ToInt32(cmbCliente.SelectedValue),
					Convert.ToInt32(cmbEmpleado.SelectedValue),
					totalVenta);

			if (idVenta > 0)
			{
				foreach (DataRow fila in detalleVenta.Rows)
				{
					C_DetalleVenta.RegistrarDetalleControlador(
						idVenta,
						Convert.ToInt32(fila["IdProducto"]),
						Convert.ToInt32(fila["Cantidad"]),
						Convert.ToDecimal(fila["Precio"]),
						Convert.ToDecimal(fila["Subtotal"])
					);
				}

				MessageBox.Show("Venta registrada correctamente");

				LimpiarVenta();
			}
			else
			{
				MessageBox.Show("No se pudo registrar la venta");
			}
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			LimpiarVenta();
		}

		private void LimpiarVenta()
		{
			detalleVenta.Rows.Clear();

			totalVenta = 0;

			txtCantidad.Clear();

			txtTotal.Text = "0.00";

			if (cmbCliente.Items.Count > 0)
				cmbCliente.SelectedIndex = 0;

			if (cmbEmpleado.Items.Count > 0)
				cmbEmpleado.SelectedIndex = 0;

			if (cmbProducto.Items.Count > 0)
				cmbProducto.SelectedIndex = 0;
		}

		private void dgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}