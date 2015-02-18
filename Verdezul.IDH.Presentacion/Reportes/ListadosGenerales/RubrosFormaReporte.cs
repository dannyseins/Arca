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
    public partial class RubrosFormaReporte : FormaReporteInterno
    {
        #region Campos
        private RubroManager objRubro;
        #endregion

        #region Constructor
        public RubrosFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public RubrosFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objRubro = new RubroManager();
        }
        #endregion

        #region Eventos
        private void RubrosFormaReporte_Load(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        protected override bool DatosReporte()
        {
            this.Elementos.NombreReporte = "ReporteRubros.rdlc";
            this.Elementos.DataSource = objRubro.SeleccionarTodos();
            return true;
        }
        #endregion
    }
}

