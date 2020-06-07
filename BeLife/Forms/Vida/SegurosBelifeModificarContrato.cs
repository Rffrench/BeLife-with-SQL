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
    public partial class VentanaModificarContrato : Form
    {
        public VentanaModificarContrato()
        {
            InitializeComponent();
            PanelResultados.Hide();
            
            ComboPlan.Items.Clear();
            ComboPlanFill();

            
           

            RadioSiHogar.Checked = true;
        }

        public void ComboPlanFill()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ComboPlanFill", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partipo = new SqlParameter("idTipoContrato", SqlDbType.Int);
                partipo.Value = SegurosBelifeAgregarContratos.tipocont; //cambiar por varibale static del tipo de contrato
                cmd.Parameters.Add(partipo);



                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                DataTable dt = new DataTable();
                dt.Columns.Add("nombre", typeof(string));

                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = reader.GetString(reader.GetOrdinal("nombre"));
                    dt.Rows.Add(dr);
                }
                reader.Close();

                ComboPlan.DataSource = dt;
                ComboPlan.DisplayMember = "nombre";
                ComboPlan.ValueMember = "nombre";

                conexion.Close();




            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


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
                ParNum.Value = TxtNumeroHogar.Text;

                cmd.Parameters.Add(ParNum);



                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    PanelResultados.Show();
                    LblNumContratoHogar.Text = rdr["numContrato"].ToString();
                    LblTitularHogar.Text = rdr["RutCliente"].ToString();
                    LblIniVigHogar.Text = rdr["fechaInicioVig"].ToString();
                    //LblPolizaHogar.Text = rdr["poliza"].ToString();



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


        private int CalcularEdad(DateTime f, DateTime Fecha)
        {
            int years = DateTime.Now.Year - Fecha.Date.Year;
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

        


        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (TxtNumeroHogar.TextLength != 14)
            {
                MessageBox.Show("ERROR: El numero de contrato no existe o no es válido");
            }
            else
            {
                BuscarContrato() ;
            }
            /*if(Contrato.contratos.Exists(i=> i.NumContrato == TxtNumero.Text) == false ||
                Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).EstaVig==false)
            {
                MessageBox.Show("Error el contrato no existe o no está vigente");
            }
            else
            {
                PanelResultados.Show();
                LblNumContrato.Text = Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).NumContrato;
                LblTitular.Text = Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).Titular;
                LblPoliza.Text = Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).Poliza.ToString();
                LblIniVig.Text=Contrato.contratos.Find(i => i.NumContrato == TxtNumero.Text).FechaInicioVig.Date.ToString();
            }*/
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            double recargo = 0;
            double primaanual = 0;
            double primamensual = 0;
            bool declarasalud = true;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            string observacion = "";


            
                recargo = Contrato.CalcularRecargoVida(LblTitularHogar.Text);
                //MessageBox.Show(recargo.ToString());
            


            if (recargo > 0 && ComboPlan.Text != "")
            {
                primaanual = Contrato.ObtenerPrimaBase(ComboPlan.Text) + recargo;
                primamensual = primaanual / 12;
                LblPrimaAnualHogar.Text = primaanual.ToString();
                LblPrimaMensualHogar.Text = primamensual.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un plan por favor");
            }

        
            if (RadioSiHogar.Checked == true)
            {
                declarasalud = true;
            }
            else
            {
                declarasalud = false;
            }
            if (TxtObservacionesHogar.Text == "")
            {
                MessageBox.Show("Ingrese una observación por favor");
            }
            else
            {
                observacion = TxtObservacionesHogar.Text;
            }

            if (recargo > 0 && ComboPlan.Text != "" && TxtObservacionesHogar.Text != "")
            {

                string resultado = Contrato.ModificarContrato(LblNumContratoHogar.Text, ComboPlan.Text, declarasalud, observacion);
                MessageBox.Show(resultado);
                TxtObservacionesHogar.Text = "";
                ComboPlan.SelectedItem = null;
                RadioSiHogar.Checked = true;
                PanelResultados.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelResultados.Hide();
        }

        private void VentanaModificarContrato_Load(object sender, EventArgs e)
        {

        }

        private void PanelResultados_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaBuscarContrato v = new VentanaBuscarContrato();
            v.ShowDialog();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaListadoContratos v = new VentanaListadoContratos();
            v.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}

