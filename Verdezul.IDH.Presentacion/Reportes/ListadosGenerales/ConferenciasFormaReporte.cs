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
    public partial class ConferenciasFormaReporte : FormaReporteInterno
    {
        #region Campos
        private ConferenciaManager objConferencia;
        #endregion

        #region Constructor
        public ConferenciasFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public ConferenciasFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objConferencia = new ConferenciaManager();
        }
        #endregion

        #region Eventos
        private void ConferenciasFormaReporte_Load(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        protected override bool DatosReporte()
        {
            this.Elementos.NombreReporte = "ReporteConferencias.rdlc";
            this.Elementos.DataSource = objConferencia.SeleccionarTodos();
            return true;
        }
        #endregion
    }
}

