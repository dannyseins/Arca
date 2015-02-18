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
    public partial class DocentesForma : FormaBase
    {
        #region Campos
        private DocenteManager objDocente;
        private ParametroManager objParametro;
        private DocenteDataSet.DocenteDataTable DocentesDataTable;
        private int _IdDocente = 0;
        private decimal ValorIVA = 0;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public DocentesForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public DocentesForma(int idUsuario)
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

            objDocente = new DocenteManager();
            objParametro = new ParametroManager();
            DocentesDataTable = new DocenteDataSet.DocenteDataTable();
        }
        #endregion

        #region Eventos
        private void DocenteForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                DocentesDataGridView.Columns["Nombre"].HeaderText = "Docente";
                DocentesDataGridView.Columns["Nombre"].Width = 200;
                DocentesDataGridView.Columns["Apellido"].HeaderText = "Instructor";
                DocentesDataGridView.Columns["Apellido"].Width = 160;
                DocentesDataGridView.Columns["Activo"].Width = 40;
                DocentesDataGridView.Columns["Activo"].SortMode = DataGridViewColumnSortMode.Automatic;

                DocentesDataGridView.Columns["Id"].Visible = false;

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
            if (_IdDocente != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objDocente.Borrar(_IdDocente);
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

        private void DocentesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DocenteDataSet.DocenteRow dr = (DocentesDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as DocenteDataSet.DocenteRow;
                _IdDocente = dr.Id;
                NombreTextBox.Text = dr.Nombre;
                ApellidoTextBox.Text = dr.Apellido;
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
                DocentesDataTable = objDocente.SeleccionarTodos();
                DocentesDataGridView.DataSource = DocentesDataTable;
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
            _IdDocente = 0;
            NombreTextBox.Text = "";
            ApellidoTextBox.Text = "";
            Activo.Checked = true;
        }

        private void GrabarDatos()
        {
            DocenteDataSet cds = new DocenteDataSet();
            DocenteDataSet.DocenteRow cr = cds.Docente.NewDocenteRow();
            cr.Nombre = NombreTextBox.Text;
            cr.Apellido = ApellidoTextBox.Text;
            cr.Activo = Activo.Checked;

            cds.Docente.Rows.Add(cr);
            try
            {
                if (_IdDocente == 0)
                    _IdDocente = objDocente.Insertar(cds);
                else
                {
                    cr.Id = _IdDocente;
                    objDocente.Modificar(cds);
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
            if (!ValidarTextBox(ApellidoTextBox)) datosCorrectos = false;

            return datosCorrectos;
        }
        #endregion
    }
}