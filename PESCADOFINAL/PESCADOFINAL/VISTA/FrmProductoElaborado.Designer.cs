namespace PESCADOFINAL.VISTA
{
    partial class FrmProductoElaborado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoElaborado));
			this.btnVolver = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrecioVenta = new System.Windows.Forms.TextBox();
			this.cmbProductoBase = new System.Windows.Forms.ComboBox();
			this.txtNombrePlato = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvElaborados = new System.Windows.Forms.DataGridView();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnAumentarStock = new System.Windows.Forms.Button();
			this.cmbElaboradoExistente = new System.Windows.Forms.ComboBox();
			this.txtStockAgregar = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvElaborados)).BeginInit();
			this.SuspendLayout();
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(320, 349);
			this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(244, 48);
			this.btnVolver.TabIndex = 22;
			this.btnVolver.Text = "VOLVER AL MENU";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(698, 282);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(140, 46);
			this.btnCancelar.TabIndex = 21;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(516, 282);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(127, 46);
			this.btnEliminar.TabIndex = 20;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(334, 282);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(132, 46);
			this.btnEditar.TabIndex = 19;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.txtCantidad);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtPrecioVenta);
			this.groupBox2.Controls.Add(this.cmbProductoBase);
			this.groupBox2.Controls.Add(this.txtNombrePlato);
			this.groupBox2.Location = new System.Drawing.Point(7, 36);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(324, 226);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "PRODUCTOS ELABORADOS";
			// 
			// txtCantidad
			// 
			this.txtCantidad.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtCantidad.Location = new System.Drawing.Point(12, 191);
			this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(240, 22);
			this.txtCantidad.TabIndex = 15;
			this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "CANTIDAD :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "PRECIO VENTA :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "NOMBRE PRODUCTO :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "PRODUCTO BASE :";
			// 
			// txtPrecioVenta
			// 
			this.txtPrecioVenta.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtPrecioVenta.Location = new System.Drawing.Point(9, 150);
			this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPrecioVenta.Name = "txtPrecioVenta";
			this.txtPrecioVenta.Size = new System.Drawing.Size(240, 22);
			this.txtPrecioVenta.TabIndex = 3;
			this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
			// 
			// cmbProductoBase
			// 
			this.cmbProductoBase.BackColor = System.Drawing.SystemColors.MenuBar;
			this.cmbProductoBase.FormattingEnabled = true;
			this.cmbProductoBase.Location = new System.Drawing.Point(9, 65);
			this.cmbProductoBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbProductoBase.Name = "cmbProductoBase";
			this.cmbProductoBase.Size = new System.Drawing.Size(232, 24);
			this.cmbProductoBase.TabIndex = 4;
			// 
			// txtNombrePlato
			// 
			this.txtNombrePlato.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtNombrePlato.Location = new System.Drawing.Point(9, 108);
			this.txtNombrePlato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNombrePlato.Name = "txtNombrePlato";
			this.txtNombrePlato.Size = new System.Drawing.Size(240, 22);
			this.txtNombrePlato.TabIndex = 2;
			this.txtNombrePlato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePlato_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dgvElaborados);
			this.groupBox1.Location = new System.Drawing.Point(350, 49);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(509, 199);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "PRODUCTOS";
			// 
			// dgvElaborados
			// 
			this.dgvElaborados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvElaborados.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvElaborados.Location = new System.Drawing.Point(3, 17);
			this.dgvElaborados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvElaborados.Name = "dgvElaborados";
			this.dgvElaborados.RowHeadersWidth = 62;
			this.dgvElaborados.RowTemplate.Height = 28;
			this.dgvElaborados.Size = new System.Drawing.Size(503, 180);
			this.dgvElaborados.TabIndex = 8;
			this.dgvElaborados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElaborados_CellClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(173, 282);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(104, 46);
			this.btnGuardar.TabIndex = 16;
			this.btnGuardar.Text = "GUARDAR";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(16, 282);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(100, 46);
			this.btnNuevo.TabIndex = 15;
			this.btnNuevo.Text = "NUEVO";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnAumentarStock
			// 
			this.btnAumentarStock.Location = new System.Drawing.Point(66, 349);
			this.btnAumentarStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAumentarStock.Name = "btnAumentarStock";
			this.btnAumentarStock.Size = new System.Drawing.Size(174, 58);
			this.btnAumentarStock.TabIndex = 23;
			this.btnAumentarStock.Text = "AUMENTAR STOCK";
			this.btnAumentarStock.UseVisualStyleBackColor = true;
			this.btnAumentarStock.Click += new System.EventHandler(this.btnAumentarStock_Click);
			// 
			// cmbElaboradoExistente
			// 
			this.cmbElaboradoExistente.FormattingEnabled = true;
			this.cmbElaboradoExistente.Location = new System.Drawing.Point(404, 18);
			this.cmbElaboradoExistente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbElaboradoExistente.Name = "cmbElaboradoExistente";
			this.cmbElaboradoExistente.Size = new System.Drawing.Size(108, 24);
			this.cmbElaboradoExistente.TabIndex = 24;
			// 
			// txtStockAgregar
			// 
			this.txtStockAgregar.Location = new System.Drawing.Point(377, 256);
			this.txtStockAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtStockAgregar.Name = "txtStockAgregar";
			this.txtStockAgregar.Size = new System.Drawing.Size(89, 22);
			this.txtStockAgregar.TabIndex = 25;
			this.txtStockAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockAgregar_KeyPress);
			// 
			// FrmProductoElaborado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(866, 432);
			this.Controls.Add(this.txtStockAgregar);
			this.Controls.Add(this.cmbElaboradoExistente);
			this.Controls.Add(this.btnAumentarStock);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnNuevo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmProductoElaborado";
			this.Text = "FrmProductoElaborado";
			this.Load += new System.EventHandler(this.FrmProductoElaborado_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvElaborados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.ComboBox cmbProductoBase;
        private System.Windows.Forms.TextBox txtNombrePlato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvElaborados;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAumentarStock;
        private System.Windows.Forms.ComboBox cmbElaboradoExistente;
        private System.Windows.Forms.TextBox txtStockAgregar;
    }
}