using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Curso
    /// </summary>
    public partial class CursoDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Cursos.
        /// </summary>
        /// <param name="Id">Id de Curso</param>
        /// <returns>CursoDataSet</returns>
        public CursoDataSet.CursoDataTable Seleccionar(int id)
        {
            return ((CursoDataSet)SQLConexion.Seleccionar("Curso_Seleccionar", id, typeof(CursoDataSet))).Curso;
        }

        /// <summary>
        /// Inserta un nuevo Curso.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Curso a Insertar.</param>
        /// <returns>Id de Curso Insertado</returns>
        public int Insertar(CursoDataSet ds)
        {
            CursoDataSet.CursoRow cr = ds.Curso[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Activo", cr.Activo)
            };
            return SQLConexion.Insertar("Curso_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Curso.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Curso a Modificar.</param>
        public int Modificar(CursoDataSet ds)
        {
            CursoDataSet.CursoRow cr = ds.Curso[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Activo", cr.Activo)
            };
            return SQLConexion.Modificar("Curso_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Curso
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Curso a Borrar.</param>
        public int Borrar(CursoDataSet ds)
        {
            CursoDataSet.CursoRow cr = ds.Curso[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Curso_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Curso
        /// </summary>
        /// <param name="id">Identificador de Curso</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Curso_Borrar", parametros);
        }
    }
}