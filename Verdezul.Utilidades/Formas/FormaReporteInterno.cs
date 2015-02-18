using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using Verdezul.Utilidades.Configuracion;
using Verdezul.Utilidades.Clases;

namespace Verdezul.Utilidades.Formas
{
    public partial class FormaReporteInterno : FormaBase
    {
        #region Campos
        private ToolStripButton MostrarBoton;
        private VerdezulConfiguration Configuracion;
        #endregion

        #region Propiedades
        private ElementosReporte _Elementos;
        public ElementosReporte Elementos
        {
            get { return _Elementos; }
            set { _Elementos = value; }
        }

        private bool _TieneParametros = true;
        public bool TieneParametros
        {
            get
            {
                return _TieneParametros;
            }
            set
            {
                _TieneParametros = value;
                if (!_TieneParametros)
                    ReporteSplitContainer.SplitterDistance = 0;
            }
        }

        public bool IsSplitterFixed
        {
            get { return this.ReporteSplitContainer.IsSplitterFixed; }
            set { this.ReporteSplitContainer.IsSplitterFixed = value; }
        }
        #endregion

        #region Constructor
        public FormaReporteInterno()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        private void InicializarComponentesAdicionales()
        {
            this.MostrarBoton = AgregarBotonAccion("MostrarBoton", "Mostrar", null, MostrarBoton_Click);
            this.Configuracion = ConfigurationManager.GetSection("Verdezul") as VerdezulConfiguration;
            this._Elementos = new ElementosReporte();
        }
        #endregion

        #region Eventos
        private void MostrarBoton_Click(object sender, EventArgs e)
        {
            MostrarReporte();
        }
        #endregion

        #region Métodos
        protected void MostrarReporte()
        {
            try
            {
                if (this.DatosReporte())
                {
                    this.VisorReporte.LocalReport.ReportPath = String.Format(@"{0}\{1}", Configuracion.Conexiones.Reportes.Carpeta, Elementos.NombreReporte);
                    this.VisorReporte.LocalReport.DataSources.Clear();
                    if (Elementos.DataSource != null)
                        this.VisorReporte.LocalReport.DataSources.Add(new ReportDataSource("dsDatos", new BindingSource(Elementos.DataSource.DataSet, Elementos.DataSource.TableName)));

                    Elementos.ParametrosReporte.Add(new ReportParameter("Titulo", this.Text));
                    this.VisorReporte.LocalReport.SetParameters(Elementos.ParametrosReporte);
                    this.VisorReporte.RefreshReport();
                    this.VisorReporte.SetDisplayMode(DisplayMode.PrintLayout);
                    this.VisorReporte.ZoomMode = ZoomMode.PageWidth;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se puede mostrar los datos del reporte", ex);
            }
        }
        #endregion

        #region Métodos Virtuales
        protected virtual bool DatosReporte() { return true; }
        #endregion
    }
}