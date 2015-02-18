using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    public partial class CierreDeCajaManager
    {
        public Nullable<int> PedirIdCierreDeCajaxIdCajaIdUsuario(int idCaja, int idUsuario)
        {
            return objCierreDeCaja.PedirIdCierreDeCajaxIdCajaIdUsuario(idCaja, idUsuario);
        }

        public Nullable<int> AbrirCaja(int idCaja, int idUsuario)
        {
            return objCierreDeCaja.AbrirCaja(idCaja, idUsuario);
        }

        public int CerrarCaja(int idCierreDeCaja)
        {
            return objCierreDeCaja.CerrarCaja(idCierreDeCaja);
        }

        public CierreDeCajaDataSet.CierreDeCajaDataTable SeleccionarEntreFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCierreDeCaja.SeleccionarEntreFechas(fechaDesde, fechaHasta);
        }
    }
}
