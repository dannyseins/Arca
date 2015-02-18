using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Caja
    /// </summary>
    public partial class CajaDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Cajas.
        /// </summary>
        /// <param name="Id">Id de Caja</param>
        /// <returns>CajaDataSet</returns>
        public CajaDataSet.CajaDataTable Seleccionar(int id)
        {
            return ((CajaDataSet)SQLConexion.Seleccionar("Caja_Seleccionar", id, typeof(CajaDataSet))).Caja;
        }

        /// <summary>
        /// Inserta un nuevo Caja.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Caja a Insertar.</param>
        /// <returns>Id de Caja Insertado</returns>
        public int Insertar(CajaDataSet ds)
        {
            CajaDataSet.CajaRow cr = ds.Caja[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("IP", cr.IP),
                SqlParameterInput("Observacion", cr.Observacion),
            };
            return SQLConexion.Insertar("Caja_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Caja.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Caja a Modificar.</param>
        public int Modificar(CajaDataSet ds)
        {
            CajaDataSet.CajaRow cr = ds.Caja[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("IP", cr.IP),
                SqlParameterInput("Observacion", cr.Observacion),
            };
            return SQLConexion.Modificar("Caja_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Caja
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Caja a Borrar.</param>
        public int Borrar(CajaDataSet ds)
        {
            CajaDataSet.CajaRow cr = ds.Caja[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Caja_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Caja
        /// </summary>
        /// <param name="id">Identificador de Caja</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Caja_Borrar", parametros);
        }
    }
}