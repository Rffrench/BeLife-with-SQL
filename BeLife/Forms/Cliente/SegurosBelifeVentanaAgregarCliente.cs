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
    public partial class VentanaAgregarCliente : Form
    {
        
        public int CalcularEdad(DateTime f)
        {
            int years = DateTime.Now.Year - Fecha.Value.Year;
            if(f.Month > DateTime.Now.Month)
            {
                years--;
            }
            if(f.Month == DateTime.Now.Month && f.Day > DateTime.Now.Day)
            {
                years--;
            }
            return years;
        }

        public void ValidarEspacios()
        {
            if(TxtRut.Text.Length<8 || TxtRut.Text.Length > 10)
            {
                errorRut.SetError(TxtRut, "El rut no puede tener menos de 8 caracteres ni más de 10");
                TxtRut.Focus();
                return;
            }
            errorRut.SetError(TxtRut, "");

            if (TxtNombre.Text.Length<1)
            {
                errorNombre.SetError(TxtNombre, "El nombre no puede quedar en blanco");
                TxtNombre.Focus();
                return;
            }
            errorNombre.SetError(TxtNombre, "");

            if (TxtApellidos.Text.Length<1)
            {
                errorApellidos.SetError(TxtApellidos, "Los apellidos no puede quedar en blanco");
                TxtApellidos.Focus();
                return;
            }
            errorApellidos.SetError(TxtApellidos, "");
            
        }
        
        

        public VentanaAgregarCliente()
        {
            InitializeComponent();
            RadioM.Checked=true;
            RadioSoltero.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }

        private void LblRut_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VentanaAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ValidarEspacios();
            
            byte sex;
            byte ecivil;
            DateTime fec;

            if (RadioM.Checked == true)
            {
                sex = 1;
            }
            else
            {
                sex = 2;
            }

            if(RadioSoltero.Checked == true)
            {
                ecivil = 1;
            }
            else if(RadioCasado.Checked == true)
             {
                ecivil = 2;
            }else if(RadioDivorciado.Checked == true)
            {
                ecivil = 3;
            }
            else
            {
                ecivil = 4;
            }
            int edad = CalcularEdad(Fecha.Value.Date);

            if (CalcularEdad(Fecha.Value.Date) >= 18)
            {
                fec = Fecha.Value.Date;
            }
            else
            {
                errorFecha.SetError(Fecha, "La fecha especificada es mayor a la actual o usted es menor de edad");
                Fecha.Focus();
                return;
            }
            errorFecha.SetError(Fecha, "");


            if (Cliente.clientes.Exists(i => TxtRut.Text == i.Rut))
            {
                MessageBox.Show("El cliente ya existe");
            }
            else if (TxtRut.Text.Length >= 8 && TxtRut.Text.Length <= 10 && TxtNombre.Text.Length > 0 && TxtApellidos.Text.Length > 0)
            {
                Cliente.clientes.Add(new Cliente(TxtRut.Text, TxtNombre.Text, TxtApellidos.Text, fec, sex, ecivil));
                //MessageBox.Show("El cliente ha sido registrado");
                try
                {
                    Cliente cl = new Cliente(TxtRut.Text, TxtNombre.Text, TxtApellidos.Text, fec, sex, ecivil);
                    string resultado = cl.AgregarCliente(cl);
                    MessageBox.Show(resultado);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }
            }

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
           VentanaBuscarCliente v = new VentanaBuscarCliente();
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

        private void BtnListadoClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaListarCliente v= new SegurosBelifeVentanaListarCliente();
            v.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

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
