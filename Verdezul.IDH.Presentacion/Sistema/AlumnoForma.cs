using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Business;
using Verdezul.IDH.Configuracion;

namespace Verdezul.IDH.Presentacion.Sistema
{
    public partial class AlumnoForma : FormaBase
    {
        #region Servicios
        private AlumnoManager AlumnoServicio;
        private EstadoAlumnoManager EstadoAlumnoServicio;
        private AreaManager AreaServicio;
        private HorarioManager HorarioServicio;
        private CursoManager CursoServicio;
        private HorarioAlumnoManager HorarioAlumnoServicio;
        #endregion

        #region Campos
        private AlumnoDataSet.AlumnoDataTable AlumnosDataTable;
        private AreaDataSet Areas;
        private XmlDocument OpcionesPreguntaXML;
        private Properties.Settings ConfiguracionLocal;
        private string CarpetaFotos;
        #endregion

        #region Propiedades
        private int _IdAlumno = 0;
        public int IdAlumno
        { get { return _IdAlumno; } }

        private bool _PermitirModificar = true;
        public bool PermitirModificar
        {
            get { return _PermitirModificar; }
            set { _PermitirModificar = value; }
        }
        #endregion

        #region Botones
        ToolStripButton GrabarBoton;
        ToolStripButton BorrarBoton;
        ToolStripButton LimpiarBoton;
        ToolStripButton GrabarCerrarBoton;
        #endregion

        #region Constructores e Inicialización
        public AlumnoForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            this.GrabarCerrarBoton.Visible = false;
            this.GrabarBoton.Visible = true;
        }

        public AlumnoForma(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            this.GrabarCerrarBoton.Visible = false;
            this.GrabarBoton.Visible = true;
            IdUsuario = idUsuario;
        }

        public AlumnoForma(string identificacion)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            this.NumeroIdentificacionTextBox.Text = identificacion;
            this.NombreTextBox.Focus();
            this.GrabarCerrarBoton.Visible = true;
            this.GrabarBoton.Visible = false;
        }

        private void InicializarComponentesAdicionales()
        {
            GrabarBoton = AgregarBotonAccion("Grabar", "Grabar", Imagenes.Grabar, Grabar_Click);
            BorrarBoton = AgregarBotonAccion("Borrar", "Borrar", Imagenes.Borrar, Borrar_Click);
            LimpiarBoton = AgregarBotonAccion("Limpiar", "Limpiar", Imagenes.Limpiar, LimpiarBoton_Click);
            GrabarCerrarBoton = AgregarBotonAccion("GrabarCerrar", "Grabar/Cerrar", Imagenes.Grabar, GrabarCerrar_Click);

            AlumnoServicio = new AlumnoManager();
            EstadoAlumnoServicio = new EstadoAlumnoManager();
            AreaServicio = new AreaManager();
            HorarioServicio = new HorarioManager();
            CursoServicio = new CursoManager();
            HorarioAlumnoServicio = new HorarioAlumnoManager();

            AlumnosDataTable = new AlumnoDataSet.AlumnoDataTable();
            AreaServicio = new AreaManager();

            Areas = AreaServicio.SeleccionarConNiveles(0);

            TipoIdentificacionComboBox.DataSource = PedirTipoIdentificaciones();
            TipoIdentificacionComboBox.SelectedIndex = 0;

            EstadoComboBox.DataSource = PedirEstadosAlumno();
            EstadoComboBox.SelectedIndex = 0;

            OpcionesPreguntaXML = new XmlDocument();
            OpcionesPreguntaXML.Load(String.Format(@"{0}\{1}", Application.StartupPath, "Datos/Valores.xml"));

            MedioConocimientoComboBox.DataSource = PedirOpcionesPregunta("medioConocimiento");
            MedioConocimientoComboBox.SelectedIndex = 0;

            MotivoInscripcionComboBox.DataSource = PedirOpcionesPregunta("motivoInscripcion");
            MotivoInscripcionComboBox.SelectedIndex = 0;

            MotivoSalidaComboBox.DataSource = PedirOpcionesPregunta("motivoSalida");
            MotivoSalidaComboBox.SelectedIndex = 0;

            ConfiguracionLocal = new Properties.Settings();
            FotoOpenFileDialog.Title = this.Text;
            CarpetaFotos = string.Format("{0}{1}", Application.StartupPath, ConfiguracionLocal.CarpetaFotos);

            AreaNivelCombos.CargarDatos();
            AreaNivelCombos.LimpiarAreaNivel();
        }
        #endregion

        #region Eventos
        private void AlumnoForma_Load(object sender, EventArgs e)
        {
            if (TraerDatos())
            {
                ConfigurarDataGrid();
                NumeroIdentificacionTextBox.Focus();
            }
            else
                CerrarFormaAlCargar = true;
        }

        private void GrabarCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    GrabarDatos();
                    this.DialogResult = DialogResult.Yes;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se guardaron los datos", ex);
            }
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    GrabarDatos();
                    MostrarMensaje("La información del alumno ha sido guardada.");
                    LimpiarCampos();
                    TraerDatos();
                }
                else
                {
                    throw new Exception("Faltan algunos datos, revise cada pestaña.");
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se guardaron los datos", ex);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (_IdAlumno != 0)
            {
                if (Preguntar("Está seguro que desea borrar ?").Equals(DialogResult.Yes))
                {
                    try
                    {
                        AlumnoServicio.Borrar(_IdAlumno);
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

        private void MedioConocimientoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MedioConocimientoTextBox.Enabled = (MedioConocimientoComboBox.SelectedValue.Equals(-1));
            MedioConocimientoTextBox.Text = "";
        }

        private void MotivoInscripcionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MotivoInscripcionTextBox.Enabled = (MotivoInscripcionComboBox.SelectedValue.Equals(-1));
            MotivoInscripcionTextBox.Text = "";
        }

        private void MotivoSalidaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MotivoSalidaTextBox.Enabled = (MotivoSalidaComboBox.SelectedValue.Equals(-1));
            MotivoSalidaTextBox.Text = "";
        }

        private void AlumnoForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Preguntar("Desea salir de la Administración de Alumnos ?").Equals(DialogResult.No))
                e.Cancel = true;
        }

        private void AlumnosDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex != -1) && PermitirModificar)
            {
                AlumnoDataSet.AlumnoRow dr = (AlumnosDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as AlumnoDataSet.AlumnoRow;
                _IdAlumno = dr.Id;
                AcademicosPanel.Enabled = true;
                EstadoComboBox.SelectedValue = dr.IdEstadoAlumno;
                CodigoTextBox.Text = dr.Codigo;
                NombreTextBox.Text = dr.Nombre;
                ApellidoTextBox.Text = dr.Apellido;
                TipoIdentificacionComboBox.SelectedValue = dr.TipoIdentificacion;
                NumeroIdentificacionTextBox.Text = dr.NumeroIdentificacion;
                FechaNacimientoDateTimePicker.Value = dr.FechaNacimiento;
                DireccionTextBox.Text = dr.Direccion;
                EmailTextBox.Text = dr.Email;
                TelefonoDomicilioTextBox.Text = dr.TelefonoDomicilio;
                TelefonoOficinaTextBox.Text = dr.TelefonoOficina;
                TelefonoCelularTextBox.Text = dr.TelefonoCelular;
                FechaIngresoDateTimePicker.Value = dr.FechaIngreso;
                MedioConocimientoComboBox.SelectedValue = dr.MedioConocimiento;
                MedioConocimientoTextBox.Text = dr.IsOtroConocimientoNull() ? "" : dr.OtroConocimiento;
                MotivoInscripcionComboBox.SelectedValue = dr.MotivoInscripcion;
                MotivoInscripcionTextBox.Text = dr.IsOtroInscripcionNull() ? "" : dr.OtroInscripcion;
                MotivoSalidaComboBox.SelectedValue = dr.MotivoSalida;
                MotivoSalidaTextBox.Text = dr.IsOtroSalidaNull() ? "" : dr.OtroSalida;
                FotoAlumnoPictureBox.ImageLocation = dr.IsArchivoFotoNull() ? "" : string.Format(@"{0}\{1}", CarpetaFotos, dr.ArchivoFoto);
                CargarCursosAlumno(_IdAlumno);
                CargarAreaNivelAlumno(_IdAlumno);
                MarcaError.Clear();
            }
        }

        private void SubirFotoButton_Click(object sender, EventArgs e)
        {
            if (FotoOpenFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                try
                {
                    string archivoSubir = FotoOpenFileDialog.FileName;
                    string extension = new FileInfo(archivoSubir).Extension;
                    string nombreArchivo = string.Format("{0}{1}", CodigoTextBox.Text, extension);
                    string archivoFoto = string.Format(@"{0}\{1}", CarpetaFotos, nombreArchivo);
                    File.Copy(archivoSubir, archivoFoto, true);
                    AlumnoServicio.ModificarFoto(_IdAlumno, nombreArchivo);
                    AlumnosDataTable.FindById(_IdAlumno).ArchivoFoto = nombreArchivo;
                    FotoAlumnoPictureBox.ImageLocation = archivoFoto;
                }
                catch (Exception ex)
                {
                    MostrarMensaje("La imagen no pudo ser subida/actualizada", ex);
                }
            }
        }
        #endregion

        #region Métodos
        private bool TraerDatos()
        {
            try
            {
                AlumnosDataTable = AlumnoServicio.SeleccionarTodos();
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
            _IdAlumno = 0;
            AreaNivelCombos.LimpiarAreaNivel();
            EstadoComboBox.SelectedValue = 0;
            CodigoTextBox.Text = "";
            NombreTextBox.Text = "";
            ApellidoTextBox.Text = "";
            TipoIdentificacionComboBox.SelectedValue = 1;
            FechaNacimientoDateTimePicker.Value = DateTime.Today;
            NumeroIdentificacionTextBox.Text = "";
            DireccionTextBox.Text = "";
            EmailTextBox.Text = "";
            TelefonoDomicilioTextBox.Text = "";
            TelefonoOficinaTextBox.Text = "";
            TelefonoCelularTextBox.Text = "";
            FechaIngresoDateTimePicker.Value = DateTime.Today;
            MedioConocimientoComboBox.SelectedValue = 0;
            MedioConocimientoTextBox.Text = "";
            MotivoInscripcionComboBox.SelectedValue = 0;
            MotivoInscripcionTextBox.Text = "";
            MotivoSalidaComboBox.SelectedValue = 0;
            MotivoSalidaTextBox.Text = "";
            AcademicosPanel.Enabled = false;
            FotoAlumnoPictureBox.ImageLocation = "";
            AreaNivelCombos.LimpiarAreaNivel();
            CursosDataGridView.DataSource = null;
            MarcaError.Clear();
        }

        private void GrabarDatos()
        {
            AlumnoDataSet cds = new AlumnoDataSet();
            AlumnoDataSet.AlumnoRow cr = cds.Alumno.NewAlumnoRow();

            cr.IdEstadoAlumno = (int)EstadoComboBox.SelectedValue;
            cr.Codigo = CodigoTextBox.Text;
            cr.Nombre = NombreTextBox.Text;
            cr.Apellido = ApellidoTextBox.Text;
            cr.TipoIdentificacion = (int)TipoIdentificacionComboBox.SelectedValue;
            cr.NumeroIdentificacion = NumeroIdentificacionTextBox.Text;
            cr.FechaNacimiento = FechaNacimientoDateTimePicker.Value;
            cr.Direccion = DireccionTextBox.Text;
            cr.Email = EmailTextBox.Text;
            cr.TelefonoDomicilio = TelefonoDomicilioTextBox.Text;
            cr.TelefonoOficina = TelefonoOficinaTextBox.Text;
            cr.TelefonoCelular = TelefonoCelularTextBox.Text;
            cr.FechaIngreso = FechaIngresoDateTimePicker.Value;
            cr.MedioConocimiento = (int)MedioConocimientoComboBox.SelectedValue;
            cr.OtroConocimiento = (MedioConocimientoComboBox.SelectedValue.Equals(-1)) ? MedioConocimientoTextBox.Text : "";
            cr.MotivoInscripcion = (int)MotivoInscripcionComboBox.SelectedValue;
            cr.OtroInscripcion = (MotivoInscripcionComboBox.SelectedValue.Equals(-1)) ? MotivoInscripcionTextBox.Text : "";
            cr.MotivoSalida = (int)MotivoSalidaComboBox.SelectedValue;
            cr.OtroSalida = (MotivoSalidaComboBox.SelectedValue.Equals(-1)) ? MotivoSalidaTextBox.Text : "";

            cds.Alumno.Rows.Add(cr);
            try
            {
                if (_IdAlumno == 0)
                    _IdAlumno = AlumnoServicio.Insertar(cds);
                else
                {
                    cr.Id = _IdAlumno;
                    AlumnoServicio.Modificar(cds);
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
            if (!ValidarTextBox(NumeroIdentificacionTextBox)) datosCorrectos = false;
            if (!ValidarCedula(NumeroIdentificacionTextBox)) datosCorrectos = false;
            if (!ValidarComboBox(EstadoComboBox)) datosCorrectos = false;
            if (!ValidarTelefonoEcuador(TelefonoDomicilioTextBox)) datosCorrectos = false;
            if (!ValidarTelefonoEcuador(TelefonoOficinaTextBox)) datosCorrectos = false;
            if (!ValidarTelefonoEcuador(TelefonoCelularTextBox)) datosCorrectos = false;
            if (!ValidarMail(EmailTextBox)) datosCorrectos = false;

            return datosCorrectos;
        }

        private void ConfigurarDataGrid()
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
            AlumnosDataGridView.Columns["ArchivoFoto"].Visible = false;
        }
        #endregion

        #region Métodos Complementarios
        private void CargarAreaNivelAlumno(int idAlumno)
        {
            HorarioAlumnoDataSet.HorarioAlumnoDataTable hadt = HorarioAlumnoServicio.PedirHorarioyNivelxAlumno(idAlumno);
            if (hadt.Rows.Count != 0)
            {
                HorarioAlumnoDataSet.HorarioAlumnoRow harow = hadt.Rows[0] as HorarioAlumnoDataSet.HorarioAlumnoRow;
                AreaNivelCombos.SetIdNivel((int)harow["IdNivel"]);
            }
            else
            {
                AreaNivelCombos.LimpiarAreaNivel();
            }
        }

        private void CargarCursosAlumno(int idAlumno)
        {
            CursosDataGridView.DataSource = CursoServicio.SeleccionarxIdAlumno(idAlumno);
            CursosDataGridView.Columns["Id"].Visible = false;
            CursosDataGridView.Columns["Activo"].Visible = false;
        }

        private EstadoAlumnoDataSet.EstadoAlumnoDataTable PedirEstadosAlumno()
        {
            EstadoAlumnoDataSet.EstadoAlumnoDataTable dtEstadosAlumnos;
            dtEstadosAlumnos = EstadoAlumnoServicio.SeleccionarTodos();
            EstadoAlumnoDataSet.EstadoAlumnoRow srow = dtEstadosAlumnos.NewEstadoAlumnoRow();
            srow.Id = 0;
            srow.Nombre = "(Seleccione)";
            dtEstadosAlumnos.Rows.InsertAt(srow, 0);
            return dtEstadosAlumnos;
        }

        private AreaDataSet.AreaDataTable PedirNiveles()
        {
            AreaDataSet.AreaDataTable dtArea;
            dtArea = AreaServicio.SeleccionarTodos();
            AreaDataSet.AreaRow sarow = dtArea.NewAreaRow();
            sarow.Id = 0;
            sarow.Nombre = "(Seleccione)";
            dtArea.Rows.InsertAt(sarow, 0);
            return dtArea;
        }

        private object PedirOpcionesPregunta(string tipoOpcion)
        {
            List<OpcionPregunta> listaOpciones = new List<OpcionPregunta>();
            XmlNodeList valores = OpcionesPreguntaXML.GetElementsByTagName(tipoOpcion);
            XmlNodeList lista = ((XmlElement)valores[0]).GetElementsByTagName("opcion");

            listaOpciones.Add(new OpcionPregunta(0, "(Seleccione)"));
            foreach (XmlElement nodo in lista)
            {
                listaOpciones.Add(new OpcionPregunta(int.Parse(nodo.GetAttribute("id")), nodo.GetAttribute("texto")));
            }
            listaOpciones.Add(new OpcionPregunta(-1, "(Otro)"));

            return listaOpciones;
        }
        #endregion
    }
}