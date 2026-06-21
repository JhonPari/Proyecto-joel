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

namespace ProyectoJoel.Vista.Login
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			DataTable dt =
				C_Login.IniciarSesionControlador(
					txtUsuario.Text,
					txtContrasena.Text);

			if (dt.Rows.Count == 0)
			{
				MessageBox.Show(
					"Usuario o contraseña incorrectos");

				return;
			}

			string rol =
				dt.Rows[0]["Rol"].ToString();

			if (rol == "admin")
			{
				Form1 frm = new Form1();
				frm.Show();

				this.Hide();
			}
			else if (rol == "cajero")
			{
				FrmVistaCajero frm = new FrmVistaCajero();
				frm.Show();

				this.Hide();
			}
			else
			{
				MessageBox.Show(
					"Rol no válido");
			}
		}
	}
}
