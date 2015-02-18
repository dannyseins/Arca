using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    public partial class CierreDeCajaDataAccess
    {
        public int? PedirIdCierreDeCajaxIdCajaIdUsuario(int idCaja, int idUsuario)
        {
            SqlParameter[] parametros = { 
                SqlParameterOutput("IdCierreDeCaja", DbType.Int32), 
                SqlParameterInput("IdCaja", idCaja),
                SqlParameterInput("IdUsuario", idUsuario)
            };
            object idCierreDeCaja = SQLConexion.Ejecutar("CierreDeCaja_PedirIdCierreDeCajaxIdCajaIdUsuario", parametros, "IdCierreDeCaja");
            return ((idCierreDeCaja == DBNull.Value) ? null : (Nullable<int>)idCierreDeCaja);
        }

        public int? AbrirCaja(int idCaja, int idUsuario)
        {
            SqlParameter[] parametros = { 
                SqlParameterOutput("IdCierreDeCaja", DbType.Int32), 
                SqlParameterInput("IdCaja", idCaja),
                SqlParameterInput("IdUsuario", idUsuario)
            };
            return (int)SQLConexion.Ejecutar("CierreDeCaja_AbrirCaja", parametros, "IdCierreDeCaja");
        }

        public int CerrarCaja(int idCierreDeCaja)
        {
            SqlParameter[] parametros = { 
                SqlParameterInput("IdCierreDeCaja", idCierreDeCaja)
            };
            return (int)SQLConexion.Ejecutar("CierreDeCaja_CerrarCaja", parametros);
        }

        public CierreDeCajaDataSet.CierreDeCajaDataTable SeleccionarEntreFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            SqlParameter[] parametros = { 
                SqlParameterInput("FechaDesde", fechaDesde),
                SqlParameterInput("FechaHasta", fechaHasta)
            };
            return ((CierreDeCajaDataSet)SQLConexion.SeleccionarDatos("CierreDeCaja_SeleccionarEntreFechas", parametros, typeof(CierreDeCajaDataSet))).CierreDeCaja;
        }
    }
}
