using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Business;
using Microsoft.Reporting.WinForms;

namespace Verdezul.IDH.Presentacion.Reportes
{
    public partial class PagosxCierreFormaReporte : FormaReporteInterno
    {
        #region Campos
        private PagoManager objPago;
        private CierreDeCajaDataSet.CierreDeCajaRow _CierreDeCajaRow;
        #endregion

        #region Constructor
        public PagosxCierreFormaReporte(CierreDeCajaDataSet.CierreDeCajaRow cierreDeCajaRow)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            _CierreDeCajaRow = cierreDeCajaRow;
        }

        public PagosxCierreFormaReporte(CierreDeCajaDataSet.CierreDeCajaRow cierreDeCajaRow, int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            _CierreDeCajaRow = cierreDeCajaRow;
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objPago = new PagoManager();
        }
        #endregion

        #region Eventos
        private void AulasFormaReporte_Load(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        protected override bool DatosReporte()
        {
            this.Elementos.ParametrosReporte.Clear();
            try
            {
                this.Elementos.ParametrosReporte.Add(new ReportParameter("FechasCierre", string.Format("{0:dd/MM/yy HH:mm} - {1:dd/MM/yy HH:mm}", _CierreDeCajaRow.FechaApertura, _CierreDeCajaRow.FechaCierre)));
            }
            catch
            {
                this.Elementos.ParametrosReporte.Add(new ReportParameter("FechasCierre", string.Format("{0:dd/MM/yy HH:mm} - {1}", _CierreDeCajaRow.FechaApertura, "(No hay fecha de cierre aún)")));
            }
            this.Elementos.ParametrosReporte.Add(new ReportParameter("Caja", _CierreDeCajaRow["Caja"].ToString()));
            this.Elementos.ParametrosReporte.Add(new ReportParameter("Usuario", _CierreDeCajaRow["Usuario"].ToString()));
            this.Elementos.ParametrosReporte.Add(new ReportParameter("Observaciones", (!_CierreDeCajaRow.IsObservacionesNull()) ? _CierreDeCajaRow.Observaciones: ""));
            this.Elementos.NombreReporte = "ReportePagosxCierre.rdlc";
            this.Elementos.DataSource = objPago.SeleccionarConDetallexCierreDeCaja(_CierreDeCajaRow.Id).Pago;
            return true;
        }
        #endregion
    }
}

