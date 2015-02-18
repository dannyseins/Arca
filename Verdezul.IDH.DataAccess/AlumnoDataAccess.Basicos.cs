using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Alumno
    /// </summary>
    public partial class AlumnoDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Alumnos.
        /// </summary>
        /// <param name="Id">Id de Alumno</param>
        /// <returns>AlumnoDataSet</returns>
        public AlumnoDataSet.AlumnoDataTable Seleccionar(int id)
        {
            return ((AlumnoDataSet)SQLConexion.Seleccionar("Alumno_Seleccionar", id, typeof(AlumnoDataSet))).Alumno;
        }

        /// <summary>
        /// Inserta un nuevo Alumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Alumno a Insertar.</param>
        /// <returns>Id de Alumno Insertado</returns>
        public int Insertar(AlumnoDataSet ds)
        {
            AlumnoDataSet.AlumnoRow cr = ds.Alumno[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("IdEstadoAlumno", cr.IdEstadoAlumno),
                SqlParameterInput("Codigo", cr.Codigo),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Apellido", cr.Apellido),
                SqlParameterInput("TipoIdentificacion", cr.TipoIdentificacion),
                SqlParameterInput("NumeroIdentificacion", cr.NumeroIdentificacion),
                SqlParameterInput("FechaNacimiento", cr.FechaNacimiento),
                SqlParameterInput("Direccion", cr.Direccion),
                SqlParameterInput("Email", cr.Email),
                SqlParameterInput("TelefonoDomicilio", cr.TelefonoDomicilio),
                SqlParameterInput("TelefonoOficina", cr.TelefonoOficina),
                SqlParameterInput("TelefonoCelular", cr.TelefonoCelular),
                SqlParameterInput("FechaIngreso", cr.FechaIngreso),
                SqlParameterInput("MedioConocimiento", cr.MedioConocimiento),
                SqlParameterInput("OtroConocimiento", cr.OtroConocimiento),
                SqlParameterInput("MotivoInscripcion", cr.MotivoInscripcion),
                SqlParameterInput("OtroInscripcion", cr.OtroInscripcion),
                SqlParameterInput("MotivoSalida", cr.MotivoSalida),
                SqlParameterInput("OtroSalida", cr.OtroSalida),
                SqlParameterReturn()
            };
            return SQLConexion.Insertar("Alumno_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Alumno.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Alumno a Modificar.</param>
        public int Modificar(AlumnoDataSet ds)
        {
            AlumnoDataSet.AlumnoRow cr = ds.Alumno[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("IdEstadoAlumno", cr.IdEstadoAlumno),
                SqlParameterInput("Codigo", cr.Codigo),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Apellido", cr.Apellido),
                SqlParameterInput("TipoIdentificacion", cr.TipoIdentificacion),
                SqlParameterInput("NumeroIdentificacion", cr.NumeroIdentificacion),
                SqlParameterInput("FechaNacimiento", cr.FechaNacimiento),
                SqlParameterInput("Direccion", cr.Direccion),
                SqlParameterInput("Email", cr.Email),
                SqlParameterInput("TelefonoDomicilio", cr.TelefonoDomicilio),
                SqlParameterInput("TelefonoOficina", cr.TelefonoOficina),
                SqlParameterInput("TelefonoCelular", cr.TelefonoCelular),
                SqlParameterInput("FechaIngreso", cr.FechaIngreso),
                SqlParameterInput("MedioConocimiento", cr.MedioConocimiento),
                SqlParameterInput("OtroConocimiento", cr.OtroConocimiento),
                SqlParameterInput("MotivoInscripcion", cr.MotivoInscripcion),
                SqlParameterInput("OtroInscripcion", cr.OtroInscripcion),
                SqlParameterInput("MotivoSalida", cr.MotivoSalida),
                SqlParameterInput("OtroSalida", cr.OtroSalida),
            };
            return SQLConexion.Modificar("Alumno_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Alumno
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Alumno a Borrar.</param>
        public int Borrar(AlumnoDataSet ds)
        {
            AlumnoDataSet.AlumnoRow cr = ds.Alumno[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Alumno_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Alumno
        /// </summary>
        /// <param name="id">Identificador de Alumno</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Alumno_Borrar", parametros);
        }
    }
}