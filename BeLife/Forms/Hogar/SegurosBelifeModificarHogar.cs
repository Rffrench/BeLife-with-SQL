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
    public partial class ModificarHogar : Form
    {
        public ModificarHogar()
        {
            InitializeComponent();
        }

        private void btnListadoHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarHogar v = new ListarHogar();
            v.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void btnCrearHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeCrearHogar v = new SegurosBelifeCrearHogar();
            v.ShowDialog();
        }

        private void btnTerminarHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarHogar v = new EliminarHogar();
            v.ShowDialog();
        }

        private void btnBuscarHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarHogar v = new BuscarHogar();
            v.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBeLifeSeleccionarRegistrar v = new SegurosBeLifeSeleccionarRegistrar();
            v.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainHogar v = new MainHogar();
            v.ShowDialog();
        }

        private void ModificarHogar_Load(object sender, EventArgs e)
        {

        }

        private void PanelResultados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAceptarHogar_Click(object sender, EventArgs e)
        {

        }
    }
}
