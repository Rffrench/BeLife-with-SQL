using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BeLife.Clases;

namespace BeLife
{
    class Contrato
    {
        private string numContrato;
        private DateTime fechaCreacion;
        private DateTime fechaTermino;
        private string titular;
        private string nomPlan;
        private int idTipoContrato;
        private DateTime fechaInicioVig;
        private DateTime fechaTerminoVig;
        private bool estaVig;
        private bool conDeclaracionDeSalud;
        private double primaAnual;
        private double primaMensual;
        private string observaciones;


        //getters y setters
        public string NumContrato
        {
            get { return this.numContrato; }
            set { this.numContrato = value; }
        }

        public DateTime FechaCreacion
        {
            get { return this.fechaCreacion; }
            set { this.fechaCreacion = value; }
        }

        public DateTime FechaTermino
        {
            get { return this.fechaTermino; }
            set { this.fechaTermino = value; }
        }

        public string Titular
        {
            get { return this.titular; }
            set { this.titular = value; }
        }

        public string NomPlan
        {
            get { return this.nomPlan; }
            set { this.nomPlan = value; }
        }

        public int IdTipoContrato
        {
            get { return this.idTipoContrato; }
            set { this.idTipoContrato = value; }
        }

        public DateTime FechaInicioVig
        {
            get { return this.fechaInicioVig; }
            set { this.fechaInicioVig = value; }
        }

        public DateTime FechaTerminoVig
        {
            get { return this.fechaTerminoVig; }
            set { this.fechaTerminoVig = value; }
        }

        public bool EstaVig
        {
            get { return this.estaVig; }
            set { this.estaVig = value; }
        }

        public bool ConDeclaracionDeSalud
        {
            get { return this.conDeclaracionDeSalud; }
            set { this.conDeclaracionDeSalud = value; }
        }

        public double PrimaAnual
        {
            get { return this.primaAnual; }
            set { this.primaAnual = value; }
        }

        public double PrimaMensual
        {
            get { return this.primaMensual; }
            set { this.primaMensual = value; }
        }

        public string Observaciones
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }





        public Contrato(string numContrato, DateTime fechaCreacion, DateTime fechaTermino, string titular,
                string nomPlan, int idTipoContrato, DateTime fechaInicioVig, DateTime fechaTerminoVig,
                bool EstaVig, bool conDeclaracionDeSalud, double primaAnual, double primaMensual, string observaciones)
        {
            this.numContrato = numContrato;
            this.fechaCreacion = fechaCreacion;
            this.fechaTermino = fechaTermino;
            this.titular = titular;
            this.nomPlan = nomPlan;
            this.idTipoContrato = idTipoContrato;
            this.fechaInicioVig = fechaInicioVig;
            this.fechaTerminoVig = fechaTerminoVig;
            this.EstaVig = EstaVig;
            this.conDeclaracionDeSalud = conDeclaracionDeSalud;
            this.primaAnual = primaAnual;
            this.primaMensual = primaMensual;
            this.observaciones = observaciones;
        }




        public static List<Contrato> contratos = new List<Contrato>();


        public string AgregarContrato(Contrato cont)
        {
            string resultado = "";
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "AgregarContrato";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParNumCont = new SqlParameter("@numContrato", SqlDbType.VarChar);
                ParNumCont.Value = cont.NumContrato;

                cmd.Parameters.Add(ParNumCont);


                SqlParameter ParFecCreacion = new SqlParameter("@fechaCreacion", SqlDbType.DateTime);
                ParFecCreacion.Value = cont.FechaCreacion;

                cmd.Parameters.Add(ParFecCreacion);


                SqlParameter ParFecTermino = new SqlParameter("@fechaTermino", SqlDbType.DateTime);
                ParFecTermino.Value = cont.FechaTermino;

                cmd.Parameters.Add(ParFecTermino);


                SqlParameter ParTitular = new SqlParameter("@RutCliente", SqlDbType.VarChar);
                ParTitular.Value = cont.Titular;

                cmd.Parameters.Add(ParTitular);


                SqlParameter ParPlan = new SqlParameter("@nomPlan", SqlDbType.VarChar);
                ParPlan.Value = cont.NomPlan;

                cmd.Parameters.Add(ParPlan);


                SqlParameter ParTipo = new SqlParameter("@idTipoContrato", SqlDbType.Int);
                ParTipo.Value = cont.IdTipoContrato;

                cmd.Parameters.Add(ParTipo);


                SqlParameter ParFecInicioVig = new SqlParameter("@fechaInicioVig", SqlDbType.DateTime);
                ParFecInicioVig.Value = cont.FechaInicioVig;

                cmd.Parameters.Add(ParFecInicioVig);


                SqlParameter ParFecTerminoVig = new SqlParameter("@fechaTerminoVig", SqlDbType.DateTime);
                ParFecTerminoVig.Value = cont.FechaTerminoVig;

                cmd.Parameters.Add(ParFecTerminoVig);


                SqlParameter ParEstaVig = new SqlParameter("@estaVig", SqlDbType.Bit);
                ParEstaVig.Value = cont.EstaVig;

                cmd.Parameters.Add(ParEstaVig);


                SqlParameter ParConDeclaracion = new SqlParameter("conDeclaracionDeSalud", SqlDbType.Bit);
                ParConDeclaracion.Value = cont.ConDeclaracionDeSalud;

                cmd.Parameters.Add(ParConDeclaracion);


                SqlParameter ParPrimaAnual = new SqlParameter("@primaAnual", SqlDbType.Decimal);
                ParPrimaAnual.Value = cont.PrimaAnual;

                cmd.Parameters.Add(ParPrimaAnual);


                SqlParameter ParPrimaMensual = new SqlParameter("@primaMensual", SqlDbType.Decimal);
                ParPrimaMensual.Value = cont.PrimaMensual;

                cmd.Parameters.Add(ParPrimaMensual);


                SqlParameter ParObservaciones = new SqlParameter("@observaciones", SqlDbType.VarChar);
                ParObservaciones.Value = cont.Observaciones;

                cmd.Parameters.Add(ParObservaciones);






                if (cmd.ExecuteNonQuery() == 1)
                {
                    resultado = "Contrato registrado con éxito";
                }





            }
            catch (Exception error)
            {
                //MessageBox.Show("Error: El número de contrato ingresado ya se encuentra registrado en la base de datos");
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public string AgregarContratoVehiculo(ContratoVehiculo cont)
        {
            string resultado = "";
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "AgregarContratoVehiculo";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParNumCont = new SqlParameter("@numContrato", SqlDbType.VarChar);
                ParNumCont.Value = cont.NumContrato;

                cmd.Parameters.Add(ParNumCont);


                SqlParameter ParPatente = new SqlParameter("@patente", SqlDbType.VarChar);
                ParPatente.Value = cont.Patente;

                cmd.Parameters.Add(ParPatente);


                if (cmd.ExecuteNonQuery() == 1)
                {
                    resultado = "Contrato de Vehículo registrado con éxito";
                }





            }
            catch (Exception error)
            {
                //MessageBox.Show("Error: El número de contrato de vehículo ingresado ya se encuentra registrado en la base de datos");
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public string AgregarContratoVivienda(ContratoVivienda cont)
        {
            string resultado = "";
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "AgregarContratoVivienda";
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParNumCont = new SqlParameter("@numContrato", SqlDbType.VarChar);
                ParNumCont.Value = cont.NumContrato;

                cmd.Parameters.Add(ParNumCont);


                SqlParameter ParCod = new SqlParameter("@codigoPostal", SqlDbType.VarChar);
                ParCod.Value = cont.CodigoPostal;

                cmd.Parameters.Add(ParCod);


                if (cmd.ExecuteNonQuery() == 1)
                {
                    resultado = "Contrato de Vivienda registrado con éxito";
                }





            }
            catch (Exception error)
            {
                //MessageBox.Show("Error: El número de contrato de vivienda ingresado ya se encuentra registrado en la base de datos");
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }



        public static double CalcularRecargoVida(string rut)
        {
            double recargo = 0.0;
            SqlConnection conexion = new SqlConnection(ConSql.conexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("CalcularRecargoVida", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRut = new SqlParameter("@rut", SqlDbType.VarChar);
                ParRut.Value = rut;
                cmd.Parameters.Add(ParRut);

                SqlParameter ParRecargo = new SqlParameter("@recargo", SqlDbType.Decimal);
                //ParRecargo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParRecargo).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();


                recargo = Convert.ToDouble(cmd.Parameters["@recargo"].Value);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }

            return recargo;


        }

        public static double CalcularRecargoVehiculos(string rut)
        {
            double recargo = 0.0;
            SqlConnection conexion = new SqlConnection(ConSql.conexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("CalcularRecargoVehiculos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRut = new SqlParameter("@rut", SqlDbType.VarChar);
                ParRut.Value = rut;
                cmd.Parameters.Add(ParRut);

                SqlParameter ParRecargo = new SqlParameter("@recargo", SqlDbType.Decimal);
                //ParRecargo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParRecargo).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();


                recargo = Convert.ToDouble(cmd.Parameters["@recargo"].Value);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }

            return recargo;


        }

        public static double CalcularRecargoViviendas(string rut)
        {
            double recargo = 0.0;
            SqlConnection conexion = new SqlConnection(ConSql.conexion);

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("CalcularRecargoViviendas", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRut = new SqlParameter("@rut", SqlDbType.VarChar);
                ParRut.Value = rut;
                cmd.Parameters.Add(ParRut);

                SqlParameter ParRecargo = new SqlParameter("@recargo", SqlDbType.Decimal);
                //ParRecargo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParRecargo).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                var prerecargo = cmd.Parameters["@recargo"].Value;
                if (prerecargo != DBNull.Value) @recargo = Convert.ToDouble(prerecargo);
                //recargo = Convert.ToDouble(cmd.Parameters["@recargo"].Value);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }

            return recargo;


        }



        public static double ObtenerPrimaBase(string nom)
        {
            double prima = 0;
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("ObtenerPrimaBase", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parnom = new SqlParameter("@nombre", SqlDbType.VarChar);
                parnom.Value = nom;
                //parnom.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(parnom);

                SqlParameter parprima = new SqlParameter("@prima", SqlDbType.Decimal);
                //parnom.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parprima).Direction = ParameterDirection.Output;


                cmd.ExecuteNonQuery();

                prima = Convert.ToDouble(cmd.Parameters["@prima"].Value);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }

            return prima;

        }

        public static string TerminarContrato(string num)
        {
            string resultadoterminar = "";
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "TerminarContrato";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNum = new SqlParameter();
                ParNum.ParameterName = "@numContrato";
                ParNum.SqlDbType = SqlDbType.VarChar;
                ParNum.Value = num;
                comando.Parameters.Add(ParNum);




                resultadoterminar = (comando.ExecuteNonQuery() == 1) ? "El contrato ha sido terminado" : "No existe ningún contrato con el número ingresado." +
                    " Por favor compruebe que está bien digitado";



            }
            catch (Exception error)
            {
                resultadoterminar = error.Message;
            }
            finally
            {
                conexion.Close();
            }

            return resultadoterminar;

        }

        public static string ModificarContrato(string num, string plan, bool declaracion, string observaciones)
        {
            string resultado = "";
            SqlConnection conexion = new SqlConnection(ConSql.conexion);

            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ModificarContrato", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNum = new SqlParameter();
                ParNum.ParameterName = "@numContrato";
                ParNum.SqlDbType = SqlDbType.VarChar;
                ParNum.Value = num;
                cmd.Parameters.Add(ParNum);

                SqlParameter ParPlan = new SqlParameter("@plan", SqlDbType.VarChar);
                ParPlan.Value = plan;
                cmd.Parameters.Add(ParPlan);

                SqlParameter ParDeclaracion = new SqlParameter("@declaracion", SqlDbType.Bit);
                ParDeclaracion.Value = declaracion;
                cmd.Parameters.Add(ParDeclaracion);

                SqlParameter ParObservaciones = new SqlParameter("@observaciones", SqlDbType.VarChar);
                ParObservaciones.Value = observaciones;
                cmd.Parameters.Add(ParObservaciones);


                if (cmd.ExecuteNonQuery() == 1)
                {
                    resultado = "El contrato ha sido modificado con éxito";
                }
                else
                {
                    resultado = "error";
                }

            }
            catch (Exception error)
            {
                resultado = error.Message;
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }

    }
}
/***
 *      ######   ##########    # #                              #####     #               #        ######### 
 *                        #    # #     ########## #########    #     #    #    ########## #   ###          # 
 *    ##########         #     # #             #  #       #    #     #    ##           #  ####             # 
 *         #     ########      # #   #        #   #       #     #####     # #         #   #        ########  
 *         #         ##       #  #  #      # #    #       #    #     #    #  #     # #    #               #  
 *        #        ##        #   # #        #     #########    #     #    #         #     #               #  
 *      ##       ##         #    ##          #                  #####     #          #     ####### ########  
 *           ｌ ｏ ｓ　 ｓ ｕ ｐ ｅ ｒ　 ８　 ｔ ｅ ａ ｍ　 だ佳ツが                                                                                                 
 */
