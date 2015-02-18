using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Business;
using Verdezul.IDH.Presentacion.Sistema;

namespace Verdezul.IDH.Presentacion.Controles
{
    public partial class AlumnoControl : UserControl
    {
        #region Eventos
        //private delegate void EventoAlumno(object sender, EventArgs e, AlumnoDataSet.AlumnoRow Alumno);
        //public event EventoAlumno AlumnoEncontrado; 

        public event EventHandler AlumnoEncontrado;
        protected virtual void OnAlumnoEncontrado(System.EventArgs e)
        {
            if (AlumnoEncontrado != null)
            {
                AlumnoEncontrado(this, e);
            }
        }
        #endregion

        #region Campos
        private FormaBase FormaPadre;
        private AlumnoManager AlumnoServicio;
        #endregion

        #region Propiedades
        private AlumnoDataSet.AlumnoRow _AlumnoFila;
        public AlumnoDataSet.AlumnoRow AlumnoFila
        {
            get { return _AlumnoFila;  }
        }

        public Nullable<int> IdAlumno
        {
            get
            {
                if (_AlumnoFila != null)
                    return _AlumnoFila.Id;
                return null;
            }
        }

        public string Identificacion
        {
            get { return IdentificacionTextBox.Text; }
        }

        public string Nombre
        {
            get { return NombreTextBox.Text; }
            set { NombreTextBox.Text = value; }
        }

        public string Apellido
        {
            get { return ApellidoTextBox.Text; }
            set { ApellidoTextBox.Text = value; }
        }

        public bool BuscarVisible
        {
            get { return BuscarButton.Visible; }
            set { BuscarButton.Visible = value; }
        }

        private bool _PermitirCrearAlumno = true;
        public bool PermitirCrearAlumno
        {
            get { return _PermitirCrearAlumno; }
            set { _PermitirCrearAlumno = value; }
        }
        #endregion

        #region Constructor
        public AlumnoControl()
        {
            InitializeComponent();
            AlumnoServicio = new AlumnoManager();
        }
        #endregion

        #region Eventos
        private void AlumnoControl_Load(object sender, EventArgs e)
        {
            this.FormaPadre = (Verdezul.Utilidades.Formas.FormaBase)this.FindForm();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            AlumnoBusquedaForma formaBusqueda = new AlumnoBusquedaForma(NombreTextBox.Text, ApellidoTextBox.Text);
            if (formaBusqueda.ShowDialog().Equals(DialogResult.Yes))
            {
                _AlumnoFila = formaBusqueda.AlumnoRow;
                LlenarDatosAlumno();
                FormaPadre.MarcaError.SetError(IdentificacionTextBox, "");
                OnAlumnoEncontrado(e);
            }
            FormaPadre.MarcaError.SetError(NombreTextBox, "");
        }

        private void IdentificacionTextBox_Leave(object sender, EventArgs e)
        {
            if (PermitirCrearAlumno)
            {
                if (IdentificacionTextBox.Text != "")
                {
                    try
                    {
                        AlumnoDataSet.AlumnoDataTable cdt = AlumnoServicio.SeleccionarxIdentificaionxNombrexApellido(IdentificacionTextBox.Text, "", "");
                        if (cdt.Rows.Count == 0)
                        {
                            if (FormaPadre.Preguntar("Este Alumno no existe, desea agregarlo ?").Equals(DialogResult.Yes))
                            {
                                AlumnoForma alumnoForma = new AlumnoForma(IdentificacionTextBox.Text);
                                alumnoForma.PermitirModificar = false;
                                if (alumnoForma.ShowDialog().Equals(DialogResult.Yes))
                                {
                                    _AlumnoFila = AlumnoServicio.SeleccionarxId(alumnoForma.IdAlumno)[0];
                                    LlenarDatosAlumno();
                                    OnAlumnoEncontrado(e);
                                }
                            }
                        }
                        else
                        {
                            _AlumnoFila = cdt[0];
                            LlenarDatosAlumno();
                            OnAlumnoEncontrado(e);
                        }

                    }
                    catch (Exception ex)
                    {
                        FormaPadre.MostrarMensaje(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Métodos Privados
        private void LlenarDatosAlumno()
        {
            IdentificacionTextBox.Text = _AlumnoFila.NumeroIdentificacion;
            NombreTextBox.Text = _AlumnoFila.Nombre;
            ApellidoTextBox.Text = _AlumnoFila.Apellido;
        }
        #endregion

        #region Métodos Públicos
        public void Limpiar()
        {
            IdentificacionTextBox.Text = "";
            NombreTextBox.Text = "";
            ApellidoTextBox.Text = "";
            _AlumnoFila = null;
            FormaPadre.MarcaError.SetError(IdentificacionTextBox, "");
        }

        public bool ValidarAlumnoEscogido()
        {
            if ((!this.IdAlumno.HasValue) || (this.IdAlumno == 0))
            {
                FormaPadre.MarcaError.SetError(IdentificacionTextBox, "No ha escogido un Alumno válido.");
                return false;
            }
            return true;
        }
        #endregion
    }
}
