using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Business;

namespace Verdezul.IDH.Presentacion.Reportes
{
    public partial class DocentesFormaReporte : FormaReporteInterno
    {
        #region Campos
        private DocenteManager objDocente;
        #endregion

        #region Constructor
        public DocentesFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public DocentesFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objDocente = new DocenteManager();
        }
        #endregion

        #region Eventos
        private void DocentesFormaReporte_Load(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        protected override bool DatosReporte()
        {
            this.Elementos.NombreReporte = "ReporteDocentes.rdlc";
            this.Elementos.DataSource = objDocente.SeleccionarTodos();
            return true;
        }
        #endregion
    }
}