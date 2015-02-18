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

namespace Verdezul.IDH.Presentacion.Administracion
{
    public partial class ConferenciaForma : FormaBase
    {
        #region Campos
        private ConferenciaManager objConferencia;
        private ParametroManager objParametro;
        private ConferenciaDataSet.ConferenciaDataTable ConferenciasDataTable;
        private int _IdConferencia = 0;
        private decimal ValorIVA = 0;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public ConferenciaForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public ConferenciaForma(int idUsuario)
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

            objConferencia = new ConferenciaManager();
            objParametro = new ParametroManager();
            ConferenciasDataTable = new ConferenciaDataSet.ConferenciaDataTable();
        }
        #endregion

        #region Eventos
        private void ConferenciaForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                ConferenciasDataGridView.Columns["Nombre"].HeaderText = "Conferencia";
                ConferenciasDataGridView.Columns["Nombre"].Width = 200;
                ConferenciasDataGridView.Columns["Instructor"].HeaderText = "Instructor";
                ConferenciasDataGridView.Columns["Instructor"].Width = 160;
                ConferenciasDataGridView.Columns["Fecha"].HeaderText = "Fecha";
                ConferenciasDataGridView.Columns["Fecha"].Width = 80;
                ConferenciasDataGridView.Columns["Activo"].Width = 40;
                ConferenciasDataGridView.Columns["Activo"].SortMode = DataGridViewColumnSortMode.Automatic;

                ConferenciasDataGridView.Columns["Id"].Visible = false;

            }
            else
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
            if (_IdConferencia != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objConferencia.Borrar(_IdConferencia);
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

        private void ConferenciasDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ConferenciaDataSet.ConferenciaRow dr = (ConferenciasDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as ConferenciaDataSet.ConferenciaRow;
                _IdConferencia = dr.Id;
                NombreTextBox.Text = dr.Nombre;
                InstructorTextBox.Text = dr.Instructor;
                Activo.Checked = dr.Activo;
                FechaDateTimePicker.Value = dr.Fecha;
                MarcaError.Clear();
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                ConferenciasDataTable = objConferencia.SeleccionarTodos();
                ConferenciasDataGridView.DataSource = ConferenciasDataTable;
                ValorIVA = Convert.ToDecimal(objParametro.SeleccionarxNombre("IVA"));
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
            _IdConferencia = 0;
            NombreTextBox.Text = "";
            InstructorTextBox.Text = "";
            FechaDateTimePicker.Value = DateTime.Today;
            Activo.Checked = true;
        }

        private void GrabarDatos()
        {
            ConferenciaDataSet cds = new ConferenciaDataSet();
            ConferenciaDataSet.ConferenciaRow cr = cds.Conferencia.NewConferenciaRow();
            cr.Nombre = NombreTextBox.Text;
            cr.Instructor = InstructorTextBox.Text;
            cr.Fecha = FechaDateTimePicker.Value.Date;
            cr.Activo = Activo.Checked;

            cds.Conferencia.Rows.Add(cr);
            try
            {
                if (_IdConferencia == 0)
                    _IdConferencia = objConferencia.Insertar(cds);
                else
                {
                    cr.Id = _IdConferencia;
                    objConferencia.Modificar(cds);
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

            if (!ValidarTextBox(NombreTextBox)) datosCorrectos = false;
            if (!ValidarTextBox(InstructorTextBox)) datosCorrectos = false;

            return datosCorrectos;
        }
        #endregion
    }
}