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
    public partial class VentanaListadoContratos : Form
    {
        public VentanaListadoContratos()
        {
            InitializeComponent();
            LlenarListadoContratos();

            if (Plan.planes.Count < 3)
            {
                Plan.planes.Add(new Plan(1, "Plan 1", 15, 10)); //precios en UF
                Plan.planes.Add(new Plan(2, "Plan 2", 21, 20));
                Plan.planes.Add(new Plan(3, "Plan 3", 28, 30));
            }

            ComboPoliza.Items.Clear();
                foreach (Plan p in Plan.planes)
            {

                ComboPoliza.Items.Add(p.PolizaActual);
            }
            
            

        }

        public void LlenarListadoContratos()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ListadoContratos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGrid.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void LlenarListadoContratosNro()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ListadoContratosFiltroNro", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNro = new SqlParameter("@nroContrato", SqlDbType.VarChar);
                ParNro.Value = TxtNro.Text;
                cmd.Parameters.Add(ParNro);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGrid.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }



        public void LlenarListadoContratosRut()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ListadoContratosFiltroRut", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRut = new SqlParameter("@rut", SqlDbType.VarChar);
                ParRut.Value = TxtRut.Text;
                cmd.Parameters.Add(ParRut);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGrid.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void LlenarListadoContratosPoliza()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ListadoContratosFiltroPoliza", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPoliza = new SqlParameter("@poliza", SqlDbType.Int);
                ParPoliza.Value = ComboPoliza.Text;
                cmd.Parameters.Add(ParPoliza);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGrid.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }




        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnFiltrarNumero_Click(object sender, EventArgs e)
        {
            if(TxtNro.TextLength!= 14)
            {
                MessageBox.Show("ERROR: El numero de contrato no existe o no es válido");
            }
            else
            {
                LlenarListadoContratosNro();
            }
            
            /*if (ComboNumero.SelectedItem == null)
            {
                MessageBox.Show("Error debe seleccionar un numero de contrato");
            }
            else
            {
                                
            }*/
        }

        private void BtnFiltrarRut_Click(object sender, EventArgs e)
        {

            if (TxtRut.TextLength < 8 || TxtRut.TextLength > 10)
            {
                MessageBox.Show("La longitud del rut ingresado es incorrecta. Por favor verifique que el rut tiene entre 8 y 10 dígitos ");
            }
            else
            {
                LlenarListadoContratosRut();
            }
        }

        private void BtnFiltrarPoliza_Click(object sender, EventArgs e)
        {
            if (ComboPoliza.Text != "")
            {
                LlenarListadoContratosPoliza();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una póliza para continuar");
            }
            

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void VentanaListadoContratos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaBuscarContrato v = new VentanaBuscarContrato();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaModificarContrato v = new VentanaModificarContrato();
            v.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
