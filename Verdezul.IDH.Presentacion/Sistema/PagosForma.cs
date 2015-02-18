using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Printing;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Business;
using Verdezul.IDH.Configuracion;
using Verdezul.IDH.Configuracion.Enumerados;
using Verdezul.Utilidades;

namespace Verdezul.IDH.Presentacion.Sistema
{
    public partial class PagosForma : FormaBase
    {
        #region DataSet
        private PagoDataSet PagoActualDataSet = new PagoDataSet();
        private RubroDataSet.RubroDataTable dtRubros = new RubroDataSet.RubroDataTable();
        private ConferenciaDataSet.ConferenciaDataTable dtConferencias = new ConferenciaDataSet.ConferenciaDataTable();
        private DataTable dtMotivoPago = new DataTable();
        private ParametroDataSet.ParametroDataTable dtParametro;
        #endregion

        #region Servicios
        private RubroManager RubroServicio;
        private ConferenciaManager ConferenciaServicio;
        private PagoManager PagoServicio;
        private CierreDeCajaManager CierreDeCajaServicio;
        private SecuenciaImpresionManager SecuenciaServicio;
        private AreaManager AreaServicio;
        private ParametroManager ParametroServicio;
        private HorarioAlumnoManager HorarioAlumnoServicio;
        #endregion

        #region Campos
        private int IdCaja;
        private Nullable<int> IdCierreDeCaja;
        private RecaudacionesConfiguracion Configuracion;
        private decimal ValorIVA;
        private decimal ValorMensualidad;
        private decimal ValorConferencia;
        private EmpresaInformacion EmpresaDatos;
        #endregion

        #region Botones
        private ToolStripItem GrabarBoton;
        private ToolStripItem LimpiarBoton;
        #endregion

        #region Constructor
        public PagosForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public PagosForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            this.IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            RubroServicio = new RubroManager();
            ConferenciaServicio = new ConferenciaManager();
            PagoServicio = new PagoManager();
            CierreDeCajaServicio = new CierreDeCajaManager();
            SecuenciaServicio = new SecuenciaImpresionManager();
            AreaServicio = new AreaManager();
            ParametroServicio = new ParametroManager();
            HorarioAlumnoServicio = new HorarioAlumnoManager();

            Configuracion = ConfigurationManager.GetSection("IDH.Recaudaciones") as RecaudacionesConfiguracion;

            BarraBotones.ImageScalingSize = new Size(32, 32);
            GrabarBoton = AgregarBotonAccion("Grabar", "Grabar", Imagenes.GrabarPago, GrabarBoton_Click);
            LimpiarBoton = AgregarBotonAccion("Limpiar", "Limpiar", Imagenes.Limpiar, LimpiarBoton_Click);
            MarcarComoDropDownButton = AgregarDropDown("MarcarComoDropDownButton", "Marca como Ingresado",
                Imagenes.MarcarPago, this.estadoToolStripDropDown,
                MarcarComoDropDownButton_DropDownItemClicked, MarcarComoDropDownButton_DoubleClick);
            ImprimirBoton = AgregarBotonAccion("ImprimirBoton", "Imprimir", Imagenes.Imprimir, ImprimirBoton_Click);
            CerrarCajaBoton = AgregarBotonAccion("CerrarCaja", "Cerrar Caja", Imagenes.CerrarCaja, CerrarCajaBoton_Click);
            EstadoPagoActivo = EstadoPago.Ingresado;

            IdCaja = Configuracion.CajaLocal;
            MarcarComoDropDownButton.Enabled = false;
            AlumnoPago.BuscarVisible = true;
        }
        #endregion

        #region Eventos Generales
        private void CajaForma_Load(object sender, EventArgs e)
        {
            try
            {
                PagoActualDataSet.DetallePago.DescripcionColumn.Expression = MetodosGenerales.ExpresionDetallePago;

                dtParametro = ParametroServicio.SeleccionarTodos();

                ValorIVA = Convert.ToDecimal(MetodosGenerales.BuscarValorParametro("IVA", dtParametro));
                ValorMensualidad = Convert.ToDecimal(MetodosGenerales.BuscarValorParametro("ValorMensualidad", dtParametro));
                ValorConferencia = Convert.ToDecimal(MetodosGenerales.BuscarValorParametro("ValorConferencia", dtParametro));

                // Llenar meses
                MesCursoComboBox.DataSource = MetodosGenerales.Meses();
                MesNivelComboBox.DataSource = MetodosGenerales.Meses();
                AnoNivelComboBox.DataSource = MetodosGenerales.TresAnos();
                AnoCursoComboBox.DataSource = MetodosGenerales.TresAnos();
                MesCursoComboBox.SelectedValue = DateTime.Today.Month;
                MesNivelComboBox.SelectedValue = DateTime.Today.Month;
                AnoNivelComboBox.SelectedValue = DateTime.Today.Year;
                AnoCursoComboBox.SelectedValue = DateTime.Today.Year;

                RubroComboBox.DataSource = PedirRubros();
                ConferenciaComboBox.DataSource = PedirConferencias();
                MotivoPagoComboBox.DataSource = MetodosGenerales.PedirMotivosPago();
                TipoAbonoComboBox.DataSource = MetodosGenerales.PedirTiposAbono();

                EmpresaDatos = new EmpresaInformacion(MetodosGenerales.BuscarValorParametro("Empresa", dtParametro),
                                                        MetodosGenerales.BuscarValorParametro("Dirección", dtParametro),
                                                        MetodosGenerales.BuscarValorParametro("Teléfono", dtParametro),
                                                        MetodosGenerales.BuscarValorParametro("RUC", dtParametro));

                IdUsuario = FormaContenedora.IdUsuario;

                IVALabel.Text = string.Format("IVA {0}%", ValorIVA);
                IdCierreDeCaja = CierreDeCajaServicio.PedirIdCierreDeCajaxIdCajaIdUsuario(IdCaja, IdUsuario);

                if (IdCierreDeCaja.HasValue)
                {
                    switch (IdCierreDeCaja.Value)
                    {
                        case 0:
                            if (Preguntar("Desea abrir la caja en este momento ?").Equals(DialogResult.Yes))
                                IdCierreDeCaja = CierreDeCajaServicio.AbrirCaja(IdCaja, IdUsuario);
                            else
                                throw new Exception("La Apertura ha sido cancelada por el Usuario.");
                            break;
                        case -1:
                            throw new Exception("La caja se encuentra abierta por otro usuario.");
                    }
                }
                else
                {
                    throw new Exception("La caja o el usuario no existen o no están activos.");
                }

                // Inicialización de Pagos Realizados
                IniciarPagosRealizados();

                HabilitacionNumericUpDown(CantidadNumericUpDown, false);
                HabilitacionNumericUpDown(ValorNumericUpDown, false);
                HabilitacionNumericUpDown(IVANumericUpDown, false);
                //HabilitacionNumericUpDown(DescuentoNumericUpDown, false);
                HabilitacionNumericUpDown(PVPNumericUpDown, false);
                DetallePagoVentana.QuitarVisualizacion();
                PagoActualDataSet.DetallePago.Clear();
                AlumnoPago.Focus(); /**/
            }
            catch (Exception ex)
            {
                CerrarFormaAlCargar = true;
                MostrarMensaje("No se puede abrir la Caja.", ex);
            }
        }

        private void GrabarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroDocumento = "";
                if (PagoActualDataSet.Pago.Rows.Count == 0)
                {
                    PagoDataSet.PagoRow pr = PagoActualDataSet.Pago.NewPagoRow();
                    pr.Id = 0;
                    pr.IdCierreDeCaja = IdCierreDeCaja.Value;
                    if (AlumnoPago.ValidarAlumnoEscogido())
                        pr.IdAlumno = AlumnoPago.IdAlumno.Value;
                    else
                        return;

                    int idSecuencia = 0;
                    if (ConFactura.Checked)
                    {
                        pr.NumeroDocumento = PedirNuevoNumeroDocumentoPago(TipoDocumentoPago.Factura, ref idSecuencia);
                        pr.IdSecuencia = idSecuencia;
                        pr.Estado = (int)EstadoPago.Facturado;
                        pr.TipoDocumentoPago = (int)TipoDocumentoPago.Factura;
                    }
                    else if (ConNotaDeVenta.Checked)
                    {
                        pr.NumeroDocumento = PedirNuevoNumeroDocumentoPago(TipoDocumentoPago.NotaDeVenta, ref idSecuencia);
                        pr.IdSecuencia = idSecuencia;
                        pr.Estado = (int)EstadoPago.Facturado;
                        pr.TipoDocumentoPago = (int)TipoDocumentoPago.Factura;
                    }
                    pr.FormaPago = (int)FormasPago.Efectivo;
                    pr.Fecha = DateTime.Now;
                    pr.Observacion = "";
                    PagoActualDataSet.Pago.Rows.Add(pr);
                    numeroDocumento = pr.NumeroDocumento;
                }

                if ((PagoActualDataSet.DetallePago == null) || (PagoActualDataSet.DetallePago.Rows.Count > 0))
                {
                    PagoServicio.InsertarNivel(PagoActualDataSet);
                    DocumentoPagoImpreso facturaPago = new DocumentoPagoImpreso(PagoActualDataSet, AlumnoPago.AlumnoFila, EmpresaDatos);

                    //Impresión de Factura
                    ImpresionPrevia(numeroDocumento, facturaPago.Factura_PrintPage, 100);

                    ReiniciarPago();
                    LlenarPagos();
                    DetallePagoGroupBox.Enabled = false;
                }
                else
                    MostrarMensaje("Debe ingresar el detalle de pago antes de guardar.");
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se pudo grabar el Pago", ex);
            }
        }

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            ReiniciarPago();
        }

        private void PagoTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PagoTabControl.SelectedTab == RegistroTabPage)
            {
                GrabarBoton.Enabled = true;
                LimpiarBoton.Enabled = true;
                ImprimirBoton.Enabled = false;
                MarcarComoDropDownButton.Enabled = false;
            }
            else if (PagoTabControl.SelectedTab == PagosRealizadosTabPage)
            {
                GrabarBoton.Enabled = false;
                LimpiarBoton.Enabled = false;
                ImprimirBoton.Enabled = true;
                MarcarComoDropDownButton.Enabled = true;
            }
        }

        private void AlumnoPago_AlumnoEncontrado(object sender, EventArgs e)
        {
            try
            {
                DetallePagoGroupBox.Enabled = true;
                int idAlumno = AlumnoPago.IdAlumno.Value;

                // Horarios Cursos
                HorarioAlumnoDataSet.HorarioAlumnoDataTable dtHorariosCurso = HorarioAlumnoServicio.SeleccionarxIdAlumno(idAlumno, 1, true);
                dtHorariosCurso.Columns.Add("NombreHorario", typeof(string), MetodosGenerales.ExpresionHorarioNombre);
                MetodosGenerales.AdicionarTextoHorario(dtHorariosCurso, "(Seleccione)", 0);
                HorarioCursoComboBox.DataSource = dtHorariosCurso;

                // Horarios Nivel
                HorarioAlumnoDataSet.HorarioAlumnoDataTable dtHorarioNivel = HorarioAlumnoServicio.SeleccionarxIdAlumno(idAlumno, 2, true);
                dtHorarioNivel.Columns.Add("NombreHorario", typeof(string), MetodosGenerales.ExpresionHorarioNombre);
                MetodosGenerales.AdicionarTextoHorario(dtHorarioNivel, "(Seleccione)", 0);
                HorarioNivelComboBox.DataSource = dtHorarioNivel;
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se puede recuperar la información de alumno", ex);
            }
        }

        private void PagosForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CerrarFormaAlCargar)
                if (Preguntar("Desea salir de la Caja de Pagos ?").Equals(DialogResult.No))
                    e.Cancel = true;
        }
        #endregion

        #region Eventos DetallePagos
        private void MotivoPagoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CantidadNumericUpDown.Value = 1;
            DescuentoNumericUpDown.Value = 0;

            MensualidadCursoPanel.Visible = false;
            MensualidadNivelPanel.Visible = false;
            ConferenciaPanel.Visible = false;
            RubroPanel.Visible = false;
            TipoAbonoComboBox.SelectedValue = TipoAbono.Completo;

            switch ((MotivoPago)MotivoPagoComboBox.SelectedValue)
            {
                case MotivoPago.MensualidadCurso:
                    MensualidadCursoPanel.Visible = true;
                    HabilitacionNumericUpDown(CantidadNumericUpDown, false);
                    ValorNumericUpDown.Value = ValorMensualidad;
                    IVANumericUpDown.Value = 0;
                    DescuentoNumericUpDown.Value = 0;
                    TipoAbonoComboBox.Enabled = true;
                    ActualizarValores();
                    break;
                case MotivoPago.MensualidadNivel:
                    MensualidadNivelPanel.Visible = true;
                    HabilitacionNumericUpDown(CantidadNumericUpDown, false);
                    ValorNumericUpDown.Value = ValorMensualidad;
                    IVANumericUpDown.Value = 0;
                    DescuentoNumericUpDown.Value = 0;
                    TipoAbonoComboBox.Enabled = true;
                    ActualizarValores();
                    break;
                case MotivoPago.Conferencia:
                    HabilitacionNumericUpDown(CantidadNumericUpDown, true);
                    ConferenciaPanel.Visible = true;
                    ValorNumericUpDown.Value = ValorConferencia;
                    IVANumericUpDown.Value = 0;
                    ActualizarValores();
                    CantidadNumericUpDown.Enabled = true;
                    TipoAbonoComboBox.Enabled = false;
                    break;
                case MotivoPago.Rubro:
                    HabilitacionNumericUpDown(CantidadNumericUpDown, true);
                    RubroPanel.Visible = true;
                    RubroDataSet.RubroRow rrow = dtRubros.FindById((int)RubroComboBox.SelectedValue);
                    ValorNumericUpDown.Value = rrow.Valor;
                    IVANumericUpDown.Value = rrow.IVA;
                    ActualizarValores();
                    CantidadNumericUpDown.Enabled = true;
                    TipoAbonoComboBox.Enabled = false;
                    break;
            }
        }

        private void RubroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RubroDataSet.RubroRow rrow = dtRubros.FindById((int)RubroComboBox.SelectedValue);
            ValorNumericUpDown.Value = rrow.Valor;
            IVANumericUpDown.Value = rrow.IVA;
            ActualizarValores();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (DetallePagosDataGrid.DataSource == null)
            {
                this.TipoAbonoTextoColumn.ValueMember = "Valor";
                this.TipoAbonoTextoColumn.DisplayMember = "Texto";
                this.TipoAbonoTextoColumn.ValueType = typeof(int);
                this.TipoAbonoTextoColumn.DataSource = MetodosGenerales.PedirTiposAbono();

                DetallePagosDataGrid.DataSource = PagoActualDataSet.DetallePago;
                DetallePagosDataGrid.Columns["PVPColumn"].DisplayIndex = 6;
                DetallePagosDataGrid.Columns["Id"].Visible = false;
                DetallePagosDataGrid.Columns["IdPago"].Visible = false;
                DetallePagosDataGrid.Columns["IdMotivoPago"].Visible = false;
                DetallePagosDataGrid.Columns["IdRubro"].Visible = false;
                DetallePagosDataGrid.Columns["Rubro"].Visible = false;
                DetallePagosDataGrid.Columns["IdConferencia"].Visible = false;
                DetallePagosDataGrid.Columns["Conferencia"].Visible = false;
                DetallePagosDataGrid.Columns["HorarioNombre"].Visible = false;
                DetallePagosDataGrid.Columns["IdHorarioAlumno"].Visible = false;
                DetallePagosDataGrid.Columns["MesPago"].Visible = false;
                DetallePagosDataGrid.Columns["Area"].Visible = false;
                DetallePagosDataGrid.Columns["Nivel"].Visible = false;
            }

            PagoDataSet.DetallePagoRow dprow = PagoActualDataSet.DetallePago.NewDetallePagoRow();
            dprow.IdPago = 1;
            dprow.Cantidad = Convert.ToInt32(CantidadNumericUpDown.Value);
            dprow.Valor = Math.Round(ValorNumericUpDown.Value, 3);
            dprow.IVA = Math.Round(IVANumericUpDown.Value, 3);
            dprow.PVP = Math.Round(PVPNumericUpDown.Value, 3);
            dprow.Descuento = Convert.ToInt32(DescuentoNumericUpDown.Value);
            dprow.TipoAbono = (int)TipoAbonoComboBox.SelectedValue;
            dprow.IdMotivoPago = (int)MotivoPagoComboBox.SelectedValue;
            switch ((MotivoPago)MotivoPagoComboBox.SelectedValue)
            {
                case MotivoPago.MensualidadCurso:
                    if (!ValidarMensualidadCurso())
                    {
                        dprow.IdHorarioAlumno = (int)HorarioCursoComboBox.SelectedValue;
                        dprow.MesPago = new DateTime((int)AnoCursoComboBox.SelectedValue, (int)MesCursoComboBox.SelectedValue, 1);

                        dprow.IdRubro = 0;
                        dprow.IdConferencia = 0;

                        dprow.HorarioNombre = HorarioCursoComboBox.Text;

                        PagoActualDataSet.DetallePago.Rows.Add(dprow);
                        LlenarTotales();
                    }
                    break;
                case MotivoPago.MensualidadNivel:
                    if (!ValidarMensualidadNivel())
                    {
                        dprow.IdHorarioAlumno = (int)HorarioNivelComboBox.SelectedValue;
                        dprow.MesPago = new DateTime((int)AnoCursoComboBox.SelectedValue, (int)MesCursoComboBox.SelectedValue, 1);

                        dprow.IdRubro = 0;
                        dprow.IdConferencia = 0;

                        dprow.HorarioNombre = HorarioNivelComboBox.Text;

                        PagoActualDataSet.DetallePago.Rows.Add(dprow);
                        LlenarTotales();
                    }
                    break;
                case MotivoPago.Conferencia:
                    if (!ValidarConferencia())
                    {
                        dprow.IdConferencia = (int)ConferenciaComboBox.SelectedValue;

                        dprow.IdRubro = 0;
                        dprow.IdHorarioAlumno = 0;
                        dprow.MesPago = new DateTime();

                        dprow.Conferencia = ConferenciaComboBox.Text;
                        PagoActualDataSet.DetallePago.Rows.Add(dprow);
                        LlenarTotales();
                    }
                    break;
                case MotivoPago.Rubro:
                    if (!ValidarRubro())
                    {
                        dprow.IdRubro = (int)RubroComboBox.SelectedValue;

                        dprow.IdConferencia = 0;
                        dprow.IdHorarioAlumno = 0;
                        dprow.MesPago = new DateTime();

                        dprow.Rubro = RubroComboBox.Text;

                        PagoActualDataSet.DetallePago.Rows.Add(dprow);
                        LlenarTotales();
                    }
                    break;
            }
        }

        private void BorrarDetalleButton_Click(object sender, EventArgs e)
        {
            MotivoPagoComboBox.SelectedValue = MotivoPago.Rubro;
            ConferenciaComboBox.SelectedValue = 0;
            RubroComboBox.SelectedValue = 0;
            CantidadNumericUpDown.Text = "0";
            IVANumericUpDown.Text = "0";
            PVPNumericUpDown.Text = "0";
            ValorNumericUpDown.Text = "0";
            DescuentoNumericUpDown.Text = "0";
            // Otros campos
        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ActualizarValores();
        }

        private void DescuentoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ActualizarValores();
        }

        private void ValorNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ActualizarValores();
        }

        private void TipoAbonoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((TipoAbono)TipoAbonoComboBox.SelectedValue)
            {
                case TipoAbono.Completo:
                    switch ((MotivoPago)MotivoPagoComboBox.SelectedValue)
                    { 
                        case MotivoPago.MensualidadCurso:
                            ValorNumericUpDown.Value = ValorMensualidad;
                            break;
                        case MotivoPago.MensualidadNivel:
                            ValorNumericUpDown.Value = ValorMensualidad;
                            break;
                        case MotivoPago.Conferencia:
                            ValorNumericUpDown.Value = ValorConferencia;
                            break;
                        case MotivoPago.Rubro:
                            RubroComboBox_SelectedIndexChanged(sender, e);
                            break;
                    }
                    HabilitacionNumericUpDown(ValorNumericUpDown, false);
                    break;
                case TipoAbono.Parcial:
                    HabilitacionNumericUpDown(ValorNumericUpDown, true);
                    break;
            }
        }
        #endregion

        #region Eventos PagosDataGrid
        private void PagosDataGrid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            LlenarTotales();
        }
        #endregion

        #region Métodos
        private void LlenarTotales()
        {
            int totalItems = 0;
            decimal totalValor = 0;
            decimal totalIVA = 0;
            decimal totalPagar = 0;
            foreach (PagoDataSet.DetallePagoRow dpr in PagoActualDataSet.DetallePago)
            {
                totalItems += dpr.Cantidad;
                totalValor += dpr.Valor;
                totalIVA += dpr.IVA;
                totalPagar += dpr.PVP;
            }
            TotalItemsTextBox.Text = totalItems.ToString();
            TotalValorTextBox.Text = Math.Round(totalValor, 2).ToString();
            TotalIVATextBox.Text = Math.Round(totalIVA, 2).ToString();
            TotalPagarTextBox.Text = Math.Round(totalPagar, 2).ToString();
        }

        private void ActualizarValores()
        {
            decimal valorPagar = (CantidadNumericUpDown.Value * (ValorNumericUpDown.Value + IVANumericUpDown.Value));
            decimal descuento = valorPagar * DescuentoNumericUpDown.Value / 100;
            PVPNumericUpDown.Value = valorPagar - descuento;
        }

        private DataTable PedirRubros()
        {
            // Subrutina de Pedir Rubros Activos.
            dtRubros = RubroServicio.SeleccionarActivos();

            // Agregar la fila de Selección
            RubroDataSet.RubroRow drSeleccionar = dtRubros.NewRubroRow();
            drSeleccionar.Id = 0;
            drSeleccionar.Nombre = "(Seleccione)";
            drSeleccionar.Descripcion = "";
            drSeleccionar.PVP = 0;
            drSeleccionar.Valor = 0;
            drSeleccionar.IVA = 0;
            drSeleccionar.TieneIVA = false;
            drSeleccionar.Activo = true;
            dtRubros.Rows.InsertAt(drSeleccionar, 0);

            return dtRubros;
        }

        private DataTable PedirConferencias()
        {
            // Subrutina de Pedir Conferencias Activas.
            dtConferencias = ConferenciaServicio.SeleccionarActivos();

            // Agregar la fila de Selección
            ConferenciaDataSet.ConferenciaRow drSeleccionar = dtConferencias.NewConferenciaRow();
            drSeleccionar.Id = 0;
            drSeleccionar.Nombre = "(Seleccione)";
            drSeleccionar.Activo = true;
            drSeleccionar.Fecha = DateTime.Today;
            drSeleccionar.Instructor = "";
            dtConferencias.Rows.InsertAt(drSeleccionar, 0);

            return dtConferencias;
        }

        private string PedirNuevoNumeroDocumentoPago(TipoDocumentoPago tipoDocumentoPago, ref int idSecuencia)
        {
            SecuenciaImpresionDataSet.SecuenciaImpresionRow sir = SecuenciaServicio.PedirNuevoNumeroSecuencia((int)tipoDocumentoPago)[0];
            idSecuencia = sir.Id;
            return DocumentoPagoImpreso.NumeroFacturaImpresion(sir.Prefijo, sir.ValorUsado, sir.NumCaracteres);
        }

        private void ReiniciarPago()
        {
            AlumnoPago.Limpiar();
            PagoActualDataSet.Clear();
            TotalItemsTextBox.Text = "0";
            TotalIVATextBox.Text = "0";
            TotalPagarTextBox.Text = "0";
            TotalValorTextBox.Text = "0";
            AlumnoPago.Focus();
        }

        private bool ValidarCampos()
        {
            bool datosCorrectos = true;
            MarcaError.Clear();
            if (!AlumnoPago.ValidarAlumnoEscogido()) datosCorrectos = false;
            return datosCorrectos;
        }

        private void HabilitacionNumericUpDown(NumericUpDown control, bool habilitar)
        {
            control.ReadOnly = !habilitar;
            control.Increment = (habilitar) ? 1 : 0;
        }
        #endregion

        #region Métodos Validación DetallePagos
        private bool ValidarRubro()
        {
            MarcaError.Clear();
            if (ValidarComboBox(RubroComboBox))
                return false;
            return true;
        }

        private bool ValidarConferencia()
        {
            MarcaError.Clear();
            if (ValidarComboBox(ConferenciaComboBox))
                return false;
            return true;
        }

        private bool ValidarMensualidadCurso()
        {
            MarcaError.Clear();
            if (ValidarComboBox(HorarioCursoComboBox))
                return false;
            return true;
        }

        private bool ValidarMensualidadNivel()
        {
            MarcaError.Clear();
            if (ValidarComboBox(HorarioNivelComboBox))
                return false;
            return true;
        }
        #endregion
    }
}
