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
    public partial class SecuenciasForma : FormaBase
    {
        #region Campos
        private SecuenciaImpresionManager objSecuenciaImpresion;
        private SecuenciaImpresionDataSet.SecuenciaImpresionDataTable SecuenciaImpresionsDataTable;
        #endregion

        #region Propiedades
        private int _IdSecuenciaImpresion = 0;
        public int IdSecuenciaImpresion
        { get { return _IdSecuenciaImpresion; } }
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton PonerEnUsoBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public SecuenciasForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            this.GrabarBoton.Visible = true;
        }

        public SecuenciasForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            this.GrabarBoton.Visible = true;
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("Grabar", "Grabar", Imagenes.Grabar, Grabar_Click);
            BorrarBoton = AgregarBotonAccion("Borrar", "Borrar", Imagenes.Borrar, Borrar_Click);
            PonerEnUsoBoton = AgregarBotonAccion("PonerEnUso", "Usar Secuencia", Imagenes.UsarSecuencia, PonerEnUsoBoton_Click);
            LimpiarBoton = AgregarBotonAccion("Limpiar", "Limpiar", Imagenes.Limpiar, LimpiarBoton_Click);

            objSecuenciaImpresion = new SecuenciaImpresionManager();
            SecuenciaImpresionsDataTable = new SecuenciaImpresionDataSet.SecuenciaImpresionDataTable();
            TipoDocumentoComboBox.DataSource = MetodosGenerales.PedirTiposDocumentoPago();
            TipoDocumentoColumn.ValueMember = "Valor";
            TipoDocumentoColumn.DisplayMember = "Texto";
            TipoDocumentoColumn.DataPropertyName = "TipoDocumentoPago";
            TipoDocumentoColumn.DataSource = MetodosGenerales.PedirTiposDocumentoPago();
        }
        #endregion

        #region Eventos
        private void SecuenciaImpresionForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                SecuenciaImpresionsDataGridView.Columns["ValorInicio"].HeaderText = "Inicio";
                SecuenciaImpresionsDataGridView.Columns["ValorInicio"].Width = 50;
                SecuenciaImpresionsDataGridView.Columns["ValorFin"].HeaderText = "Fin";
                SecuenciaImpresionsDataGridView.Columns["ValorFin"].Width = 50;
                SecuenciaImpresionsDataGridView.Columns["ValorUsado"].HeaderText = "Actual";
                SecuenciaImpresionsDataGridView.Columns["ValorUsado"].Width = 50;
                SecuenciaImpresionsDataGridView.Columns["NumCaracteres"].HeaderText = "Longitud";
                SecuenciaImpresionsDataGridView.Columns["NumCaracteres"].Width = 50;
                SecuenciaImpresionsDataGridView.Columns["EnUso"].HeaderText = "En Uso";
                SecuenciaImpresionsDataGridView.Columns["EnUso"].Width = 50;
                SecuenciaImpresionsDataGridView.Columns["EnUso"].SortMode = DataGridViewColumnSortMode.Automatic;
                SecuenciaImpresionsDataGridView.Columns["Cerrado"].Width = 50;
                SecuenciaImpresionsDataGridView.Columns["Cerrado"].SortMode = DataGridViewColumnSortMode.Automatic;
                SecuenciaImpresionsDataGridView.Columns["Prefijo"].Width = 45;

                SecuenciaImpresionsDataGridView.Columns["Id"].Visible = false;
                SecuenciaImpresionsDataGridView.Columns["Fecha"].Visible = false;
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
            if (_IdSecuenciaImpresion != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        if ((!EnUso.Checked) && (!Cerrado.Checked) && (!ValorUsadoNumericUpDown.Value.Equals("0")))
                        {
                            objSecuenciaImpresion.Borrar(_IdSecuenciaImpresion);
                            LimpiarCampos();
                            TraerDatos();
                        }
                        else
                        {
                            MostrarMensaje(string.Format("No se puede borrar esta secuencia por todas o algunas de las siguientes razones:\n{0}{1}{2}",
                                "- La secuencia se encuentra marcada como 'En Uso'\n",
                                "- La secuencia ya ha sido cerrada\n", 
                                "- La secuencia fue usada alguna vez (aunque no esté en uso)"));
                        }
                    }
                    catch (Exception ex)
                    {
                        MostrarMensaje("No se pudo borrar", ex);
                    }
                }
            }
        }

        private void PonerEnUsoBoton_Click(object sender, EventArgs e)
        {
            if (_IdSecuenciaImpresion != 0)
            {
                if (Preguntar("Sólo puede tener una secuencia activa a la vez" +  
                        "\nla anterior quedará inactiva. " + 
                        "\nEstá seguro que desea poner esta secuencia como activa ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objSecuenciaImpresion.PonerEnUso(_IdSecuenciaImpresion, (int)TipoDocumentoComboBox.SelectedValue);
                        LimpiarCampos();
                        TraerDatos();
                    }
                    catch (Exception ex)
                    {
                        MostrarMensaje("No se pudo poner en uso la secuencia", ex);
                    }
                }
            }
        }

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void SecuenciaImpresionsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                SecuenciaImpresionDataSet.SecuenciaImpresionRow dr = (SecuenciaImpresionsDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as SecuenciaImpresionDataSet.SecuenciaImpresionRow;
                _IdSecuenciaImpresion = dr.Id; 
                PrefijoTextBox.Text = dr.Prefijo;
                NumCaracteresNumericUpDown.Value = dr.NumCaracteres;
                ValorInicioNumericUpDown.Value = dr.ValorInicio;
                ValorFinNumericUpDown.Value = dr.ValorFin;
                ValorUsadoNumericUpDown.Value = dr.ValorUsado;
                EnUso.Checked = dr.EnUso;
                Cerrado.Checked = dr.Cerrado;
                FechaDateTimePicker.Value = dr.Fecha;
                TipoDocumentoComboBox.SelectedValue = dr.TipoDocumentoPago;
                TipoDocumentoComboBox.Enabled = false;
                EscribirEjemplo();
                MarcaError.Clear();
            }
        }

        private void PrefijoTextBox_TextChanged(object sender, EventArgs e)
        {
            EscribirEjemplo();
        }

        private void NumCaracteresNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            EscribirEjemplo();
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                SecuenciaImpresionsDataTable = objSecuenciaImpresion.SeleccionarTodos();
                SecuenciaImpresionsDataGridView.DataSource = SecuenciaImpresionsDataTable;
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
            _IdSecuenciaImpresion = 0;
            PrefijoTextBox.Text = "";
            NumCaracteresNumericUpDown.Value = 3;
            EjemploTextBox.Text = "001";
            ValorInicioNumericUpDown.Value = 1;
            ValorFinNumericUpDown.Value = 1;
            ValorUsadoNumericUpDown.Value = 1;
            EnUso.Checked = false;
            Cerrado.Checked = false;
            FechaDateTimePicker.Value = DateTime.Today;
            TipoDocumentoComboBox.Enabled = true;
        }

        private void GrabarDatos()
        {
            SecuenciaImpresionDataSet cds = new SecuenciaImpresionDataSet();
            SecuenciaImpresionDataSet.SecuenciaImpresionRow cr = cds.SecuenciaImpresion.NewSecuenciaImpresionRow();
            cr.Prefijo = PrefijoTextBox.Text;
            cr.NumCaracteres = Convert.ToInt32(NumCaracteresNumericUpDown.Value);
            cr.ValorInicio = Convert.ToInt32(ValorInicioNumericUpDown.Value);
            cr.ValorFin = Convert.ToInt32(ValorFinNumericUpDown.Value);
            cr.ValorUsado = Convert.ToInt32(ValorUsadoNumericUpDown.Value);
            cr.EnUso = EnUso.Checked;
            cr.Cerrado = Cerrado.Checked;
            cr.Fecha = FechaDateTimePicker.Value;
            cr.TipoDocumentoPago = (int)TipoDocumentoComboBox.SelectedValue;

            cds.SecuenciaImpresion.Rows.Add(cr);
            try
            {
                if (_IdSecuenciaImpresion == 0)
                    _IdSecuenciaImpresion = objSecuenciaImpresion.Insertar(cds);
                else
                {
                    cr.Id = _IdSecuenciaImpresion;
                    objSecuenciaImpresion.Modificar(cds);
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

            if (!ValidarNumericUpDown(ValorFinNumericUpDown)) datosCorrectos = false;
            if (!ValidarNumericUpDown(ValorInicioNumericUpDown)) datosCorrectos = false;

            return datosCorrectos;
        }

        private void EscribirEjemplo()
        {
            EjemploTextBox.Text = DocumentoPagoImpreso.NumeroFacturaImpresion(PrefijoTextBox.Text, 
                Convert.ToInt32(ValorUsadoNumericUpDown.Value), 
                Convert.ToInt32(NumCaracteresNumericUpDown.Value));
        }
        #endregion
    }
}