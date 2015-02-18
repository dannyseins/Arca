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
    public partial class AreaNivelForma : FormaBase
    {
        #region Campos
        private AreaManager objArea;
        private NivelManager objNivel;
        private ParametroManager objParametro;
        private AreaDataSet AreasDataSet;
        private int _IdArea = 0;
        private int _IdNivel = 0;
        private int IdAreaSeleccionado = 0;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public AreaNivelForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public AreaNivelForma(int idUsuario)
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

            objArea = new AreaManager();
            objNivel = new NivelManager();
            objParametro = new ParametroManager();
            AreasDataSet = new AreaDataSet();
        }
        #endregion

        #region Eventos
        private void AreaForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                AreasDataGridView.Columns["Nombre"].HeaderText = "Nombre";
                AreasDataGridView.Columns["Nombre"].Width = 300;

                AreasDataGridView.Columns["Id"].Visible = false;
            }
            else
                CerrarFormaAlCargar = true;
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (AreaNivelTabControl.SelectedTab.Name)
                {
                    case "AreaTabPage":
                        if (ValidarCamposArea())
                        {
                            GrabarDatosArea();
                            //MostrarMensaje("Grabación Correcta");
                            TraerDatos();
                            LimpiarCampos();
                        }
                        break;
                    case "NivelTabPage":
                        if (ValidarCamposNivel())
                        {
                            GrabarDatosNivel();
                            //MostrarMensaje("Grabación Correcta");
                            TraerDatos();
                            LimpiarCampos();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se guardaron los datos", ex);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            switch (AreaNivelTabControl.SelectedTab.Name)
            {
                case "AreaTabPage":
                    if (_IdArea != 0)
                    {
                        if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                        {
                            try
                            {
                                objArea.Borrar(_IdArea);
                                LimpiarCampos();
                                TraerDatos();
                            }
                            catch (Exception ex)
                            {
                                MostrarMensaje("No se pudo borrar", ex);
                            }
                        }
                    }
                    break;
                case "NivelTabPage":
                    if (_IdNivel != 0)
                    {
                        if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                        {
                            try
                            {
                                objNivel.Borrar(_IdNivel);
                                TraerDatos();
                                LimpiarCampos();
                            }
                            catch (Exception ex)
                            {
                                MostrarMensaje("No se pudo borrar", ex);
                            }
                        }
                    }
                    break;
            }
        }

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void AreasDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AreaDataSet.AreaRow dr = (AreasDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as AreaDataSet.AreaRow;
                _IdArea = dr.Id;
                NombreAreaTextBox.Text = dr.Nombre;
                MarcaError.Clear();
            }
        }

        private void NivelesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AreaDataSet.NivelRow dr = (NivelesDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as AreaDataSet.NivelRow;
                _IdNivel = dr.Id;
                NombreNivelTextBox.Text = dr.Nombre;
                MarcaError.Clear();
                AreasComboBox.Enabled = false;
            }
        }

        private void AreasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NivelesDataGridView.DataSource = MetodosGenerales.FiltrarNivelesxArea((int)AreasComboBox.SelectedValue, AreasDataSet);
            NivelesDataGridView.Columns["Nombre"].HeaderText = "Nombre";
            NivelesDataGridView.Columns["Nombre"].Width = 300;
            NivelesDataGridView.Columns["Id"].Visible = false;
            NivelesDataGridView.Columns["IdArea"].Visible = false;
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                AreasDataSet = objArea.SeleccionarConNiveles(0);
                AreasDataGridView.DataSource = AreasDataSet.Area;

                // Aumento de Código para mantenimiento de Niveles según Área.
                AreaDataSet.AreaDataTable AreasNivelesDataTable = AreasDataSet.Area.Copy() as AreaDataSet.AreaDataTable;
                AreaDataSet.AreaRow srow = AreasNivelesDataTable.NewAreaRow();
                srow.Id = 0;
                srow.Nombre = "(Seleccione)";
                AreasNivelesDataTable.Rows.InsertAt(srow, 0);
                AreasComboBox.DataSource = AreasNivelesDataTable;

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
            _IdArea = 0;
            _IdNivel = 0;
            NombreAreaTextBox.Text = "";
            NombreNivelTextBox.Text = "";
            AreasComboBox.Enabled = true;
            AreasComboBox.SelectedValue = IdAreaSeleccionado;
        }

        private void GrabarDatosArea()
        {
            AreaDataSet cds = new AreaDataSet();
            AreaDataSet.AreaRow cr = cds.Area.NewAreaRow();
            cr.Nombre = NombreAreaTextBox.Text;

            cds.Area.Rows.Add(cr);
            try
            {
                if (_IdArea == 0)
                    _IdArea = objArea.Insertar(cds);
                else
                {
                    cr.Id = _IdArea;
                    objArea.Modificar(cds);
                }
            }
            catch
            {
                throw;
            }
        }

        private void GrabarDatosNivel()
        {
            AreaDataSet cds = new AreaDataSet();
            AreaDataSet.NivelRow nrow = cds.Nivel.NewNivelRow();
            nrow.IdArea = (int)AreasComboBox.SelectedValue;
            nrow.Nombre = NombreNivelTextBox.Text;

            cds.Nivel.Rows.Add(nrow);
            try
            {
                if (_IdNivel == 0)
                    _IdNivel = objNivel.Insertar(cds);
                else
                {
                    nrow.Id = _IdNivel;
                    objNivel.Modificar(cds);
                }
                IdAreaSeleccionado = (int)AreasComboBox.SelectedValue;
            }
            catch
            {
                throw;
            }
        }

        private bool ValidarCamposArea()
        {
            bool datosCorrectos = true;
            MarcaError.Clear();

            if (!ValidarTextBox(NombreAreaTextBox)) datosCorrectos = false;

            return datosCorrectos;
        }

        private bool ValidarCamposNivel()
        {
            bool datosCorrectos = true;
            MarcaError.Clear();

            if (!ValidarTextBox(NombreNivelTextBox)) datosCorrectos = false;
            if (!ValidarComboBox(AreasComboBox)) datosCorrectos = false;

            return datosCorrectos;
        }
        #endregion
    }
}