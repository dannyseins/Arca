using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Parametro
    /// </summary>
    public partial class ParametroDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Parametros.
        /// </summary>
        /// <param name="Id">Id de Parametro</param>
        /// <returns>ParametroDataSet</returns>
        public ParametroDataSet.ParametroDataTable Seleccionar(int id)
        {
            return ((ParametroDataSet)SQLConexion.Seleccionar("Parametro_Seleccionar", id, typeof(ParametroDataSet))).Parametro;
        }

        /// <summary>
        /// Inserta un nuevo Parametro.
        /// </summary>
        /// <param name="ds">Conjunto de datos tValoro Parametro a Insertar.</param>
        /// <returns>Id de Parametro Insertado</returns>
        public int Insertar(ParametroDataSet ds)
        {
            ParametroDataSet.ParametroRow cr = ds.Parametro[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Valor", cr.Valor),
                SqlParameterInput("Descripcion", cr.Descripcion),
            };
            return SQLConexion.Insertar("Parametro_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Parametro.
        /// </summary>
        /// <param name="ds">Conjunto de datos tValoro Parametro a Modificar.</param>
        public int Modificar(ParametroDataSet ds)
        {
            ParametroDataSet.ParametroRow cr = ds.Parametro[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Valor", cr.Valor),
                SqlParameterInput("Descripcion", cr.Descripcion),
            };
            return SQLConexion.Modificar("Parametro_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Parametro
        /// </summary>
        /// <param name="ds">Conjunto de datos tValoro Parametro a Borrar.</param>
        public int Borrar(ParametroDataSet ds)
        {
            ParametroDataSet.ParametroRow cr = ds.Parametro[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Parametro_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Parametro
        /// </summary>
        /// <param name="id">Identificador de Parametro</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Parametro_Borrar", parametros);
        }
    }
}