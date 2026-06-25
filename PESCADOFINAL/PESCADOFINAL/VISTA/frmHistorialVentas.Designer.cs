namespace PESCADOFINAL.VISTA
{
	partial class frmHistorialVentas
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtBuscarCliente = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtIinicio = new System.Windows.Forms.DateTimePicker();
			this.dtFin = new System.Windows.Forms.DateTimePicker();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnMenu = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(21, 113);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(847, 311);
			this.dataGridView1.TabIndex = 0;
			// 
			// txtBuscarCliente
			// 
			this.txtBuscarCliente.Location = new System.Drawing.Point(12, 69);
			this.txtBuscarCliente.Name = "txtBuscarCliente";
			this.txtBuscarCliente.Size = new System.Drawing.Size(167, 22);
			this.txtBuscarCliente.TabIndex = 1;
			this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Buscar Cliente";
			// 
			// dtIinicio
			// 
			this.dtIinicio.Location = new System.Drawing.Point(233, 67);
			this.dtIinicio.Name = "dtIinicio";
			this.dtIinicio.Size = new System.Drawing.Size(246, 22);
			this.dtIinicio.TabIndex = 3;
			// 
			// dtFin
			// 
			this.dtFin.Location = new System.Drawing.Point(485, 67);
			this.dtFin.Name = "dtFin";
			this.dtFin.Size = new System.Drawing.Size(246, 22);
			this.dtFin.TabIndex = 4;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(748, 60);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(102, 31);
			this.btnBuscar.TabIndex = 5;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(387, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Buscar En Rango de  Fechas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(295, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Fecha Inicio";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(563, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Fecha Fin";
			// 
			// btnMenu
			// 
			this.btnMenu.Location = new System.Drawing.Point(736, 20);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(132, 23);
			this.btnMenu.TabIndex = 9;
			this.btnMenu.Text = "Volver Menu";
			this.btnMenu.UseVisualStyleBackColor = true;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// frmHistorialVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(904, 450);
			this.Controls.Add(this.btnMenu);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dtFin);
			this.Controls.Add(this.dtIinicio);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBuscarCliente);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmHistorialVentas";
			this.Text = "frmHistorialVentas";
			this.Load += new System.EventHandler(this.frmHistorialVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtBuscarCliente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtIinicio;
		private System.Windows.Forms.DateTimePicker dtFin;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnMenu;
	}
}