using ProyectoJoel.Controlador;
using ProyectoJoel.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ProyectoJoel.Vista
{
	public partial class FrmVenta : Form
	{
		private DataTable detalleVenta = new DataTable();
		private decimal totalVenta = 0;
		private DataTable tablaClientes = new DataTable();
		private DataTable tablaEmpleados = new DataTable();

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

			if (detalleVenta.Columns.Count == 0)
			{
				detalleVenta.Columns.Add("IdProducto", typeof(int));
				detalleVenta.Columns.Add("Producto", typeof(string));
				detalleVenta.Columns.Add("Precio", typeof(decimal));
				detalleVenta.Columns.Add("Cantidad", typeof(int));
				detalleVenta.Columns.Add("Subtotal", typeof(decimal));
			}

			dgvDetalleVenta.DataSource = detalleVenta;

			txtPrecio.ReadOnly = true;
			txtTotal.ReadOnly = true;
			txtTotal.Text = "0.00";
		}
		private void CargarClientes()
		{
			tablaClientes = C_Cliente.ListarClienteControlador();

			cmbCliente.DataSource = tablaClientes;
			cmbCliente.DisplayMember = "Nombre";
			cmbCliente.ValueMember = "IdCliente";
		}

		private void CargarEmpleados()
		{
			tablaEmpleados = C_Empleado.ListarEmpleadoControlador();

			cmbEmpleado.DataSource = tablaEmpleados;
			cmbEmpleado.DisplayMember = "Nombre";
			cmbEmpleado.ValueMember = "IdEmpleado";
		}
		private void BuscarCliente()
		{
			string texto = txtCliente.Text.Trim();

			DataView vista = tablaClientes.DefaultView;

			if (string.IsNullOrWhiteSpace(texto))
			{
				vista.RowFilter = "";
			}
			else
			{
				vista.RowFilter =
					$"Nombre LIKE '%{texto}%' OR " +
					$"Apellido LIKE '%{texto}%' OR " +
					$"DNI LIKE '%{texto}%'";
			}

			cmbCliente.DataSource = vista;
			cmbCliente.DisplayMember = "Nombre";
			cmbCliente.ValueMember = "IdCliente";
		}

		private void BuscarEmpleado()
		{
			string texto = txtEmpleado.Text.Trim();

			DataView vista = tablaEmpleados.DefaultView;

			if (string.IsNullOrWhiteSpace(texto))
			{
				vista.RowFilter = "";
			}
			else
			{
				vista.RowFilter =
					$"Nombre LIKE '%{texto}%' OR " +
					$"Apellido LIKE '%{texto}%' OR " +
					$"DNI LIKE '%{texto}%'";
			}

			cmbEmpleado.DataSource = vista;
			cmbEmpleado.DisplayMember = "Nombre";
			cmbEmpleado.ValueMember = "IdEmpleado";
		}

		private void CargarProductos()
		{
			DataTable dt = C_Producto.ListarProductoControlador();

			cmbProducto.DataSource = dt;
			cmbProducto.DisplayMember = "Nombre";
			cmbProducto.ValueMember = "IdProducto";

			cmbProducto.SelectedIndexChanged -= cmbProducto_SelectedIndexChanged;
			cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;

			if (dt.Rows.Count > 0)
				txtPrecio.Text = dt.Rows[0]["Precio"].ToString();
		}

		private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbProducto.SelectedItem == null)
				return;

			DataRowView fila = (DataRowView)cmbProducto.SelectedItem;

			if (fila.Row.Table.Columns.Contains("Precio"))
				txtPrecio.Text = fila["Precio"].ToString();
		}

		private bool ValidarCantidad()
		{
			if (string.IsNullOrWhiteSpace(txtCantidad.Text))
			{
				MessageBox.Show("La cantidad no puede estar vacía");
				txtCantidad.Focus();
				return false;
			}

			if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad))
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

			int cantidad = Convert.ToInt32(txtCantidad.Text.Trim());

			if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio))
			{
				MessageBox.Show("Precio inválido");
				return;
			}

			decimal subtotal = cantidad * precio;

			detalleVenta.Rows.Add(
				Convert.ToInt32(cmbProducto.SelectedValue),
				cmbProducto.Text,
				precio,
				cantidad,
				subtotal);

			totalVenta += subtotal;
			txtTotal.Text = totalVenta.ToString("0.00");

			txtCantidad.Clear();
			txtCantidad.Focus();
		}

		private void btnQuitar_Click(object sender, EventArgs e)
		{
			if (dgvDetalleVenta.CurrentRow == null)
			{
				MessageBox.Show("Seleccione un producto del detalle");
				return;
			}

			decimal subtotal =
				Convert.ToDecimal(
					dgvDetalleVenta.CurrentRow.Cells["Subtotal"].Value);

			totalVenta -= subtotal;

			if (totalVenta < 0)
				totalVenta = 0;

			txtTotal.Text = totalVenta.ToString("0.00");

			dgvDetalleVenta.Rows.Remove(dgvDetalleVenta.CurrentRow);
		}

		private void btnGuardarVenta_Click(object sender, EventArgs e)
		{
			if (detalleVenta.Rows.Count == 0)
			{
				MessageBox.Show("Agregue productos");
				return;
			}

			if (cmbCliente.SelectedIndex < 0)
			{
				MessageBox.Show("Seleccione un cliente");
				return;
			}

			if (cmbEmpleado.SelectedIndex < 0)
			{
				MessageBox.Show("Seleccione un empleado");
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

				GenerarReciboPDF(idVenta);

				LimpiarVenta();
			}
			else
			{
				MessageBox.Show("No se pudo registrar la venta");
			}
		}

		private DataTable CargarReciboVenta(int idVenta)
		{
			DataTable dt = new DataTable();

			SqlConnection conexion =
				new dbConexion().ObtenerConexion();

			conexion.Open();

			SqlCommand cmd =
				new SqlCommand("RECIBO_VENTA", conexion);

			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@IdVenta", idVenta);

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);

			conexion.Close();

			return dt;
		}

		private void GenerarReciboPDF(int idVenta)
		{
			DataTable dt = CargarReciboVenta(idVenta);

			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("No se encontraron datos para el recibo.");
				return;
			}

			LocalReport reporte = new LocalReport();

			reporte.ReportEmbeddedResource =
				"ProyectoJoel.Reportes.ReciboVenta.rdlc";

			reporte.DataSources.Clear();

			reporte.DataSources.Add(
				new ReportDataSource("DSReciboVenta", dt));

			try
			{
				byte[] pdf = reporte.Render("WORDOPENXML");

				SaveFileDialog guardar = new SaveFileDialog();
				guardar.Filter = "Archivo PDF|*.pdf";
				guardar.Filter = "Archivo Word|*.docx";
				guardar.FileName = "Recibo_Venta_" + idVenta + ".docx";

				if (guardar.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllBytes(guardar.FileName, pdf);
					MessageBox.Show("Recibo generado correctamente.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Error al generar el recibo:\n" +
					ex.Message + "\n\n" +
					"Detalle:\n" +
					ex.InnerException?.Message);
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

			txtCantidad.Focus();
		}


		private void dgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			BuscarCliente();
		}

		private void txtCliente_TextChanged(object sender, EventArgs e)
		{
			BuscarCliente();
		}

		private void btnBuscarEmpleado_Click(object sender, EventArgs e)
		{
			BuscarEmpleado();
		}

		private void txtEmpleado_TextChanged(object sender, EventArgs e)
		{
			BuscarEmpleado();
			
		}
	}
}