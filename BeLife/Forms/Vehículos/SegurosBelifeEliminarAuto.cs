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
    public partial class EliminarAuto : Form
    {
        public EliminarAuto()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void btnBuscarAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarAuto v = new BuscarAuto();
            v.ShowDialog();
        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaAgregarAuto v = new SegurosBelifeVentanaAgregarAuto();
            v.ShowDialog();
        }

        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarAuto v = new ModificarAuto();
            v.ShowDialog();
        }

        private void btnListadoAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaListarAuto v = new SegurosBelifeVentanaListarAuto();
            v.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAutos v = new MainAutos();
            v.ShowDialog();
        }

        private void EliminarAuto_Load(object sender, EventArgs e)
        {

        }

        private void BtnTerminarAuto_Click(object sender, EventArgs e)
        {
            if (TxtNumeroAuto.TextLength != 14)
            {
                MessageBox.Show("ERROR: El numero de contrato no existe o no es válido");
            }
            else
            {
                MessageBox.Show(Contrato.TerminarContrato(TxtNumeroAuto.Text));
            }
        }
    }
}
