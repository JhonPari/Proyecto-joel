namespace PESCADOFINAL.VISTA
{
    partial class FrmCategoria
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvCategorias = new System.Windows.Forms.DataGridView();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtNombre);
			this.groupBox2.Location = new System.Drawing.Point(19, 46);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(284, 154);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DATOS CATEGORIA:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "NOMBRE DE LA CATEGORIA :";
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtNombre.Location = new System.Drawing.Point(5, 94);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(229, 22);
			this.txtNombre.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dgvCategorias);
			this.groupBox1.Location = new System.Drawing.Point(325, 28);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(523, 182);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CATEGORIAS";
			// 
			// dgvCategorias
			// 
			this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCategorias.Location = new System.Drawing.Point(3, 17);
			this.dgvCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvCategorias.Name = "dgvCategorias";
			this.dgvCategorias.RowHeadersWidth = 62;
			this.dgvCategorias.RowTemplate.Height = 28;
			this.dgvCategorias.Size = new System.Drawing.Size(517, 163);
			this.dgvCategorias.TabIndex = 9;
			this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(643, 258);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(133, 49);
			this.btnCancelar.TabIndex = 17;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(325, 346);
			this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(189, 57);
			this.btnVolver.TabIndex = 16;
			this.btnVolver.Text = "VOLVER AL MENU";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(459, 258);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(122, 49);
			this.btnEliminar.TabIndex = 15;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(316, 258);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(101, 49);
			this.btnEditar.TabIndex = 14;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(172, 258);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(116, 51);
			this.btnGuardar.TabIndex = 13;
			this.btnGuardar.Text = "GUARDAR";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(19, 258);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(127, 49);
			this.btnNuevo.TabIndex = 12;
			this.btnNuevo.Text = "NUEVO";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// FrmCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(866, 429);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnNuevo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmCategoria";
			this.Text = "FrmCategoria";
			this.Load += new System.EventHandler(this.FrmCategoria_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
    }
}