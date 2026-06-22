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
    public partial class FrmCompras : Form
    {

        private DataTable dtProductos; // catalogo de insumos ya registrados
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(cmbProveedor, "Seleccione el proveedor de la compra.");
            tip.SetToolTip(cmbCategoria, "Categoria del producto nuevo.");
            tip.SetToolTip(cmbProducto, "Producto YA comprado antes. Bloquea el campo de producto nuevo.");
            tip.SetToolTip(txtProducto, "Producto NUEVO. Solo letras. Bloquea el combo de producto existente.");
            tip.SetToolTip(txtTamano, "Tamano del producto. Alfanumerico (Ej: Pequeno, Grande).");
            tip.SetToolTip(txtCantidad, "Cantidad comprada. Solo numeros enteros.");
            tip.SetToolTip(txtPrecioUnit, "Precio / Total de la linea. Admite decimales (Ej: 100.50).");
            tip.SetToolTip(btnAgregar, "Agrega la linea a la grilla de detalle.");
            tip.SetToolTip(btnRegistrar, "Registra la compra completa (cabecera + detalle) y actualiza stock.");
            tip.SetToolTip(btnNuevo, "Inicia una compra nueva (limpia proveedor y detalle).");
            tip.SetToolTip(btnQuitar, "Quita la linea seleccionada de la grilla de detalle.");
            tip.SetToolTip(btnCancelar, "Limpia los campos de la linea actual.");
            tip.SetToolTip(btnVolver, "Cerrar y volver al menu principal.");

            configurarGrilla();
            cargarProveedores();
            cargarCategorias();
            cargarProductos();


        }

        // ============================================================
        //  Grilla de detalle: COLUMNA PRD_COD OBLIGATORIA
        // ============================================================
        private void configurarGrilla()
        {
            dgvDetalle.Columns.Clear();
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Columna oculta con el ID del producto (FK del detalle)
            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "PRD_COD", HeaderText = "PRD_COD", Visible = false });

            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "PRODUCTO", HeaderText = "Producto", Width = 160 });
            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "TAMANO", HeaderText = "Tamano", Width = 90 });
            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "CANTIDAD", HeaderText = "Cantidad", Width = 80 });
            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "PRECIO", HeaderText = "Precio", Width = 90 });
        }

        private void cargarProveedores()
        {
            cmbProveedor.DataSource    = C_Proveedor.listar();
            cmbProveedor.DisplayMember = "NOMBRE";
            cmbProveedor.ValueMember   = "CODIGO";
            cmbProveedor.SelectedIndex = -1;
        }

        private void cargarCategorias()
        {
            cmbCategoria.DataSource    = C_Categoria.listar();
            cmbCategoria.DisplayMember = "NOMBRE";
            cmbCategoria.ValueMember   = "CODIGO";
            cmbCategoria.SelectedIndex = -1;
        }

        private void cargarProductos()
        {
            dtProductos = C_Producto.listar(); // CODIGO, NOMBRE, TAMANO, CAT_CODIGO ...
            cmbProducto.DataSource    = dtProductos;
            cmbProducto.DisplayMember = "NOMBRE";
            cmbProducto.ValueMember   = "CODIGO";
            cmbProducto.SelectedIndex = -1;
        }


        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex >= 0 && cmbProducto.SelectedItem is DataRowView fila)
            {
                txtProducto.Clear();
                txtProducto.Enabled = false;
                txtTamano.Text = fila["TAMANO"].ToString(); // autocompletado historico
            }
            else
            {
                txtProducto.Enabled = true;
            }


        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text.Trim() != "")
            {
                cmbProducto.SelectedIndex = -1;
                cmbProducto.Enabled = false;
            }
            else
            {
                cmbProducto.Enabled = true;
            }

        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El nombre del producto solo admite letras.", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtTamano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El tamano solo admite letras y numeros.", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("La cantidad solo admite numeros enteros.", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtPrecioUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '.' && txtPrecioUnit.Text.Contains("."))
                e.Handled = true;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedIndex == -1)
            { MessageBox.Show("Seleccione un proveedor."); return; }

            if (dgvDetalle.Rows.Count == 0)
            { MessageBox.Show("Agregue al menos un producto al detalle."); return; }

            // 1) Cabecera de compra
            int comCod = C_Compra.autonumericoCom();
            C_Compra.registrarCompra(comCod, Convert.ToInt32(cmbProveedor.SelectedValue));

            // 2) Detalle: bloque SEGURO requerido por el docente
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.IsNewRow) continue;
                try
                {
                    string prdCodStr = fila.Cells["PRD_COD"].Value?.ToString() ?? "0";
                    string cantStr = fila.Cells["CANTIDAD"].Value?.ToString() ?? "0";
                    string precioStr = fila.Cells["PRECIO"].Value?.ToString() ?? "0";

                    int prdCod = 0;
                    if (!int.TryParse(prdCodStr, out prdCod) || prdCod <= 0)
                    {
                        MessageBox.Show($"ERROR: Codigo de producto invalido '{prdCodStr}'.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int cantidad = 0;
                    if (!int.TryParse(cantStr, out cantidad) || cantidad <= 0)
                    {
                        MessageBox.Show($"ERROR: Cantidad invalida '{cantStr}'.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    decimal precio = 0m;
                    if (!decimal.TryParse(precioStr, out precio) || precio <= 0)
                    {
                        MessageBox.Show($"ERROR: Precio invalido '{precioStr}'.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ENVIO A LA CAPA CONTROLADOR incluyendo prdCod (FK del detalle)
                    int dCod = C_Compra.autonumericoDCom();
                    C_Compra.registrarDetalle(dCod, comCod, prdCod, cantidad, precio);

                    // El stock del insumo equivale a la cantidad comprada
                    C_Producto.aumentarStock(prdCod, cantidad);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar la linea: " + ex.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Compra registrada. Stock actualizado.", "EXITO");
            limpiarTodo();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int prdCod;
            string nombre, tamano;

            if (cmbProducto.SelectedIndex >= 0)
            {
                // Producto existente: su ID viene del combo
                prdCod = Convert.ToInt32(cmbProducto.SelectedValue);
                nombre = cmbProducto.Text;
                tamano = txtTamano.Text.Trim();
            }
            else
            {
                // Producto nuevo: se da de alta y se obtiene su ID
                if (txtProducto.Text.Trim() == "")
                { MessageBox.Show("Elija un producto del combo o escriba uno nuevo."); return; }
                if (cmbCategoria.SelectedIndex == -1)
                { MessageBox.Show("Seleccione la categoria del nuevo producto."); return; }

                prdCod = C_Producto.autonumerico();
                C_Producto.registrar(prdCod, Convert.ToInt32(cmbCategoria.SelectedValue),
                    txtProducto.Text.Trim(), txtTamano.Text.Trim(), 0);
                nombre = txtProducto.Text.Trim();
                tamano = txtTamano.Text.Trim();
            }

            if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
            { MessageBox.Show("Cantidad invalida."); txtCantidad.Focus(); return; }

            if (!decimal.TryParse(txtPrecioUnit.Text.Trim(), out decimal precio) || precio <= 0)
            { MessageBox.Show("Precio invalido."); txtPrecioUnit.Focus(); return; }

            // La fila guarda el PRD_COD (clave para el detalle de compra)
            dgvDetalle.Rows.Add(prdCod, nombre, tamano, cantidad, precio);
            limpiarEntradaLinea();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarTodo();
            cmbProveedor.Focus();

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow == null) { MessageBox.Show("Seleccione una linea del detalle."); return; }
            dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarEntradaLinea();
        }

        private void limpiarEntradaLinea()
        {
            cmbProducto.SelectedIndex = -1;
            cmbProducto.Enabled = true;
            txtProducto.Enabled = true;
            txtProducto.Clear();
            txtTamano.Clear();
            txtCantidad.Clear();
            txtPrecioUnit.Clear();
        }

        private void limpiarTodo()
        {
            cmbProveedor.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            dgvDetalle.Rows.Clear();
            limpiarEntradaLinea();
            cargarProductos();
        }

    }
}
