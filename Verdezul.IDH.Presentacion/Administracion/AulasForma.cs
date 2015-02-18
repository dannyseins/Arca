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
    public partial class AulasForma : FormaBase
    {
        #region Campos
        private AulaManager objAula;
        private AulaDataSet.AulaDataTable AulasDataTable;
        private int _IdAula = 0;
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        #endregion

        #region Constructores e Inicialización
        public AulasForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public AulasForma(int idUsuario)
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

            objAula = new AulaManager();
            AulasDataTable = new AulaDataSet.AulaDataTable();
        }
        #endregion

        #region Eventos
        private void AulaForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                AulasDataGridView.Columns["Nombre"].HeaderText = "Nombre";
                AulasDataGridView.Columns["Nombre"].Width = 300;

                AulasDataGridView.Columns["Id"].Visible = false;
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
                    TraerDatos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se guardaron los datos", ex);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (_IdAula != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        objAula.Borrar(_IdAula);
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

        private void AulasDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AulaDataSet.AulaRow dr = (AulasDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as AulaDataSet.AulaRow;
                _IdAula = dr.Id;
                NombreAulaTextBox.Text = dr.Nombre;
                ActivoCheckBox.Checked = dr.Activo;
                MarcaError.Clear();
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                AulasDataTable = objAula.SeleccionarTodos();
                AulasDataGridView.DataSource = AulasDataTable;
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
            _IdAula = 0;
            NombreAulaTextBox.Text = "";
            ActivoCheckBox.Checked = true;
        }

        private void GrabarDatos()
        {
            AulaDataSet cds = new AulaDataSet();
            AulaDataSet.AulaRow cr = cds.Aula.NewAulaRow();
            cr.Nombre = NombreAulaTextBox.Text;
            cr.Activo = ActivoCheckBox.Checked;

            cds.Aula.Rows.Add(cr);
            try
            {
                if (_IdAula == 0)
                    _IdAula = objAula.Insertar(cds);
                else
                {
                    cr.Id = _IdAula;
                    objAula.Modificar(cds);
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

            if (!ValidarTextBox(NombreAulaTextBox)) datosCorrectos = false;

            return datosCorrectos;
        }
        #endregion
    }
}