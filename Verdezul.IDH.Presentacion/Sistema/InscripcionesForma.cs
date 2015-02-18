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
    public partial class InscripcionesForma : FormaBase
    {
        #region Campos
        private HorarioAlumnoManager objHorarioAlumno;
        private ParametroManager objParametro;
        private HorarioAlumnoDataSet.HorarioAlumnoDataTable HorarioAlumnosDataTable;
        private int _IdHorarioAlumno = 0;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        ToolStripButton NuevoBoton;
        #endregion

        #region Constructores e Inicialización
        public InscripcionesForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public InscripcionesForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = IdUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("GrabarBoton", "Grabar", Imagenes.Grabar, Grabar_Click);
            BorrarBoton = AgregarBotonAccion("BorrarBoton", "Borrar", Imagenes.Borrar, Borrar_Click);
            LimpiarBoton = AgregarBotonAccion("LimpiarBoton", "Limpiar", Imagenes.Limpiar, LimpiarBoton_Click);
            NuevoBoton = AgregarBotonAccion("NuevoBoton", "Nuevo", Imagenes.Nuevo, NuevoBoton_Click);
            objHorarioAlumno = new HorarioAlumnoManager();
            objParametro = new ParametroManager();
            HorarioAlumnosDataTable = new HorarioAlumnoDataSet.HorarioAlumnoDataTable();
        }
        #endregion

        #region Eventos
        private void InscripcionesForma_Load(object sender, EventArgs e)
        {
            try
            {
                HorarioCombos.CargarDatos();
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
                    HorarioCombos.LimpiarCursoHorario();
                    _IdHorarioAlumno = 0;
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
                    if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                    {
                        try
                        {
                            objHorarioAlumno.Borrar(_IdHorarioAlumno);
                            HorarioCombos.LimpiarCursoHorario();
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
            HorarioCombos.Enabled = true;
            HorarioCombos.SetIdCurso(0);
            InicioDateTimePicker.Enabled = true;
            CerrarInscripcionCheckBox.Enabled = true;
            CerrarInscripcionCheckBox.Checked = false;
            ActivoCheckBox.Checked = true;
            PagosInt.Text = "0";
        }

        private void HorarioAlumnosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MarcaError.Clear();
                HorarioAlumnoDataSet.HorarioAlumnoRow dr = (HorarioAlumnosDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as HorarioAlumnoDataSet.HorarioAlumnoRow;
                bool existeHorario = true;
                try
                {
                    HorarioCombos.SetIdHorario(dr.IdHorario);
                }
                catch
                {
                    if (Preguntar("No se puede editar este horario por estar inactivo, desea cambiarlo ?").Equals(DialogResult.Yes))
                    {
                        HorarioCombos.SetIdHorario(0);
                        existeHorario = true;
                    }
                    else
                    {
                        HorarioCombos.LimpiarCursoHorario();
                        existeHorario = false;
                        _IdHorarioAlumno = 0;
                    }
                }

                if (existeHorario)
                {
                    _IdHorarioAlumno = dr.Id;
                    InicioDateTimePicker.Value = dr.FechaInicio;
                    CerrarInscripcionCheckBox.Checked = !dr.IsFechaFinNull();
                    if (!dr.IsFechaFinNull()) FinDateTimePicker.Value = dr.FechaFin;
                    ActivoCheckBox.Checked = dr.Activo;
                    PagosInt.Text = dr["NumeroPagos"].ToString();
                    MarcaError.Clear();

                    // Revisión de Datos posibles de cambio
                    // Sin Pago - Abierto/Cerrado -> Todos los datos cambiables
                    // Con Pago - Abierto -> FechaFin
                    // Con Pago - Cerrado -> Nada

                    HorarioCombos.Enabled = dr["NumeroPagos"].Equals(0);
                    InicioDateTimePicker.Enabled = dr["NumeroPagos"].Equals(0);
                    FinDateTimePicker.Enabled = dr["NumeroPagos"].Equals(0);
                    CerrarInscripcionCheckBox.Enabled = (dr["NumeroPagos"].Equals(0) || dr.IsFechaFinNull());

                    if (!dr.IsFechaFinNull() && !dr["NumeroPagos"].Equals(0))
                        MostrarMensaje("No puede modificar la información por encontrarse registrados pagos.");
                }
            }
        }

        private void CerrarInscripcionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FinDateTimePicker.Enabled = CerrarInscripcionCheckBox.Checked;
        }

        private void AlumnoHorario_AlumnoEncontrado(object sender, EventArgs e)
        {
            if (TraerDatos(AlumnoHorario.IdAlumno.Value))
            {
                HorarioCombos.Enabled = true;
                ActivoCheckBox.Enabled = true;
                InicioDateTimePicker.Enabled = true;
                CerrarInscripcionCheckBox.Enabled = true;
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos(int idAlumno)
        {
            try
            {
                HorarioAlumnosDataTable = objHorarioAlumno.SeleccionarxIdAlumno(idAlumno);
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
            HorarioCombos.SetIdCurso(0);
            HorarioCombos.Enabled = false;
            ActivoCheckBox.Enabled = false;
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
            cr.IdHorario = HorarioCombos.GetIdHorario();
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

            if (!HorarioCombos.ValidarHorario()) datosCorrectos = false;
            if (!AlumnoHorario.ValidarAlumnoEscogido()) datosCorrectos = false;

            return datosCorrectos;
        }

        private void ConfigurarDataGrid()
        {
            HorarioAlumnosDataGridView.Columns["Id"].Visible = false;
            HorarioAlumnosDataGridView.Columns["IdAlumno"].Visible = false;
            HorarioAlumnosDataGridView.Columns["IdHorario"].Visible = false;
            HorarioAlumnosDataGridView.Columns["Activo"].Width = 40;
            HorarioAlumnosDataGridView.Columns["Activo"].SortMode = DataGridViewColumnSortMode.Automatic;
            HorarioAlumnosDataGridView.Columns["HoraInicio"].HeaderText = "H.I.";
            HorarioAlumnosDataGridView.Columns["HoraInicio"].Width = 40;
            HorarioAlumnosDataGridView.Columns["HoraFin"].HeaderText = "H.F.";
            HorarioAlumnosDataGridView.Columns["HoraFin"].Width = 40;
            HorarioAlumnosDataGridView.Columns["Curso"].Width = 220;
            HorarioAlumnosDataGridView.Columns["Docente"].Width = 120;
            HorarioAlumnosDataGridView.Columns["Dias"].Width = 120;
            HorarioAlumnosDataGridView.Columns["Dias"].HeaderText = "Días";
            HorarioAlumnosDataGridView.Columns["Aula"].Width = 50;
            HorarioAlumnosDataGridView.Columns["HoraInicio"].DefaultCellStyle.Format = MetodosGenerales.FormatoHoraEnHorario;
            HorarioAlumnosDataGridView.Columns["HoraFin"].DefaultCellStyle.Format = MetodosGenerales.FormatoHoraEnHorario;
            HorarioAlumnosDataGridView.Columns["FechaInicio"].HeaderText = "Mes Inicio";
            HorarioAlumnosDataGridView.Columns["FechaInicio"].DefaultCellStyle.Format = MetodosGenerales.FormatoMesAnio;
            HorarioAlumnosDataGridView.Columns["FechaFin"].HeaderText = "Mes Fin";
            HorarioAlumnosDataGridView.Columns["FechaFin"].DefaultCellStyle.Format = MetodosGenerales.FormatoMesAnio;
            HorarioAlumnosDataGridView.Columns["NumeroPagos"].Width = 40;
            HorarioAlumnosDataGridView.Columns["FechaInicio"].Width = 75;
            HorarioAlumnosDataGridView.Columns["FechaFin"].Width = 75;
            HorarioAlumnosDataGridView.Columns["NumeroPagos"].HeaderText = "Pagos";
            HorarioAlumnosDataGridView.Columns["FechaInicio"].DisplayIndex = 12;
            HorarioAlumnosDataGridView.Columns["FechaFin"].DisplayIndex = 12;
            HorarioAlumnosDataGridView.Columns["Activo"].DisplayIndex = 12;
        }
        #endregion
    }
}