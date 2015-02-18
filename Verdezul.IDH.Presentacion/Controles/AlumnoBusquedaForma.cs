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

namespace Verdezul.IDH.Presentacion.Controles
{
    public partial class AlumnoBusquedaForma : FormaBase
    {
        #region Campos
        private AlumnoManager objAlumno;
        private EstadoAlumnoManager objEstadoAlumno;
        private AreaManager objArea;
        private AlumnoDataSet.AlumnoDataTable AlumnosDataTable;
        public AlumnoDataSet.AlumnoRow AlumnoRow;
        #endregion

        #region Propiedades
        private int _IdAlumno = 0;
        public int IdAlumno
        { get { return _IdAlumno; } }
        #endregion

        #region Botones
        ToolStripButton LimpiarBoton;
        ToolStripButton BuscarBoton;
        #endregion

        #region Constructores e Inicialización
        public AlumnoBusquedaForma(string nombre, string apellido)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            this.AlumnoControlBusqueda.Nombre = nombre;
            this.AlumnoControlBusqueda.Apellido = apellido;
        }

        private void InicializarComponentesAdicionales()
        {
            BuscarBoton = AgregarBotonAccion("Buscar", "Buscar", Imagenes.Buscar, Buscar_Click);
            LimpiarBoton = AgregarBotonAccion("Limpiar", "Limpiar", Imagenes.Cortar, LimpiarBoton_Click);

            objAlumno = new AlumnoManager();
            objEstadoAlumno = new EstadoAlumnoManager();
            objArea = new AreaManager();

            AlumnosDataTable = new AlumnoDataSet.AlumnoDataTable();
        }
        #endregion

        #region Eventos
        private void AlumnoForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos(AlumnoControlBusqueda.Identificacion, AlumnoControlBusqueda.Nombre, AlumnoControlBusqueda.Apellido))
            {
                AlumnosDataGridView.Columns["Codigo"].HeaderText = "Código";
                AlumnosDataGridView.Columns["Codigo"].Width = 60;
                AlumnosDataGridView.Columns["Nombre"].HeaderText = "Nombre";
                AlumnosDataGridView.Columns["Nombre"].Width = 120;
                AlumnosDataGridView.Columns["Apellido"].HeaderText = "Apellido";
                AlumnosDataGridView.Columns["Apellido"].Width = 120;
                AlumnosDataGridView.Columns["TelefonoDomicilio"].HeaderText = "Tlf. Dom.";
                AlumnosDataGridView.Columns["TelefonoDomicilio"].Width = 80;
                AlumnosDataGridView.Columns["TelefonoOficina"].HeaderText = "Tlf. Ofi.";
                AlumnosDataGridView.Columns["TelefonoOficina"].Width = 80;
                AlumnosDataGridView.Columns["TelefonoCelular"].HeaderText = "Celular";
                AlumnosDataGridView.Columns["TelefonoCelular"].Width = 80;
                AlumnosDataGridView.Columns["NumeroIdentificacion"].HeaderText = "Identificación";
                AlumnosDataGridView.Columns["NumeroIdentificacion"].Width = 100;

                AlumnosDataGridView.Columns["Id"].Visible = false;
                AlumnosDataGridView.Columns["TipoIdentificacion"].Visible = false;
                AlumnosDataGridView.Columns["IdEstadoAlumno"].Visible = false;
                AlumnosDataGridView.Columns["Email"].Visible = false;
                AlumnosDataGridView.Columns["Direccion"].Visible = false;
                AlumnosDataGridView.Columns["FechaNacimiento"].Visible = false;

                AlumnosDataGridView.Columns["FechaIngreso"].Visible = false;
                AlumnosDataGridView.Columns["MedioConocimiento"].Visible = false;
                AlumnosDataGridView.Columns["OtroConocimiento"].Visible = false;
                AlumnosDataGridView.Columns["MotivoInscripcion"].Visible = false;
                AlumnosDataGridView.Columns["OtroInscripcion"].Visible = false;
                AlumnosDataGridView.Columns["MotivoSalida"].Visible = false;
                AlumnosDataGridView.Columns["OtroSalida"].Visible = false;
            }
            else
                CerrarFormaAlCargar = true;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                TraerDatos(AlumnoControlBusqueda.Identificacion, AlumnoControlBusqueda.Nombre, AlumnoControlBusqueda.Apellido);
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

        private void AlumnosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AlumnoRow = (AlumnosDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as AlumnoDataSet.AlumnoRow;
                this.DialogResult = DialogResult.Yes;
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos(string identificacion, string nombre, string apellido)
        {
            try
            {
                AlumnosDataTable = objAlumno.SeleccionarxIdentificaionxNombrexApellido(identificacion, nombre, apellido);
                AlumnosDataGridView.DataSource = AlumnosDataTable;
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
            AlumnoControlBusqueda.Limpiar();
        }
        #endregion

        #region Métodos Complementarios
        private EstadoAlumnoDataSet.EstadoAlumnoDataTable PedirEstadosAlumno()
        {
            EstadoAlumnoDataSet.EstadoAlumnoDataTable dtEstadosAlumnos;
            dtEstadosAlumnos = objEstadoAlumno.SeleccionarTodos();
            EstadoAlumnoDataSet.EstadoAlumnoRow srow = dtEstadosAlumnos.NewEstadoAlumnoRow();
            srow.Id = 0;
            srow.Nombre = "(Seleccione)";
            dtEstadosAlumnos.Rows.InsertAt(srow, 0);
            return dtEstadosAlumnos;
        }

        private AreaDataSet.AreaDataTable PedirNiveles()
        {
            AreaDataSet.AreaDataTable dtArea;
            dtArea = objArea.SeleccionarTodos();
            AreaDataSet.AreaRow sarow = dtArea.NewAreaRow();
            sarow.Id = 0;
            sarow.Nombre = "(Seleccione)";
            dtArea.Rows.InsertAt(sarow, 0);
            return dtArea;
        }
        #endregion
    }
}