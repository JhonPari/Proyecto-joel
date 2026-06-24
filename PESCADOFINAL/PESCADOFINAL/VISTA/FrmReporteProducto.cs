using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PESCADOFINAL.VISTA
{
    public partial class FrmReporteProducto : Form
    {
        public FrmReporteProducto()
        {
            InitializeComponent();
        }

        private void FrmReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pezFinalDataSet2.ESTADISTICA_PRODUCTOS_MAS_VENDIDOS' Puede moverla o quitarla según sea necesario.
            this.eSTADISTICA_PRODUCTOS_MAS_VENDIDOSTableAdapter.Fill(this.pezFinalDataSet2.ESTADISTICA_PRODUCTOS_MAS_VENDIDOS);

            this.reportViewer1.RefreshReport();
        }

        private void botonReportes_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
