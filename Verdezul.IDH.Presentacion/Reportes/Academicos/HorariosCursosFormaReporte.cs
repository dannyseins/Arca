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
    public partial class HorariosCursosFormaReporte : FormaReporteInterno
    {
        #region Campos
        private HorarioManager objHorario;
        #endregion

        #region Constructor
        public HorariosCursosFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public HorariosCursosFormaReporte(int idUsuario)
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
            HorariosCombo.CargarDatos();
        }
        #endregion

        #region Métodos
        protected override bool DatosReporte()
        {
            if (ValidarParametros())
            {
                this.Elementos.ParametrosReporte.Clear();
                this.Elementos.NombreReporte = "ReporteHorariosCursos.rdlc";
                this.Elementos.DataSource = objHorario.SeleccionarxIdCurso(HorariosCombo.GetIdCurso());
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

