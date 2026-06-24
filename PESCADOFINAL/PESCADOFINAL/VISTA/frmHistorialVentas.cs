using PESCADOFINAL.CONTROLADOR;
using System;
using System.Data;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
	public partial class frmHistorialVentas : Form
	{
		private DataTable tablaVentas = new DataTable();

		public frmHistorialVentas()
		{
			InitializeComponent();
		}

		private void frmHistorialVentas_Load(object sender, EventArgs e)
		{
			dtIinicio.Value = DateTime.Now.AddMonths(-1);
			dtFin.Value = DateTime.Now;

			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.ReadOnly = true;
			dataGridView1.SelectionMode =
				DataGridViewSelectionMode.FullRowSelect;

			CargarTodasLasVentas();
		}

		private void CargarTodasLasVentas()
		{
			tablaVentas = C_Venta.listarTodasVentas();
			dataGridView1.DataSource = tablaVentas;
		}

		private void CargarVentasPorFecha()
		{
			tablaVentas =
				C_Venta.historialVentasFecha(
					dtIinicio.Value,
					dtFin.Value);

			dataGridView1.DataSource = tablaVentas;
		}

		private void BuscarClienteEnGrid()
		{
			string texto = txtBuscarCliente.Text.Trim();

			if (tablaVentas == null)
				return;

			DataView vista = tablaVentas.DefaultView;

			if (string.IsNullOrWhiteSpace(texto))
			{
				vista.RowFilter = "";
			}
			else
			{
				vista.RowFilter =
					$"CLIENTE LIKE '%{texto}%' OR " +
					$"NIT LIKE '%{texto}%'";
			}

			dataGridView1.DataSource = vista;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (dtIinicio.Value.Date > dtFin.Value.Date)
			{
				MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha fin.");
				return;
			}

			CargarVentasPorFecha();
			BuscarClienteEnGrid();
		}



		private void txtBuscarCliente_TextChanged_1(object sender, EventArgs e)
		{
			BuscarClienteEnGrid();
		}
	}
}