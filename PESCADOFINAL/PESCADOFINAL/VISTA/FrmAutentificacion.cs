using PESCADOFINAL.CONTROLADOR;
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
    public partial class FrmAutentificacion : Form
    {
        public static int usuarioId = 0;
        public static string usuarioNom = "";
        public static string usuarioRol = "";


        public FrmAutentificacion()
        {
            InitializeComponent();
        }

        private void FrmAutentificacion_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txtLogin, "Ingrese su nombre de usuario (sin espacios)");
            tip.SetToolTip(txtPassword, "Ingrese su contrasena");
            tip.SetToolTip(buttonIngresar, "Validar credenciales e ingresar al sistema");
            tip.SetToolTip(btnSalir, "Cerrar la ventana de login y volver al inicio");

            txtLogin.Focus();

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string usu = txtLogin.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (usu == "") { MessageBox.Show("Ingrese su nombre de usuario", "VALIDACION"); txtLogin.Focus(); return; }
            if (pass == "") { MessageBox.Show("Ingrese su contrasena", "VALIDACION"); txtPassword.Focus(); return; }

            DataTable dt = C_Usuario.login(usu, pass);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Usuario o contrasena incorrectos", "ACCESO DENEGADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Clear(); txtPassword.Clear(); txtLogin.Focus();
                return;
            }

            usuarioId  = Convert.ToInt32(dt.Rows[0]["USU_CODIGO"]);
            usuarioNom = dt.Rows[0]["USU_NOMBRE"].ToString();
            usuarioRol = dt.Rows[0]["USU_ROL"].ToString();

            string rol = usuarioRol.ToUpper();
            if (rol.Contains("ADMIN")) { new FrmMenuPrincipal().Show(); this.Hide(); }
            else if (rol.Contains("CAJERO")) { new FrmMenuCajero().Show(); this.Hide(); }
            else MessageBox.Show("Rol no reconocido", "ERROR");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
            this.Close();

        }

    }
}
