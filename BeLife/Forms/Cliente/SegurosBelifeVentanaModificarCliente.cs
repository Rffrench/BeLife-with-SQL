using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BeLife
{
    public partial class VentanaModificarCliente : Form
    {
        public VentanaModificarCliente()
        {
            InitializeComponent();
            PanelResultados.Hide();
            Panel2.Hide();
            
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaClientes v = new VentanaClientes();
            this.Hide();
            v.ShowDialog();


        }

        public int CalcularEdad(DateTime f)
        {
            int years = DateTime.Now.Year - Fecha2.Value.Year; //se llama fecha 2 el datetimepicker ahora
            if (f.Month > DateTime.Now.Month)
            {
                years--;
            }
            if (f.Month == DateTime.Now.Month && f.Day > DateTime.Now.Day)
            {
                years--;
            }
            return years;
        }

        private bool BuscarCliente()
        {
            string resultado = "";
            bool existe;
            SqlConnection con = new SqlConnection(ConSql.conexion);

            try
            {


                con.Open();

                SqlDataReader rdr;
                SqlCommand cmd = new SqlCommand("BuscarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRut = new SqlParameter("@rut", SqlDbType.VarChar);
                ParRut.Value = TxtRut.Text;

                cmd.Parameters.Add(ParRut);



                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    LblRut2.Text = rdr["RutCliente"].ToString();


                    existe = true;


                }
                else
                {
                    MessageBox.Show("El rut ingresado no se encuentra registrado en la base de datos");
                    existe = false;
                }

            }
            catch (Exception error)
            {
                resultado = error.Message;
                MessageBox.Show(resultado);
                existe = false;

            }
            finally
            {
                con.Close();
            }


            return existe;

        }



        private void BtnModificar_Click(object sender, EventArgs e)
        {

            string sexo;
            if (TxtRut.TextLength < 8 || TxtRut.TextLength > 10)
            {
                MessageBox.Show("La longitud del rut ingresado es incorrecta. Por favor verifique que el rut tiene entre 8 y 10 dígitos ");
            }
            else if (BuscarCliente())
            {
                PanelResultados.Show();
                Panel2.Show();
            }

            /*string sexo;

            if (Cliente.clientes.Exists(i => TxtRut.Text == i.Rut) == false)
            {
                MessageBox.Show("Error el cliente no existe");
            }
            else
            {
                PanelResultados.Show();
                if (Cliente.clientes.Find(i => i.Rut == TxtRut.Text).IdSexo == 1)
                {
                    sexo = "Masculino";
                }
                else
                {
                    sexo = "Femenino";
                }
                    
                    LblRut.Text = Cliente.clientes.Find(i => i.Rut == TxtRut.Text).Rut;
                    LblNombre.Text = Cliente.clientes.Find(i => i.Rut == TxtRut.Text).Nombre;
                    LblApellidos.Text = Cliente.clientes.Find(i => i.Rut == TxtRut.Text).Apellidos;
                    LblSexo.Text = sexo;

                }

            */
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            
           



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaBuscarCliente v = new VentanaBuscarCliente();
            v.ShowDialog();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaAgregarCliente Ventana2 = new VentanaAgregarCliente();
            

            Ventana2.ShowDialog();

            this.Show();
        }

        private void BtnListadoClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaListarCliente v = new SegurosBelifeVentanaListarCliente();
            v.ShowDialog();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaEliminarCliente v = new VentanaEliminarCliente();
            v.ShowDialog();
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelResultados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAceptar2_Click(object sender, EventArgs e)
        {
            byte ecivil;
            byte sex;

            if (RadioM.Checked == true)
            {
                sex = 1;
            }
            else
            {
                sex = 2;
            }


            if (RadioS.Checked == true)
            {
                ecivil = 1;
            }
            else if (RadioC.Checked == true)
            {
                ecivil = 2;
            }
            else if (RadioD.Checked == true)
            {
                ecivil = 3;
            }
            else
            {
                ecivil = 4;
            }
            if (CalcularEdad(Fecha2.Value.Date) >= 18 && TxtNombre.Text != "" && TxtApellidos.Text != "")
            {
                Cliente cl = new Cliente(LblRut2.Text, TxtNombre.Text, TxtApellidos.Text, Fecha2.Value.Date, sex, ecivil);
                string resultado= cl.ModificarCliente(cl);
                MessageBox.Show(resultado);
                Panel2.Hide();
                TxtRut.Text = "";

                /*Cliente.clientes.Find(i => i.Rut == TxtRut.Text).FechaNacimiento = Fecha.Value.Date;
                Cliente.clientes.Find(i => i.Rut == TxtRut.Text).IdEcivil = ecivil;
                PanelResultados.Hide();
                MessageBox.Show("Cliente Modificado con Éxito");*/
            }
            else
            {
                MessageBox.Show("ERROR: Compruebe que la edad ingresada sea mayor o igual a 18 años y que todos los campos estén rellenados");
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
