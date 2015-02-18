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
    public partial class AlumnosPorNivelFormaReporte : FormaReporteInterno
    {
        #region Campos
        private AlumnoManager objAlumno;
        private DocenteManager objDocente;
        private HorarioManager HorarioServicio;
        private HorarioDataSet.HorarioDataTable HorariosDataTable;
        #endregion

        #region Constructor
        public AlumnosPorNivelFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public AlumnosPorNivelFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objAlumno = new AlumnoManager();
            objDocente = new DocenteManager();
            HorarioServicio = new HorarioManager();
        }
        #endregion

        #region Eventos
        private void AlumnosPorCursoFormaReporte_Load(object sender, EventArgs e)
        {
            HorariosDataTable = HorarioServicio.SeleccionarxTipoHorario(2);
            AreaNivelCombos.CargarDatos();
            TipoListadoComboBox.SelectedIndex = 1;
        }

        private void AreaNivelCombos_NivelCambiado(object sender, System.EventArgs e)
        {
            HorarioNivelComboBox.DataSource = MetodosGenerales.FiltrarHorariosxNivel(AreaNivelCombos.GetIdNivel(), HorariosDataTable);
        }
        #endregion

        #region Métodos
        protected override bool DatosReporte()
        {
            if (ValidarParametros())
            {
                DocenteDataSet.DocenteDataTable dtDocente = objDocente.SeleccionarxId((int)HorarioNivelComboBox.SelectedValue);
                this.Elementos.ParametrosReporte.Clear();
                this.Elementos.ParametrosReporte.Add(new ReportParameter("NombreAreaNivel", string.Format("{0}/{1}", AreaNivelCombos.GetNombreArea(), AreaNivelCombos.GetNombreNivel())));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("NombreHorario", HorarioNivelComboBox.Text));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("Docente", string.Format("{0} {1}", dtDocente[0].Nombre, dtDocente[0].Apellido)));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("TipoListado", TipoListadoComboBox.SelectedItem.ToString()));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("Mes", DateTime.Today.ToString("MMMM")));
                this.Elementos.NombreReporte = "ReporteAlumnosPorNivel.rdlc";
                this.Elementos.DataSource = objAlumno.SeleccionarxIdHorario((int)HorarioNivelComboBox.SelectedValue);
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
            if (!AreaNivelCombos.ValidarNivel()) parametrosValidos = false;
            if (!ValidarComboBox(HorarioNivelComboBox)) parametrosValidos = false;
            return parametrosValidos;
        }
        #endregion
    }
}

