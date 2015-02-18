using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Configuracion.Enumerados;
using System.Data;

namespace Verdezul.IDH.Business
{
    public partial class PagoManager
    {
        public int InsertarNivel(PagoDataSet ds)
        {
            return objPago.InsertarNivel(ds);
        }

        public PagoDataSet SeleccionarConDetallexCierreDeCaja(int idCierreDeCaja)
        {
            return objPago.SeleccionarConDetallexCierreDeCaja(idCierreDeCaja);
        }

        public void CambiarEstado(string listaPagos, EstadoPago EstadoPagoActivo)
        {
            objPago.CambiarEstado(listaPagos, EstadoPagoActivo);
        }

        public DataTable PedirDeudas(int tipoHorarioIdMotivoPago, int idCurso, int idArea, int idNivel, int idAlumno, DateTime mesDeuda)
        {
            return objPago.PedirDeudas(tipoHorarioIdMotivoPago, idCurso, idArea, idNivel, idAlumno, mesDeuda);
        }

        public PagoDataSet SeleccionarxIdConDetalle(int idPago, string numeroDocumento)
        {
            return objPago.SeleccionarxIdConDetalle(idPago, numeroDocumento);
        }

    }
}
