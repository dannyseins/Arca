using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Docente
    /// </summary>
    public partial class DocenteDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Docentes.
        /// </summary>
        /// <param name="Id">Id de Docente</param>
        /// <returns>DocenteDataSet</returns>
        public DocenteDataSet.DocenteDataTable Seleccionar(int id)
        {
            return ((DocenteDataSet)SQLConexion.Seleccionar("Docente_Seleccionar", id, typeof(DocenteDataSet))).Docente;
        }

        /// <summary>
        /// Inserta un nuevo Docente.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Docente a Insertar.</param>
        /// <returns>Id de Docente Insertado</returns>
        public int Insertar(DocenteDataSet ds)
        {
            DocenteDataSet.DocenteRow cr = ds.Docente[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Apellido", cr.Apellido),
                SqlParameterInput("Activo", cr.Activo)
            };
            return SQLConexion.Insertar("Docente_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Docente.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Docente a Modificar.</param>
        public int Modificar(DocenteDataSet ds)
        {
            DocenteDataSet.DocenteRow cr = ds.Docente[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Apellido", cr.Apellido),
                SqlParameterInput("Activo", cr.Activo)
            };
            return SQLConexion.Modificar("Docente_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Docente
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Docente a Borrar.</param>
        public int Borrar(DocenteDataSet ds)
        {
            DocenteDataSet.DocenteRow cr = ds.Docente[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Docente_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Docente
        /// </summary>
        /// <param name="id">Identificador de Docente</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Docente_Borrar", parametros);
        }
    }
}