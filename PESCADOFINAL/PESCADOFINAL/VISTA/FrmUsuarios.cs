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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txtNombre, "Nombre completo. Solo letras, sin numeros.");
            tip.SetToolTip(txtUsuario, "Usuario alfanumerico. Sin caracteres especiales.");
            tip.SetToolTip(txtContrasena, "Contrasena alfanumerica. Sin caracteres especiales.");
            tip.SetToolTip(cmbRol, "Seleccione el rol: ADMIN o CAJERO.");
            tip.SetToolTip(btnNuevo, "Preparar el formulario para un nuevo usuario.");
            tip.SetToolTip(btnGuardar, "Registrar un nuevo usuario.");
            tip.SetToolTip(btnEditar, "Guardar cambios del usuario seleccionado.");
            tip.SetToolTip(btnEliminar, "Eliminar el usuario seleccionado.");
            tip.SetToolTip(btnCancelar, "Limpiar los campos.");
            tip.SetToolTip(btnVolver, "Cerrar y volver al menu principal.");

            cmbRol.Items.Clear();
            cmbRol.Items.Add("ADMIN");
            cmbRol.Items.Add("CAJERO");
            listar();
            estadoInicial();

        }

        private void listar()
        {
            dgvUsuarios.DataSource = C_Usuario.listar();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }


        // ----- NOMBRE: solo letras -----

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El nombre solo admite letras (sin numeros).", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // ----- USUARIO: alfanumerico -----
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El usuario solo admite letras y numeros (sin caracteres especiales).",
                    "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        // ----- CONTRASENA: alfanumerico -----
        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("La contrasena solo admite letras y numeros (sin caracteres especiales).",
                    "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow f = dgvUsuarios.Rows[e.RowIndex];
            txtCodigo.Text  = f.Cells["CODIGO"].Value.ToString();
            txtNombre.Text  = f.Cells["NOMBRE"].Value.ToString();
            txtUsuario.Text = f.Cells["USUARIO"].Value.ToString();
            txtContrasena.Clear(); // por seguridad no se muestra la clave
            cmbRol.SelectedItem = f.Cells["ROL"].Value.ToString();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombre.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar(true)) return;
            if (C_Usuario.existe(txtUsuario.Text.Trim()) > 0)
            { MessageBox.Show("Ese nombre de usuario ya existe."); return; }

            int cod = C_Usuario.autonumerico();
            C_Usuario.registrar(cod, txtNombre.Text.Trim(), txtUsuario.Text.Trim(),
                txtContrasena.Text.Trim(), cmbRol.SelectedItem.ToString());
            MessageBox.Show("Usuario registrado.", "EXITO");
            limpiar(); listar(); estadoInicial();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            { MessageBox.Show("Seleccione un usuario de la lista."); return; }
            if (!validar(false)) return;

            C_Usuario.editar(Convert.ToInt32(txtCodigo.Text), txtNombre.Text.Trim(),
                txtUsuario.Text.Trim(), txtContrasena.Text.Trim(), cmbRol.SelectedItem.ToString());
            MessageBox.Show("Usuario actualizado.", "EXITO");
            limpiar(); listar(); estadoInicial();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            { MessageBox.Show("Seleccione un usuario de la lista."); return; }

            var rta = MessageBox.Show("¿Eliminar el usuario seleccionado?", "CONFIRMAR",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta != DialogResult.Yes) return;

            C_Usuario.eliminar(Convert.ToInt32(txtCodigo.Text));
            MessageBox.Show("Usuario eliminado.", "EXITO");
            limpiar(); listar(); estadoInicial();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar(); estadoInicial();
        }

        // pideClave = true exige contrasena (alta); en edicion es opcional
        private bool validar(bool pideClave)
        {
            if (txtNombre.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || cmbRol.SelectedItem == null)
            { MessageBox.Show("Complete nombre, usuario y rol."); return false; }
            if (pideClave && txtContrasena.Text.Trim() == "")
            { MessageBox.Show("Ingrese la contrasena."); txtContrasena.Focus(); return false; }
            return true;
        }

        private void limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            cmbRol.SelectedIndex = -1;
            txtNombre.Focus();
        }

        private void estadoInicial()
        {
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

    }
}
