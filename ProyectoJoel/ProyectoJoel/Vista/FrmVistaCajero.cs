using ProyectoJoel.Vista.Login;
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
	public partial class FrmVistaCajero : Form
	{
		public FrmVistaCajero()
		{
			InitializeComponent();
		}

		private void btnVentaCajero_Click(object sender, EventArgs e)
		{
			FrmVenta frm = new FrmVenta();
			frm.ShowDialog();
		}

		private void btnRegistraClienteCajero_Click(object sender, EventArgs e)
		{
			FrmCliente frm = new FrmCliente();
			frm.ShowDialog();
		}

		private void btnHistorial_Click(object sender, EventArgs e)
		{
			FrmHistorialVentas frm = new FrmHistorialVentas();
			frm.ShowDialog();
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
	}
}
