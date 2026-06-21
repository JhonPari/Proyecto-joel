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

namespace ProyectoJoel.Vista.frontis
{
	public partial class frmfront : Form
	{
		public frmfront()
		{
			InitializeComponent();
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			label4.Visible = false;
			label5.Visible = false;
			btnNosotros.Click += btnNosotros_Click;
		}

		private void btnIniciarsession_Click(object sender, EventArgs e)
		{
			FrmLogin frm = new FrmLogin();
			frm.Show();

			this.Hide();

		}

		private void btnNosotros_Click(object sender, EventArgs e)
		{
			pictureBox2.Visible = true;
			pictureBox3.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
			label4.Visible = true;
			label5.Visible = true;
		}
	}
}
