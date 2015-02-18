using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Observacion
    /// </summary>
    public partial class ObservacionDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Observacions.
        /// </summary>
        /// <param name="Id">Id de Observacion</param>
        /// <returns>ObservacionDataSet</returns>
        public ObservacionDataSet.ObservacionDataTable Seleccionar(int id)
        {
            return ((ObservacionDataSet)SQLConexion.Seleccionar("Observacion_Seleccionar", id, typeof(ObservacionDataSet))).Observacion;
        }

        /// <summary>
        /// Inserta un nuevo Observacion.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Observacion a Insertar.</param>
        /// <returns>Id de Observacion Insertado</returns>
        public int Insertar(ObservacionDataSet ds)
        {
            ObservacionDataSet.ObservacionRow cr = ds.Observacion[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("IdAlumno", cr.IdAlumno),
                SqlParameterInput("IdDocente", cr.IdDocente),
                SqlParameterInput("TextoAbierto", cr.TextoAbierto),
                SqlParameterInput("Fecha", cr.Fecha),
            };
            return SQLConexion.Insertar("Observacion_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Observacion.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Observacion a Modificar.</param>
        public int Modificar(ObservacionDataSet ds)
        {
            ObservacionDataSet.ObservacionRow cr = ds.Observacion[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("IdAlumno", cr.IdAlumno),
                SqlParameterInput("IdDocente", cr.IdDocente),
                SqlParameterInput("TextoAbierto", cr.TextoAbierto),
                SqlParameterInput("Fecha", cr.Fecha),
            };
            return SQLConexion.Modificar("Observacion_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Observacion
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Observacion a Borrar.</param>
        public int Borrar(ObservacionDataSet ds)
        {
            ObservacionDataSet.ObservacionRow cr = ds.Observacion[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Observacion_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Observacion
        /// </summary>
        /// <param name="id">Identificador de Observacion</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Observacion_Borrar", parametros);
        }
    }
}