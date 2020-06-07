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
    public partial class VentanaTerminarContratoHogar : Form
    {
        public VentanaTerminarContratoHogar()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            if (TxtNumero.TextLength != 14)
            {
                MessageBox.Show("ERROR: El numero de contrato no existe o no es válido");
            }
            else
            {
                MessageBox.Show(Contrato.TerminarContrato(TxtNumero.Text));
            }
            
            
            /*if(Contrato.contratos.Exists(i=> i.NumContrato == TxtNumero.Text))
            {
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).EstaVig = false;
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).FechaTermino = DateTime.Now;
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).FechaTerminoVig = DateTime.Now;
                MessageBox.Show("El contrato ha sido terminado");



            }
            else
            {
                MessageBox.Show("ERROR: El contrato no existe");
            }*/
        }

        private void VentanaTerminarContrato_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaListadoContratos v = new VentanaListadoContratos();
            v.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaModificarContrato v = new VentanaModificarContrato();
            v.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaBuscarContrato v = new VentanaBuscarContrato();
            v.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaTerminarContratoHogar v = new VentanaTerminarContratoHogar();
            v.ShowDialog();
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
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
