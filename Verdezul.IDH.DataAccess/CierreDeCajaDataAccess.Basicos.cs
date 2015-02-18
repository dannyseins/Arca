using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para CierreDeIDH
    /// </summary>
    public partial class CierreDeCajaDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona CierreDeIDHs.
        /// </summary>
        /// <param name="Id">Id de CierreDeIDH</param>
        /// <returns>CierreDeIDHDataSet</returns>
        public CierreDeCajaDataSet.CierreDeCajaDataTable Seleccionar(int id)
        {
            return ((CierreDeCajaDataSet)SQLConexion.Seleccionar("CierreDeCaja_Seleccionar", id, typeof(CierreDeCajaDataSet))).CierreDeCaja;
        }

        /// <summary>
        /// Inserta un nuevo CierreDeIDH.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo CierreDeIDH a Insertar.</param>
        /// <returns>Id de CierreDeIDH Insertado</returns>
        public int Insertar(CierreDeCajaDataSet ds)
        {
            CierreDeCajaDataSet.CierreDeCajaRow cr = ds.CierreDeCaja[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("FechaApertura", cr.FechaApertura),
                SqlParameterInput("FechaCierre", cr.FechaCierre),
                SqlParameterInput("IdIDH", cr.IdCaja),
                SqlParameterInput("IdUsuario", cr.IdUsuario),
                SqlParameterInput("Observaciones", cr.Observaciones)
            };
            return SQLConexion.Insertar("CierreDeCaja_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un CierreDeIDH.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo CierreDeIDH a Modificar.</param>
        public int Modificar(CierreDeCajaDataSet ds)
        {
            CierreDeCajaDataSet.CierreDeCajaRow cr = ds.CierreDeCaja[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("FechaApertura", cr.FechaApertura),
                SqlParameterInput("FechaCierre", cr.FechaCierre),
                SqlParameterInput("IdIDH", cr.IdCaja),
                SqlParameterInput("IdUsuario", cr.IdUsuario),
                SqlParameterInput("Observaciones", cr.Observaciones)
            };
            return SQLConexion.Modificar("CierreDeCaja_Modificar", parametros);
        }

        /// <summary>
        /// Borra un CierreDeIDH
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo CierreDeIDH a Borrar.</param>
        public int Borrar(CierreDeCajaDataSet ds)
        {
            CierreDeCajaDataSet.CierreDeCajaRow cr = ds.CierreDeCaja[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("CierreDeCaja_Borrar", parametros);
        }

        /// <summary>
        /// Borra un CierreDeIDH
        /// </summary>
        /// <param name="id">Identificador de CierreDeIDH</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("CierreDeCaja_Borrar", parametros);
        }
    }
}