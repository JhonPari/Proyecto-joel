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
    public partial class FrmProductoElaborado : Form
    {
        public FrmProductoElaborado()
        {
            InitializeComponent();
        }

        private void FrmProductoElaborado_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(cmbProductoBase, "Insumo base original (Ej: Tambaqui Pequeno).");
            tip.SetToolTip(txtNombrePlato, "Nombre del plato / elaborado. Solo letras.");
            tip.SetToolTip(txtPrecioVenta, "Precio de venta. Decimales. No afecta ventas ya hechas.");
            tip.SetToolTip(txtCantidad, "Cantidad de elaborados a producir. Solo enteros.");
            tip.SetToolTip(cmbElaboradoExistente, "Plato YA registrado para aumentar su stock.");
            tip.SetToolTip(txtStockAgregar, "Cantidad a producir del plato seleccionado. Solo enteros.");
            tip.SetToolTip(btnAumentarStock, "Sube el stock del plato seleccionado y descuenta su insumo base.");
            tip.SetToolTip(btnNuevo, "Preparar el formulario para un nuevo plato.");
            tip.SetToolTip(btnGuardar, "Registrar el elaborado: sube su stock y descuenta el insumo base.");
            tip.SetToolTip(btnEditar, "Actualizar el precio/datos del plato seleccionado.");
            tip.SetToolTip(btnEliminar, "Eliminar el plato seleccionado.");
            tip.SetToolTip(btnCancelar, "Limpiar los campos.");
            tip.SetToolTip(btnVolver, "Cerrar y volver al menu principal.");

            cargarInsumos();
            cargarElaborados();
            listar();
            estadoInicial();
        }

        // Insumos base (FrmProductos) para el ALTA de un elaborado
        private void cargarInsumos()
        {
            DataTable dt = C_Producto.listar();
            cmbProductoBase.DataSource    = dt;
            cmbProductoBase.DisplayMember = "NOMBRE";
            cmbProductoBase.ValueMember   = "CODIGO";
            cmbProductoBase.SelectedIndex = -1;
        }

        // Platos YA registrados para AUMENTAR su stock
        private void cargarElaborados()
        {
            DataTable dt = C_ProductoElaborado.listar(); // CODIGO, PLATO, PRD_BASE, CANTIDAD(rend), ...
            cmbElaboradoExistente.DataSource    = dt;
            cmbElaboradoExistente.DisplayMember = "PLATO";
            cmbElaboradoExistente.ValueMember   = "CODIGO";
            cmbElaboradoExistente.SelectedIndex = -1;
        }

        private void listar()
        {
            dgvElaborados.DataSource = C_ProductoElaborado.listar();
        }


        // ----- NOMBRE PLATO: solo letras -----
        private void txtNombrePlato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
                e.Handled = true;

        }


        // ----- PRECIO VENTA: decimales -----
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '.' && txtPrecioVenta.Text.Contains("."))
                e.Handled = true;

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtStockAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void dgvElaborados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow f = dgvElaborados.Rows[e.RowIndex];
            txtCodigo.Text       = f.Cells["CODIGO"].Value.ToString();
            txtNombrePlato.Text  = f.Cells["PLATO"].Value.ToString();
            txtPrecioVenta.Text  = f.Cells["PRECIO"].Value.ToString();
            cmbProductoBase.SelectedValue = f.Cells["PRD_BASE"].Value;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        // Rendimiento segun el insumo base (Pescado=2 -> factor 0.5; otros=1)
        private decimal rendimientoDe(string nombreInsumo, string categoriaInsumo)
        {
            string n = (nombreInsumo ?? "").ToUpper();
            string c = (categoriaInsumo ?? "").ToUpper();
            if (n.Contains("PESCADO") || n.Contains("TAMBAQUI") || c.Contains("PESCADO"))
                return 2m;
            return 1m;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            cmbProductoBase.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbProductoBase.SelectedIndex == -1)
            { MessageBox.Show("Seleccione el insumo base."); return; }
            if (txtNombrePlato.Text.Trim() == "")
            { MessageBox.Show("Ingrese el nombre del plato."); txtNombrePlato.Focus(); return; }
            if (!decimal.TryParse(txtPrecioVenta.Text.Trim(), out decimal precio))
            { MessageBox.Show("Precio de venta invalido."); txtPrecioVenta.Focus(); return; }
            if (!int.TryParse(txtCantidad.Text.Trim(), out int cantProducir) || cantProducir <= 0)
            { MessageBox.Show("Cantidad invalida."); txtCantidad.Focus(); return; }

            DataRowView baseRow = (DataRowView)cmbProductoBase.SelectedItem;
            int prdBase = Convert.ToInt32(baseRow["CODIGO"]);
            string nombreInsumo = baseRow["NOMBRE"].ToString();
            string categoriaInsumo = baseRow.Row.Table.Columns.Contains("CATEGORIA")
                                     ? baseRow["CATEGORIA"].ToString() : "";

            decimal rendimiento = rendimientoDe(nombreInsumo, categoriaInsumo);
            decimal descuentoInsumo = cantProducir / rendimiento;

            // 1) Alta del elaborado (guarda el rendimiento)
            int pelCod = C_ProductoElaborado.autonumerico();
            C_ProductoElaborado.registrar(pelCod, prdBase, txtNombrePlato.Text.Trim(),
                "", precio, rendimiento);

            // 2) Aumenta su propio stock con lo producido
            C_ProductoElaborado.aumentarStock(pelCod, cantProducir);

            // 3) Descuenta el insumo base segun la conversion
            C_Producto.descontarStock(prdBase, descuentoInsumo);

            MessageBox.Show("Elaborado registrado.\nProducidos: " + cantProducir +
                "\nInsumo descontado: " + descuentoInsumo.ToString("N2") +
                " (" + nombreInsumo + ")", "EXITO");
            limpiar(); listar(); cargarInsumos(); cargarElaborados(); estadoInicial();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            { MessageBox.Show("Seleccione un elaborado de la lista."); return; }
            if (!decimal.TryParse(txtPrecioVenta.Text.Trim(), out decimal precio))
            { MessageBox.Show("Precio invalido."); return; }
            if (cmbProductoBase.SelectedIndex == -1)
            { MessageBox.Show("Seleccione el insumo base."); return; }

            int prdBase = Convert.ToInt32(cmbProductoBase.SelectedValue);
            C_ProductoElaborado.editar(Convert.ToInt32(txtCodigo.Text), prdBase,
                txtNombrePlato.Text.Trim(), "", precio, 1);
            MessageBox.Show("Precio actualizado (ventas anteriores intactas).", "EXITO");
            limpiar(); listar(); cargarElaborados(); estadoInicial();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            { MessageBox.Show("Seleccione un elaborado de la lista."); return; }

            var rta = MessageBox.Show("¿Eliminar el plato seleccionado?", "CONFIRMAR",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta != DialogResult.Yes) return;

            C_ProductoElaborado.eliminar(Convert.ToInt32(txtCodigo.Text));
            MessageBox.Show("Plato eliminado.", "EXITO");
            limpiar(); listar(); cargarElaborados(); estadoInicial();

        }

        private void btnAumentarStock_Click(object sender, EventArgs e)
        {
            if (cmbElaboradoExistente.SelectedIndex == -1)
            { MessageBox.Show("Seleccione un plato ya registrado."); return; }
            if (!int.TryParse(txtStockAgregar.Text.Trim(), out int cant) || cant <= 0)
            { MessageBox.Show("Cantidad a producir invalida."); txtStockAgregar.Focus(); return; }

            DataRowView row = (DataRowView)cmbElaboradoExistente.SelectedItem;
            int pelCod = Convert.ToInt32(row["CODIGO"]);
            int prdBase = Convert.ToInt32(row["PRD_BASE"]);
            decimal rend = Convert.ToDecimal(row["CANTIDAD"]); // rendimiento guardado
            if (rend <= 0) rend = 1m;

            decimal descuentoInsumo = cant / rend;

            // 1) sube el stock del plato
            C_ProductoElaborado.aumentarStock(pelCod, cant);
            // 2) descuenta el insumo base
            if (prdBase > 0)
                C_Producto.descontarStock(prdBase, descuentoInsumo);

            MessageBox.Show("Stock aumentado en " + cant + " unidades.\nInsumo descontado: " +
                descuentoInsumo.ToString("N2"), "EXITO");
            txtStockAgregar.Clear();
            cmbElaboradoExistente.SelectedIndex = -1;
            listar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar(); estadoInicial();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void limpiar()
        {
            txtCodigo.Clear();
            txtNombrePlato.Clear();
            txtPrecioVenta.Clear();
            txtCantidad.Clear();
            cmbProductoBase.SelectedIndex = -1;
        }

        private void estadoInicial()
        {
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

    }
}
