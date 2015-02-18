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
    public partial class CumpleanosFormaReporte : FormaReporteInterno
    {
        #region Campos
        private AlumnoManager objAlumno;
        #endregion

        #region Constructor
        public CumpleanosFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public CumpleanosFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objAlumno = new AlumnoManager();
        }
        #endregion

        #region Eventos
        private void AulasFormaReporte_Load(object sender, EventArgs e)
        {
            MesCumpleanosComboBox.DisplayMember = "NombreMes";
            MesCumpleanosComboBox.ValueMember = "NumeroMes";
            MesCumpleanosComboBox.DataSource = MetodosGenerales.Meses();
            MesCumpleanosComboBox.SelectedValue = DateTime.Today.Month;
            MostrarReporte();
        }

        protected override bool DatosReporte()
        {
            this.Elementos.NombreReporte = "ReporteCumpleanos.rdlc";
            DataRowView dr = MesCumpleanosComboBox.SelectedItem as DataRowView;
            this.Elementos.ParametrosReporte.Clear();
            this.Elementos.ParametrosReporte.Add(new ReportParameter("Mes", dr["NombreMes"].ToString()));
            this.Elementos.DataSource = objAlumno.SeleccionarxMesNacimiento((int)MesCumpleanosComboBox.SelectedValue);
            return true;
        }
        #endregion
    }
}

