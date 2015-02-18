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
    public partial class ObservacionesAlumnoFormaReporte : FormaReporteInterno
    {
        #region Campos
        private ObservacionManager objObservacion;
        #endregion

        #region Constructor
        public ObservacionesAlumnoFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public ObservacionesAlumnoFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objObservacion = new ObservacionManager();
        }
        #endregion

        #region Eventos
        private void HorariosCursosFormaReporte_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Métodos
        protected override bool DatosReporte()
        {
            if (ValidarParametros())
            {
                this.Elementos.ParametrosReporte.Clear();
                this.Elementos.ParametrosReporte.Add(new ReportParameter("Alumno", string.Format("{0} {1}", AlumnoObservacion.Nombre, AlumnoObservacion.Apellido)));
                this.Elementos.NombreReporte = "ReporteObservacionesAlumnos.rdlc";
                this.Elementos.DataSource = objObservacion.SeleccionarxIdAlumno(AlumnoObservacion.IdAlumno.Value);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidarParametros()
        {
            bool parametrosCorrectos = true;
            if (!AlumnoObservacion.ValidarAlumnoEscogido()) parametrosCorrectos = false;
            return parametrosCorrectos;
        }
        #endregion
    }
}

