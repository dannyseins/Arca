using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Area
    /// </summary>
    public partial class AreaDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Areas.
        /// </summary>
        /// <param name="Id">Id de Area</param>
        /// <returns>AreaDataSet</returns>
        public AreaDataSet.AreaDataTable Seleccionar(int id)
        {
            return ((AreaDataSet)SQLConexion.Seleccionar("Area_Seleccionar", id, typeof(AreaDataSet))).Area;
        }

        /// <summary>
        /// Inserta un nuevo Area.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Area a Insertar.</param>
        /// <returns>Id de Area Insertado</returns>
        public int Insertar(AreaDataSet ds)
        {
            AreaDataSet.AreaRow pr = ds.Area[0];
            SqlParameter[] parametrosArea = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("Nombre", pr.Nombre)
            };
            return SQLConexion.Insertar("Area_Insertar", parametrosArea);
        }

        /// <summary>
        /// Modifica un Area.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Area a Modificar.</param>
        public int Modificar(AreaDataSet ds)
        {
            AreaDataSet.AreaRow pr = ds.Area[0];
            SqlParameter[] parametrosArea = {
                SqlParameterInput("Id", pr.Id),
                SqlParameterInput("Nombre", pr.Nombre)
            };
            return SQLConexion.Modificar("Area_Modificar", parametrosArea);
        }

        /// <summary>
        /// Borra un Area
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Area a Borrar.</param>
        public int Borrar(AreaDataSet ds)
        {
            AreaDataSet.AreaRow cr = ds.Area[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Area_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Area
        /// </summary>
        /// <param name="id">Identificador de Area</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Area_Borrar", parametros);
        }
    }
}
