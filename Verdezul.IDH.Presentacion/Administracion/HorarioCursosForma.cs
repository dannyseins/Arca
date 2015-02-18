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

namespace Verdezul.IDH.Presentacion.Administracion
{
    public partial class HorarioCursosForma : FormaBase
    {
        #region Campos
        private HorarioManager objHorario;
        private HorarioDataSet.HorarioDataTable HorariosDataTable;
        private int _IdHorario = 0;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public HorarioCursosForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public HorarioCursosForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = IdUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("Grabar", "Grabar", Imagenes.Grabar, Grabar_Click);
            BorrarBoton = AgregarBotonAccion("Borrar", "Borrar", Imagenes.Borrar, Borrar_Click);
            LimpiarBoton = AgregarBotonAccion("Limpiar", "Limpiar", Imagenes.Limpiar, LimpiarBoton_Click);

            objHorario = new HorarioManager();
            HorariosDataTable = new HorarioDataSet.HorarioDataTable();
        }
        #endregion

        #region Eventos
        private void HorarioCursosForma_Load(object sender, EventArgs e)
        {
            if (!TraerDatos())
                CerrarFormaAlCargar = true;
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    GrabarDatos();
                    //MostrarMensaje("Grabación Correcta");
                    LimpiarCampos();
                    TraerDatos();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se guardaron los datos", ex);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (_IdHorario != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objHorario.Borrar(_IdHorario);
                        LimpiarCampos();
                        TraerDatos();
                    }
                    catch (Exception ex)
                    {
                        MostrarMensaje("No se pudo borrar", ex);
                    }
                }
            }
        }

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void HorariosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                HorarioDataSet.HorarioRow dr = (HorariosDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as HorarioDataSet.HorarioRow;
                _IdHorario = dr.Id;
                CursoComboBox.SelectedValue = dr.IdCurso;
                AulaComboBox.SelectedValue = dr.IdAula;
                DocenteComboBox.SelectedValue = dr.IdDocente;
                HoraInicioMaskedTextBox.Text = dr.HoraInicio.ToString("HH:mm");
                HoraFinMaskedTextBox.Text = dr.HoraFin.ToString("HH:mm");
                Activo.Checked = dr.Activo;

                for (int i = 0; i < DiasCheckedListBox.Items.Count; i++)
                    DiasCheckedListBox.SetItemChecked(i, false);

                foreach (string dia in dr.Dias.Split(','))
                {
                    DiasCheckedListBox.SetItemChecked(DiasCheckedListBox.Items.IndexOf(dia.Trim()), true);
                }
                MarcaError.Clear();
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                HorariosDataTable = objHorario.SeleccionarxTipoHorario(1);
                HorariosDataGridView.DataSource = HorariosDataTable;

                CampoFilaAdicional idCampoAdicional = new CampoFilaAdicional("Id", 0);
                CampoFilaAdicional nombreCampoAdicional = new CampoFilaAdicional("Nombre", "(Seleccione)");
                CampoFilaAdicional activoCampoAdicional = new CampoFilaAdicional("Activo", true);

                CursoManager objCurso = new CursoManager();
                CursoDataSet.CursoDataTable cursoDataTable = objCurso.SeleccionarActivos();
                MetodosGenerales.AgregarFila(cursoDataTable, 0,
                    idCampoAdicional,
                    nombreCampoAdicional,
                    activoCampoAdicional);
                CursoComboBox.DataSource = cursoDataTable;

                AulaManager objAula = new AulaManager();
                AulaDataSet.AulaDataTable aulaDataTable = objAula.SeleccionarActivos();
                MetodosGenerales.AgregarFila(aulaDataTable, 0,
                    idCampoAdicional,
                    nombreCampoAdicional,
                    activoCampoAdicional);
                AulaComboBox.DataSource = aulaDataTable;

                DocenteManager objDocente = new DocenteManager();
                DocenteDataSet.DocenteDataTable docenteDataTable = objDocente.SeleccionarActivos();
                MetodosGenerales.AgregarFila(docenteDataTable, 0,
                    idCampoAdicional,
                    nombreCampoAdicional,
                    activoCampoAdicional,
                    new CampoFilaAdicional("Apellido", ""));
                DocenteComboBox.DataSource = docenteDataTable;
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
            _IdHorario = 0;
            CursoComboBox.SelectedValue = 0;
            AulaComboBox.SelectedValue = 0;
            DocenteComboBox.SelectedValue = 0;
            HoraInicioMaskedTextBox.Text = "00:00";
            HoraFinMaskedTextBox.Text = "00:00";
            Activo.Checked = true;
            for (int i = 0; i < DiasCheckedListBox.Items.Count; i++)
                DiasCheckedListBox.SetItemChecked(i, false);
            MarcaError.Clear();
        }

        private void GrabarDatos()
        {
            HorarioDataSet cds = new HorarioDataSet();
            HorarioDataSet.HorarioRow cr = cds.Horario.NewHorarioRow();
            cr.IdNivel = 0;
            cr.IdCurso = (int)CursoComboBox.SelectedValue;
            cr.IdAula = (int)AulaComboBox.SelectedValue;
            cr.IdDocente = (int)DocenteComboBox.SelectedValue;
            cr.HoraInicio = DateTime.Parse(HoraInicioMaskedTextBox.Text);
            cr.HoraFin = DateTime.Parse(HoraFinMaskedTextBox.Text);
            cr.TipoHorario = 1;
            cr.Activo = Activo.Checked;

            List<string> diasSeleccionados = new List<string>();
            foreach (object obj in DiasCheckedListBox.CheckedItems)
            {
                diasSeleccionados.Add(obj.ToString());
            }
            cr.Dias = string.Join(",", diasSeleccionados.ToArray());

            cds.Horario.Rows.Add(cr);
            try
            {
                if (_IdHorario == 0)
                    _IdHorario = objHorario.Insertar(cds);
                else
                {
                    cr.Id = _IdHorario;
                    objHorario.Modificar(cds);
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

            if (!ValidarComboBox(CursoComboBox)) datosCorrectos = false;
            if (!ValidarComboBox(AulaComboBox)) datosCorrectos = false;
            if (!ValidarComboBox(DocenteComboBox)) datosCorrectos = false;
            if (DiasCheckedListBox.CheckedItems.Count == 0)
            {
                MarcaError.SetError(DiasCheckedListBox, "Escoja al menos un día.");
                datosCorrectos = false;
            }

            DateTime horaInicio;
            try
            {
                horaInicio = (DateTime)HoraInicioMaskedTextBox.ValidateText();
            }
            catch
            {
                MarcaError.SetError(HoraInicioMaskedTextBox, "Hora no válida");
                return false;
            }

            DateTime horaFin;
            try
            {
                horaFin = (DateTime)HoraFinMaskedTextBox.ValidateText();
            }
            catch
            {
                MarcaError.SetError(HoraFinMaskedTextBox, "Hora no válida");
                return false;
            }

            if ((DateTime)HoraInicioMaskedTextBox.ValidateText() >= (DateTime)HoraFinMaskedTextBox.ValidateText())
            {
                MarcaError.SetError(HoraFinMaskedTextBox, "La hora de fin debe ser mayor a la de inicio.");
                datosCorrectos = false;
            }

            return datosCorrectos;
        }

        private void ConfigurarDataGrid()
        {
            HorariosDataGridView.Columns["Curso"].DisplayIndex = 1;
            HorariosDataGridView.Columns["Curso"].Width = 220;
            HorariosDataGridView.Columns["Docente"].DisplayIndex = 2;
            HorariosDataGridView.Columns["Docente"].Width = 120;
            HorariosDataGridView.Columns["Aula"].DisplayIndex = 3;
            HorariosDataGridView.Columns["Aula"].Width = 50;
            HorariosDataGridView.Columns["HoraInicio"].HeaderText = "Inicio";
            HorariosDataGridView.Columns["HoraInicio"].Width = 40;
            HorariosDataGridView.Columns["HoraInicio"].DisplayIndex = 4;
            HorariosDataGridView.Columns["HoraInicio"].DefaultCellStyle.Format = MetodosGenerales.FormatoHoraEnHorario;
            HorariosDataGridView.Columns["HoraFin"].HeaderText = "Fin";
            HorariosDataGridView.Columns["HoraFin"].Width = 40;
            HorariosDataGridView.Columns["HoraFin"].DefaultCellStyle.Format = MetodosGenerales.FormatoHoraEnHorario;
            HorariosDataGridView.Columns["HoraFin"].DisplayIndex = 5;
            HorariosDataGridView.Columns["Dias"].HeaderText = "Días";
            HorariosDataGridView.Columns["Dias"].DisplayIndex = 6;
            HorariosDataGridView.Columns["Activo"].Width = 40;
            HorariosDataGridView.Columns["Activo"].SortMode = DataGridViewColumnSortMode.Automatic;
            HorariosDataGridView.Columns["Activo"].DisplayIndex = 7;

            HorariosDataGridView.Columns["Id"].Visible = false;
            HorariosDataGridView.Columns["IdCurso"].Visible = false;
            HorariosDataGridView.Columns["IdAula"].Visible = false;
            HorariosDataGridView.Columns["IdDocente"].Visible = false;
            HorariosDataGridView.Columns["TipoHorario"].Visible = false;
            HorariosDataGridView.Columns["IdNivel"].Visible = false;
            HorariosDataGridView.Columns["Area"].Visible = false;
            HorariosDataGridView.Columns["Nivel"].Visible = false;
            HorariosDataGridView.Columns["NombreHorario"].Visible = false;
        }
        #endregion
    }
}