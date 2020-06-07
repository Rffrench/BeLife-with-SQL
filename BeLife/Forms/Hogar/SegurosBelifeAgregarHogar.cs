﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using BeLife.Clases;

namespace BeLife
{
    public partial class SegurosBelifeCrearHogar : Form
    {
        public SegurosBelifeCrearHogar()
        {
            InitializeComponent();
            ComboTitular.Items.Clear();
            ComboPlan.Items.Clear();
            ComboCod.Items.Clear();

            ComboPlanFill();
            ComboTitularFill();
            ComboCodigoFill();


            RadioSi.Checked = true;
        }

        public void ValidarEspaciosHogar()
        {

        }

        public void ComboTitularFill()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {


                conexion.Open();

                SqlCommand cmd = new SqlCommand("ComboTitularFill", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                DataTable dt = new DataTable();
                dt.Columns.Add("Titular", typeof(string));

                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = reader.GetString(reader.GetOrdinal("RutCliente"));
                    dt.Rows.Add(dr);
                }
                reader.Close();

                ComboTitular.DataSource = dt;
                ComboTitular.DisplayMember = "titular";
                ComboTitular.ValueMember = "titular";

                conexion.Close();




            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


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

        public void ComboCodigoFill()
        {
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {


                conexion.Open();

                SqlCommand cmd = new SqlCommand("ComboCodigoFill", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                DataTable dt = new DataTable();
                dt.Columns.Add("codigoPostal", typeof(string));

                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = reader.GetInt32(reader.GetOrdinal("codigoPostal"));
                    dt.Rows.Add(dr);
                }
                reader.Close();

                ComboCod.DataSource = dt;
                ComboCod.DisplayMember = "codigoPostal";
                ComboCod.ValueMember = "codigoPostal";

                conexion.Close();




            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }



        private bool ValidaInicio(DateTime d)
        {
            DateTime hoy = DateTime.Today;
            DateTime maxmes; //var para sacar la condicion de la fecha de inicio que sea max 1 mes dsps de la actual
            if (DateTime.Now.Year == 12)//si es el mes 12 le sumo 1 año y el mes que sea el 1, sino quedaria como 13
            {
                maxmes = new DateTime(DateTime.Now.Year + 1, 1, DateTime.Now.Day);
            }
            else //si no, basta con sumarle un mes
            {
                maxmes = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
            }

            if (DateTime.Compare(hoy, d) <= 0 && DateTime.Compare(d, maxmes) <= 0)
            {//aquí comparo las fechas con el método compare, diciendo que la fecha de inicio de vigencia
                //debe ser mayor o igual a la de hoy y menor a 1 mes desde hoy.
                return true;
            }
            else
            {
                return false;
            }

        }
        public string getMes()
        {
            string x;
            if (DateTime.Now.Month < 10)
            {
                x = "0" + DateTime.Now.Month;
            }
            else
            {
                x = DateTime.Now.Month.ToString();
            }
            return x;
        }

        public string getDia()
        {
            string x;
            if (DateTime.Now.Day < 10)
            {
                x = "0" + DateTime.Now.Day;
            }
            else
            {
                x = DateTime.Now.Day.ToString();
            }
            return x;
        }

        public string getHora()
        {
            string x;
            if (DateTime.Now.Hour < 10)
            {
                x = "0" + DateTime.Now.Hour;
            }
            else
            {
                x = DateTime.Now.Hour.ToString();
            }
            return x;
        }
        public string getMin()
        {
            string x;
            if (DateTime.Now.Minute < 10)
            {
                x = "0" + DateTime.Now.Minute;
            }
            else
            {
                x = DateTime.Now.Minute.ToString();
            }
            return x;
        }

        public string getSeg()
        {
            string x;
            if (DateTime.Now.Second < 10)
            {
                x = "0" + DateTime.Now.Second;
            }
            else
            {
                x = DateTime.Now.Second.ToString();
            }
            return x;
        }
        private bool ValidaTitular()
        {

            if (ComboTitular.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int CalcularEdad(DateTime f, DateTime Fecha)
        {
            int years = DateTime.Now.Year - Fecha.Date.Year;
            if (Fecha.Month > DateTime.Now.Month)
            {
                years--;
            }
            if (Fecha.Month == DateTime.Now.Month && Fecha.Day > DateTime.Now.Day)
            {
                years--;
            }
            return years;
        }

        



        private void btnTerminarHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarHogar v = new EliminarHogar();
            v.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaMain v = new VentanaMain();
            v.ShowDialog();
        }

        private void btnBuscarHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuscarHogar v = new BuscarHogar();
            v.ShowDialog();
        }

        private void btnModificarHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarHogar v = new ModificarHogar();
            v.ShowDialog();
        }

        private void btnListadoHogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarHogar v = new ListarHogar();
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainHogar v = new MainHogar();
            v.ShowDialog();
        }

        private void SegurosBelifeCrearHogar_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearHogar_Click(object sender, EventArgs e)
        {
            DateTime inivig = DateTime.Today;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            DateTime finvig = DateTime.Today;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            string numcontrato = DateTime.Now.Year.ToString() + getMes() + getDia() + getHora() + getMin() + getSeg();
            /*NUMCONTRATO obtenido con métodos que capturan partes de la fecha x separado y le agregan un 0 dependiendo
            else valor de estas partes*/
            DateTime feccreacion = DateTime.Now;
            DateTime fectermino = DateTime.Today;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            bool estavig = true;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            //double recargo = CalculaRecargoEdad() + CalculaRecargoSexo() + CalculaRecargoEstado();
            double recargo = 0;
            double primaanual = 0;
            double primamensual = 0;
            bool declarasalud = true;//se le parte asignanado esto pq no acepta nulos, sería cm un null
            string observacion = "";
            int poliza;

            if (ComboTitular.Text != "")
            {
                recargo = Contrato.CalcularRecargoViviendas(ComboTitular.Text);
                //MessageBox.Show(recargo.ToString());
            }


            if (recargo > 0 && ComboPlan.Text != "")
            {
                //MessageBox.Show(Contrato.ObtenerPrimaBase(ComboPlan.Text).ToString());
                //primaanual = Plan.planes.Find(i => i.Nombre == ComboPlan.Text).PrimaBase + recargo;//cambiar esto por porc pa la prima del plan y combo pal plan
                primaanual = Contrato.ObtenerPrimaBase(ComboPlan.Text) + recargo;
                primamensual = primaanual / 12;
                LblPrimaAnual.Text = primaanual.ToString();
                LblPrimaMensual.Text = primamensual.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un plan por favor");
            }
            if (ValidaInicio(FecIniVig.Value.Date))
            {

                inivig = FecIniVig.Value.Date;
                finvig = new DateTime(FecIniVig.Value.Year + 1, FecIniVig.Value.Month, FecIniVig.Value.Day);
                fectermino = finvig;
                LblNumContrato.Text = numcontrato;

            }
            else
            {


                MessageBox.Show("Fecha de inicio de vigencia INCORRECTA");
            }
            if (RadioSi.Checked == true)
            {
                declarasalud = true;
            }
            else
            {
                declarasalud = false;
            }
            if (TxtObservaciones.Text == "")
            {
                MessageBox.Show("Ingrese una observación por favor");
            }
            else
            {
                observacion = TxtObservaciones.Text;
            }


            if ((recargo > 0 && ComboPlan.Text != "" && ValidaInicio(FecIniVig.Value.Date)) && TxtObservaciones.Text != "")
            {

                try
                {
                    MessageBox.Show(ComboPlan.Text);
                    Contrato con = new Contrato(numcontrato, feccreacion, fectermino, ComboTitular.Text, ComboPlan.Text,
                    SegurosBelifeAgregarContratos.tipocont, inivig, finvig, estavig, declarasalud, 12.5, 3.5, observacion);
                    ContratoVivienda conviv = new ContratoVivienda(numcontrato, Convert.ToInt32(ComboCod.Text));
                    string resultado = con.AgregarContrato(con);
                    //MessageBox.Show(resultado);
                    string resultado2 = con.AgregarContratoVivienda(conviv);
                    //MessageBox.Show(resultado2);
                    //no olvisdar cambiaR EL TIPO DE COPNTRATO EN EL CONSTR

                }
                catch (Exception error)
                {
                    MessageBox.Show("El contrato ya existe");
                }


            }
        }
        

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
