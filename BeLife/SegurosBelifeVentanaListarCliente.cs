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
    public partial class SegurosBelifeVentanaListarCliente : Form
    {
        public SegurosBelifeVentanaListarCliente()
        {
            InitializeComponent();
           // LlenarListadoClientes();

            List<string> sexos = new List<string>() { "Masculino", "Femenino" };
            List<string> estados = new List<string>() { "Soltero", "Casado", "Divorciado", "Viudo" };
            //Lista.Items.Clear();
            ComboSexo.Items.Clear();
            ComboEstados.Items.Clear();

            //Lista.DataSource = Cliente.clientes;
            /*foreach (Cliente c in Cliente.clientes)
            {
                Lista.Items.Add(c);
            }
            Lista.DisplayMember = "Rut";
            Lista.ValueMember = "Rut";*/

            foreach (string s in sexos)//agregando sexos a combo box para filtrar
            {

                ComboSexo.Items.Add(s);

                /* string y = Lista.GetItemText(Lista.TopIndex+1);
                 Lista.Items.Add(Cliente.clientes.Find(i => i.Rut != y).Rut);*/
            }

            foreach (string e in estados)//agregando estados civiles a combobox para filtrar
            {
                ComboEstados.Items.Add(e);

            }
        }

        public void LlenarListadoClientes()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ListadoClientes", conexion);
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

        public void LlenarListadoClientesSexo()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            byte sex = 0;
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ListadoClientesFiltroSexo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParSexo = new SqlParameter("@idSexo", SqlDbType.TinyInt);
                if (ComboSexo.Text=="Masculino")
                {
                    sex = 1;
                }
                else
                {
                    sex = 2;
                }
                ParSexo.Value = sex;
                cmd.Parameters.Add(ParSexo);

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

        public void LlenarListadoClientesEstados()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            byte ecivil = 0;
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ListadoClientesFiltroEstados", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEstado = new SqlParameter("@idEstadoCivil",SqlDbType.TinyInt);
                if (ComboEstados.Text=="Soltero")
                {
                    ecivil = 1;
                }
                else if (ComboEstados.Text == "Casado")
                {
                    ecivil = 2;
                }
                else if (ComboEstados.Text == "Divorciado")
                {
                    ecivil = 3;
                }
                else
                {
                    ecivil = 4;
                }
                ParEstado.Value = ecivil;
                cmd.Parameters.Add(ParEstado);

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


        private void button3_Click(object sender, EventArgs e)
        {
                    }

        private void VentanaListarCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            VentanaBuscarCliente v = new VentanaBuscarCliente();
            this.Hide();
            v.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            VentanaMain Ventana2 = new VentanaMain();
            this.Hide();

            Ventana2.ShowDialog();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            VentanaAgregarCliente Ventana2 = new VentanaAgregarCliente();
            this.Hide();

            Ventana2.ShowDialog();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaModificarCliente v = new VentanaModificarCliente();
            v.ShowDialog();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaEliminarCliente v = new VentanaEliminarCliente();
            v.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaClientes Ventana2 = new VentanaClientes();
            this.Hide();

            Ventana2.ShowDialog();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            LlenarListadoClientes();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LlenarListadoClientesSexo();
        }

        private void BtnEstados_Click(object sender, EventArgs e)
        {
            LlenarListadoClientesEstados();
        }

        private void ComboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
