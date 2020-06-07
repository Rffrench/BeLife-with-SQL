using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeLife
{
    public partial class SegurosBeLifeSeleccionarRegistrar : Form
    {
        public SegurosBeLifeSeleccionarRegistrar()
        {
            InitializeComponent();
        }

        private void BtnRegViv_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBeLifeRegistrarVivienda x = new SegurosBeLifeRegistrarVivienda();
            x.ShowDialog();

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegVeh_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBeLifeRegistrarVehiculo x = new SegurosBeLifeRegistrarVehiculo();
            x.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain x = new VentanaMain();
            x.ShowDialog();
        }
    }
}
