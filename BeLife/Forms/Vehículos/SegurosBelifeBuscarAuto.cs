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
    public partial class BuscarAuto : Form
    {
        public BuscarAuto()
        {
            InitializeComponent();
            PanelResultados.Hide();
        }

        private void BuscarContratoAuto()
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
                ParNum.Value = TxtNumeroAuto.Text;

                cmd.Parameters.Add(ParNum);
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    PanelResultados.Show();

                    while (rdr.Read())
                    {
                        LblNumeroContratoAuto.Text = rdr["numContrato"].ToString();
                        LblFechaCreacionAuto.Text = rdr["fechaCreacion"].ToString();
                        LblFechaTerminoAuto.Text = rdr["fechaTermino"].ToString();
                        LblTitularAuto.Text = rdr["RutCliente"].ToString();
                        LblPlanAuto.Text = rdr["planAsociado"].ToString();
                        LblPolizaAuto.Text = rdr["poliza"].ToString();
                        LblInicioVigAuto.Text = rdr["fechaInicioVig"].ToString();
                        LblFinVigAuto.Text = rdr["fechaTerminoVig"].ToString();
                        LblEstaVigAuto.Text = (rdr["estaVig"].ToString() == "True") ? "SI" : "NO";
                        LblDeclaracionSaludAuto.Text = (rdr["conDeclaracionDeSalud"].ToString() == "True") ? "SI" : "NO";
                        LblPrimaAnualAuto.Text = rdr["primaAnual"].ToString();
                        LblPrimaMensualAuto.Text = rdr["primaMensual"].ToString();
                        LblObservacionesAuto.Text = rdr["observaciones"].ToString();
                        LblAñoFabricanteAuto.Text = rdr["añoFabricacion"].ToString();
                        LblMarcaAuto.Text = rdr["marcaAuto"].ToString();
                        LblModeloAuto.Text = rdr["marcaAuto"].ToString();

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












        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void btnTerminarAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarAuto v = new EliminarAuto();
            v.ShowDialog();
        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaAgregarAuto v = new SegurosBelifeVentanaAgregarAuto();
            v.ShowDialog();
        }

        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarAuto v = new ModificarAuto();
            v.ShowDialog();
        }

        private void btnListadoAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaListarAuto v = new SegurosBelifeVentanaListarAuto();
            v.ShowDialog();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAutos v = new MainAutos();
            v.ShowDialog();
        }

        private void BuscarAuto_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarAuto_Click(object sender, EventArgs e)
        {

        }

        private void PanelResultados_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
