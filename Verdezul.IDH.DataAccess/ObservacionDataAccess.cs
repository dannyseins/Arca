using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    public partial class ObservacionDataAccess
    {
        /// <summary>
        /// Selecciona Observacions Activos
        /// </summary>
        /// <returns></returns>
        public ObservacionDataSet.ObservacionDataTable SeleccionarActivos()
        {
            return ((ObservacionDataSet)SQLConexion.SeleccionarDatos("Observacion_SeleccionarActivos", typeof(ObservacionDataSet))).Observacion;
        }

        /// <summary>
        /// Selecciona todas las observaciones de un alumno.
        /// </summary>
        /// <param name="idAlumno">Identificador de Alumno.</param>
        /// <returns></returns>
        public ObservacionDataSet.ObservacionDataTable SeleccionarxIdAlumno(int idAlumno)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdAlumno", idAlumno),
            };

            return ((ObservacionDataSet)SQLConexion.SeleccionarDatos("Observacion_SeleccionarxIdAlumno",parametros, typeof(ObservacionDataSet))).Observacion;
        }
    }
}
