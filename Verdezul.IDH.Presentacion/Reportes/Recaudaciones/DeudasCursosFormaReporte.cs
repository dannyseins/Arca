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
    public partial class DeudasCursosFormaReporte : FormaReporteInterno
    {
        #region Campos
        private PagoManager objPago;
        #endregion

        #region Constructor
        public DeudasCursosFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public DeudasCursosFormaReporte(int idUsuario)
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
        private void DeudasCursosFormaReporte_Load(object sender, EventArgs e)
        {
            HorariosCursoCombos.CargarDatos();
        }
        #endregion

        #region Métodos
        protected override bool DatosReporte()
        {
            if (ValidarParametros())
            {
                this.Elementos.ParametrosReporte.Clear();
                this.Elementos.ParametrosReporte.Add(new ReportParameter("NombreCurso", HorariosCursoCombos.GetNombreCurso()));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("Mes", MesDeudaDateTimePicker.Value.ToString("MMMM")));
                this.Elementos.NombreReporte = "ReporteDeudasCursos.rdlc";
                this.Elementos.DataSource = objPago.PedirDeudas(1, HorariosCursoCombos.GetIdCurso(), 0,
                    0, 0, new DateTime(MesDeudaDateTimePicker.Value.Year, MesDeudaDateTimePicker.Value.Month, 1));
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

