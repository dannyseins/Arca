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
    public partial class AlumnosPorCursoFormaReporte : FormaReporteInterno
    {
        #region Campos
        private AlumnoManager objAlumno;
        private DocenteManager objDocente;
        #endregion

        #region Constructor
        public AlumnosPorCursoFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public AlumnosPorCursoFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objAlumno = new AlumnoManager();
            objDocente = new DocenteManager();
        }
        #endregion

        #region Eventos
        private void AlumnosPorCursoFormaReporte_Load(object sender, EventArgs e)
        {
            HorariosCursoCombos.CargarDatos();
            TipoListadoComboBox.SelectedIndex = 1;
        }
        #endregion

        #region Métodos
        protected override bool DatosReporte()
        {
            if (ValidarParametros())
            {
                DocenteDataSet.DocenteDataTable dtDocente = objDocente.SeleccionarxId(HorariosCursoCombos.GetIdDocente());
                this.Elementos.ParametrosReporte.Clear();
                this.Elementos.ParametrosReporte.Add(new ReportParameter("NombreCurso", HorariosCursoCombos.GetNombreCurso()));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("NombreHorario", HorariosCursoCombos.GetNombreHorario()));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("Docente", string.Format("{0} {1}", dtDocente[0].Nombre, dtDocente[0].Apellido)));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("TipoListado", TipoListadoComboBox.Text));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("Mes", DateTime.Today.ToString("MMMM")));
                this.Elementos.NombreReporte = "ReporteAlumnosPorCurso.rdlc";
                this.Elementos.DataSource = objAlumno.SeleccionarxIdHorario(HorariosCursoCombos.GetIdHorario());
                dtDocente.Dispose();
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidarParametros()
        {
            bool parametrosValidos = true;
            if (!HorariosCursoCombos.ValidarHorario()) parametrosValidos = false;
            return parametrosValidos;
        }
        #endregion
    }
}

