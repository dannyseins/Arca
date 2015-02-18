using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Nivel
    /// </summary>
    public partial class NivelDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Nivels.
        /// </summary>
        /// <param name="Id">Id de Nivel</param>
        /// <returns>NivelDataSet</returns>
        public AreaDataSet.NivelDataTable Seleccionar(int id)
        {
            return ((AreaDataSet)SQLConexion.Seleccionar("Nivel_Seleccionar", id, typeof(AreaDataSet))).Nivel;
        }

        /// <summary>
        /// Inserta un nuevo Nivel.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Nivel a Insertar.</param>
        /// <returns>Id de Nivel Insertado</returns>
        public int Insertar(AreaDataSet ds)
        {
            AreaDataSet.NivelRow pr = ds.Nivel[0];
            SqlParameter[] parametrosNivel = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("IdArea", pr.IdArea),
                SqlParameterInput("Nombre", pr.Nombre)
            };
            return SQLConexion.Insertar("Nivel_Insertar", parametrosNivel);
        }

        /// <summary>
        /// Modifica un Nivel.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Nivel a Modificar.</param>
        public int Modificar(AreaDataSet ds)
        {
            AreaDataSet.NivelRow pr = ds.Nivel[0];
            SqlParameter[] parametrosNivel = {
                SqlParameterInput("Id", pr.Id),
                SqlParameterInput("IdArea", pr.IdArea),
                SqlParameterInput("Nombre", pr.Nombre)
            };
            return SQLConexion.Modificar("Nivel_Modificar", parametrosNivel);
        }

        /// <summary>
        /// Borra un Nivel
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Nivel a Borrar.</param>
        public int Borrar(AreaDataSet ds)
        {
            AreaDataSet.NivelRow cr = ds.Nivel[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Nivel_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Nivel
        /// </summary>
        /// <param name="id">Identificador de Nivel</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Nivel_Borrar", parametros);
        }
    }
}
