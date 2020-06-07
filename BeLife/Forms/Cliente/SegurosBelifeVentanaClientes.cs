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
    public partial class VentanaClientes : Form
    {
        public VentanaClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            VentanaAgregarCliente Ventana2 = new VentanaAgregarCliente();
            this.Hide();

            Ventana2.ShowDialog();

            this.Show();

        }

        private void VentanaClientes_Load(object sender, EventArgs e)
        {

        }

        private void BtnListadoClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaListarCliente v = new SegurosBelifeVentanaListarCliente();
            v.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            VentanaBuscarCliente v = new VentanaBuscarCliente();
            this.Hide();
            v.ShowDialog();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaEliminarCliente v = new VentanaEliminarCliente();
            v.ShowDialog();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaModificarCliente v = new VentanaModificarCliente();
            v.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaBuscarCliente v = new VentanaBuscarCliente();
            this.Hide();
            v.ShowDialog();
        }
    }
}
/***
 *      ######   ##########    # #                              #####     #               #        ######### 
 *                        #    # #     ########## #########    #     #    #    ########## #   ###          # 
 *    ##########         #     # #             #  #       #    #     #    ##           #  ####             # 
 *         #     ########      # #   #        #   #       #     #####     # #         #   #        ########  
 *         #         ##       #  #  #      # #    #       #    #     #    #  #     # #    #               #  
 *        #        ##        #   # #        #     #########    #     #    #         #     #               #  
 *      ##       ##         #    ##          #                  #####     #          #     ####### ########  
 *           ｌ ｏ ｓ　 ｓ ｕ ｐ ｅ ｒ　 ８　 ｔ ｅ ａ ｍ　 だ佳ツが                                                                                                 
 */
