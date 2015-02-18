using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;
using Verdezul.Utilidades.Configuracion;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Conexion a SQLServer.
    /// </summary>
    public class SQLConexion
    {
        #region Campos
        /// <summary>
        /// Cadena de Conexión a la Base de Datos
        /// </summary>
        private static string StringConexion
        {
            get
            {
                VerdezulConfiguration conf = ConfigurationManager.GetSection("Verdezul") as VerdezulConfiguration;
                return string.Format(ConfigurationManager.ConnectionStrings[conf.Conexiones.BaseDatos.NombreConexion].ConnectionString);
            }
        }

        /// <summary>
        /// Objeto de Conexión a Base de Datos
        /// </summary>
        private static SqlConnection Conexion;
        private static string NombreParametroRetorno = "ReturnValue";
        #endregion

        #region SeleccionarDatos
        /// <summary>
        /// Ejecuta un procedimiento almacenado sin parámetros y devuelve un DataSet.
        /// </summary>
        /// <param name="nombreProcedimiento">Nombre del Procedimiento Almacenado.</param>
        /// <returns>Retorna un DataSet genérico</returns>
        public static DataSet SeleccionarDatos(string nombreProcedimiento)
        {
            return SeleccionarDatos(nombreProcedimiento, null, null);
        }
        /// <summary>
        /// Ejecuta un procedimiento almacenado con parámetros y devuelve un DataSet.
        /// </summary>
        /// <param name="nombreProcedimiento">Nombre del Procedimiento Almacenado.</param>
        /// <param name="parametros">Arreglo de parámetros para Procedimiento Almacenado.</param>
        /// <returns>Retorna un DataSet genérico</returns>
        public static DataSet SeleccionarDatos(string nombreProcedimiento, SqlParameter[] parametros)
        {
            return SeleccionarDatos(nombreProcedimiento, parametros, null);
        }
        /// <summary>
        /// Ejecuta un procedimiento almacenado sin parámetros y devuelve un DataSet específico.
        /// </summary>
        /// <param name="nombreProcedimiento">Nombre del Procedimiento Almacenado.</param>
        /// <param name="tipoDataSet">Tipo de DataSet definido en Entidades.</param>
        /// <returns>Retorna un DataSet del tipo 'tipoDataSet'</returns>
        public static DataSet SeleccionarDatos(string nombreProcedimiento, Type tipoDataSet)
        {
            return SeleccionarDatos(nombreProcedimiento, null, tipoDataSet);
        }
        /// <summary>
        /// Ejecuta un procedimiento almacenado con parámetros y devuelve un DataSet específico.
        /// </summary>
        /// <param name="nombreProcedimiento">Nombre del Procedimiento Almacenado.</param>
        /// <param name="parametros">Arreglo de parámetros para Procedimiento Almacenado.</param>
        /// <param name="tipoDataSet">Tipo de DataSet definido en Entidades.</param>
        /// <returns>Retorna un DataSet del tipo 'tipoDataSet'</returns>
        public static DataSet SeleccionarDatos(string nombreProcedimiento, SqlParameter[] parametros, Type tipoDataSet)
        {
            Conexion = new SqlConnection(StringConexion);

            SqlCommand sqlcommand = new SqlCommand(nombreProcedimiento, Conexion);
            sqlcommand.CommandType = CommandType.StoredProcedure;

            // Agregado de Parámetros de Procedimiento Almacenado
            if (parametros != null)
                sqlcommand.Parameters.AddRange(parametros);

            // Creación e Instanciación de DataSet de respuesta.
            DataSet dataSet;
            if (tipoDataSet != null)
                dataSet = Activator.CreateInstance(tipoDataSet) as DataSet;
            else
            {
                dataSet = new DataSet();
                dataSet.Tables.Add();
            }

            // Petición de Datos.
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);
            try
            {
                List<DataTable> dts = new List<DataTable>();
                foreach (DataTable dt in dataSet.Tables) { dts.Add(dt); }

                sqlDataAdapter.Fill(0, 0, dts.ToArray());

                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
            }
            catch (Exception ex)
            {
                VerificarException(ex);
            }
            return dataSet;
        }
        #endregion

        #region Ejecutar
        /// <summary>
        /// Ejecuta un procedimiento almacenado sin parámetros
        /// </summary>
        /// <param name="nombreProcedimiento">Nombre del Procedimiento Almacenado.</param>
        /// <returns>Devuelve el valor de Retorno del Procedimiento Almacenado.</returns>
        public static object Ejecutar(string nombreProcedimiento)
        {
            return Ejecutar(nombreProcedimiento, null, null);
        }
        /// <summary>
        /// Ejecuta un procedimiento almacenado con parámetros
        /// </summary>
        /// <param name="nombreProcedimiento">Nombre del Procedimiento Almacenado.</param>
        /// <param name="parametros">Arreglo de parámetros para Procedimiento Almacenado.</param>
        /// <returns>Devuelve el valor de Retorno del Procedimiento Almacenado.</returns>
        public static object Ejecutar(string nombreProcedimiento, SqlParameter[] parametros)
        {
            return Ejecutar(nombreProcedimiento, parametros, null);
        }
        /// <summary>
        /// Ejecuta un procedimiento almacenado con parámetros
        /// </summary>
        /// <param name="nombreProcedimiento">Nombre del Procedimiento Almacenado.</param>
        /// <param name="parametros">Arreglo de parámetros para Procedimiento Almacenado.</param>
        /// <param name="nombreParametroRetorno">Nombre del parámetro de retorno.</param>
        /// <returns>Devuelve el valor del Parámetro de Retorno de 'nombreParametroRetorno'.</returns>
        public static object Ejecutar(string nombreProcedimiento, SqlParameter[] parametros, string nombreParametroRetorno)
        {
            Conexion = new SqlConnection(StringConexion);
            Conexion.Open();

            SqlCommand sqlcommand = new SqlCommand(nombreProcedimiento, Conexion);
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.AddRange(parametros);

            // Agrega el parámetro de retorno si no lo tuviera
            if (!sqlcommand.Parameters.Contains(NombreParametroRetorno))
            {
                SqlParameter spRetorno = new SqlParameter();
                spRetorno.ParameterName = NombreParametroRetorno;
                spRetorno.Direction = ParameterDirection.ReturnValue;
                sqlcommand.Parameters.Add(spRetorno);
            }

            try
            {
                sqlcommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                VerificarException(ex);
            }
            finally
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
            }

            if (nombreParametroRetorno == null)
                nombreParametroRetorno = NombreParametroRetorno;

            return sqlcommand.Parameters[nombreParametroRetorno].Value;
        }
        #endregion

        #region Mantenimiento Básico
        public static int Insertar(string nombreProcedimiento, SqlParameter[] parametros)
        {
            return Convert.ToInt32(Ejecutar(nombreProcedimiento, parametros, "Id"));
        }

        public static int Modificar(string nombreProcedimiento, SqlParameter[] parametros)
        {
            return Convert.ToInt32(Ejecutar(nombreProcedimiento, parametros));
        }

        public static int Borrar(string nombreProcedimiento, SqlParameter[] parametros)
        {
            return Convert.ToInt32(Ejecutar(nombreProcedimiento, parametros));
        }

        public static DataSet Seleccionar(string nombreProcedimiento, int id, Type tipoDataSet)
        {
            return SeleccionarDatos(
                nombreProcedimiento,
                new SqlParameter[] { new SqlParameter("Id", id) },
                tipoDataSet);
        }
        #endregion

        #region Mantenimiento por Niveles
        public static int InsertarNivel(string nombreProcedimientoPadre, string nombreProcedimientoHijo,
            SqlParameter[] parametrosPadre, List<SqlParameter[]> listaParametrosHijo,
            string nombreIdPadre)
        {
            Conexion = new SqlConnection(StringConexion);
            Conexion.Open();

            SqlCommand sqlcommandPadre = new SqlCommand(nombreProcedimientoPadre, Conexion);
            sqlcommandPadre.CommandType = CommandType.StoredProcedure;
            sqlcommandPadre.Parameters.AddRange(parametrosPadre);

            // Agrega el parámetro de retorno si no lo tuviera
            if (!sqlcommandPadre.Parameters.Contains(NombreParametroRetorno))
            {
                SqlParameter spRetorno = new SqlParameter();
                spRetorno.ParameterName = NombreParametroRetorno;
                spRetorno.Direction = ParameterDirection.ReturnValue;
                sqlcommandPadre.Parameters.Add(spRetorno);
            }

            sqlcommandPadre.ExecuteScalar();

            int idPadre = (int)sqlcommandPadre.Parameters["Id"].Value;

            foreach (SqlParameter[] parametrosHijo in listaParametrosHijo)
            {
                SqlCommand sqlcommandHijo = new SqlCommand(nombreProcedimientoHijo, Conexion);
                sqlcommandHijo.CommandType = CommandType.StoredProcedure;
                sqlcommandHijo.Parameters.AddRange(parametrosHijo);
                sqlcommandHijo.Parameters[nombreIdPadre].Value = idPadre;
                sqlcommandHijo.ExecuteScalar();
            }

            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();

            return idPadre;
        }
        #endregion

        #region Métodos
        private static void VerificarException(Exception ex)
        {
            string mensaje = "";
            switch (ex.GetType().Name)
            {
                case "SqlException":
                    SqlException sqlex = ex as SqlException;
                    switch (sqlex.Number)
                    {
                        case 15350:
                            mensaje = "No existe conexión con la base de datos.";
                            break;
                        case 2601:
                            mensaje = "No pueden existir dos registros con la misma información básica.";
                            break;
                        case 547:
                            mensaje = "Existe información relacionada con el registro que se desea borrar.";
                            break;
                        default:
                            mensaje = "Error en la base de datos. \n - Número de Excepción : " +
                                sqlex.Number.ToString() + "\n - Mensaje: " + sqlex.Message;
                            break;
                    }
                    break;
                default:
                    mensaje = ex.GetType().Name + ": \n" + ex.Message;
                    break;
            }
            throw new Exception(mensaje);
        }
        #endregion
    }
}