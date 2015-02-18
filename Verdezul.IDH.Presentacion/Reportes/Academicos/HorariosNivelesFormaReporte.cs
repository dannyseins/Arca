using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Business;
using Verdezul.IDH.Configuracion;

namespace Verdezul.IDH.Presentacion.Reportes
{
    public partial class HorariosNivelesFormaReporte : FormaReporteInterno
    {
        #region Campos
        private HorarioManager objHorario;
        #endregion

        #region Constructor
        public HorariosNivelesFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public HorariosNivelesFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objHorario = new HorarioManager();
        }
        #endregion

        #region Eventos
        private void HorariosCursosFormaReporte_Load(object sender, EventArgs e)
        {
            NivelCombo.CargarDatos();
        }
        #endregion

        #region Métodos
        protected override bool DatosReporte()
        {
            if (ValidarParametros())
            {
                this.Elementos.ParametrosReporte.Clear();
                this.Elementos.NombreReporte = "ReporteHorariosNiveles.rdlc";
                this.Elementos.DataSource = objHorario.SeleccionarxIdNivelArea(NivelCombo.GetIdArea(), NivelCombo.GetIdNivel());
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidarParametros()
        {
            return true;
        }
        #endregion
    }
}

