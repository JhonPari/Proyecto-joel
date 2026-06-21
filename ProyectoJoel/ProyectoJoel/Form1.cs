using ProyectoJoel.Vista;
using ProyectoJoel.Vista.Login;
using ProyectoJoel.Vista.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJoel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCategoria_Click(object sender, EventArgs e)
		{
			FrmCategoria frm = new FrmCategoria();
			frm.ShowDialog();
		}

		private void btnProductos_Click(object sender, EventArgs e)
		{
			FrmProducto frm = new FrmProducto();
			frm.ShowDialog();
		}

		private void btnClientes_Click(object sender, EventArgs e)
		{
			FrmCliente frm = new FrmCliente();
			frm.ShowDialog();
		}

		private void btnEmpleados_Click(object sender, EventArgs e)
		{
			FrmEmpleado frm = new FrmEmpleado();
			frm.ShowDialog();
		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
			FrmUsuarios frm = new FrmUsuarios();
			frm.ShowDialog();
		}

		private void btnVentas_Click(object sender, EventArgs e)
		{
			FrmVenta frm = new FrmVenta();
			frm.ShowDialog();
		}



		private void pictureBox9_Click(object sender, EventArgs e)
		{

		}

		private void btnCerrarSession_Click(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show(
			"¿Desea cerrar sesión?",
			"Cerrar Sesión",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				FrmLogin login = new FrmLogin();

				login.Show();

				this.Close();
			}
		}

		private void btnHistorial_Click_1(object sender, EventArgs e)
		{
			FrmHistorialVentas frm = new FrmHistorialVentas();
			frm.ShowDialog();
		}

		private void btnReportes_Click(object sender, EventArgs e)
		{
			FrmReporteVentas frm = new FrmReporteVentas();
			frm.ShowDialog();
		}

		private void btnReporte2_Click(object sender, EventArgs e)
		{
			FrmReporteStock frm = new FrmReporteStock();
			frm.ShowDialog();
		}

		private void btnReporte3_Click(object sender, EventArgs e)
		{
			FrmReporteProductoVentas frm = new FrmReporteProductoVentas();
			frm.ShowDialog();
		}
	}
}
