using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Configuracion.Enumerados;
//using Verdezul.IDH.Configuracion.Enumerados;

namespace Verdezul.IDH.DataAccess
{
    public partial class PagoDataAccess
    {
        public int InsertarNivel(PagoDataSet ds)
        {
            using (TransactionScope ts = new TransactionScope())
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

                List<SqlParameter[]> listaParametrosDetallePago = new List<SqlParameter[]>();

                foreach (PagoDataSet.DetallePagoRow dpr in ds.DetallePago.Rows)
                {
                    SqlParameter[] parametrosDetallePago = {
                        SqlParameterOutput("Id", DbType.Int32),
                        SqlParameterInput("IdPago", null),
                        SqlParameterInput("Cantidad", dpr.Cantidad),
                        SqlParameterInput("Valor", dpr.Valor),
                        SqlParameterInput("IVA", dpr.IVA),
                        SqlParameterInput("PVP", dpr.PVP),
                        SqlParameterInput("Descuento", dpr.Descuento),
                        SqlParameterInput("IdMotivoPago", dpr.IdMotivoPago),
                        SqlParameterInput("IdRubro", ValorEnteroNulo(dpr.IdRubro)),
                        SqlParameterInput("IdConferencia", ValorEnteroNulo(dpr.IdConferencia)),
                        SqlParameterInput("IdHorarioAlumno", ValorEnteroNulo(dpr.IdHorarioAlumno)),
                        SqlParameterInput("MesPago", ValorFechaNulo(dpr.MesPago)),
                        SqlParameterInput("TipoAbono", dpr.TipoAbono),
                    };
                    listaParametrosDetallePago.Add(parametrosDetallePago);
                }

                int IdPago = SQLConexion.InsertarNivel("Pago_Insertar", "DetallePago_Insertar",
                    parametrosPago, listaParametrosDetallePago, "IdPago");

                ts.Complete();
                return IdPago;
            }
        }

        public PagoDataSet SeleccionarConDetallexCierreDeCaja(int idCierreDeCaja)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdCierreDeCaja", idCierreDeCaja)
            };

            return (PagoDataSet)SQLConexion.SeleccionarDatos("Pago_SeleccionarConDetallexCierreDeCaja", parametros, typeof(PagoDataSet));
        }

        public object CambiarEstado(string listaPagos, EstadoPago EstadoPagoActivo)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("ListaPedidos", listaPagos),
                SqlParameterInput("Estado", (int)EstadoPagoActivo)
            };

            return (PagoDataSet)SQLConexion.SeleccionarDatos("Pago_CambiarEstado", parametros, typeof(PagoDataSet));
        }

        public DataTable PedirDeudas(int tipoHorarioIdMotivoPago, int idCurso, int idArea, int idNivel, int idAlumno, DateTime mesDeuda)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("TipoHorarioIdMotivoPago", tipoHorarioIdMotivoPago),
                SqlParameterInput("IdCurso", idCurso),
                SqlParameterInput("IdArea", idArea),
                SqlParameterInput("IdNivel", idNivel),
                SqlParameterInput("IdAlumno", idAlumno),
                SqlParameterInput("MesDeuda", mesDeuda)
            };

            return ((DataSet)SQLConexion.SeleccionarDatos("Pago_PedirDeudas", parametros, null)).Tables[0];
        }

        public PagoDataSet SeleccionarxIdConDetalle(int idPago, string numeroDocumento)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdPago", idPago),
                SqlParameterInput("NumeroDocumento", numeroDocumento)
            };

            return (PagoDataSet)SQLConexion.SeleccionarDatos("Pago_SeleccionarxIdConDetalle", parametros, typeof(PagoDataSet));
        }
    }
}
