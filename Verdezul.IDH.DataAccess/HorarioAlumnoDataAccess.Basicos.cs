using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para HorarioAlumno
    /// </summary>
    public partial class HorarioAlumnoDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona HorarioAlumnos.
        /// </summary>
        /// <param name="Id">Id de HorarioAlumno</param>
        /// <returns>HorarioAlumnoDataSet</returns>
        public HorarioAlumnoDataSet.HorarioAlumnoDataTable Seleccionar(int id)
        {
            return ((HorarioAlumnoDataSet)SQLConexion.Seleccionar("HorarioAlumno_Seleccionar", id, typeof(HorarioAlumnoDataSet))).HorarioAlumno;
        }

        /// <summary>
        /// Inserta un nuevo HorarioAlumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo HorarioAlumno a Insertar.</param>
        /// <returns>Id de HorarioAlumno Insertado</returns>
        public int Insertar(HorarioAlumnoDataSet ds)
        {
            HorarioAlumnoDataSet.HorarioAlumnoRow cr = ds.HorarioAlumno[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("IdAlumno", cr.IdAlumno),
                SqlParameterInput("IdHorario", cr.IdHorario),
                SqlParameterInput("FechaInicio", cr.FechaInicio),
                SqlParameterInput("FechaFin", ValorFechaNulo(cr.FechaFin)),
                SqlParameterInput("Activo", cr.Activo),
            };
            return SQLConexion.Insertar("HorarioAlumno_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un HorarioAlumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo HorarioAlumno a Modificar.</param>
        public int Modificar(HorarioAlumnoDataSet ds)
        {
            HorarioAlumnoDataSet.HorarioAlumnoRow cr = ds.HorarioAlumno[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("IdAlumno", cr.IdAlumno),
                SqlParameterInput("IdHorario", cr.IdHorario),
                SqlParameterInput("FechaInicio", cr.FechaInicio),
                SqlParameterInput("FechaFin", ValorFechaNulo(cr.FechaFin)),
                SqlParameterInput("Activo", cr.Activo),
            };
            return SQLConexion.Modificar("HorarioAlumno_Modificar", parametros);
        }

        /// <summary>
        /// Borra un HorarioAlumno
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo HorarioAlumno a Borrar.</param>
        public int Borrar(HorarioAlumnoDataSet ds)
        {
            HorarioAlumnoDataSet.HorarioAlumnoRow cr = ds.HorarioAlumno[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("HorarioAlumno_Borrar", parametros);
        }

        /// <summary>
        /// Borra un HorarioAlumno
        /// </summary>
        /// <param name="id">Identificador de HorarioAlumno</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("HorarioAlumno_Borrar", parametros);
        }
    }
}