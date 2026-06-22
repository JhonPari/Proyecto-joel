namespace PESCADOFINAL.VISTA
{
    partial class FrmProveedores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvProveedores = new System.Windows.Forms.DataGridView();
			this.btnVolver = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(34, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 16);
			this.label1.TabIndex = 23;
			this.label1.Text = "REGISTRAR PROVEEDOR";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtNombre);
			this.groupBox2.Controls.Add(this.txtDireccion);
			this.groupBox2.Controls.Add(this.txtTelefono);
			this.groupBox2.Location = new System.Drawing.Point(29, 67);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(337, 177);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DATOS DEL PROVEEDOR";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 16);
			this.label5.TabIndex = 18;
			this.label5.Text = "TELEFONO :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 16);
			this.label4.TabIndex = 17;
			this.label4.Text = "DIRECCIÓN :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "NOMBRE :";
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.SystemColors.Info;
			this.txtNombre.Location = new System.Drawing.Point(96, 26);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(236, 22);
			this.txtNombre.TabIndex = 3;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// txtDireccion
			// 
			this.txtDireccion.BackColor = System.Drawing.SystemColors.Info;
			this.txtDireccion.Location = new System.Drawing.Point(96, 94);
			this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(236, 22);
			this.txtDireccion.TabIndex = 1;
			this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
			// 
			// txtTelefono
			// 
			this.txtTelefono.BackColor = System.Drawing.SystemColors.Info;
			this.txtTelefono.Location = new System.Drawing.Point(96, 58);
			this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(236, 22);
			this.txtTelefono.TabIndex = 2;
			this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
			this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefono_Validating);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(182, 285);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(119, 48);
			this.btnGuardar.TabIndex = 21;
			this.btnGuardar.Text = "REGISTRAR";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dgvProveedores);
			this.groupBox1.Location = new System.Drawing.Point(398, 29);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(439, 207);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "LISTA DE PROVEEDORES";
			// 
			// dgvProveedores
			// 
			this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProveedores.Location = new System.Drawing.Point(3, 17);
			this.dgvProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvProveedores.Name = "dgvProveedores";
			this.dgvProveedores.RowHeadersWidth = 62;
			this.dgvProveedores.RowTemplate.Height = 28;
			this.dgvProveedores.Size = new System.Drawing.Size(433, 188);
			this.dgvProveedores.TabIndex = 10;
			this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(333, 354);
			this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(201, 46);
			this.btnVolver.TabIndex = 19;
			this.btnVolver.Text = "VOLVER AL MENU";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(498, 286);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(126, 47);
			this.btnCancelar.TabIndex = 18;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(333, 286);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(126, 47);
			this.btnEditar.TabIndex = 17;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(676, 286);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(114, 47);
			this.btnEliminar.TabIndex = 16;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(38, 285);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(117, 48);
			this.btnNuevo.TabIndex = 15;
			this.btnNuevo.Text = "NUEVO";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// FrmProveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(866, 432);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnNuevo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmProveedores";
			this.Text = "FrmProveedores";
			this.Load += new System.EventHandler(this.FrmProveedores_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
    }
}