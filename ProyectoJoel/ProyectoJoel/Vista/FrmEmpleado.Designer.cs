namespace ProyectoJoel.Vista
{
	partial class FrmEmpleado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
			this.lbNombre = new System.Windows.Forms.Label();
			this.lblApellido = new System.Windows.Forms.Label();
			this.lblCargo = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtCargo = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.dgvEmpleados = new System.Windows.Forms.DataGridView();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbNombre
			// 
			this.lbNombre.AutoSize = true;
			this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lbNombre.Location = new System.Drawing.Point(106, 89);
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Size = new System.Drawing.Size(74, 20);
			this.lbNombre.TabIndex = 0;
			this.lbNombre.Text = "Nombre";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblApellido.Location = new System.Drawing.Point(106, 130);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(76, 20);
			this.lblApellido.TabIndex = 1;
			this.lblApellido.Text = "Apellido";
			// 
			// lblCargo
			// 
			this.lblCargo.AutoSize = true;
			this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblCargo.Location = new System.Drawing.Point(106, 172);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(59, 20);
			this.lblCargo.TabIndex = 2;
			this.lblCargo.Text = "Cargo";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblTelefono.Location = new System.Drawing.Point(397, 89);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(81, 20);
			this.lblTelefono.TabIndex = 3;
			this.lblTelefono.Text = "Telefono";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.lblEmail.Location = new System.Drawing.Point(397, 129);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(56, 20);
			this.lblEmail.TabIndex = 4;
			this.lblEmail.Text = "Email";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(194, 86);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(145, 22);
			this.txtNombre.TabIndex = 5;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(194, 130);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(145, 22);
			this.txtApellido.TabIndex = 6;
			// 
			// txtCargo
			// 
			this.txtCargo.Location = new System.Drawing.Point(194, 172);
			this.txtCargo.Name = "txtCargo";
			this.txtCargo.Size = new System.Drawing.Size(145, 22);
			this.txtCargo.TabIndex = 7;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(485, 89);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(145, 22);
			this.txtTelefono.TabIndex = 8;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(485, 129);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(145, 22);
			this.txtEmail.TabIndex = 9;
			// 
			// dgvEmpleados
			// 
			this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmpleados.Location = new System.Drawing.Point(12, 223);
			this.dgvEmpleados.Name = "dgvEmpleados";
			this.dgvEmpleados.RowHeadersWidth = 51;
			this.dgvEmpleados.RowTemplate.Height = 24;
			this.dgvEmpleados.Size = new System.Drawing.Size(838, 150);
			this.dgvEmpleados.TabIndex = 10;
			this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick_1);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.YellowGreen;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.btnGuardar.Location = new System.Drawing.Point(270, 379);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(101, 42);
			this.btnGuardar.TabIndex = 11;
			this.btnGuardar.Text = "Crear";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.Orange;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.btnEditar.Location = new System.Drawing.Point(377, 379);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(101, 42);
			this.btnEditar.TabIndex = 12;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Red;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
			this.btnEliminar.Location = new System.Drawing.Point(485, 379);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(101, 42);
			this.btnEliminar.TabIndex = 13;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(-48, -8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(938, 58);
			this.label1.TabIndex = 15;
			this.label1.Text = "Registrar Empleados ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-2, -8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(93, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// FrmEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(850, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dgvEmpleados);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtCargo);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.lblCargo);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.lbNombre);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmEmpleado";
			this.Text = "Empleado";
			this.Load += new System.EventHandler(this.FrmEmpleado_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbNombre;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblCargo;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtCargo;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.DataGridView dgvEmpleados;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}