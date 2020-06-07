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
    public partial class SegurosBeLifeRegistrarVivienda : Form
    {
        public SegurosBeLifeRegistrarVivienda()
        {
            InitializeComponent();
            ComboRegionFill();
        }

        public void ComboRegionFill()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ComboRegionFill", conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                DataTable dt = new DataTable();
                dt.Columns.Add("NombreRegion", typeof(string));

                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = reader.GetString(reader.GetOrdinal("NombreRegion"));
                    dt.Rows.Add(dr);
                }
                reader.Close();

                ComboRegion.DataSource = dt;
                ComboRegion.DisplayMember = "NombreRegion";
                ComboRegion.ValueMember = "NombreRegion";

                conexion.Close();




            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        public void ComboComunaFill()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ComboComunaFill", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parreg = new SqlParameter("@NombreRegion", SqlDbType.VarChar);
                parreg.Value = ComboRegion.Text;
                cmd.Parameters.Add(parreg);


                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                DataTable dt = new DataTable();
                dt.Columns.Add("NombreComuna", typeof(string));

                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = reader.GetString(reader.GetOrdinal("NombreComuna"));
                    dt.Rows.Add(dr);
                }
                reader.Close();

                ComboComuna.DataSource = dt;
                ComboComuna.DisplayMember = "NombreComuna";
                ComboComuna.ValueMember = "NombreComuna";

                conexion.Close();




            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }





        private void SegurosBeLifeRegistrarVivienda_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainHogar x = new MainHogar();
            x.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SegurosBeLifeSeleccionarRegistrar x = new SegurosBeLifeSeleccionarRegistrar();
            x.ShowDialog();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConSql.conexion);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AgregarVivienda", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parcod = new SqlParameter("@codigoPostal", SqlDbType.Int);
                parcod.Value = TxtCodigo.Text;
                cmd.Parameters.Add(parcod);

                SqlParameter paranho= new SqlParameter("@anho", SqlDbType.Int);
                paranho.Value = TxtAnho.Text;
                cmd.Parameters.Add(paranho);

                SqlParameter pardir = new SqlParameter("@direccion", SqlDbType.VarChar);
                pardir.Value = TxtDireccion.Text;
                cmd.Parameters.Add(pardir);

                SqlParameter parvinm = new SqlParameter("@valorInmueble", SqlDbType.Float);
                parvinm.Value = TxtValInm.Text;
                cmd.Parameters.Add(parvinm);

                SqlParameter parvcont = new SqlParameter("@valorContenido", SqlDbType.Float);
                parvcont.Value = TxtValCont.Text;
                cmd.Parameters.Add(parvcont);

                SqlParameter parreg = new SqlParameter("@nomRegion", SqlDbType.VarChar);
                parreg.Value = ComboRegion.Text;
                cmd.Parameters.Add(parreg);

                SqlParameter parcom = new SqlParameter("@nomComuna", SqlDbType.VarChar);
                parcom.Value = ComboComuna.Text;
                cmd.Parameters.Add(parcom);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Vivienda Registrada");
                }


            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ComboRegion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void ComboRegion_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void ComboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboComunaFill();
        }
    }

}
