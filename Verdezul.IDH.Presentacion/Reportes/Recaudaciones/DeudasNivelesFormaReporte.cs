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
    public partial class DeudasNivelesFormaReporte : FormaReporteInterno
    {
        #region Campos
        private PagoManager objPago;
        #endregion

        #region Constructor
        public DeudasNivelesFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public DeudasNivelesFormaReporte(int idUsuario)
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
        private void DeudasNivelesFormaReporte_Load(object sender, EventArgs e)
        {
            AreaNivelCombos.CargarDatos();
        }
        #endregion

        #region Métodos
        protected override bool DatosReporte()
        {
            if (ValidarParametros())
            {
                this.Elementos.ParametrosReporte.Clear();
                this.Elementos.ParametrosReporte.Add(new ReportParameter("NombreAreaNivel", 
                    string.Format("{0}/{1}", AreaNivelCombos.GetNombreArea(), AreaNivelCombos.GetNombreNivel())));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("Mes", MesDeudaDateTimePicker.Value.ToString("MMMM")));
                this.Elementos.NombreReporte = "ReporteDeudasNiveles.rdlc";
                this.Elementos.DataSource = objPago.PedirDeudas(2, 0, AreaNivelCombos.GetIdArea(),
                    AreaNivelCombos.GetIdNivel(), 0, new DateTime(MesDeudaDateTimePicker.Value.Year, MesDeudaDateTimePicker.Value.Month, 1));
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

