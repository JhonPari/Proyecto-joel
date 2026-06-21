using ProyectoJoel.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJoel.Vista
{
	public partial class FrmHistorialVentas : Form
	{
		public FrmHistorialVentas()
		{
			InitializeComponent();
		}

		private void FrmHistorialVentas_Load(object sender, EventArgs e)
		{
			dgvVentas.DataSource =
	C_HistorialVentas.ListarVentasControlador();

			dgvVentas.AutoSizeColumnsMode =
				DataGridViewAutoSizeColumnsMode.Fill;
		}
	}
}
