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
    public partial class AulasFormaReporte : FormaReporteInterno
    {
        #region Campos
        private AulaManager objAula;
        #endregion

        #region Constructor
        public AulasFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public AulasFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objAula = new AulaManager();
        }
        #endregion

        #region Eventos
        private void AulasFormaReporte_Load(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        protected override bool DatosReporte()
        {
            this.Elementos.NombreReporte = "ReporteAulas.rdlc";
            this.Elementos.DataSource = objAula.SeleccionarTodos();
            return true;
        }
        #endregion
    }
}

