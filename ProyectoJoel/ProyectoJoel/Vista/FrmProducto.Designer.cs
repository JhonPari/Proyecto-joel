namespace ProyectoJoel.Vista
{
	partial class FrmProducto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblTalla = new System.Windows.Forms.Label();
			this.lblColor = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblStock = new System.Windows.Forms.Label();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.txtTalla = new System.Windows.Forms.TextBox();
			this.txtColor = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.bntEditar = new System.Windows.Forms.Button();
			this.bntEliminar = new System.Windows.Forms.Button();
			this.btnImagen = new System.Windows.Forms.Button();
			this.pbImagen = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProductos = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblNombre.ForeColor = System.Drawing.Color.White;
			this.lblNombre.Location = new System.Drawing.Point(61, 122);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(74, 20);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Nombre";
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblMarca.ForeColor = System.Drawing.Color.White;
			this.lblMarca.Location = new System.Drawing.Point(61, 159);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(61, 20);
			this.lblMarca.TabIndex = 1;
			this.lblMarca.Text = "Marca";
			// 
			// lblTalla
			// 
			this.lblTalla.AutoSize = true;
			this.lblTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblTalla.ForeColor = System.Drawing.Color.White;
			this.lblTalla.Location = new System.Drawing.Point(61, 195);
			this.lblTalla.Name = "lblTalla";
			this.lblTalla.Size = new System.Drawing.Size(50, 20);
			this.lblTalla.TabIndex = 2;
			this.lblTalla.Text = "Talla\n";
			// 
			// lblColor
			// 
			this.lblColor.AutoSize = true;
			this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblColor.ForeColor = System.Drawing.Color.White;
			this.lblColor.Location = new System.Drawing.Point(61, 236);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(54, 20);
			this.lblColor.TabIndex = 3;
			this.lblColor.Text = "Color";
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblPrecio.ForeColor = System.Drawing.Color.White;
			this.lblPrecio.Location = new System.Drawing.Point(347, 122);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(63, 20);
			this.lblPrecio.TabIndex = 4;
			this.lblPrecio.Text = "Precio";
			// 
			// lblStock
			// 
			this.lblStock.AutoSize = true;
			this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblStock.ForeColor = System.Drawing.Color.White;
			this.lblStock.Location = new System.Drawing.Point(347, 165);
			this.lblStock.Name = "lblStock";
			this.lblStock.Size = new System.Drawing.Size(56, 20);
			this.lblStock.TabIndex = 5;
			this.lblStock.Text = "Stock";
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblCategoria.ForeColor = System.Drawing.Color.White;
			this.lblCategoria.Location = new System.Drawing.Point(347, 200);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(90, 20);
			this.lblCategoria.TabIndex = 6;
			this.lblCategoria.Text = "Categoria";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(179, 122);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 22);
			this.txtNombre.TabIndex = 7;
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(179, 159);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(100, 22);
			this.txtMarca.TabIndex = 8;
			// 
			// txtTalla
			// 
			this.txtTalla.Location = new System.Drawing.Point(179, 195);
			this.txtTalla.Name = "txtTalla";
			this.txtTalla.Size = new System.Drawing.Size(100, 22);
			this.txtTalla.TabIndex = 9;
			// 
			// txtColor
			// 
			this.txtColor.Location = new System.Drawing.Point(179, 236);
			this.txtColor.Name = "txtColor";
			this.txtColor.Size = new System.Drawing.Size(100, 22);
			this.txtColor.TabIndex = 10;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(465, 122);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(121, 22);
			this.txtPrecio.TabIndex = 11;
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(465, 165);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(121, 22);
			this.txtStock.TabIndex = 12;
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Location = new System.Drawing.Point(465, 200);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
			this.cmbCategoria.TabIndex = 13;
			// 
			// dgvProductos
			// 
			this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Location = new System.Drawing.Point(13, 309);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.RowHeadersWidth = 51;
			this.dgvProductos.RowTemplate.Height = 24;
			this.dgvProductos.Size = new System.Drawing.Size(1158, 150);
			this.dgvProductos.TabIndex = 14;
			this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.btnGuardar.Location = new System.Drawing.Point(219, 465);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(209, 48);
			this.btnGuardar.TabIndex = 15;
			this.btnGuardar.Text = "Crear Producto";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// bntEditar
			// 
			this.bntEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
			this.bntEditar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.bntEditar.Location = new System.Drawing.Point(444, 465);
			this.bntEditar.Name = "bntEditar";
			this.bntEditar.Size = new System.Drawing.Size(206, 48);
			this.bntEditar.TabIndex = 16;
			this.bntEditar.Text = "Editar Producto";
			this.bntEditar.UseVisualStyleBackColor = false;
			this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
			// 
			// bntEliminar
			// 
			this.bntEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
			this.bntEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.bntEliminar.Location = new System.Drawing.Point(656, 465);
			this.bntEliminar.Name = "bntEliminar";
			this.bntEliminar.Size = new System.Drawing.Size(215, 48);
			this.bntEliminar.TabIndex = 17;
			this.bntEliminar.Text = "Eliminar Producto";
			this.bntEliminar.UseVisualStyleBackColor = false;
			this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
			// 
			// btnImagen
			// 
			this.btnImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
			this.btnImagen.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.btnImagen.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnImagen.Location = new System.Drawing.Point(624, 122);
			this.btnImagen.Name = "btnImagen";
			this.btnImagen.Size = new System.Drawing.Size(119, 45);
			this.btnImagen.TabIndex = 18;
			this.btnImagen.Text = "Imagen";
			this.btnImagen.UseVisualStyleBackColor = false;
			this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
			// 
			// pbImagen
			// 
			this.pbImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
			this.pbImagen.Location = new System.Drawing.Point(762, 126);
			this.pbImagen.Name = "pbImagen";
			this.pbImagen.Size = new System.Drawing.Size(202, 130);
			this.pbImagen.TabIndex = 19;
			this.pbImagen.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
			this.label1.Location = new System.Drawing.Point(-8, -3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1199, 65);
			this.label1.TabIndex = 20;
			this.label1.Text = "Registrar Productos";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(93, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(1001, 259);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 20);
			this.label2.TabIndex = 39;
			this.label2.Text = "Buscar Productos";
			// 
			// txtProductos
			// 
			this.txtProductos.Location = new System.Drawing.Point(984, 280);
			this.txtProductos.Name = "txtProductos";
			this.txtProductos.Size = new System.Drawing.Size(175, 22);
			this.txtProductos.TabIndex = 38;
			this.txtProductos.TextChanged += new System.EventHandler(this.txtProductos_TextChanged);
			// 
			// FrmProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1182, 538);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtProductos);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbImagen);
			this.Controls.Add(this.btnImagen);
			this.Controls.Add(this.bntEliminar);
			this.Controls.Add(this.bntEditar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.cmbCategoria);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtColor);
			this.Controls.Add(this.txtTalla);
			this.Controls.Add(this.txtMarca);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblCategoria);
			this.Controls.Add(this.lblStock);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.lblTalla);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.lblNombre);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmProducto";
			this.Text = "Producto";
			this.Load += new System.EventHandler(this.FrmProducto_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.Label lblTalla;
		private System.Windows.Forms.Label lblColor;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label lblStock;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.TextBox txtTalla;
		private System.Windows.Forms.TextBox txtColor;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.ComboBox cmbCategoria;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button bntEditar;
		private System.Windows.Forms.Button bntEliminar;
		private System.Windows.Forms.Button btnImagen;
		private System.Windows.Forms.PictureBox pbImagen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductos;
	}
}