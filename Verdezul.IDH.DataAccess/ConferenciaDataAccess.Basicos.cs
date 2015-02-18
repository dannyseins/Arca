using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Conferencia
    /// </summary>
    public partial class ConferenciaDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Conferencias.
        /// </summary>
        /// <param name="Id">Id de Conferencia</param>
        /// <returns>ConferenciaDataSet</returns>
        public ConferenciaDataSet.ConferenciaDataTable Seleccionar(int id)
        {
            return ((ConferenciaDataSet)SQLConexion.Seleccionar("Conferencia_Seleccionar", id, typeof(ConferenciaDataSet))).Conferencia;
        }

        /// <summary>
        /// Inserta un nuevo Conferencia.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Conferencia a Insertar.</param>
        /// <returns>Id de Conferencia Insertado</returns>
        public int Insertar(ConferenciaDataSet ds)
        {
            ConferenciaDataSet.ConferenciaRow cr = ds.Conferencia[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Fecha", cr.Fecha),
                SqlParameterInput("Instructor", cr.Instructor),
                SqlParameterInput("Activo", cr.Activo)
            };
            return SQLConexion.Insertar("Conferencia_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Conferencia.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Conferencia a Modificar.</param>
        public int Modificar(ConferenciaDataSet ds)
        {
            ConferenciaDataSet.ConferenciaRow cr = ds.Conferencia[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Fecha", cr.Fecha),
                SqlParameterInput("Instructor", cr.Instructor),
                SqlParameterInput("Activo", cr.Activo)
            };
            return SQLConexion.Modificar("Conferencia_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Conferencia
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Conferencia a Borrar.</param>
        public int Borrar(ConferenciaDataSet ds)
        {
            ConferenciaDataSet.ConferenciaRow cr = ds.Conferencia[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Conferencia_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Conferencia
        /// </summary>
        /// <param name="id">Identificador de Conferencia</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Conferencia_Borrar", parametros);
        }
    }
}