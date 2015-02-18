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

namespace Verdezul.IDH.Presentacion.Seguridad
{
    public partial class ParametrosForma : FormaBase
    {
        #region Campos
        private ParametroManager objParametro;
        private ParametroDataSet.ParametroDataTable ParametrosDataTable;
        #endregion

        #region Propiedades
        private int _IdParametro = 0;
        public int IdParametro
        { get { return _IdParametro; } }
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public ParametrosForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public ParametrosForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("Grabar", "Grabar", Imagenes.Grabar, GrabarBoton_Click);
            LimpiarBoton = AgregarBotonAccion("Limpiar", "Limpiar", Imagenes.Limpiar, LimpiarBoton_Click);

            objParametro = new ParametroManager();
            ParametrosDataTable = new ParametroDataSet.ParametroDataTable();
        }
        #endregion

        #region Eventos
        private void ParametroForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                ParametrosDataGridView.Columns["Nombre"].HeaderText = "Parámetro";
                ParametrosDataGridView.Columns["Nombre"].Width = 120;
                ParametrosDataGridView.Columns["Valor"].HeaderText = "Valor";
                ParametrosDataGridView.Columns["Valor"].Width = 180;
                ParametrosDataGridView.Columns["Descripcion"].HeaderText = "Descripción";
                ParametrosDataGridView.Columns["Descripcion"].Width = 270;
                ParametrosDataGridView.Columns["Tipo"].HeaderText = "Tipo de Dato";
                ParametrosDataGridView.Columns["Tipo"].Width = 100;
                ParametrosDataGridView.Columns["Id"].Visible = false;
                GrabarBoton.Enabled = false;
            }
            else
                CerrarFormaAlCargar = true;
        }

        private void GrabarBoton_Click(object sender, EventArgs e)
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

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void ParametrosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ParametroDataSet.ParametroRow dr = (ParametrosDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as ParametroDataSet.ParametroRow;
                _IdParametro = dr.Id;
                NombreLabel.Text = dr.Nombre;
                DescripcionLabel.Text = dr.Descripcion;
                ValorTextBox.Text = dr.Valor;
                TipoLabel.Text = dr.Tipo;
                ValorTextBox.Tag = dr.Tipo;
                GrabarBoton.Enabled = true;
                MarcaError.Clear();
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                ParametrosDataTable = objParametro.SeleccionarTodos();
                ParametrosDataGridView.DataSource = ParametrosDataTable;
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
            _IdParametro = 0;
            NombreLabel.Text = "";
            DescripcionLabel.Text = "";
            ValorTextBox.Text = "";
            TipoLabel.Text = "";
            ValorTextBox.Tag = null;
            GrabarBoton.Enabled = false;
        }

        private void GrabarDatos()
        {
            ParametroDataSet cds = new ParametroDataSet();
            ParametroDataSet.ParametroRow cr = cds.Parametro.NewParametroRow();
            cr.Nombre = NombreLabel.Text;
            cr.Descripcion = DescripcionLabel.Text;
            cr.Valor = Convert.ChangeType(ValorTextBox.Text, Type.GetType(ValorTextBox.Tag.ToString())).ToString(); 
            cr.Tipo = TipoLabel.Text;
            cds.Parametro.Rows.Add(cr);
            try
            {
                //if (_IdParametro == 0)
                //    _IdParametro = objParametro.Insertar(cds);
                //else
                {
                    cr.Id = _IdParametro;
                    objParametro.Modificar(cds);
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

            if (!ValidarTextBox(ValorTextBox)) datosCorrectos = false;

            return datosCorrectos;
        }
        #endregion
    }
}