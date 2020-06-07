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
    public partial class BuscarHogar : Form
    {
        public BuscarHogar()
        {
            InitializeComponent();
        }

        private void cabecera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnListadoHogar_Click(object sender, EventArgs e)
        {
             this.Hide();
            ListarHogar v = new ListarHogar();
            v.ShowDialog();
        }

        private void btnTerminarHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarHogar v = new EliminarHogar();
            v.ShowDialog();
        }

        private void btnCrearHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeCrearHogar v = new SegurosBelifeCrearHogar();
            v.ShowDialog();
        }

        private void btnModificarHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarHogar v = new ModificarHogar();
            v.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainHogar v = new MainHogar();
            v.ShowDialog();
        }

        private void PanelResultados_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
