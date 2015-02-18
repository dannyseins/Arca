using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Pago
    /// </summary>
    public partial class PagoDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Pagos.
        /// </summary>
        /// <param name="Id">Id de Pago</param>
        /// <returns>PagoDataSet</returns>
        public PagoDataSet.PagoDataTable Seleccionar(int id)
        {
            return ((PagoDataSet)SQLConexion.Seleccionar("Pago_Seleccionar", id, typeof(PagoDataSet))).Pago;
        }

        /// <summary>
        /// Inserta un nuevo Pago.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Pago a Insertar.</param>
        /// <returns>Id de Pago Insertado</returns>
        public int Insertar(PagoDataSet ds)
        {
            PagoDataSet.PagoRow pr = ds.Pago[0];
            SqlParameter[] parametrosPago = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("IdAlumno", pr.IdAlumno),
                SqlParameterInput("IdCierreDeCaja", pr.IdCierreDeCaja),
                SqlParameterInput("IdSecuencia", pr.IdSecuencia),
                SqlParameterInput("Fecha", pr.Fecha),
                SqlParameterInput("TipoDocumentoPago", pr.TipoDocumentoPago),
                SqlParameterInput("Estado", pr.Estado),
                SqlParameterInput("FormaPago", pr.FormaPago),
                SqlParameterInput("NumeroDocumento", pr.NumeroDocumento),
                SqlParameterInput("Observacion", pr.Observacion)
            };
            return SQLConexion.Insertar("Pago_Insertar", parametrosPago);
        }

        /// <summary>
        /// Modifica un Pago.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Pago a Modificar.</param>
        public int Modificar(PagoDataSet ds)
        {
            PagoDataSet.PagoRow pr = ds.Pago[0];
            SqlParameter[] parametrosPago = {
                SqlParameterInput("Id", pr.Id),
                SqlParameterInput("IdAlumno", pr.IdAlumno),
                SqlParameterInput("IdCierreDeCaja", pr.IdCierreDeCaja),
                SqlParameterInput("IdSecuencia", pr.IdSecuencia),
                SqlParameterInput("Fecha", pr.Fecha),
                SqlParameterInput("TipoDocumentoPago", pr.TipoDocumentoPago),
                SqlParameterInput("Estado", pr.Estado),
                SqlParameterInput("FormaPago", pr.FormaPago),
                SqlParameterInput("NumeroDocumento", pr.NumeroDocumento),
                SqlParameterInput("Observacion", pr.Observacion)
            };
            return SQLConexion.Modificar("Pago_Modificar", parametrosPago);
        }

        /// <summary>
        /// Borra un Pago
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Pago a Borrar.</param>
        public int Borrar(PagoDataSet ds)
        {
            PagoDataSet.PagoRow cr = ds.Pago[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Pago_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Pago
        /// </summary>
        /// <param name="id">Identificador de Pago</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Pago_Borrar", parametros);
        }
    }
}
