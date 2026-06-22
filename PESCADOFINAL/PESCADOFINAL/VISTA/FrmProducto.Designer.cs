namespace PESCADOFINAL.VISTA
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTamano = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrecioCosto = new System.Windows.Forms.TextBox();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.botonCancelar = new System.Windows.Forms.Button();
			this.botonGuardar = new System.Windows.Forms.Button();
			this.botonEliminar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.cmbCategoria);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtTamano);
			this.groupBox2.Controls.Add(this.txtNombre);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtPrecioCosto);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(513, 54);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(354, 276);
			this.groupBox2.TabIndex = 46;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DATOS PRODUCTO";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 17);
			this.label4.TabIndex = 41;
			this.label4.Text = "CATEGORIA :";
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.BackColor = System.Drawing.SystemColors.Info;
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Location = new System.Drawing.Point(9, 82);
			this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(293, 26);
			this.cmbCategoria.TabIndex = 40;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(5, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "NOMBRE PRODUCTO:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(12, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 17);
			this.label2.TabIndex = 26;
			this.label2.Text = "TAMAÑO: ";
			// 
			// txtTamano
			// 
			this.txtTamano.BackColor = System.Drawing.SystemColors.Info;
			this.txtTamano.Location = new System.Drawing.Point(9, 190);
			this.txtTamano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTamano.Name = "txtTamano";
			this.txtTamano.Size = new System.Drawing.Size(294, 24);
			this.txtTamano.TabIndex = 38;
			this.txtTamano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamano_KeyPress);
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.SystemColors.Info;
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(9, 136);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(293, 24);
			this.txtNombre.TabIndex = 22;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(12, 223);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 17);
			this.label3.TabIndex = 27;
			this.label3.Text = "PRECIO:";
			// 
			// txtPrecioCosto
			// 
			this.txtPrecioCosto.BackColor = System.Drawing.SystemColors.Info;
			this.txtPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioCosto.Location = new System.Drawing.Point(9, 244);
			this.txtPrecioCosto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPrecioCosto.Name = "txtPrecioCosto";
			this.txtPrecioCosto.Size = new System.Drawing.Size(294, 24);
			this.txtPrecioCosto.TabIndex = 24;
			this.txtPrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCosto_KeyPress);
			// 
			// btnEditar
			// 
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Location = new System.Drawing.Point(272, 282);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(154, 38);
			this.btnEditar.TabIndex = 45;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnVolver
			// 
			this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.Location = new System.Drawing.Point(118, 347);
			this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(249, 50);
			this.btnVolver.TabIndex = 44;
			this.btnVolver.Text = "VOLVER AL MENU";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.button2_Click);
			// 
			// botonCancelar
			// 
			this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonCancelar.Location = new System.Drawing.Point(38, 277);
			this.botonCancelar.Name = "botonCancelar";
			this.botonCancelar.Size = new System.Drawing.Size(149, 38);
			this.botonCancelar.TabIndex = 43;
			this.botonCancelar.Text = "CANCELAR";
			this.botonCancelar.UseVisualStyleBackColor = true;
			this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
			// 
			// botonGuardar
			// 
			this.botonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonGuardar.Location = new System.Drawing.Point(38, 225);
			this.botonGuardar.Name = "botonGuardar";
			this.botonGuardar.Size = new System.Drawing.Size(149, 41);
			this.botonGuardar.TabIndex = 42;
			this.botonGuardar.Text = "GUARDAR";
			this.botonGuardar.UseVisualStyleBackColor = true;
			this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
			// 
			// botonEliminar
			// 
			this.botonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonEliminar.Location = new System.Drawing.Point(272, 225);
			this.botonEliminar.Name = "botonEliminar";
			this.botonEliminar.Size = new System.Drawing.Size(154, 41);
			this.botonEliminar.TabIndex = 41;
			this.botonEliminar.Text = "ELIMINAR";
			this.botonEliminar.UseVisualStyleBackColor = true;
			this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dgvProductos);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(11, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(497, 170);
			this.groupBox1.TabIndex = 40;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "LISTADO DE DATOS";
			// 
			// dgvProductos
			// 
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProductos.Location = new System.Drawing.Point(3, 19);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.RowHeadersWidth = 62;
			this.dgvProductos.RowTemplate.Height = 28;
			this.dgvProductos.Size = new System.Drawing.Size(491, 148);
			this.dgvProductos.TabIndex = 0;
			this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
			// 
			// FrmProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(866, 432);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.botonCancelar);
			this.Controls.Add(this.botonGuardar);
			this.Controls.Add(this.botonEliminar);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmProducto";
			this.Text = "FrmProducto";
			this.Load += new System.EventHandler(this.FrmProducto_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamano;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}