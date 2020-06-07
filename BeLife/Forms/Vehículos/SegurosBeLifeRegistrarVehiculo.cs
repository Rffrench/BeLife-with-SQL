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
using BeLife.Clases;

namespace BeLife
{
    public partial class SegurosBeLifeRegistrarVehiculo : Form
    {
        public SegurosBeLifeRegistrarVehiculo()
        {
            InitializeComponent();
            ComboMarcasFill();
            //ComboModelosFill();
        }

        private void SegurosBeLifeRegistrarVehiculo_Load(object sender, EventArgs e)
        {

        }

        /*public void ValidarEspaciosAuto()
        {

            if (TxtMarcaAuto.Text.Length < 1)
            {
                errorMarca.SetError(TxtMarcaAuto, "El nombre no puede quedar en blanco");
                TxtMarcaAuto.Focus();
                return;
            }
            errorMarca.SetError(TxtMarcaAuto, "");
            Regex F1marca = new Regex("^[A-Z]{2,4}[0-9]{2,4}$");


            if (!F1marca.IsMatch(TxtMarcaAuto.Text))
            {
                errorMarca.SetError(TxtMarcaAuto, "La pantente debe tener un total de 6 carácteres alfanuméricos");
                TxtMarcaAuto.Focus();
                return;
            }
            errorMarca.SetError(TxtMarcaAuto, "");


        }*/


        public void ComboMarcasFill()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ComboMarcasFill", conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                DataTable dt = new DataTable();
                dt.Columns.Add("Descripcion", typeof(string));

                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = reader.GetString(reader.GetOrdinal("Descripcion"));
                    dt.Rows.Add(dr);
                }
                reader.Close();

                ComboMarca.DataSource = dt;
                ComboMarca.DisplayMember = "Descripcion";
                ComboMarca.ValueMember = "Descripcion";

                conexion.Close();




            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }


        public void ComboModelosFill()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ComboModelosFill", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parmarca = new SqlParameter("@nomMarca", SqlDbType.VarChar);
                parmarca.Value = ComboMarca.Text;
                cmd.Parameters.Add(parmarca);

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                DataTable dt = new DataTable();
                dt.Columns.Add("Descripcion", typeof(string));

                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = reader.GetString(reader.GetOrdinal("Descripcion"));
                    dt.Rows.Add(dr);
                }
                reader.Close();

                ComboModelo.DataSource = dt;
                ComboModelo.DisplayMember = "Descripcion";
                ComboModelo.ValueMember = "Descripcion";

                conexion.Close();




            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain x = new VentanaMain();
            x.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBeLifeSeleccionarRegistrar x = new SegurosBeLifeSeleccionarRegistrar();
            x.ShowDialog();
        }

        private void btnCrearHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAutos x = new MainAutos();
            x.ShowDialog();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConSql.conexion);
            string resultado = "";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AgregarVehiculo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parpatente = new SqlParameter("@patente", SqlDbType.VarChar);
                parpatente.Value = TxtPatente.Text;
                cmd.Parameters.Add(parpatente);

                SqlParameter parmarca = new SqlParameter("@nomMarca", SqlDbType.VarChar);
                parmarca.Value = ComboMarca.Text;
                cmd.Parameters.Add(parmarca);

                SqlParameter parmodelo = new SqlParameter("@nomModelo", SqlDbType.VarChar);
                parmodelo.Value = ComboModelo.Text;
                cmd.Parameters.Add(parmodelo);

                SqlParameter paranho = new SqlParameter("@anho", SqlDbType.Int);
                paranho.Value = TxtAnho.Text;
                cmd.Parameters.Add(paranho);




                if (cmd.ExecuteNonQuery() == 1)
                {
                    resultado = "Vehículo registrado con éxito";
                }
                MessageBox.Show(resultado);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.Close();






            }
        }

        private void ComboMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void ComboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void ComboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboModelosFill();
        }
    }
}
