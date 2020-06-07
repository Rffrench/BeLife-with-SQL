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
    public partial class VentanaMain : Form
    {
        public VentanaMain()
        {
            InitializeComponent();
        }

        private void btnClientesMain_Click(object sender, EventArgs e)
        {
            VentanaClientes Ventana1 = new VentanaClientes();
            this.Hide();
            Ventana1.ShowDialog();
            this.Show();
            
        }

        private void VentanaMain_Load(object sender, EventArgs e)
        {

        }

        private void btnContratosMain_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            SegurosBelifeAgregarContratos x = new SegurosBelifeAgregarContratos();
            x.ShowDialog();
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBeLifeSeleccionarRegistrar x = new SegurosBeLifeSeleccionarRegistrar();
            x.ShowDialog();

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
