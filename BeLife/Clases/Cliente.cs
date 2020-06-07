using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeLife
{
    class Cliente
    {
        private string nombre;
        private string apellidos;
        private string rut;
        private DateTime fechaNacimiento;
        private byte idSexo; // 1= Masculino     2= Femenino
        private byte idEcivil;//1= Soltero 2=Casado 3=Divorciado 4= Viudo


        //getters y setters
        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        public string Apellidos
        {
            get { return this.apellidos; }
            set { this.apellidos = value; }
        }

        public string Rut
        {
            get { return this.rut; }
            set { this.rut = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        public byte IdSexo
        {
            get { return this.idSexo; }
            set { this.idSexo = value; }
        }

        public byte IdEcivil
        {
            get { return this.idEcivil; }
            set { this.idEcivil = value; }
        }



        public static List<Cliente> clientes = new List<Cliente>();




        public Cliente(string rut, string nombre, string apellidos, DateTime fechaNacimiento, byte idSexo, byte idEcivil)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.idSexo = idSexo;
            this.idEcivil = idEcivil;
        }

        public string AgregarCliente(Cliente cl)
        {
            /*Para comprobar si existe o no tengo que hacer el CRUD (CreateRetrieveUpdateDelete)
             * si existe un rut q es llave primaria me va tirar una excepcion esto, en ese caso la tengo que capturar
             * y con eso puedo hacer varias cosas. 
             * También puedo llamar a un procedimiento dentro de un package usando el nomnbre del package '.' nom procedimiento
             y en el package meto todos los procedimientos CRUD*/
            string resultado = "";
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {

                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();
                MessageBox.Show("connected");

                // Estableciendo el comando
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "AgregarCliente";
                comando.CommandType = CommandType.StoredProcedure;

                //parametros para el procedimiento
                //rut
                SqlParameter ParRut = new SqlParameter();
                ParRut.ParameterName = "@rut";
                ParRut.SqlDbType = SqlDbType.VarChar;
                //ParRut.Size = 10;
                ParRut.Value = cl.Rut;

                comando.Parameters.Add(ParRut);

                //nombre
                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@nombre";
                ParNombres.SqlDbType = SqlDbType.VarChar;
                //ParNombres.Size = 20;
                ParNombres.Value = cl.Nombre;

                comando.Parameters.Add(ParNombres);


                //apellidos
                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                //ParApellidos.Size = 20;
                ParApellidos.Value = cl.Apellidos;

                comando.Parameters.Add(ParApellidos);


                //fecha de nacimiento
                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fechaNacimiento";
                ParFecha.SqlDbType = SqlDbType.DateTime;
                ParFecha.Value = cl.FechaNacimiento;

                comando.Parameters.Add(ParFecha);


                //id sexo
                SqlParameter ParIdSexo = new SqlParameter();
                ParIdSexo.ParameterName = "@idSexo";
                ParIdSexo.SqlDbType = SqlDbType.TinyInt;
                ParIdSexo.Value = cl.IdSexo;

                comando.Parameters.Add(ParIdSexo);


                //id estado civil
                SqlParameter ParIdEcivil = new SqlParameter();
                ParIdEcivil.ParameterName = "@idEcivil";
                ParIdEcivil.SqlDbType = SqlDbType.TinyInt;
                ParIdEcivil.Value = cl.IdEcivil;

                comando.Parameters.Add(ParIdEcivil);


                //ejecutar la query o procedimiento
                if (comando.ExecuteNonQuery() == 1)
                {
                    resultado = "El cliente fue registrado exitosamente en la base de datos";
                }
                //resultado = comando.ExecuteNonQuery().ToString();


            }
            catch (Exception error)
            {

                resultado = "ERROR: El rut ingresado ya se encuentra registrado en la base de datos. Por favor intente" +
                    " ingresando otro rut.";
                //resultado = error.Message;

            }
            finally
            {
                conexion.Close();
            }

            return resultado;

        }

        public string ModificarCliente(Cliente cl)
        {
            string resultado = "";
            SqlConnection conexion = new SqlConnection(ConSql.conexion);

            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("ModificarCliente", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRut = new SqlParameter("@rut", SqlDbType.VarChar);
                ParRut.Value = cl.Rut;
                cmd.Parameters.Add(ParRut);

                SqlParameter ParNombres = new SqlParameter("@nombres", SqlDbType.VarChar);
                ParNombres.Value = cl.Nombre;
                cmd.Parameters.Add(ParNombres);

                SqlParameter ParApellidos = new SqlParameter("@apellidos", SqlDbType.VarChar);
                ParApellidos.Value = cl.Apellidos;
                cmd.Parameters.Add(ParApellidos);

                SqlParameter ParFecha = new SqlParameter("@fechaNacimiento", SqlDbType.DateTime);
                ParFecha.Value = cl.FechaNacimiento;
                cmd.Parameters.Add(ParFecha);

                SqlParameter ParIdSexo = new SqlParameter("@idSexo", SqlDbType.TinyInt);
                ParIdSexo.Value = cl.IdSexo;
                cmd.Parameters.Add(ParIdSexo);

                SqlParameter ParIdEcivil = new SqlParameter("@idEstadoCivil", SqlDbType.TinyInt);
                ParIdEcivil.Value = cl.IdEcivil;
                cmd.Parameters.Add(ParIdEcivil);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    resultado = "El cliente ha sido modificado con éxito";
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

        public static string EliminarCliente(string rut)
        {
            string resultadoeliminar = "";
            SqlConnection conexion = new SqlConnection(ConSql.conexion);
            try
            {
                
                //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BeLife;Integrated Security=True"); duoc
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "EliminarCliente";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRut = new SqlParameter();
                ParRut.ParameterName = "@rut";
                ParRut.SqlDbType = SqlDbType.VarChar;
                ParRut.Value = rut;
                comando.Parameters.Add(ParRut);

                


                resultadoeliminar = (comando.ExecuteNonQuery() == 1) ? "El cliente ha sido eliminado" : "No existe ningún cliente con el rut ingresado." +
                    " Por favor compruebe que está bien digitado";

                

            }
            catch (Exception error)
            {
                resultadoeliminar = error.Message;
            }
            finally
            {
             conexion.Close();
            }
            
            return resultadoeliminar;

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
