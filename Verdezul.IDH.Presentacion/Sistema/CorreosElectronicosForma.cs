using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.IO;
using System.Xml;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Business;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Configuracion;

namespace Verdezul.IDH.Presentacion.Sistema
{
    public partial class CorreosElectronicosForma : FormaBase
    {
        #region Campos
        private AlumnoManager AlumnoServicio;
        private CursoManager CursoServicio;
        private List<string> ListaDirecciones;
        private bool TodosEscogidos = false;
        private int TipoPertenencia = 1;
        #endregion

        #region Botones
        private ToolStripButton BuscarBoton;
        private ToolStripButton GenerarBoton;
        private ToolStripButton EscogerTodosBoton;
        private ToolStripButton CopiarBoton;
        #endregion

        #region Constructor
        public CorreosElectronicosForma()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        private void InicializarComponentesAdicionales()
        {
            AlumnoServicio = new AlumnoManager();
            CursoServicio = new CursoManager();
            BuscarBoton = AgregarBotonAccion("Buscar", "Buscar", Imagenes.Buscar, BuscarBoton_Click);
            GenerarBoton = AgregarBotonAccion("Generar", "Generar", Imagenes.GenerarDirecciones, GenerarBoton_Click);
            EscogerTodosBoton = AgregarBotonAccion("EscogerTodos", "Escoger Todos", Imagenes.EscogerTodos, EscogerTodosBoton_Click);
            CopiarBoton = AgregarBotonAccion("Copiar", "Copiar", Imagenes.Copiar1, CopiarBoton_Click);
        }
        #endregion

        #region Eventos
        private void CorreosElectronicosForma_Load(object sender, EventArgs e)
        {
            AreaNivelCombos.CargarDatos();
            CursoDataSet.CursoDataTable cursoDataTable = CursoServicio.SeleccionarTodos();
            MetodosGenerales.AgregarFila(cursoDataTable, 0,
                new CampoFilaAdicional("Id", 0),
                new CampoFilaAdicional("Nombre", "(Seleccione)"),
                new CampoFilaAdicional("Activo", true));

            CursosComboBox.DataSource = cursoDataTable;

            AlumnosDataGridView.DataSource = AlumnoServicio.SeleccionarxPertenenciaAreaNivelCurso(1, 0, 0, 0);
            ConfigurarDataGrid();
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                int idArea = AreaNivelCombos.GetIdArea();
                int idNivel = AreaNivelCombos.GetIdNivel();
                int idCurso = (int)CursosComboBox.SelectedValue;
                AlumnosDataGridView.DataSource = AlumnoServicio.SeleccionarxPertenenciaAreaNivelCurso(TipoPertenencia, idArea, idNivel, idCurso);
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se pudo recuperar los datos", ex);
            }
        }

        private void GenerarBoton_Click(object sender, EventArgs e)
        {
            ListaDirecciones = new List<string>();
            foreach (DataGridViewRow dgvr in AlumnosDataGridView.Rows)
            {
                if (dgvr.Cells[EscogerColumn.Name].Value != null)
                    if (dgvr.Cells[EscogerColumn.Name].Value.Equals(true))
                        if (dgvr.Cells["Email"].Value != DBNull.Value)
                            if (!dgvr.Cells["Email"].Value.Equals(""))
                                ListaDirecciones.Add(dgvr.Cells["Email"].Value.ToString());
            }

            DireccionesTextBox.Text = string.Join(", ", ListaDirecciones.ToArray());
        }

        private void EscogerTodosBoton_Click(object sender, EventArgs e)
        {
            TodosEscogidos = !TodosEscogidos;
            foreach (DataGridViewRow dgvr in AlumnosDataGridView.Rows)
            {
                dgvr.Cells[EscogerColumn.Name].Value = TodosEscogidos;
            }
            EscogerTodosBoton.Text = (TodosEscogidos) ? "Quitar Todos" : "Escoger Todos";
        }

        private void CopiarBoton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DireccionesTextBox.Text);
        }

        private void TodosRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TodosRadioButton.Checked == true)
                TipoPertenencia = 1;
        }

        private void AreaNivelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AreaNivelRadioButton.Checked == true)
                TipoPertenencia = 2;
        }

        private void CursoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CursoRadioButton.Checked == true)
                TipoPertenencia = 3;
        }

        private void NoAlumnosRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoAlumnosRadioButton.Checked == true)
                TipoPertenencia = 4;
        }

        private void CursosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CursoRadioButton.Checked = true;
        }

        private void AreaNivelCombos_Enter(object sender, EventArgs e)
        {
            AreaNivelRadioButton.Checked = true;
        }

        private void AlumnosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AlumnosDataGridView.EndEdit();
        }
        #endregion

        #region Métodos
        private void ConfigurarDataGrid()
        {
            AlumnosDataGridView.Columns["Codigo"].HeaderText = "Código";
            AlumnosDataGridView.Columns["Codigo"].Width = 50;
            AlumnosDataGridView.Columns["Nombre"].HeaderText = "Nombre";
            AlumnosDataGridView.Columns["Nombre"].Width = 100;
            AlumnosDataGridView.Columns["Apellido"].HeaderText = "Apellido";
            AlumnosDataGridView.Columns["Apellido"].Width = 100;
            AlumnosDataGridView.Columns["Email"].HeaderText = "Correo Electrónico";
            AlumnosDataGridView.Columns["Email"].Width = 180;

            AlumnosDataGridView.Columns["Id"].Visible = false;
            AlumnosDataGridView.Columns["ArchivoFoto"].Visible = false;
            AlumnosDataGridView.Columns["NumeroIdentificacion"].Visible = false;
            AlumnosDataGridView.Columns["TipoIdentificacion"].Visible = false;
            AlumnosDataGridView.Columns["IdEstadoAlumno"].Visible = false;
            AlumnosDataGridView.Columns["TelefonoDomicilio"].Visible = false;
            AlumnosDataGridView.Columns["TelefonoOficina"].Visible = false;
            AlumnosDataGridView.Columns["TelefonoCelular"].Visible = false;
            AlumnosDataGridView.Columns["FechaIngreso"].Visible = false;
            AlumnosDataGridView.Columns["Direccion"].Visible = false;
            AlumnosDataGridView.Columns["FechaNacimiento"].Visible = false;
            AlumnosDataGridView.Columns["MedioConocimiento"].Visible = false;
            AlumnosDataGridView.Columns["MotivoInscripcion"].Visible = false;
            AlumnosDataGridView.Columns["MotivoSalida"].Visible = false;
            AlumnosDataGridView.Columns["OtroConocimiento"].Visible = false;
            AlumnosDataGridView.Columns["OtroInscripcion"].Visible = false;
            AlumnosDataGridView.Columns["OtroSalida"].Visible = false;

            foreach (DataGridViewColumn dgvc in AlumnosDataGridView.Columns)
            {
                dgvc.ReadOnly = true;
            }
            this.EscogerColumn.ReadOnly = false;

        }
        #endregion

        public XmlDocument MailXML;

        public void EnviarMail(List<string> archivosAdjuntos)
        {
            MailMessage Correo = new MailMessage();
            Correo.To.Add(ConfigurationManager.AppSettings["Destino"]);
            Correo.Subject = "Envio Imagen";

            foreach (string archivo in archivosAdjuntos)
            {
                if (File.Exists(archivo))
                    Correo.Attachments.Add(new Attachment(archivo));
            }

            MailXML = new XmlDocument();
            MailXML.Load("XMLMail.xml");

            string enlace = "http://img.photobucket.com/albums/v421/Eclisse/food009.jpg";
            Correo.Body = string.Format(MailXML.GetElementsByTagName("cuerpoGenerico").Item(0).InnerText, enlace);

            MessageBox.Show(Correo.Body);
            Correo.IsBodyHtml = true;
            Correo.Priority = MailPriority.High;

            SmtpClient Cliente = new SmtpClient();
            string mensaje = "";
            try
            {
                Cliente.Send(Correo);
                mensaje = string.Format("Un correo de prueba ha sido enviado con éxito a {0} a las {1}", Correo.To[0].Address, DateTime.Now);
            }
            catch (Exception ex)
            {
                mensaje = string.Format("El correo no pudo ser enviado a {0}.\n\nLa Excepción generada dice:\n {1}\n\nFecha de Envío: {2}\n\nInformación Adicional:\n{3}",
                    ConfigurationManager.AppSettings["Destino"],
                    ex.Message,
                    DateTime.Now,
                    ex.StackTrace);
            }

        }
    }
}