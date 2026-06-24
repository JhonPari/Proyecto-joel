namespace ProyectoJoel.Vista
{
	partial class FrmVenta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.cmbProducto = new System.Windows.Forms.ComboBox();
			this.cmbEmpleado = new System.Windows.Forms.ComboBox();
			this.cmbCliente = new System.Windows.Forms.ComboBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblProducto = new System.Windows.Forms.Label();
			this.lblEmpleado = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnGuardarVenta = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(144, 383);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(121, 22);
			this.txtTotal.TabIndex = 23;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(144, 342);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(121, 22);
			this.txtPrecio.TabIndex = 22;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(144, 301);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(121, 22);
			this.txtCantidad.TabIndex = 21;
			// 
			// cmbProducto
			// 
			this.cmbProducto.FormattingEnabled = true;
			this.cmbProducto.Location = new System.Drawing.Point(144, 263);
			this.cmbProducto.Name = "cmbProducto";
			this.cmbProducto.Size = new System.Drawing.Size(121, 24);
			this.cmbProducto.TabIndex = 20;
			// 
			// cmbEmpleado
			// 
			this.cmbEmpleado.FormattingEnabled = true;
			this.cmbEmpleado.Location = new System.Drawing.Point(144, 215);
			this.cmbEmpleado.Name = "cmbEmpleado";
			this.cmbEmpleado.Size = new System.Drawing.Size(121, 24);
			this.cmbEmpleado.TabIndex = 19;
			// 
			// cmbCliente
			// 
			this.cmbCliente.FormattingEnabled = true;
			this.cmbCliente.Location = new System.Drawing.Point(94, 131);
			this.cmbCliente.Name = "cmbCliente";
			this.cmbCliente.Size = new System.Drawing.Size(171, 24);
			this.cmbCliente.TabIndex = 18;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblTotal.ForeColor = System.Drawing.Color.White;
			this.lblTotal.Location = new System.Drawing.Point(31, 383);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(51, 20);
			this.lblTotal.TabIndex = 17;
			this.lblTotal.Text = "Total";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(31, 342);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 20);
			this.label5.TabIndex = 16;
			this.label5.Text = "Precio";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(31, 301);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 20);
			this.label4.TabIndex = 15;
			this.label4.Text = "Cantidad";
			// 
			// lblProducto
			// 
			this.lblProducto.AutoSize = true;
			this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblProducto.ForeColor = System.Drawing.Color.White;
			this.lblProducto.Location = new System.Drawing.Point(31, 263);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(84, 20);
			this.lblProducto.TabIndex = 14;
			this.lblProducto.Text = "Producto";
			// 
			// lblEmpleado
			// 
			this.lblEmpleado.AutoSize = true;
			this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblEmpleado.ForeColor = System.Drawing.Color.White;
			this.lblEmpleado.Location = new System.Drawing.Point(24, 208);
			this.lblEmpleado.Name = "lblEmpleado";
			this.lblEmpleado.Size = new System.Drawing.Size(91, 20);
			this.lblEmpleado.TabIndex = 13;
			this.lblEmpleado.Text = "Empleado";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblCliente.ForeColor = System.Drawing.Color.White;
			this.lblCliente.Location = new System.Drawing.Point(20, 128);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(68, 20);
			this.lblCliente.TabIndex = 12;
			this.lblCliente.Text = "Cliente";
			// 
			// btnQuitar
			// 
			this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
			this.btnQuitar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.btnQuitar.Location = new System.Drawing.Point(551, 114);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(206, 47);
			this.btnQuitar.TabIndex = 27;
			this.btnQuitar.Text = "Eliminar del Carrito";
			this.btnQuitar.UseVisualStyleBackColor = false;
			this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.btnNuevo.Location = new System.Drawing.Point(763, 114);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(190, 49);
			this.btnNuevo.TabIndex = 26;
			this.btnNuevo.Text = "Nueva Venta";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnGuardarVenta
			// 
			this.btnGuardarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
			this.btnGuardarVenta.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.btnGuardarVenta.Location = new System.Drawing.Point(578, 369);
			this.btnGuardarVenta.Name = "btnGuardarVenta";
			this.btnGuardarVenta.Size = new System.Drawing.Size(179, 47);
			this.btnGuardarVenta.TabIndex = 25;
			this.btnGuardarVenta.Text = "Crear Producto";
			this.btnGuardarVenta.UseVisualStyleBackColor = false;
			this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.btnAgregar.Location = new System.Drawing.Point(337, 116);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(208, 43);
			this.btnAgregar.TabIndex = 24;
			this.btnAgregar.Text = "Agregar al Carrito";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// dgvDetalleVenta
			// 
			this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalleVenta.Location = new System.Drawing.Point(337, 172);
			this.dgvDetalleVenta.Name = "dgvDetalleVenta";
			this.dgvDetalleVenta.RowHeadersWidth = 51;
			this.dgvDetalleVenta.RowTemplate.Height = 24;
			this.dgvDetalleVenta.Size = new System.Drawing.Size(625, 188);
			this.dgvDetalleVenta.TabIndex = 28;
			this.dgvDetalleVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVenta_CellClick);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
			this.label1.Location = new System.Drawing.Point(32, -5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1041, 58);
			this.label1.TabIndex = 29;
			this.label1.Text = "Registrar Ventas de Productos";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(93, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(20, 103);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(158, 22);
			this.txtCliente.TabIndex = 32;
			this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.Location = new System.Drawing.Point(20, 183);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.Size = new System.Drawing.Size(158, 22);
			this.txtEmpleado.TabIndex = 34;
			this.txtEmpleado.TextChanged += new System.EventHandler(this.txtEmpleado_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(20, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 20);
			this.label2.TabIndex = 35;
			this.label2.Text = "Buscar Cliente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(20, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 20);
			this.label3.TabIndex = 36;
			this.label3.Text = "Buscar Empleado";
			// 
			// FrmVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1065, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmpleado);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvDetalleVenta);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnGuardarVenta);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.cmbProducto);
			this.Controls.Add(this.cmbEmpleado);
			this.Controls.Add(this.cmbCliente);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblProducto);
			this.Controls.Add(this.lblEmpleado);
			this.Controls.Add(this.lblCliente);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmVenta";
			this.Text = "Venta de Productos";
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.ComboBox cmbProducto;
		private System.Windows.Forms.ComboBox cmbEmpleado;
		private System.Windows.Forms.ComboBox cmbCliente;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblProducto;
		private System.Windows.Forms.Label lblEmpleado;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnGuardarVenta;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridView dgvDetalleVenta;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.TextBox txtEmpleado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}