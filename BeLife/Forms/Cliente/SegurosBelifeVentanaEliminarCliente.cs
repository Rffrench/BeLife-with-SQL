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
    public partial class VentanaEliminarCliente : Form
    {
        public VentanaEliminarCliente()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaClientes v = new VentanaClientes();
            v.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(TxtRut.Text.Length < 8 || TxtRut.Text.Length > 10){
                MessageBox.Show("La longitud del rut ingresado es incorrecta. Por favor verifique que el rut tiene entre 8 y 10 dígitos");
            }
            else 
            {
                MessageBox.Show(Cliente.EliminarCliente(TxtRut.Text));
            }//chequear lo del contrato tb




            /*if (Cliente.clientes.Find(i=> i.Rut == TxtRut.Text) == null)
            {
                MessageBox.Show("ERROR: El cliente no existe");
            }
            else if(Contrato.contratos.Find(i=> i.Titular == TxtRut.Text) != null)
            {
                MessageBox.Show("ERROR: El cliente posee contratos.");
            }
            else
            {
                Cliente.clientes.Remove(Cliente.clientes.Find(i => i.Rut == TxtRut.Text));
                MessageBox.Show("Cliente eliminado");
            }*/
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            VentanaAgregarCliente Ventana2 = new VentanaAgregarCliente();
            this.Hide();

            Ventana2.ShowDialog();

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            VentanaBuscarCliente v = new VentanaBuscarCliente();
            this.Hide();
            v.ShowDialog();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaModificarCliente v = new VentanaModificarCliente();
            v.ShowDialog();
        }

        private void BtnListadoClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaListarCliente v = new SegurosBelifeVentanaListarCliente();
            v.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void VentanaEliminarCliente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
