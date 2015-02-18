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
    public partial class AlumnoDataAccess
    {
        /// <summary>
        /// Selecciona Alumno por Identificaion o Nombre o Apellido
        /// </summary>
        /// <param name="numeroIdentificacion"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
        public AlumnoDataSet.AlumnoDataTable SeleccionarxIdentificaionxNombrexApellido(string numeroIdentificacion, string nombre, string apellido)
        {
            SqlParameter[] parametros = { 
                SqlParameterInput("NumeroIdentificacion", numeroIdentificacion), 
                SqlParameterInput("Nombre", nombre), 
                SqlParameterInput("Apellido", apellido) 
            };
            return ((AlumnoDataSet)SQLConexion.SeleccionarDatos("Alumno_SeleccionarxIdentificaionxNombrexApellido", parametros, typeof(AlumnoDataSet))).Alumno;
        }
		
        /// <summary>
        /// Selecciona Alumnos de acuerdo al Tipo de Pertenencia
        /// </summary>
        /// <param name="tipoPertenencia">Tipo de Pertenencia</param>
        /// <param name="idArea">Identificador de Área</param>
        /// <param name="idNivel">Identificador de Nivel</param>
        /// <param name="idCurso">Identificador de Curso</param>
        /// <returns></returns>
        public AlumnoDataSet.AlumnoDataTable SeleccionarxPertenenciaAreaNivelCurso(int tipoPertenencia, int idArea, int idNivel, int idCurso)
        {
            SqlParameter[] parametros = { 
                SqlParameterInput("TipoPertenencia", tipoPertenencia), 
                SqlParameterInput("IdArea", idArea), 
                SqlParameterInput("IdNivel", idNivel), 
                SqlParameterInput("IdCurso", idCurso), 
            };
            return ((AlumnoDataSet)SQLConexion.SeleccionarDatos("Alumno_SeleccionarxPertenenciaAreaNivelCurso", parametros, typeof(AlumnoDataSet))).Alumno;
        }

        /// <summary>
        /// Actualiza el campo archivoFoto con un nombre válido
        /// </summary>
        /// <param name="_IdAlumno">Identificador de Alumno</param>
        /// <param name="archivoFoto">Nombre del archivo de imagen de foto.</param>
        public void ModificarFoto(int idAlumno, string archivoFoto)
        {
            SqlParameter[] parametros = { 
                SqlParameterInput("IdAlumno", idAlumno), 
                SqlParameterInput("ArchivoFoto", archivoFoto), 
            };
            SQLConexion.Modificar("Alumno_ModificarFoto", parametros);
        }

        /// <summary>
        /// Selecciona los alumnos cumpleañeros de un mes.
        /// </summary>
        /// <param name="mesNacimiento">Fecha que corresponde al mes.</param>
        /// <returns></returns>
        public DataTable SeleccionarxMesNacimiento(int mesNacimiento)
        {
            SqlParameter[] parametros = { 
                SqlParameterInput("MesNacimiento", mesNacimiento), 
            };
            return ((AlumnoDataSet)SQLConexion.SeleccionarDatos("Alumno_SeleccionarxMesNacimiento", parametros, typeof(AlumnoDataSet))).Alumno;
        }

        /// <summary>
        /// Selecciona Alumnos por Nivel o Curso inscritos.
        /// </summary>
        /// <param name="idHorario">Identificador de Horario.</param>
        /// <returns></returns>
        public DataTable SeleccionarxIdHorario(int idHorario)
        {
            SqlParameter[] parametros = { 
                SqlParameterInput("IdHorario", idHorario), 
            };
            return ((AlumnoDataSet)SQLConexion.SeleccionarDatos("Alumno_SeleccionarxIdHorario", parametros, typeof(AlumnoDataSet))).Alumno;
        }
    }
}