using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Aula
    /// </summary>
    public partial class AulaDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Aulas.
        /// </summary>
        /// <param name="Id">Id de Aula</param>
        /// <returns>AulaDataSet</returns>
        public AulaDataSet.AulaDataTable Seleccionar(int id)
        {
            return ((AulaDataSet)SQLConexion.Seleccionar("Aula_Seleccionar", id, typeof(AulaDataSet))).Aula;
        }

        /// <summary>
        /// Inserta un nuevo Aula.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Aula a Insertar.</param>
        /// <returns>Id de Aula Insertado</returns>
        public int Insertar(AulaDataSet ds)
        {
            AulaDataSet.AulaRow cr = ds.Aula[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Activo", cr.Activo),
            };
            return SQLConexion.Insertar("Aula_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Aula.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Aula a Modificar.</param>
        public int Modificar(AulaDataSet ds)
        {
            AulaDataSet.AulaRow cr = ds.Aula[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Activo", cr.Activo),
            };
            return SQLConexion.Modificar("Aula_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Aula
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Aula a Borrar.</param>
        public int Borrar(AulaDataSet ds)
        {
            AulaDataSet.AulaRow cr = ds.Aula[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Aula_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Aula
        /// </summary>
        /// <param name="id">Identificador de Aula</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Aula_Borrar", parametros);
        }
    }
}