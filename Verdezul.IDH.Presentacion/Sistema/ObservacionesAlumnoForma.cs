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
    public partial class ObservacionesAlumnoForma : FormaBase
    {
        #region Campos
        private DocenteManager objDocente;
        private ParametroManager objParametro;
        private ObservacionManager objObservacion;
        private ObservacionDataSet.ObservacionDataTable ObservacionsDataTable;
        private int _IdObservacion = 0;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public ObservacionesAlumnoForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public ObservacionesAlumnoForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = IdUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("Grabar", "Grabar", Imagenes.Grabar, Grabar_Click);
            //BorrarBoton = AgregarBotonAccion("Borrar", "Borrar", Imagenes.Borrar, Borrar_Click);
            LimpiarBoton = AgregarBotonAccion("Limpiar", "Limpiar", Imagenes.Limpiar, LimpiarBoton_Click);

            objDocente = new DocenteManager();
            objParametro = new ParametroManager();
            objObservacion = new ObservacionManager();
            ObservacionsDataTable = new ObservacionDataSet.ObservacionDataTable();
        }
        #endregion

        #region Eventos
        private void InscripcionesForma_Load(object sender, EventArgs e)
        {
            DocenteDataSet.DocenteDataTable ddt = objDocente.SeleccionarTodos();
            ddt.Columns.Add("NombreCompleto", typeof(string), "[Nombre]+' ' +[Apellido]");
            DocenteDataSet.DocenteRow drow = ddt.NewDocenteRow();
            drow.Id = 0;
            drow.Nombre = "(Seleccione)";
            drow.Apellido = "";
            drow.Activo = true;
            ddt.Rows.InsertAt(drow, 0);
            DocenteComboBox.DataSource = ddt;
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    GrabarDatos();
                    //MostrarMensaje("Grabación Correcta");
                    _IdObservacion = 0;
                    DocenteComboBox.SelectedValue = 0;
                    TextoAbiertoTextBox.Text = "";
                    FechaObservacionDateTimePicker.Value = DateTime.Today;
                    TraerDatos(AlumnoObservacion.IdAlumno.Value);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se guardaron los datos", ex);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (_IdObservacion != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objObservacion.Borrar(_IdObservacion);
                        _IdObservacion = 0;
                        DocenteComboBox.SelectedValue = 0;
                        TextoAbiertoTextBox.Text = "";
                        FechaObservacionDateTimePicker.Value = DateTime.Today;
                        TraerDatos(AlumnoObservacion.IdAlumno.Value);
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

        private void ObservacionsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ObservacionDataSet.ObservacionRow dr = (ObservacionsDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as ObservacionDataSet.ObservacionRow;
                _IdObservacion = dr.Id;
                DocenteComboBox.SelectedValue = dr.IdDocente;
                FechaObservacionDateTimePicker.Value = dr.Fecha;
                TextoAbiertoTextBox.Text = dr.TextoAbierto;
                MarcaError.Clear();
            }
        }

        private void AlumnoObservacion_AlumnoEncontrado(object sender, EventArgs e)
        {
            if (TraerDatos(AlumnoObservacion.IdAlumno.Value))
            {
                DocenteComboBox.Enabled = true;
                FechaObservacionDateTimePicker.Enabled = true;
                TextoAbiertoTextBox.Enabled = true;
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos(int idAlumno)
        {
            try
            {
                ObservacionsDataTable = objObservacion.SeleccionarxIdAlumno(idAlumno);
                ObservacionsDataGridView.DataSource = ObservacionsDataTable;
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
            _IdObservacion = 0;
            AlumnoObservacion.Limpiar();
            FechaObservacionDateTimePicker.Value = DateTime.Today;
            FechaObservacionDateTimePicker.Enabled = false;
            TextoAbiertoTextBox.Text = "";
            TextoAbiertoTextBox.Enabled = false;
            DocenteComboBox.SelectedValue = 0;
            DocenteComboBox.Enabled = false;
            ObservacionsDataGridView.DataSource = null;
            MarcaError.Clear();
        }

        private void GrabarDatos()
        {
            ObservacionDataSet cds = new ObservacionDataSet();
            ObservacionDataSet.ObservacionRow cr = cds.Observacion.NewObservacionRow();
            cr.IdAlumno = AlumnoObservacion.IdAlumno.Value;
            cr.IdDocente = (int)DocenteComboBox.SelectedValue;
            cr.TextoAbierto = TextoAbiertoTextBox.Text;
            cr.Fecha = FechaObservacionDateTimePicker.Value;

            cds.Observacion.Rows.Add(cr);
            try
            {
                if (_IdObservacion == 0)
                    _IdObservacion = objObservacion.Insertar(cds);
                else
                {
                    cr.Id = _IdObservacion;
                    objObservacion.Modificar(cds);
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

            if (!AlumnoObservacion.ValidarAlumnoEscogido()) datosCorrectos = false;
            if (!ValidarComboBox(DocenteComboBox)) datosCorrectos = false;
            if (TextoAbiertoTextBox.Text == "") datosCorrectos = false;
            return datosCorrectos;
        }

        private void ConfigurarDataGrid()
        {
            ObservacionsDataGridView.Columns["Id"].Visible = false;
            ObservacionsDataGridView.Columns["IdAlumno"].Visible = false;
            ObservacionsDataGridView.Columns["IdDocente"].Visible = false;
            ObservacionsDataGridView.Columns["TextoAbierto"].Width = 400;
            ObservacionsDataGridView.Columns["Fecha"].Width = 70;
            ObservacionsDataGridView.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            ObservacionsDataGridView.Columns["Docente"].Width = 100;
        }
        #endregion
    }
}