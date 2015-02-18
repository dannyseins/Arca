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
    public partial class VisorReportes : FormaBase
    {
        #region Campos
        private VerdezulConfiguration Configuracion;
        #endregion

        #region Propiedades
        private ElementosReporte _Elementos;
        public ElementosReporte Elementos
        {
            get { return _Elementos; }
            set { _Elementos = value; }
        }

        private bool _Refrescar;
        public bool Refrescar
        {
            get { return _Refrescar; }
            set { _Refrescar = value; }
        }
        #endregion

        #region Constructor
        public VisorReportes(ElementosReporte elementos)
        {
            InitializeComponent();
            Elementos = elementos;
            InicializarComponentesAdicionales();
        }

        private void InicializarComponentesAdicionales()
        {
            this.Configuracion = ConfigurationManager.GetSection("Verdezul") as VerdezulConfiguration;
            this.BarraBotones.Visible = false;
            this.BarraEstado.Visible = false;
            this.ConfigurarReporte();
        }
        #endregion

        #region Eventos
        private void FormaReporte_Load(object sender, EventArgs e)
        {
            ConfigurarReporte();
        }

        private void VisorReportes_Activated(object sender, EventArgs e)
        {
            if (Refrescar)
            {
                ConfigurarReporte();
            }
        }
        #endregion

        #region Métodos
        private void ConfigurarReporte()
        {
            this.Text = string.Format("Visor de Reportes - {0}", Elementos.Titulo);
            this.VisorReporte.LocalReport.ReportPath = String.Format(@"{0}\{1}", Configuracion.Conexiones.Reportes.Carpeta, Elementos.NombreReporte);
            this.VisorReporte.LocalReport.DataSources.Clear();
            if (Elementos.DataSource != null)
                this.VisorReporte.LocalReport.DataSources.Add(new ReportDataSource("dsDatos", new BindingSource(Elementos.DataSource.DataSet, Elementos.DataSource.TableName)));
            if (Elementos.ParametrosReporte.Count > 0)
                this.VisorReporte.LocalReport.SetParameters(Elementos.ParametrosReporte);
            this.VisorReporte.RefreshReport();
            this.VisorReporte.SetDisplayMode(DisplayMode.PrintLayout);
            this.VisorReporte.ZoomMode = ZoomMode.PageWidth;
        }
        #endregion
    }
}