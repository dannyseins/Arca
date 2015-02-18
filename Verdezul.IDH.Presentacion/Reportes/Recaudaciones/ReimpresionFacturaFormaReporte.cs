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
    public partial class ReimpresionFacturaFormaReporte : FormaBase
    {
        #region Campos
        private PagoManager objPago;
        private AlumnoManager objAlumno;
        private ParametroManager ParametroServicio;
        private ParametroDataSet.ParametroDataTable dtParametro;
        private EmpresaInformacion EmpresaDatos;
        #endregion

        #region Botones
        private ToolStripButton MostrarBoton;
        #endregion

        #region Constructor
        public ReimpresionFacturaFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public ReimpresionFacturaFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objPago = new PagoManager();
            objAlumno = new AlumnoManager();
            ParametroServicio = new ParametroManager();
            this.MostrarBoton = AgregarBotonAccion("MostrarBoton", "Mostrar", Imagenes.ImpresionPrevia, MostrarBoton_Click);
        }
        #endregion

        #region Eventos
        private void ReimpresionFacturaFormaReporte_Load(object sender, EventArgs e)
        {
            dtParametro = ParametroServicio.SeleccionarTodos();
            EmpresaDatos = new EmpresaInformacion(MetodosGenerales.BuscarValorParametro("Empresa", dtParametro),
                                                    MetodosGenerales.BuscarValorParametro("Dirección", dtParametro),
                                                    MetodosGenerales.BuscarValorParametro("Teléfono", dtParametro),
                                                    MetodosGenerales.BuscarValorParametro("RUC", dtParametro));
        }

        private void MostrarBoton_Click(object sender, EventArgs e)
        {
            if (ValidarParametros())
            {
                int idPago = 0;
                string numeroDocumento = "";
                if (IdPagoRadioButton.Checked)
                    idPago = Convert.ToInt32(IdPagoTextBox.Text);
                else
                    numeroDocumento = NumeroDocumentoTextBox.Text;

                PagoDataSet pds = objPago.SeleccionarxIdConDetalle(idPago, numeroDocumento);
                if (pds.Pago.Rows.Count > 0)
                {
                    pds.DetallePago.DescripcionColumn.Expression = MetodosGenerales.ExpresionDetallePago;
                    AlumnoDataSet.AlumnoDataTable adt = objAlumno.SeleccionarxId(pds.Pago[0].IdAlumno);
                    AlumnoDataSet.AlumnoRow arow = adt[0];
                    DocumentoPagoImpreso facturaPrueba = new DocumentoPagoImpreso(pds, arow, EmpresaDatos);
                    ImpresionPrevia(pds.Pago[0].NumeroDocumento, facturaPrueba.Factura_PrintPage, 100);
                }
                else
                {
                    MostrarMensaje("No existe pago con el criterio seleccionado.");
                }
            }
        }
        #endregion

        #region Métodos
        private bool ValidarParametros()
        {
            bool parametrosCorrectos = true;
            MarcaError.Clear();
            if (IdPagoRadioButton.Checked)
                try
                {
                    Convert.ToInt32(IdPagoTextBox.Text);
                }
                catch
                {
                    MarcaError.SetError(IdPagoTextBox, "Ingrese un valor numérico.");
                    parametrosCorrectos = false;
                }
            else
            {
                if (!ValidarTextBox(NumeroDocumentoTextBox))
                    parametrosCorrectos = false;
            }
            return parametrosCorrectos;
        }
        #endregion
    }
}

