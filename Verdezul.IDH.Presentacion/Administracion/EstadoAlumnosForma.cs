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
    public partial class EstadoAlumnoForma : FormaBase
    {
        #region Campos
        private EstadoAlumnoManager objEstadoAlumno;
        private ParametroManager objParametro;
        private EstadoAlumnoDataSet.EstadoAlumnoDataTable EstadoAlumnosDataTable;
        private int _IdEstadoAlumno = 0;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public EstadoAlumnoForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public EstadoAlumnoForma(int idUsuario)
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

            objEstadoAlumno = new EstadoAlumnoManager();
            objParametro = new ParametroManager();
            EstadoAlumnosDataTable = new EstadoAlumnoDataSet.EstadoAlumnoDataTable();
        }
        #endregion

        #region Eventos
        private void EstadoAlumnoForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                EstadoAlumnosDataGridView.Columns["Nombre"].HeaderText = "Estado";
                EstadoAlumnosDataGridView.Columns["Nombre"].Width = 200;

                EstadoAlumnosDataGridView.Columns["Id"].Visible = false;

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
            if (_IdEstadoAlumno != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objEstadoAlumno.Borrar(_IdEstadoAlumno);
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

        private void EstadoAlumnosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                EstadoAlumnoDataSet.EstadoAlumnoRow dr = (EstadoAlumnosDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as EstadoAlumnoDataSet.EstadoAlumnoRow;
                _IdEstadoAlumno = dr.Id;
                NombreTextBox.Text = dr.Nombre;
                MarcaError.Clear();
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                EstadoAlumnosDataTable = objEstadoAlumno.SeleccionarTodos();
                EstadoAlumnosDataGridView.DataSource = EstadoAlumnosDataTable;
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
            _IdEstadoAlumno = 0;
            NombreTextBox.Text = "";
        }

        private void GrabarDatos()
        {
            EstadoAlumnoDataSet cds = new EstadoAlumnoDataSet();
            EstadoAlumnoDataSet.EstadoAlumnoRow cr = cds.EstadoAlumno.NewEstadoAlumnoRow();
            cr.Nombre = NombreTextBox.Text;

            cds.EstadoAlumno.Rows.Add(cr);
            try
            {
                if (_IdEstadoAlumno == 0)
                    _IdEstadoAlumno = objEstadoAlumno.Insertar(cds);
                else
                {
                    cr.Id = _IdEstadoAlumno;
                    objEstadoAlumno.Modificar(cds);
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

            return datosCorrectos;
        }
        #endregion
    }
}