using System;
using System.Collections.Generic;
using System.ComponentModel;
using PESCADOFINAL.CONTROLADOR;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txtNombre, "Nombre de la categoria. Solo letras, sin numeros.");
            tip.SetToolTip(btnNuevo, "Preparar el formulario para una nueva categoria.");
            tip.SetToolTip(btnGuardar, "Registrar una nueva categoria.");
            tip.SetToolTip(btnEditar, "Guardar cambios de la categoria seleccionada.");
            tip.SetToolTip(btnEliminar, "Eliminar la categoria seleccionada.");
            tip.SetToolTip(btnCancelar, "Limpiar los campos.");
            tip.SetToolTip(btnVolver, "Cerrar y volver al menu principal.");

            listar();

        }

        private void listar()
        {
            dgvCategorias.DataSource = C_Categoria.listar();
        }

        // ----- NOMBRE: solo letras y espacios -----
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("La categoria solo admite letras (sin numeros).", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // ----- Cargar fila seleccionada -----
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow f = dgvCategorias.Rows[e.RowIndex];
            txtCodigo.Text = f.Cells["CODIGO"].Value.ToString();
            txtNombre.Text = f.Cells["NOMBRE"].Value.ToString();
            // listo para editar/eliminar
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;


        }


        // ----- GUARDAR (alta) -----
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            { MessageBox.Show("Ingrese el nombre de la categoria."); txtNombre.Focus(); return; }
            if (C_Categoria.existe(txtNombre.Text.Trim()) > 0)
            { MessageBox.Show("Esa categoria ya existe."); return; }

            int cod = C_Categoria.autonumerico();
            C_Categoria.registrar(cod, txtNombre.Text.Trim());
            MessageBox.Show("Categoria registrada.", "EXITO");
            limpiar(); listar(); estadoInicial();


        }

        // ----- EDITAR -----
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            { MessageBox.Show("Seleccione una categoria de la lista."); return; }
            if (txtNombre.Text.Trim() == "")
            { MessageBox.Show("Ingrese el nombre."); txtNombre.Focus(); return; }

            C_Categoria.editar(Convert.ToInt32(txtCodigo.Text), txtNombre.Text.Trim());
            MessageBox.Show("Categoria actualizada.", "EXITO");
            limpiar(); listar(); estadoInicial();

        }


        // ----- ELIMINAR -----
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            { MessageBox.Show("Seleccione una categoria de la lista."); return; }

            var rta = MessageBox.Show("¿Eliminar la categoria seleccionada?", "CONFIRMAR",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta != DialogResult.Yes) return;

            C_Categoria.eliminar(Convert.ToInt32(txtCodigo.Text));
            MessageBox.Show("Categoria eliminada.", "EXITO");
            limpiar(); listar(); estadoInicial();


        }


        // ----- NUEVO -----
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombre.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar(); estadoInicial();
        }


        // ----- VOLVER AL MENU -----
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtNombre.Focus();
        }

        // Estado por defecto: se puede dar de alta; editar/eliminar requieren seleccion
        private void estadoInicial()
        {
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

    }
}
