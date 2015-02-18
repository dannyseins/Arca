using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Business;
using Verdezul.IDH.Configuracion;

namespace Verdezul.IDH.Presentacion.Sistema
{
    public partial class AlumnoNivelForma : FormaBase
    {
        #region Campos
        private HorarioAlumnoManager objHorarioAlumno;
        private ParametroManager objParametro;
        private HorarioAlumnoDataSet.HorarioAlumnoDataTable HorarioAlumnosDataTable;
        private int _IdHorarioAlumno = 0;
        private HorarioDataSet.HorarioDataTable HorariosDataTable;
        private HorarioManager HorarioServicio;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton UsarHorarioBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        ToolStripButton NuevoBoton;
        #endregion

        #region Constructores e Inicialización
        public AlumnoNivelForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public AlumnoNivelForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = IdUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("GrabarBoton", "Grabar", Imagenes.Grabar, Grabar_Click);
            UsarHorarioBoton = AgregarBotonAccion("UsarHorarioBoton", "Activar", Imagenes.UsarSecuencia, UsarHorarioBoton_Click);
            BorrarBoton = AgregarBotonAccion("BorrarBoton", "Borrar", Imagenes.Borrar, Borrar_Click);
            LimpiarBoton = AgregarBotonAccion("LimpiarBoton", "Limpiar", Imagenes.Limpiar, LimpiarBoton_Click);
            NuevoBoton = AgregarBotonAccion("NuevoBoton", "Nuevo", Imagenes.Nuevo, NuevoBoton_Click);

            objHorarioAlumno = new HorarioAlumnoManager();
            objParametro = new ParametroManager();
            HorarioAlumnosDataTable = new HorarioAlumnoDataSet.HorarioAlumnoDataTable();
            HorarioServicio = new HorarioManager();
        }
        #endregion

        #region Eventos
        private void AlumnoNivelForma_Load(object sender, EventArgs e)
        {
            try
            {
                HorariosDataTable = HorarioServicio.SeleccionarxTipoHorario(2);
                AreaNivelCombos.CargarDatos();
                HorarioNivelAreaActualLabel.Text = "";
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se pudo cargar los datos", ex);
                CerrarFormaAlCargar = true;
            }
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    GrabarDatos();
                    //MostrarMensaje("Grabación Correcta");
                    AreaNivelCombos.LimpiarAreaNivel();
                    HorarioNivelComboBox.SelectedValue = 0;
                    _IdHorarioAlumno = 0;
                    MostrarInfoNivelAlumno();

                    TraerDatos(AlumnoHorario.IdAlumno.Value);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se guardaron los datos", ex);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (_IdHorarioAlumno != 0)
            {
                if (int.Parse(PagosInt.Text) == 0)
                {
                    if (!ActivoCheckBox.Checked)
                    {
                        if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                        {
                            try
                            {
                                objHorarioAlumno.Borrar(_IdHorarioAlumno);
                                AreaNivelCombos.LimpiarAreaNivel();
                                HorarioNivelComboBox.SelectedValue = 0;
                                ActivoCheckBox.Checked = false;
                                ActivoCheckBox.Enabled = false;
                                _IdHorarioAlumno = 0;
                                TraerDatos(AlumnoHorario.IdAlumno.Value);
                            }
                            catch (Exception ex)
                            {
                                MostrarMensaje("No se pudo borrar", ex);
                            }
                        }
                    }
                    else
                        MostrarMensaje("No se puede borrar este nivel por ser el nivel activo.");
                }
                else
                    MostrarMensaje("No se puede borrar este registro por registrar pagos ya hechos.");
            }
        }

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            _IdHorarioAlumno = 0;
            AreaNivelCombos.Enabled = true;
            AreaNivelCombos.SetIdNivel(0);
            HorarioNivelComboBox.Enabled = true;
            HorarioNivelComboBox.SelectedValue = 0;
            InicioDateTimePicker.Enabled = true;
            CerrarInscripcionCheckBox.Enabled = true;
            CerrarInscripcionCheckBox.Checked = false;
            ActivoCheckBox.Checked = false;
            PagosInt.Text = "0";
        }

        private void UsarHorarioBoton_Click(object sender, EventArgs e)
        {
            if (_IdHorarioAlumno != 0)
            {
                if (Preguntar("Está seguro que desea usar este nivel como activo ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objHorarioAlumno.CambiarNivel(
                            AlumnoHorario.IdAlumno.Value,
                            _IdHorarioAlumno,
                            new DateTime(InicioDateTimePicker.Value.Year, InicioDateTimePicker.Value.Month, 1),
                            new DateTime());
                        ActivoCheckBox.Checked = true;
                        MostrarInfoNivelAlumno();

                        TraerDatos(AlumnoHorario.IdAlumno.Value);
                    }
                    catch (Exception ex)
                    {
                        MostrarMensaje("No se pudo borrar", ex);
                    }
                }
            }
        }

        private void CerrarInscripcionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FinDateTimePicker.Enabled = CerrarInscripcionCheckBox.Checked;
        }

        private void AreaNivelCombos_NivelCambiado(object sender, EventArgs e)
        {
            HorarioNivelComboBox.DataSource = MetodosGenerales.FiltrarHorariosxNivel(AreaNivelCombos.GetIdNivel(), HorariosDataTable);
        }

        private void HorarioAlumnosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MarcaError.Clear();
                HorarioAlumnoDataSet.HorarioAlumnoRow dr = (HorarioAlumnosDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as HorarioAlumnoDataSet.HorarioAlumnoRow;
                AreaNivelCombos.SetIdNivel((int)dr["IdNivel"]);
                HorarioNivelComboBox.SelectedValue = dr.IdHorario;
                _IdHorarioAlumno = dr.Id;
                InicioDateTimePicker.Value = dr.FechaInicio;
                CerrarInscripcionCheckBox.Checked = !dr.IsFechaFinNull();
                if (!dr.IsFechaFinNull()) FinDateTimePicker.Value = dr.FechaFin;
                ActivoCheckBox.Checked = dr.Activo;
                ActivoCheckBox.Enabled = dr.Activo;
                PagosInt.Text = dr["NumeroPagos"].ToString();
                MarcaError.Clear();

                // Revisión de Datos posibles de cambio
                // Sin Pago - Abierto/Cerrado -> Todos los datos cambiables
                // Con Pago - Abierto -> FechaFin
                // Con Pago - Cerrado -> Nada

                AreaNivelCombos.Enabled = dr["NumeroPagos"].Equals(0);
                HorarioNivelComboBox.Enabled = dr["NumeroPagos"].Equals(0);
                InicioDateTimePicker.Enabled = dr["NumeroPagos"].Equals(0);
                FinDateTimePicker.Enabled = dr["NumeroPagos"].Equals(0);
                CerrarInscripcionCheckBox.Enabled = (dr["NumeroPagos"].Equals(0) || dr.IsFechaFinNull());

                if (!dr.IsFechaFinNull() && !dr["NumeroPagos"].Equals(0))
                    MostrarMensaje("No puede modificar la información por encontrarse registrados pagos.");
            }
        }

        private void AlumnoHorario_AlumnoEncontrado(object sender, EventArgs e)
        {
            if (TraerDatos(AlumnoHorario.IdAlumno.Value))
            {
                AreaNivelCombos.Enabled = true;
                InicioDateTimePicker.Enabled = true;
                CerrarInscripcionCheckBox.Enabled = true;
                HorarioNivelComboBox.Enabled = true;
                MostrarInfoNivelAlumno();
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos(int idAlumno)
        {
            try
            {
                HorarioAlumnosDataTable = objHorarioAlumno.SeleccionarxIdAlumno(idAlumno, 2, false);
                HorarioAlumnosDataGridView.DataSource = HorarioAlumnosDataTable;
                ConfigurarDataGrid();
                return true;
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se pudo recuperar los datos", ex);
                return false;
            }
        }

        private void LimpiarCampos()
        {
            _IdHorarioAlumno = 0;
            AlumnoHorario.Limpiar();
            AreaNivelCombos.SetIdArea(0);
            AreaNivelCombos.SetIdNivel(0);
            AreaNivelCombos.Enabled = false;
            HorarioNivelComboBox.SelectedValue = 0;
            HorarioNivelComboBox.Enabled = false;
            HorarioNivelAreaActualLabel.Text = "";
            ActivoCheckBox.Checked = false;
            InicioDateTimePicker.Enabled = false;
            CerrarInscripcionCheckBox.Enabled = false;
            CerrarInscripcionCheckBox.Checked = false;
            HorarioAlumnosDataGridView.DataSource = null;
            PagosInt.Text = "0";
            MarcaError.Clear();
        }

        private void GrabarDatos()
        {
            HorarioAlumnoDataSet cds = new HorarioAlumnoDataSet();
            HorarioAlumnoDataSet.HorarioAlumnoRow cr = cds.HorarioAlumno.NewHorarioAlumnoRow();
            cr.IdAlumno = AlumnoHorario.IdAlumno.Value;
            cr.IdHorario = (int)HorarioNivelComboBox.SelectedValue;
            cr.FechaInicio = new DateTime(InicioDateTimePicker.Value.Year, InicioDateTimePicker.Value.Month, 1);
            if (CerrarInscripcionCheckBox.Checked)
                cr.FechaFin = new DateTime(FinDateTimePicker.Value.Year, FinDateTimePicker.Value.Month, 1);
            else
                cr.FechaFin = new DateTime();

            cr.Activo = ActivoCheckBox.Checked;

            cds.HorarioAlumno.Rows.Add(cr);
            try
            {
                if (_IdHorarioAlumno == 0)
                    _IdHorarioAlumno = objHorarioAlumno.Insertar(cds);
                else
                {
                    cr.Id = _IdHorarioAlumno;
                    objHorarioAlumno.Modificar(cds);
                }
            }
            catch
            {
                throw;
            }
        }

        private bool ValidarCampos()
        {
            bool datosCorrectos = true;
            MarcaError.Clear();

            if (!ValidarComboBox(HorarioNivelComboBox)) datosCorrectos = false;
            if (!AlumnoHorario.ValidarAlumnoEscogido()) datosCorrectos = false;

            return datosCorrectos;
        }

        private void ConfigurarDataGrid()
        {
            HorarioAlumnosDataGridView.Columns["Id"].Visible = false;
            HorarioAlumnosDataGridView.Columns["IdAlumno"].Visible = false;
            HorarioAlumnosDataGridView.Columns["IdHorario"].Visible = false;
            HorarioAlumnosDataGridView.Columns["Curso"].Visible = false;
            HorarioAlumnosDataGridView.Columns["IdNivel"].Visible = false;
            HorarioAlumnosDataGridView.Columns["Nivel"].HeaderText = "Área/Nivel";
            HorarioAlumnosDataGridView.Columns["Activo"].Width = 40;
            HorarioAlumnosDataGridView.Columns["Activo"].SortMode = DataGridViewColumnSortMode.Automatic;
            HorarioAlumnosDataGridView.Columns["HoraInicio"].HeaderText = "H.I.";
            HorarioAlumnosDataGridView.Columns["HoraInicio"].Width = 40;
            HorarioAlumnosDataGridView.Columns["HoraFin"].HeaderText = "H.F.";
            HorarioAlumnosDataGridView.Columns["HoraFin"].Width = 40;
            HorarioAlumnosDataGridView.Columns["Docente"].Width = 120;
            HorarioAlumnosDataGridView.Columns["Dias"].Width = 120;
            HorarioAlumnosDataGridView.Columns["Dias"].HeaderText = "Días";
            HorarioAlumnosDataGridView.Columns["Aula"].Width = 50;
            HorarioAlumnosDataGridView.Columns["HoraInicio"].DefaultCellStyle.Format = MetodosGenerales.FormatoHoraEnHorario;
            HorarioAlumnosDataGridView.Columns["HoraFin"].DefaultCellStyle.Format = MetodosGenerales.FormatoHoraEnHorario;
            HorarioAlumnosDataGridView.Columns["FechaInicio"].HeaderText = "Mes Inicio";
            HorarioAlumnosDataGridView.Columns["FechaInicio"].DefaultCellStyle.Format = MetodosGenerales.FormatoMesAnio;
            HorarioAlumnosDataGridView.Columns["FechaInicio"].Width = 75;
            HorarioAlumnosDataGridView.Columns["FechaFin"].HeaderText = "Mes Fin";
            HorarioAlumnosDataGridView.Columns["FechaFin"].DefaultCellStyle.Format = MetodosGenerales.FormatoMesAnio;
            HorarioAlumnosDataGridView.Columns["FechaFin"].Width = 75;
            HorarioAlumnosDataGridView.Columns["NumeroPagos"].Width = 40;
            HorarioAlumnosDataGridView.Columns["NumeroPagos"].HeaderText = "Pagos";
            HorarioAlumnosDataGridView.Columns["FechaInicio"].DisplayIndex = 12;
            HorarioAlumnosDataGridView.Columns["FechaFin"].DisplayIndex = 12;
            HorarioAlumnosDataGridView.Columns["Activo"].DisplayIndex = 12;
        }

        private void MostrarInfoNivelAlumno()
        {
            HorarioAlumnoDataSet.HorarioAlumnoDataTable hadt = objHorarioAlumno.PedirHorarioyNivelxAlumno(AlumnoHorario.IdAlumno.Value);
            if (hadt.Rows.Count > 0)
            {
                AreaNivelCombos.SetIdNivel((int)hadt[0]["IdNivel"]);
                HorarioNivelComboBox.SelectedValue = hadt[0].IdHorario;
                HorarioNivelAreaActualLabel.Text = string.Format("Actualmente en : {0} / {1} - {2}",
                    AreaNivelCombos.GetNombreArea(),
                    AreaNivelCombos.GetNombreNivel(),
                    HorarioNivelComboBox.Text);
                ActivoCheckBox.Checked = hadt[0].Activo;
                ActivoCheckBox.Enabled = hadt[0].Activo;
                _IdHorarioAlumno = hadt[0].Id;
            }
            else
            {
                AreaNivelCombos.SetIdArea(0);
                AreaNivelCombos.SetIdNivel(0);
                HorarioNivelComboBox.SelectedValue = 0;
                HorarioNivelAreaActualLabel.Text = "";
            }
        }
        #endregion
    }
}