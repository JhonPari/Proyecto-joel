using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace PESCADOFINAL.VISTA
{
    public partial class FrmReporteCategoria : Form
    {
        public FrmReporteCategoria()
        {
            InitializeComponent();
        }

		private void FrmReporteCategoria_Load(object sender, EventArgs e)
		{
			this.eSTADISTICA_INGRESOS_CATEGORIATableAdapter.Fill(
		this.pezFinalDataSet2.ESTADISTICA_INGRESOS_CATEGORIA);

			this.reportViewer1.RefreshReport();
		}

		private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			FrmReporteBivariado menu = new FrmReporteBivariado();
			menu.Show();
			this.Close();
		}
	}
}
