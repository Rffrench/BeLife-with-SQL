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
    public partial class ListarHogar : Form
    {
        public ListarHogar()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void btnBuscarHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarHogar v = new BuscarHogar();
            v.ShowDialog();
        }

        private void btnTerminarHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaTerminarContratoHogar v = new VentanaTerminarContratoHogar();
            v.ShowDialog();
        }

        private void btnModificarHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarHogar v = new ModificarHogar();
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainHogar v = new MainHogar();
            v.ShowDialog();
        }

        private void ListarHogar_Load(object sender, EventArgs e)
        {

        }
    }
}
