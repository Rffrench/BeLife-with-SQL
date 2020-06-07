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
    public partial class VentanaBuscarContrato : Form
    {
        public VentanaBuscarContrato()
        {
            InitializeComponent();
            PanelResultados.Hide();
        }

        private void BuscarContrato()
        {
            string resultado = "";

            SqlConnection con = new SqlConnection(ConSql.conexion);
            try
            {


                con.Open();

                SqlDataReader rdr;
                SqlCommand cmd = new SqlCommand("BuscarContrato", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNum = new SqlParameter("@numContrato", SqlDbType.VarChar);
                ParNum.Value = TxtNumero.Text;

                cmd.Parameters.Add(ParNum);
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    PanelResultados.Show();

                    while (rdr.Read())
                    {
                        LblNumeroContrato.Text = rdr["numContrato"].ToString();
                        LblFechaCreacion.Text = rdr["fechaCreacion"].ToString();
                        LblFechaTermino.Text = rdr["fechaTermino"].ToString();
                        LblTitular.Text = rdr["RutCliente"].ToString();
                        LblPlan.Text = rdr["planAsociado"].ToString();
                        LblPoliza.Text = rdr["poliza"].ToString();
                        LblInicioVig.Text = rdr["fechaInicioVig"].ToString();
                        LblFinVig.Text = rdr["fechaTerminoVig"].ToString();
                        LblEstaVig.Text = (rdr["estaVig"].ToString()=="True")? "SI": "NO";
                        LblDeclaracionSalud.Text = (rdr["conDeclaracionDeSalud"].ToString()=="True")?"SI":"NO";
                        LblPrimaAnual.Text = rdr["primaAnual"].ToString();
                        LblPrimaMensual.Text = rdr["primaMensual"].ToString();
                        LblObservaciones.Text = rdr["observaciones"].ToString();

                        
                    }






                }
                else
                {
                    MessageBox.Show("El número de contrato ingresado no se encuentra registrado en la base de datos");
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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            if (TxtNumero.TextLength != 14)
            {
                MessageBox.Show("ERROR: El numero de contrato no existe o no es válido");
            }
            else
            {
                BuscarContrato();
            }

          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNumeroContrato_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelResultados.Hide();
        }

        private void VentanaBuscarContrato_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaModificarContrato v = new VentanaModificarContrato();
            v.ShowDialog();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaListadoContratos v = new VentanaListadoContratos();
            v.ShowDialog();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            VentanaCrearContrato v = new VentanaCrearContrato();
            this.Hide();
            v.ShowDialog();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaTerminarContratoHogar v = new VentanaTerminarContratoHogar();
            v.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
