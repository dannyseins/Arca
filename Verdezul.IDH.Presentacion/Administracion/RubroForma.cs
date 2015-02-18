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
    public partial class RubroForma : FormaBase
    {

        #region Campos
        private RubroManager objRubro;
        private ParametroManager objParametro;
        private RubroDataSet.RubroDataTable RubrosDataTable;
        private int _IdRubro = 0;
        #endregion

        #region Propiedades
        private decimal _ValorIVA;
        private decimal ValorIVA
        {
            get
            {
                return TieneIVACheckBox.Checked ? _ValorIVA : 0;
            }
        }
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public RubroForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public RubroForma(int idUsuario)
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

            objRubro = new RubroManager();
            objParametro = new ParametroManager();
            RubrosDataTable = new RubroDataSet.RubroDataTable();
        }
        #endregion

        #region Eventos
        private void RubroForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                RubrosDataGridView.Columns["Nombre"].HeaderText = "Rubro";
                RubrosDataGridView.Columns["Nombre"].Width = 80;
                RubrosDataGridView.Columns["Descripcion"].HeaderText = "Descripción";
                RubrosDataGridView.Columns["Descripcion"].Width = 140;
                RubrosDataGridView.Columns["Valor"].HeaderText = "Valor";
                RubrosDataGridView.Columns["Valor"].Width = 50;
                RubrosDataGridView.Columns["IVA"].Width = 50;
                RubrosDataGridView.Columns["PVP"].Width = 50;
                RubrosDataGridView.Columns["Activo"].Width = 50;
                RubrosDataGridView.Columns["TieneIVA"].Width = 50;
                RubrosDataGridView.Columns["TieneIVA"].HeaderText = "Cobra IVA";
                RubrosDataGridView.Columns["Activo"].SortMode = DataGridViewColumnSortMode.Automatic;
                RubrosDataGridView.Columns["TieneIVA"].SortMode = DataGridViewColumnSortMode.Automatic;

                RubrosDataGridView.Columns["Id"].Visible = false;

                TieneIVACheckBox.Checked = false;
                TieneIVACheckBox.Text = string.Format("Tiene IVA de {0}%", _ValorIVA);
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
            if (_IdRubro != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objRubro.Borrar(_IdRubro);
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

        private void RubrosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                RubroDataSet.RubroRow dr = (RubrosDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as RubroDataSet.RubroRow;
                _IdRubro = dr.Id;
                NombreTextBox.Text = dr.Nombre;
                DescripcionTextBox.Text = dr.Descripcion;
                Activo.Checked = dr.Activo;
                PVPNumericUpDown.Value = dr.PVP;
                IVANumericUpDown.Value = dr.IVA;
                ValorNumericUpDown.Value = dr.Valor;
                TieneIVACheckBox.Checked = dr.TieneIVA;
                MarcaError.Clear();
            }
        }

        private void TieneIVACheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IVANumericUpDown.Value = (ValorNumericUpDown.Value / 100 * ValorIVA);
            PVPNumericUpDown.Value = ValorNumericUpDown.Value + IVANumericUpDown.Value;
        }

        private void ValorNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            IVANumericUpDown.Value = (ValorNumericUpDown.Value / 100 * ValorIVA);
            PVPNumericUpDown.Value = ValorNumericUpDown.Value + IVANumericUpDown.Value;
        }

        private void PVPNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorNumericUpDown.Value = PVPNumericUpDown.Value * 100 / (100 + ValorIVA);
            IVANumericUpDown.Value = PVPNumericUpDown.Value - ValorNumericUpDown.Value;
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                RubrosDataTable = objRubro.SeleccionarTodos();
                RubrosDataGridView.DataSource = RubrosDataTable;
                _ValorIVA = Convert.ToDecimal(objParametro.SeleccionarxNombre("IVA"));
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
            _IdRubro = 0;
            NombreTextBox.Text = "";
            DescripcionTextBox.Text = "";
            Activo.Checked = true;
            PVPNumericUpDown.Value = 0;
            IVANumericUpDown.Value = 0;
            ValorNumericUpDown.Value = 0;
        }

        private void GrabarDatos()
        {
            RubroDataSet cds = new RubroDataSet();
            RubroDataSet.RubroRow cr = cds.Rubro.NewRubroRow();
            cr.Nombre = NombreTextBox.Text;
            cr.Descripcion = DescripcionTextBox.Text;
            cr.IVA = IVANumericUpDown.Value;
            cr.PVP = PVPNumericUpDown.Value;
            cr.Valor = ValorNumericUpDown.Value;
            cr.TieneIVA = TieneIVACheckBox.Checked;
            cr.Activo = Activo.Checked;

            cds.Rubro.Rows.Add(cr);
            try
            {
                if (_IdRubro == 0)
                    _IdRubro = objRubro.Insertar(cds);
                else
                {
                    cr.Id = _IdRubro;
                    objRubro.Modificar(cds);
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
            if (!ValidarTextBox(DescripcionTextBox)) datosCorrectos = false;
            if (!ValidarNumericUpDown(ValorNumericUpDown)) datosCorrectos = false;
            if (!ValidarNumericUpDown(PVPNumericUpDown)) datosCorrectos = false;

            return datosCorrectos;
        }
        #endregion
    }
}