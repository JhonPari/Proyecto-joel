namespace PESCADOFINAL.VISTA
{
    partial class FrmMenuCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuCajero));
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.MensajeBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(606, 304);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(191, 76);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(177, 304);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(191, 76);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // MensajeBienvenido
            // 
            this.MensajeBienvenido.AutoSize = true;
            this.MensajeBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.MensajeBienvenido.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeBienvenido.ForeColor = System.Drawing.Color.DarkBlue;
            this.MensajeBienvenido.Location = new System.Drawing.Point(285, 111);
            this.MensajeBienvenido.Name = "MensajeBienvenido";
            this.MensajeBienvenido.Size = new System.Drawing.Size(443, 84);
            this.MensajeBienvenido.TabIndex = 4;
            this.MensajeBienvenido.Text = "BIENVENIDO";
            // 
            // FrmMenuCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 536);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.MensajeBienvenido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuCajero";
            this.Text = "FrmMenuCajero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label MensajeBienvenido;
    }
}