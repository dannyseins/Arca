using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para SecuenciaImpresion
    /// </summary>
    public partial class SecuenciaImpresionDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona SecuenciaImpresions.
        /// </summary>
        /// <param name="Id">Id de SecuenciaImpresion</param>
        /// <returns>SecuenciaImpresionDataSet</returns>
        public SecuenciaImpresionDataSet.SecuenciaImpresionDataTable Seleccionar(int id)
        {
            return ((SecuenciaImpresionDataSet)SQLConexion.Seleccionar("SecuenciaImpresion_Seleccionar", id, typeof(SecuenciaImpresionDataSet))).SecuenciaImpresion;
        }

        /// <summary>
        /// Inserta un nuevo SecuenciaImpresion.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo SecuenciaImpresion a Insertar.</param>
        /// <returns>Id de SecuenciaImpresion Insertado</returns>
        public int Insertar(SecuenciaImpresionDataSet ds)
        {
            SecuenciaImpresionDataSet.SecuenciaImpresionRow row = ds.SecuenciaImpresion[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("Fecha", row.Fecha),
                SqlParameterInput("ValorUsado", row.ValorUsado),
                SqlParameterInput("ValorInicio", row.ValorInicio),
                SqlParameterInput("ValorFin", row.ValorFin),
                SqlParameterInput("Prefijo", row.Prefijo),
                SqlParameterInput("NumCaracteres", row.NumCaracteres),
                SqlParameterInput("Cerrado", row.Cerrado),
                SqlParameterInput("EnUso", row.EnUso),
                SqlParameterInput("TipoDocumentoPago", row.TipoDocumentoPago),
                SqlParameterReturn()
            };
            return SQLConexion.Insertar("SecuenciaImpresion_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un SecuenciaImpresion.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo SecuenciaImpresion a Modificar.</param>
        public int Modificar(SecuenciaImpresionDataSet ds)
        {
            SecuenciaImpresionDataSet.SecuenciaImpresionRow row = ds.SecuenciaImpresion[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", row.Id),
                SqlParameterInput("Fecha", row.Fecha),
                SqlParameterInput("ValorUsado", row.ValorUsado),
                SqlParameterInput("ValorInicio", row.ValorInicio),
                SqlParameterInput("ValorFin", row.ValorFin),
                SqlParameterInput("Prefijo", row.Prefijo),
                SqlParameterInput("NumCaracteres", row.NumCaracteres),
                SqlParameterInput("Cerrado", row.Cerrado),
                SqlParameterInput("EnUso", row.EnUso),
                SqlParameterInput("TipoDocumentoPago", row.TipoDocumentoPago),
            };
            return SQLConexion.Modificar("SecuenciaImpresion_Modificar", parametros);
        }

        /// <summary>
        /// Borra un SecuenciaImpresion
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo SecuenciaImpresion a Borrar.</param>
        public int Borrar(SecuenciaImpresionDataSet ds)
        {
            SecuenciaImpresionDataSet.SecuenciaImpresionRow cr = ds.SecuenciaImpresion[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("SecuenciaImpresion_Borrar", parametros);
        }

        /// <summary>
        /// Borra un SecuenciaImpresion
        /// </summary>
        /// <param name="id">Identificador de SecuenciaImpresion</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("SecuenciaImpresion_Borrar", parametros);
        }
    }
}