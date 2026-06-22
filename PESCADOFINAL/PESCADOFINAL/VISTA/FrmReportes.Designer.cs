namespace PESCADOFINAL.VISTA
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantReportes = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalReporte = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgyReporte = new System.Windows.Forms.GroupBox();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnReporteMes = new System.Windows.Forms.Button();
            this.btnReporteDia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.dgyReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCantReportes);
            this.groupBox1.Controls.Add(this.cmbMes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTotalReporte);
            this.groupBox1.Controls.Add(this.cmbAnio);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 230);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "SELECCIONE EL MES:";
            // 
            // lblCantReportes
            // 
            this.lblCantReportes.AutoSize = true;
            this.lblCantReportes.BackColor = System.Drawing.Color.Transparent;
            this.lblCantReportes.Location = new System.Drawing.Point(6, 198);
            this.lblCantReportes.Name = "lblCantReportes";
            this.lblCantReportes.Size = new System.Drawing.Size(184, 20);
            this.lblCantReportes.TabIndex = 15;
            this.lblCantReportes.Text = "CANTIDAD VENTAS  : 0";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cmbMes.Location = new System.Drawing.Point(6, 56);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(214, 28);
            this.cmbMes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "SELECCIONE EL AÑO:";
            // 
            // lblTotalReporte
            // 
            this.lblTotalReporte.AutoSize = true;
            this.lblTotalReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReporte.Location = new System.Drawing.Point(6, 166);
            this.lblTotalReporte.Name = "lblTotalReporte";
            this.lblTotalReporte.Size = new System.Drawing.Size(141, 22);
            this.lblTotalReporte.TabIndex = 11;
            this.lblTotalReporte.Text = "TOTAL: Bs 0.00";
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbAnio.Location = new System.Drawing.Point(6, 125);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(214, 28);
            this.cmbAnio.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 55);
            this.button1.TabIndex = 20;
            this.button1.Text = "VOLVER AL MENU";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgyReporte
            // 
            this.dgyReporte.BackColor = System.Drawing.Color.Transparent;
            this.dgyReporte.Controls.Add(this.dgvReporte);
            this.dgyReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgyReporte.Location = new System.Drawing.Point(344, 25);
            this.dgyReporte.Name = "dgyReporte";
            this.dgyReporte.Size = new System.Drawing.Size(573, 260);
            this.dgyReporte.TabIndex = 19;
            this.dgyReporte.TabStop = false;
            this.dgyReporte.Text = "MUESTRA REPORTE";
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporte.Location = new System.Drawing.Point(3, 26);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 62;
            this.dgvReporte.RowTemplate.Height = 28;
            this.dgvReporte.Size = new System.Drawing.Size(567, 231);
            this.dgvReporte.TabIndex = 8;
            // 
            // btnReporteMes
            // 
            this.btnReporteMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteMes.Location = new System.Drawing.Point(288, 349);
            this.btnReporteMes.Name = "btnReporteMes";
            this.btnReporteMes.Size = new System.Drawing.Size(121, 55);
            this.btnReporteMes.TabIndex = 18;
            this.btnReporteMes.Text = "VENTAS DEL MES";
            this.btnReporteMes.UseVisualStyleBackColor = true;
            // 
            // btnReporteDia
            // 
            this.btnReporteDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteDia.Location = new System.Drawing.Point(12, 351);
            this.btnReporteDia.Name = "btnReporteDia";
            this.btnReporteDia.Size = new System.Drawing.Size(127, 53);
            this.btnReporteDia.TabIndex = 17;
            this.btnReporteDia.Text = "VENTAS DEL DIA";
            this.btnReporteDia.UseVisualStyleBackColor = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgyReporte);
            this.Controls.Add(this.btnReporteMes);
            this.Controls.Add(this.btnReporteDia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dgyReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantReportes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalReporte;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox dgyReporte;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnReporteMes;
        private System.Windows.Forms.Button btnReporteDia;
    }
}