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
    public partial class VentanaBuscarCliente : Form
    {
        public VentanaBuscarCliente()
        {
            InitializeComponent();
            PanelResultados.Hide();
        }

        private void BuscarCliente()
        {
            string resultado = "";

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

                if (rdr.HasRows)
                {
                    PanelResultados.Show();

                    while (rdr.Read())
                    {
                        LblRut.Text = rdr["RutCliente"].ToString();
                        LblNombre.Text = rdr["Nombres"].ToString();
                        LblApellidos.Text = rdr["Apellidos"].ToString();
                        LblFecha.Text = rdr["FechaNacimiento"].ToString();
                        LblSexo.Text = (rdr["IdSexo"].ToString() == "1") ? "Masculino" : "Femenino"; //'?' >> si es V asigna ese valor. ':'>> sino asigna valor fem
                        if (rdr["IdEstadoCivil"].ToString() == "1")
                        {
                            LblEstado.Text = "Soltero";
                        }
                        else if (rdr["IdEstadoCivil"].ToString() == "2")
                        {
                            LblEstado.Text = "Casado";

                        }
                        else if (rdr["IdEstadoCivil"].ToString() == "3")
                        {
                            LblEstado.Text = "Divorciado";

                        }
                        else
                        {
                            LblEstado.Text = "Viudo";
                        }
                    }






                }
                else
                {
                    MessageBox.Show("El rut ingresado no se encuentra registrado en la base de datos");
                }

            }
            catch (Exception error)
            {
                resultado = error.Message;
                MessageBox.Show(resultado);

            }
            finally
            {
                con.Close();
            }
        }


            private void BtnConsultar_Click(object sender, EventArgs e)
        {

            if (TxtRut.TextLength < 8 || TxtRut.TextLength > 10)
            {
                MessageBox.Show("La longitud del rut ingresado es incorrecta. Por favor verifique que el rut tiene entre 8 y 10 dígitos ");
            }
            else
            {
                BuscarCliente();
            }

          
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PanelResultados.Hide();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            this.Hide();
            VentanaAgregarCliente v = new VentanaAgregarCliente();
            v.ShowDialog();


                  }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaEliminarCliente v = new VentanaEliminarCliente();
            v.ShowDialog();
        }

        private void BtnListadoClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaListarCliente v= new SegurosBelifeVentanaListarCliente();
            v.ShowDialog();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {

            this.Hide();
            VentanaModificarCliente v = new VentanaModificarCliente();
            v.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaClientes v = new VentanaClientes();
            v.ShowDialog();
        }

        private void VentanaBuscarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}


