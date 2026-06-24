namespace PESCADOFINAL.VISTA
{
    partial class FrmVentas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBuscarCliente = new System.Windows.Forms.TextBox();
			this.lblImporte = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNit = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.lblStockDisp = new System.Windows.Forms.Label();
			this.lblCambio = new System.Windows.Forms.Label();
			this.txtMonto = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbProducto = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.monto = new System.Windows.Forms.Label();
			this.txtPrecioUnit = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.btnQuitarItem = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnCobrar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvDetalle = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.txtBuscarCliente);
			this.groupBox3.Controls.Add(this.lblImporte);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.txtNit);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.txtCliente);
			this.groupBox3.Controls.Add(this.lblStockDisp);
			this.groupBox3.Controls.Add(this.lblCambio);
			this.groupBox3.Controls.Add(this.txtMonto);
			this.groupBox3.Controls.Add(this.lblTotal);
			this.groupBox3.Location = new System.Drawing.Point(-1, 231);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(286, 283);
			this.groupBox3.TabIndex = 40;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "DATOS DEL CLIENTE :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Buscar Cliente (Nombre o CI)";
			// 
			// txtBuscarCliente
			// 
			this.txtBuscarCliente.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtBuscarCliente.Location = new System.Drawing.Point(6, 50);
			this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBuscarCliente.Name = "txtBuscarCliente";
			this.txtBuscarCliente.Size = new System.Drawing.Size(253, 22);
			this.txtBuscarCliente.TabIndex = 32;
			this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
			// 
			// lblImporte
			// 
			this.lblImporte.AutoSize = true;
			this.lblImporte.Location = new System.Drawing.Point(129, 215);
			this.lblImporte.Name = "lblImporte";
			this.lblImporte.Size = new System.Drawing.Size(120, 16);
			this.lblImporte.TabIndex = 30;
			this.lblImporte.Text = "IMPORTE : Bs 0.00";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(10, 167);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(126, 16);
			this.label10.TabIndex = 31;
			this.label10.Text = "MONTO RECIBIDO:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "NOMBRE :";
			// 
			// txtNit
			// 
			this.txtNit.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtNit.Location = new System.Drawing.Point(53, 135);
			this.txtNit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNit.Name = "txtNit";
			this.txtNit.Size = new System.Drawing.Size(233, 22);
			this.txtNit.TabIndex = 25;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(10, 135);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 16);
			this.label9.TabIndex = 30;
			this.label9.Text = "NIT :";
			// 
			// txtCliente
			// 
			this.txtCliente.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtCliente.Location = new System.Drawing.Point(91, 108);
			this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(195, 22);
			this.txtCliente.TabIndex = 25;
			// 
			// lblStockDisp
			// 
			this.lblStockDisp.AutoSize = true;
			this.lblStockDisp.Location = new System.Drawing.Point(10, 217);
			this.lblStockDisp.Name = "lblStockDisp";
			this.lblStockDisp.Size = new System.Drawing.Size(90, 16);
			this.lblStockDisp.TabIndex = 14;
			this.lblStockDisp.Text = "Text = Stock: -";
			// 
			// lblCambio
			// 
			this.lblCambio.AutoSize = true;
			this.lblCambio.BackColor = System.Drawing.Color.Transparent;
			this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCambio.Location = new System.Drawing.Point(148, 201);
			this.lblCambio.Name = "lblCambio";
			this.lblCambio.Size = new System.Drawing.Size(111, 17);
			this.lblCambio.TabIndex = 8;
			this.lblCambio.Text = "Cambio: Bs 0.00";
			// 
			// txtMonto
			// 
			this.txtMonto.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtMonto.Location = new System.Drawing.Point(152, 165);
			this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.Size = new System.Drawing.Size(111, 22);
			this.txtMonto.TabIndex = 7;
			this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.BackColor = System.Drawing.Color.Transparent;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(10, 201);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(100, 17);
			this.lblTotal.TabIndex = 6;
			this.lblTotal.Text = "Total : Bs 0.00";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.cmbProducto);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.cmbCategoria);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.monto);
			this.groupBox2.Controls.Add(this.txtPrecioUnit);
			this.groupBox2.Controls.Add(this.txtCantidad);
			this.groupBox2.Location = new System.Drawing.Point(-1, 27);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(284, 200);
			this.groupBox2.TabIndex = 39;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DATOS DE LA VENTA :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(5, 168);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 16);
			this.label8.TabIndex = 29;
			this.label8.Text = "PRECIO :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 16);
			this.label7.TabIndex = 29;
			this.label7.Text = "CATEGORIA :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(5, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 24;
			this.label2.Text = "FECHA :";
			// 
			// cmbProducto
			// 
			this.cmbProducto.BackColor = System.Drawing.SystemColors.MenuBar;
			this.cmbProducto.FormatString = "DisplayMember=NOMBRE";
			this.cmbProducto.FormattingEnabled = true;
			this.cmbProducto.Location = new System.Drawing.Point(102, 77);
			this.cmbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbProducto.Name = "cmbProducto";
			this.cmbProducto.Size = new System.Drawing.Size(176, 24);
			this.cmbProducto.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "PRODUCTO:";
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.BackColor = System.Drawing.SystemColors.MenuBar;
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Location = new System.Drawing.Point(108, 50);
			this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(170, 24);
			this.cmbCategoria.TabIndex = 24;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
			this.dateTimePicker1.Location = new System.Drawing.Point(78, 133);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 21;
			// 
			// monto
			// 
			this.monto.AutoSize = true;
			this.monto.BackColor = System.Drawing.Color.Transparent;
			this.monto.Location = new System.Drawing.Point(5, 107);
			this.monto.Name = "monto";
			this.monto.Size = new System.Drawing.Size(82, 16);
			this.monto.TabIndex = 17;
			this.monto.Text = "CANTIDAD :";
			// 
			// txtPrecioUnit
			// 
			this.txtPrecioUnit.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtPrecioUnit.Location = new System.Drawing.Point(78, 166);
			this.txtPrecioUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPrecioUnit.Name = "txtPrecioUnit";
			this.txtPrecioUnit.Size = new System.Drawing.Size(200, 22);
			this.txtPrecioUnit.TabIndex = 1;
			this.txtPrecioUnit.Text = "ReadOnly=True";
			// 
			// txtCantidad
			// 
			this.txtCantidad.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtCantidad.Location = new System.Drawing.Point(102, 107);
			this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(176, 22);
			this.txtCantidad.TabIndex = 2;
			// 
			// btnQuitarItem
			// 
			this.btnQuitarItem.Location = new System.Drawing.Point(657, 329);
			this.btnQuitarItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnQuitarItem.Name = "btnQuitarItem";
			this.btnQuitarItem.Size = new System.Drawing.Size(128, 41);
			this.btnQuitarItem.TabIndex = 38;
			this.btnQuitarItem.Text = "QUITAR ITEM";
			this.btnQuitarItem.UseVisualStyleBackColor = true;
			this.btnQuitarItem.Click += new System.EventHandler(this.btnQuitarItem_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(475, 465);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(183, 42);
			this.button3.TabIndex = 37;
			this.button3.Text = "VOLVER AL MENU";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(310, 330);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(121, 41);
			this.btnNuevo.TabIndex = 36;
			this.btnNuevo.Text = "NUEVO";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(475, 329);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(124, 42);
			this.btnRegistrar.TabIndex = 35;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(475, 393);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(124, 43);
			this.btnEditar.TabIndex = 34;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(657, 393);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(128, 43);
			this.btnCancelar.TabIndex = 33;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnCobrar
			// 
			this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCobrar.Location = new System.Drawing.Point(308, 465);
			this.btnCobrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCobrar.Name = "btnCobrar";
			this.btnCobrar.Size = new System.Drawing.Size(113, 42);
			this.btnCobrar.TabIndex = 32;
			this.btnCobrar.Text = "COBRAR";
			this.btnCobrar.UseVisualStyleBackColor = true;
			this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dgvDetalle);
			this.groupBox1.Location = new System.Drawing.Point(307, 27);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(533, 298);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CARRITO DE VENTA";
			// 
			// dgvDetalle
			// 
			this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalle.Location = new System.Drawing.Point(6, 40);
			this.dgvDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvDetalle.Name = "dgvDetalle";
			this.dgvDetalle.RowHeadersWidth = 62;
			this.dgvDetalle.RowTemplate.Height = 28;
			this.dgvDetalle.Size = new System.Drawing.Size(527, 212);
			this.dgvDetalle.TabIndex = 0;
			this.dgvDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(308, 393);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(113, 43);
			this.btnAgregar.TabIndex = 30;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// FrmVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(839, 525);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnQuitarItem);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCobrar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAgregar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmVentas";
			this.Text = "FrmVentas";
			this.Load += new System.EventHandler(this.FrmVentas_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblStockDisp;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label monto;
        private System.Windows.Forms.TextBox txtPrecioUnit;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnQuitarItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBuscarCliente;
	}
}