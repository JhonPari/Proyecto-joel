using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores login = new FrmProveedores();
            login.Show();
            this.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras login = new FrmCompras();
            login.Show();
            this.Close();
        }

        private void botonProductos_Click(object sender, EventArgs e)
        {
            FrmProducto producto = new FrmProducto();
            producto.Show();
            this.Hide();
        }

        private void botonCategorias_Click(object sender, EventArgs e)
        {
            FrmCategoria f = new FrmCategoria();
            f.Show();
            this.Hide();

        }

        private void botonUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.Show();

            this.Hide();
        }

        private void botonElaborados_Click(object sender, EventArgs e)
        {
            FrmProductoElaborado f = new FrmProductoElaborado();
            f.Show();
            this.Hide();
        }

        private void botonReportes_Click(object sender, EventArgs e)
        {
            FrmReportes reportes = new FrmReportes();
            reportes.Show();

            this.Hide();
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
            "¿Desea cerrar sesión?", "CERRAR SESION",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                FrmAutentificacion login = new FrmAutentificacion();
                login.Show();
                this.Close();
            }
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (FrmAutentificacion.usuarioRol == "CAJERO")
                botonUsuarios.Visible = false;
        }
    }
}
