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
    public partial class ModificarAuto : Form
    {
        public ModificarAuto()
        {
            InitializeComponent();
            PanelResultadosAuto.Hide();


            if (Plan.planes.Count < 3)
            {
                Plan.planes.Add(new Plan(1, "Plan 1", 15, 10)); //precios en UF
                Plan.planes.Add(new Plan(2, "Plan 2", 21, 20));
                Plan.planes.Add(new Plan(3, "Plan 3", 28, 30));
            }

            ComboPlanAuto.Items.Clear();
            foreach (Plan p in Plan.planes)
            {
                ComboPlanAuto.Items.Add(p.Nombre);
            }
            RadioSiAuto.Checked = true;

        }
        private bool BuscarContrato()
        {
            string resultado = "";
            bool existe;
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

                if (rdr.Read())
                {
                    PanelResultadosAuto.Show();
                    LblNumContratoAuto.Text = rdr["numContrato"].ToString();
                    LblTitularAuto.Text = rdr["RutCliente"].ToString();
                    LblIniVigAuto.Text = rdr["fechaInicioVig"].ToString();
                    LblPolizaAuto.Text = rdr["poliza"].ToString();




                    existe = true;


                }
                else
                {
                    MessageBox.Show("El número de contrato ingresado no se encuentra registrado en la base de datos");
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








        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaAgregarAuto v = new SegurosBelifeVentanaAgregarAuto();
            v.ShowDialog();
        }

        private void btnTerminarAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarAuto v = new EliminarAuto();
            v.ShowDialog();
        }

        private void btnBuscarAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarAuto v = new BuscarAuto();
            v.ShowDialog();
        }

        private void btnListadoAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBelifeVentanaListarAuto v = new SegurosBelifeVentanaListarAuto();
            v.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAutos v = new MainAutos();
            v.ShowDialog();
        }

        private void ModificarAuto_Load(object sender, EventArgs e)
        {

        }

        private void PanelResultadosAuto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAceptarAuto_Click(object sender, EventArgs e)
        {

        }
    }
}
