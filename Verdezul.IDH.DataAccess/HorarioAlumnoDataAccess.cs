using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Verdezul.IDH.DataAccess
{
    public partial class HorarioAlumnoDataAccess
    {
        /// <summary>
        /// Selecciona HorarioAlumnos Activos
        /// </summary>
        /// <returns></returns>
        public HorarioAlumnoDataSet.HorarioAlumnoDataTable SeleccionarActivos()
        {
            return ((HorarioAlumnoDataSet)SQLConexion.SeleccionarDatos("HorarioAlumno_SeleccionarActivos", typeof(HorarioAlumnoDataSet))).HorarioAlumno;
        }

        /// <summary>
        /// Selecciona los Horarios asignados por un alumno.
        /// </summary>
        /// <param name="idAlumno">Identificador de Alumno.</param>
        /// <returns></returns>
        public HorarioAlumnoDataSet.HorarioAlumnoDataTable SeleccionarxIdAlumno(int idAlumno)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdAlumno", idAlumno),
            };
            return ((HorarioAlumnoDataSet)SQLConexion.SeleccionarDatos("HorarioAlumno_SeleccionarxIdAlumno", parametros, typeof(HorarioAlumnoDataSet))).HorarioAlumno;
        }

        /// <summary>
        /// Cambia de nivel a un alumno seleccionado
        /// </summary>
        /// <param name="idAlumno">Identificador de Alumno.</param>
        /// <param name="idHorarioAlumno">Identificador de Horario.</param>
        /// <param name="fechaInicio">Fecha de Inicio de Horario.</param>
        /// <param name="fechaFin">Fecha de Fin de Horario.</param>
        public void CambiarNivel(int idAlumno, int idHorarioAlumno, DateTime fechaInicio, DateTime fechaFin)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdAlumno", idAlumno),
                SqlParameterInput("IdHorarioAlumno", idHorarioAlumno),
                SqlParameterInput("FechaInicio", fechaInicio),
                SqlParameterInput("FechaFin", ValorFechaNulo(fechaFin)),
            };
            SQLConexion.Ejecutar("HorarioAlumno_CambiarNivel", parametros);
        }

        /// <summary>
        /// Pide los horarios x nivel de un alumno dado,
        /// </summary>
        /// <param name="idAlumno">Identificador de Alumno.</param>
        /// <returns>HorarioAlumnoDataTable</returns>
        public HorarioAlumnoDataSet.HorarioAlumnoDataTable PedirHorarioyNivelxAlumno(int idAlumno)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdAlumno", idAlumno),
            };
            return ((HorarioAlumnoDataSet)SQLConexion.SeleccionarDatos("HorarioAlumno_PedirHorarioyNivelxAlumno", parametros, typeof(HorarioAlumnoDataSet))).HorarioAlumno;
        }

        /// <summary>
        /// Selecciona los Horarios asignados por un alumno por tipo de horario y actividad.
        /// </summary>
        /// <param name="idAlumno"></param>
        /// <param name="tipoHorario"></param>
        /// <param name="activo"></param>
        /// <returns></returns>
        public HorarioAlumnoDataSet.HorarioAlumnoDataTable SeleccionarxIdAlumno(int idAlumno, int tipoHorario, bool activo)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdAlumno", idAlumno),
                SqlParameterInput("TipoHorario", tipoHorario),
                SqlParameterInput("Activo", activo)
            };

            return ((HorarioAlumnoDataSet)SQLConexion.SeleccionarDatos("HorarioAlumno_SeleccionarxIdAlumnoTipoHorario", parametros, typeof(HorarioAlumnoDataSet))).HorarioAlumno;
        }
    }
}
