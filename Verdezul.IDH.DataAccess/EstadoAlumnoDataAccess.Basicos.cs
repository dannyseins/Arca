using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para EstadoAlumno
    /// </summary>
    public partial class EstadoAlumnoDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona EstadoAlumnos.
        /// </summary>
        /// <param name="Id">Id de EstadoAlumno</param>
        /// <returns>EstadoAlumnoDataSet</returns>
        public EstadoAlumnoDataSet.EstadoAlumnoDataTable Seleccionar(int id)
        {
            return ((EstadoAlumnoDataSet)SQLConexion.Seleccionar("EstadoAlumno_Seleccionar", id, typeof(EstadoAlumnoDataSet))).EstadoAlumno;
        }

        /// <summary>
        /// Inserta un nuevo EstadoAlumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo EstadoAlumno a Insertar.</param>
        /// <returns>Id de EstadoAlumno Insertado</returns>
        public int Insertar(EstadoAlumnoDataSet ds)
        {
            EstadoAlumnoDataSet.EstadoAlumnoRow cr = ds.EstadoAlumno[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("Nombre", cr.Nombre)
            };
            return SQLConexion.Insertar("EstadoAlumno_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un EstadoAlumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo EstadoAlumno a Modificar.</param>
        public int Modificar(EstadoAlumnoDataSet ds)
        {
            EstadoAlumnoDataSet.EstadoAlumnoRow cr = ds.EstadoAlumno[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("Nombre", cr.Nombre)
            };
            return SQLConexion.Modificar("EstadoAlumno_Modificar", parametros);
        }

        /// <summary>
        /// Borra un EstadoAlumno
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo EstadoAlumno a Borrar.</param>
        public int Borrar(EstadoAlumnoDataSet ds)
        {
            EstadoAlumnoDataSet.EstadoAlumnoRow cr = ds.EstadoAlumno[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("EstadoAlumno_Borrar", parametros);
        }

        /// <summary>
        /// Borra un EstadoAlumno
        /// </summary>
        /// <param name="id">Identificador de EstadoAlumno</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("EstadoAlumno_Borrar", parametros);
        }
    }
}