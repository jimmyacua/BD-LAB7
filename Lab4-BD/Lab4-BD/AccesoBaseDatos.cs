using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;
// Namespace de acceso a base de datos
using System.Data;
using System.Data.SqlClient;

/*Cambiar el namespace para que funcione!!*/
namespace Lab_Interfaces
{
    class AccesoBaseDatos
    {
        /*En Initial Catalog se agrega la base de datos propia. Intregated Security es para utilizar Windows Authentication*/
        //String conexion = "Data Source=10.1.4.55; Initial Catalog= DB_B50060; Integrated Security=SSPI";

        /*En Initial Catalog se agrega la base de datos propia. Intregated Security = false es para utilizar SQL SERVER Authentication*/
        String conexion = "Data Source=10.1.4.55;User ID= B50060;Password= Saprissa.14; Initial Catalog=DB_B50060; Integrated Security=false";

        /**
         * Constructor de la clase
         */
        public AccesoBaseDatos() {
        }

        /// <summary>
        /// Permite ejecutar una consulta SQL, los datos son devueltos en un SqlDataReader
        /// </summary>
        /// <param name="consulta">Sentencia SQL por ejecutar</param>
        /// <returns>El datareader con los resultados de la ejecución de la consulta</returns>
        public SqlDataReader EjecutarConsulta(String consulta)
        {
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlDataReader datos = null;
            SqlCommand comando = null;

            try
            {
                //Ejecuta la consulta sql recibida por parámetro y la carga en un datareader
                comando = new SqlCommand(consulta, sqlConnection);
                datos = comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex);
            }
            return datos;
        }

        /// <summary>
        /// Permite ejecutar una consulta SQL, los datos son devueltos en un DataTable
        /// </summary>
        /// <param name="consulta">Sentencia SQL por ejecutar</param>
        /// <returns>El datatable con los resultados de la ejecución de la consulta</returns>
        public DataTable EjecutarConsultaTabla(String consulta)
        {
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand comando = new SqlCommand(consulta, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Método para ejecutar un insert, update o delete
        /// </summary>
        /// <param name="consulta">Sentencia SQL por ejecutar</param>
        /// <returns>El tipo de error que generó la consulta o cero si la ejecución fue exitosa</returns>
        public int ActualizarDatos(String consulta)
        {
            int error = 0;

            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand cons = new SqlCommand(consulta, sqlConnection);

            try
            {
                //Ejecuta la consulta sql recibida por parámetro
                cons.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                error = e.Number;
                Debug.WriteLine("Error: " + error);
            }

            finally
            {
                sqlConnection.Close();
            }

            return error;
        }

        /// <summary>
        /// Método para llamar al procedimiento almacenado de eliminarEstudiante 
        /// </summary>
        /// <param name="nombre">Nombre del estudiante por eliminar</param>
        /// <returns>El tipo de error que generó la consulta o cero si la ejecución fue exitosa</returns>
        public int EliminarEstudiante(string nombre)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("eliminarEstudiante", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;

                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return error;
                    }
                    catch (SqlException ex)
                    {

                        error = ex.Number;
                        return error;
                    }
                }
            }

        }

        /// <summary>
        /// Método para llamar al procedimiento almacenado que permite agregar un nuevo usuario 
        /// </summary>
        /// <param name="usuario">Nombre del usuario</param>
        /// <param name="password">Contraseña del usuario</param>
        /// <param name="cedula">Cédula del estuidnate asociado al usuario</param>
        /// <returns>1 si se pudo guardar el nuevo usuario, un número diferente a cero que corresponde al número de error
        /// si no se pudo insertar</returns>
        public int AgregarUsuario(string usuario, string password, string cedula)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("agregarUsuario", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@pLogin", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@pPassword", SqlDbType.VarChar).Value = password;
                        cmd.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@estado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        return Convert.ToInt32(cmd.Parameters["@estado"].Value);

                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }

        }

        /// <summary>
        /// Método para llamar al procedimiento almacenado para comprobar que un usuario está en la base de datos
        /// </summary>
        /// <param name="usuario">Nombre del usuario</param>
        /// <param name="password">Contraseña del usuario</param>
        /// <returns>true si está en la base de datos, false si no</returns>
        public bool Login(string usuario, string password)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("Login", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@pLoginName", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@pPassword", SqlDbType.VarChar).Value = password;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@isInDB", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        int value = Convert.ToInt32(cmd.Parameters["@isInDB"].Value);

                        /*Si el procedimiento devuelve 1 es que si se encuentra en la BD*/
                        if (value == 1)
                        {
                            return true;
                        }

                        /*Si devuelve 0 es que no se encuentra en la BD*/
                        else
                        {
                            return false;
                        }

                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }
                }
            }

        }

        ///<summary>
        ///​ Método para llamar al procedimiento almacenado para comprobar que un
        ///usuario está en la base de datos
        ///​​</summary>
        ///​​<param name = "usuario" > Nombre del usuario</param>
        ///<param name = "password" >​ Contraseña del usuario</param>
        ///<returns>true si está en la base de datos, false si no​</returns>
        //public bool LoginFuncion(string usuario, string password){​
        public bool LoginFuction(string usuario, string password) {
            using (SqlConnection con = new SqlConnection(conexion)){
                /* El sqlCommand recibe como primer parametro el nombre del procedimiento almacenado,
                 * de segundo parametro recibe del sqlConnection
                 */
                using (SqlCommand cmd = new SqlCommand("SELECT dbo.loginUsuario(@pLoginName, @pPassword)", con)) {
                    try { 
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        SqlParameter loginName = new SqlParameter("@pLoginName", SqlDbType.VarChar);
                        loginName.Value = usuario;
                        loginName.Direction = ParameterDirection.Input;
                        SqlParameter userPassword = new SqlParameter("@pPassword", SqlDbType.VarChar);
                        userPassword.Value = password;
                        userPassword.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(loginName);
                        cmd.Parameters.Add(userPassword);
                        /*Se abre la conexión*/
                        con.Open();
                    //Se ejecuta el procedimiento almacenado​
                    return (bool)cmd.ExecuteScalar();
                    } catch (SqlException ex) {
                        return false;
                    }
                }
            }
        }


        /// <summary>
        /// Llama a la función almacenada para filtrar la tabla Estudiante por nombre.
        /// </summary>
        /// <param name="nombre">Nombre por filtrar</param>
        /// <returns>El datatable con los resultados de la ejecución de la consulta</returns>
        public DataTable FiltrarPorNombre(String nombre, String filtroTexto)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del
                procedimiento almacenado,
                * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("SELECT * from dbo.filtrarEstudiantes(@nombre, @filtroTexto)", con))
                {
                    try
                    {
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        SqlParameter paramNombre = new SqlParameter("@nombre", SqlDbType.VarChar);
                        paramNombre.Value = nombre;
                        paramNombre.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(paramNombre);
                        SqlParameter paramTexto = new
                        SqlParameter("@filtroTexto", SqlDbType.VarChar);
                        paramTexto.Value = filtroTexto;
                        paramTexto.Direction = ParameterDirection.Input;
                        cmd.Parameters.Add(paramTexto);
                        /*Se abre la conexión*/
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                    catch (SqlException ex)
                    {
                        return null;
                    }
            }
        }
    }




}
}
