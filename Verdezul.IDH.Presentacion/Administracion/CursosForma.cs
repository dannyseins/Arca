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
    public partial class CursosForma : FormaBase
    {
        #region Campos
        private CursoManager objCurso;
        private ParametroManager objParametro;
        private CursoDataSet.CursoDataTable CursosDataTable;
        private int _IdCurso = 0;
        private decimal ValorIVA = 0;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public CursosForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public CursosForma(int idUsuario)
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

            objCurso = new CursoManager();
            objParametro = new ParametroManager();
            CursosDataTable = new CursoDataSet.CursoDataTable();
        }
        #endregion

        #region Eventos
        private void CursoForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                CursosDataGridView.Columns["Nombre"].HeaderText = "Curso";
                CursosDataGridView.Columns["Nombre"].Width = 200;
                CursosDataGridView.Columns["Activo"].Width = 40;
                CursosDataGridView.Columns["Activo"].SortMode = DataGridViewColumnSortMode.Automatic;

                CursosDataGridView.Columns["Id"].Visible = false;

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
            if (_IdCurso != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objCurso.Borrar(_IdCurso);
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

        private void CursosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CursoDataSet.CursoRow dr = (CursosDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as CursoDataSet.CursoRow;
                _IdCurso = dr.Id;
                NombreTextBox.Text = dr.Nombre;
                Activo.Checked = dr.Activo;
                MarcaError.Clear();
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                CursosDataTable = objCurso.SeleccionarTodos();
                CursosDataGridView.DataSource = CursosDataTable;
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
            _IdCurso = 0;
            NombreTextBox.Text = "";
            Activo.Checked = true;
        }

        private void GrabarDatos()
        {
            CursoDataSet cds = new CursoDataSet();
            CursoDataSet.CursoRow cr = cds.Curso.NewCursoRow();
            cr.Nombre = NombreTextBox.Text;
            cr.Activo = Activo.Checked;

            cds.Curso.Rows.Add(cr);
            try
            {
                if (_IdCurso == 0)
                    _IdCurso = objCurso.Insertar(cds);
                else
                {
                    cr.Id = _IdCurso;
                    objCurso.Modificar(cds);
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