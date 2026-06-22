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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAutentificacion login = new FrmAutentificacion();
            login.Show();

            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url2 = "https://whatsapp.com/72492337";
            System.Diagnostics.Process.Start(url2);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url1 = "https://www.tiktok.com/@rincondelsabor22?is_from_webapp=1&sender_device=pc";
            System.Diagnostics.Process.Start(url1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url3 = "https://maps.app.goo.gl/ftc4bQ79T3xX5ZT56";
            System.Diagnostics.Process.Start(url3);
        }
    }
}
