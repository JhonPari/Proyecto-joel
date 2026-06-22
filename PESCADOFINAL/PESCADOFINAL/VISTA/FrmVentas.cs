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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMenuCajero menu = new FrmMenuCajero();
            menu.Show();
            this.Close();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
           

        }
    }
}
