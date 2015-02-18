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
    public partial class CajaForma : FormaBase
    {
        #region Campos
        private CajaManager objCaja;
        private CajaDataSet.CajaDataTable CajasDataTable;
        #endregion

        #region Propiedades
        private int _IdCaja = 0;
        public int IdCaja
        { get { return _IdCaja; } }
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public CajaForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public CajaForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("Grabar", "Grabar", Imagenes.Grabar, Grabar_Click);
            BorrarBoton = AgregarBotonAccion("Borrar", "Borrar", Imagenes.Borrar, Borrar_Click);
            LimpiarBoton = AgregarBotonAccion("Limpiar", "Limpiar", Imagenes.Limpiar, LimpiarBoton_Click);

            objCaja = new CajaManager();
            CajasDataTable = new CajaDataSet.CajaDataTable();
        }
        #endregion

        #region Eventos
        private void CajaForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                CajasDataGridView.Columns["Id"].HeaderText = "#";
                CajasDataGridView.Columns["Id"].Width = 20;
                CajasDataGridView.Columns["Nombre"].HeaderText = "Caja";
                CajasDataGridView.Columns["Nombre"].Width = 200;
                CajasDataGridView.Columns["Observacion"].HeaderText = "Observación";
                CajasDataGridView.Columns["Observacion"].Width = 200;
                CajasDataGridView.Columns["IP"].HeaderText = "IP";
                CajasDataGridView.Columns["IP"].Width = 80;
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
            if (_IdCaja != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objCaja.Borrar(_IdCaja);
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

        private void CajasDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CajaDataSet.CajaRow dr = (CajasDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as CajaDataSet.CajaRow;
                _IdCaja = dr.Id;
                NombreTextBox.Text = dr.Nombre;
                ObservacionTextBox.Text = dr.Observacion;
                IPTextBox.Text = dr.IP;
                IdLabel.Text = _IdCaja.ToString();
                MarcaError.Clear();
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                CajasDataTable = objCaja.SeleccionarTodos();
                CajasDataGridView.DataSource = CajasDataTable;
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
            _IdCaja = 0;
            NombreTextBox.Text = "";
            ObservacionTextBox.Text = "";
            IPTextBox.Text = "";
            IdLabel.Text = "";
        }

        private void GrabarDatos()
        {
            CajaDataSet cds = new CajaDataSet();
            CajaDataSet.CajaRow cr = cds.Caja.NewCajaRow();
            cr.Nombre = NombreTextBox.Text;
            cr.Observacion = ObservacionTextBox.Text;
            cr.IP = IPTextBox.Text;
            cds.Caja.Rows.Add(cr);
            try
            {
                if (_IdCaja == 0)
                    _IdCaja = objCaja.Insertar(cds);
                else
                {
                    cr.Id = _IdCaja;
                    objCaja.Modificar(cds);
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