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
    public partial class DeudasAlumnoFormaReporte : FormaReporteInterno
    {
        #region Campos
        private PagoManager objPago;
        #endregion

        #region Constructor
        public DeudasAlumnoFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public DeudasAlumnoFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objPago = new PagoManager();
        }
        #endregion

        #region Eventos
        private void DeudasAlumnoFormaReporte_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Métodos
        protected override bool DatosReporte()
        {
            if (ValidarParametros())
            {
                this.Elementos.ParametrosReporte.Clear();
                this.Elementos.ParametrosReporte.Add(new ReportParameter("NombreAlumno", string.Format("{0} {1}", AlumnoReporte.Nombre ,AlumnoReporte.Apellido)));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("Mes", MesDeudaDateTimePicker.Value.ToString("MMMM")));
                this.Elementos.NombreReporte = "ReporteDeudasAlumno.rdlc";
                this.Elementos.DataSource = objPago.PedirDeudas(0, 0, 0,
                    0, AlumnoReporte.IdAlumno.Value, new DateTime(MesDeudaDateTimePicker.Value.Year, MesDeudaDateTimePicker.Value.Month, 1));
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
            if (!AlumnoReporte.ValidarAlumnoEscogido()) parametrosCorrectos = false;
            return parametrosCorrectos;
        }
        #endregion
    }
}

