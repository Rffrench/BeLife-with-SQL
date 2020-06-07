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
    public partial class SegurosBelifeAgregarContratos : Form
    {
        public static int tipocont=0;
        public SegurosBelifeAgregarContratos()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRegVeh_Click(object sender, EventArgs e)
        {
            tipocont = 20;
            this.Hide();
            MainAutos x = new MainAutos();
            x.ShowDialog();
            
        }

        private void BtnRegViv_Click(object sender, EventArgs e)
        {
            tipocont = 30;
            this.Hide();
            MainHogar x = new MainHogar();
            x.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain x = new VentanaMain();
            x.ShowDialog();
        }

        private void SegurosBelifeAgregarContratos_Load(object sender, EventArgs e)
        {

        }

        private void BtnVida_Click(object sender, EventArgs e)
        {
            tipocont = 10;
            this.Hide();
            VentanaContratos x = new VentanaContratos();
            x.ShowDialog();
            
        }
    }
}
