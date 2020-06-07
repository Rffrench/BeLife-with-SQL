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
    public partial class SegurosBelifeVentanaListarAuto : Form
    {
        public SegurosBelifeVentanaListarAuto()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
       
        }

        private void btnBuscarAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarAuto v = new BuscarAuto();
            v.ShowDialog();
        }

        private void btnTerminarAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarAuto v = new EliminarAuto();
            v.ShowDialog();

        }

        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarAuto v = new ModificarAuto();
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAutos v = new MainAutos();
            v.ShowDialog();

        }

        private void SegurosBelifeVentanaListarAuto_Load(object sender, EventArgs e)
        {

        }

        private void BtnFiltrarRutAuto_Click(object sender, EventArgs e)
        {

        }
    }
}
