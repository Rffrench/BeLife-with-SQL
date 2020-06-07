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
    public partial class MainAutos : Form
    {
        public MainAutos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeAgregarContratos v = new SegurosBelifeAgregarContratos();
            v.ShowDialog();
        }

        private void btnCrearAutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaAgregarAuto v = new SegurosBelifeVentanaAgregarAuto();
            v.ShowDialog();
        }

        private void btnTerminarAutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarAuto v = new EliminarAuto();
            v.ShowDialog();
        }

        private void btnBuscarAutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarAuto v = new BuscarAuto();
            v.ShowDialog();
        }

        private void btnModificarAutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarAuto v = new ModificarAuto();
            v.ShowDialog();

        }

        private void btnListadoAutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaListarAuto v = new SegurosBelifeVentanaListarAuto();
            v.ShowDialog();
        }

        private void MainAutos_Load(object sender, EventArgs e)
        {

        }
    }
}
