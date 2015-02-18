using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Verdezul.IDH.Business;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Configuracion;

namespace Verdezul.IDH.Presentacion.Controles
{
    public partial class HorarioUserControl : UserControl
    {
        #region Campos
        private CursoManager CursoServicio;
        private HorarioManager HorarioServicio;
        private CursoDataSet.CursoDataTable CursoDatos;
        private HorarioDataSet.HorarioDataTable HorarioDatos;
        private HorarioDataSet.HorarioDataTable HorarioFiltrados;
        #endregion

        #region Propiedades Diseño
        [Category("Verdezul - IDH")]
        public FlowDirection FlowDirection
        {
            get { return CursoHorarioFlowLayoutPanel.FlowDirection; }
            set { CursoHorarioFlowLayoutPanel.FlowDirection = value; }
        }

        [Description("Indica si el ComboBox de Horario será visible")]
        [Category("Verdezul - IDH")]
        public bool HorarioVisible
        {
            get { return HorarioComboBox.Visible; }
            set
            {
                HorarioComboBox.Visible = value;
                CursoHorarioLabel.Text = value ? "Horario/Curso" : "Curso";
            }
        }

        private string _TextoAdicionalCurso = "(Seleccione)";
        [Category("Verdezul - IDH")]
        public string TextoAdicionalCurso
        {
            get { return _TextoAdicionalCurso; }
            set { _TextoAdicionalCurso = value; }
        }

        private string _TextoAdicionalHorario = "(Seleccione)";
        [Category("Verdezul - IDH")]
        public string TextoAdicionalHorario
        {
            get { return _TextoAdicionalHorario; }
            set { _TextoAdicionalHorario = value; }
        }

        private bool _UsarTextoAdicionalCurso = true;
        [Category("Verdezul - IDH")]
        public bool UsarTextoAdicionalCurso
        {
            get { return _UsarTextoAdicionalCurso; }
            set { _UsarTextoAdicionalCurso = value; }
        }

        private bool _UsarTextoAdicionalHorario = true;
        [Category("Verdezul - IDH")]
        public bool UsarTextoAdicionalHorario
        {
            get { return _UsarTextoAdicionalHorario; }
            set { _UsarTextoAdicionalHorario = value; }
        }

        private int _PosicionTextoAdicionalCurso = 0;
        [Category("Verdezul - IDH")]
        public int PosicionTextoAdicionalCurso
        {
            get { return _PosicionTextoAdicionalCurso; }
            set { _PosicionTextoAdicionalCurso = value; }
        }

        private int _PosicionTextoAdicionalHorario = 0;
        [Category("Verdezul - IDH")]
        public int PosicionTextoAdicionalHorario
        {
            get { return _PosicionTextoAdicionalHorario; }
            set { _PosicionTextoAdicionalHorario = value; }
        }
        #endregion

        #region Constructor
        public HorarioUserControl()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public void InicializarComponentesAdicionales()
        {
            CursoServicio = new CursoManager();
            HorarioServicio = new HorarioManager();
            CursoDatos = new CursoDataSet.CursoDataTable();
            HorarioFiltrados = new HorarioDataSet.HorarioDataTable();
        }
        #endregion

        #region Eventos
        private void CursoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HorarioVisible)
            {
                FiltrarHorariosxCurso((int)CursoComboBox.SelectedValue);
                if (_UsarTextoAdicionalHorario)
                    MetodosGenerales.AdicionarTextoHorario(HorarioFiltrados, _TextoAdicionalHorario, _PosicionTextoAdicionalHorario);
                HorarioComboBox.DataSource = HorarioFiltrados;
                HorarioComboBox.SelectedIndex = 0;
            }
        }
        #endregion

        #region Métodos Privados
        private void FiltrarHorariosxCurso(int idCurso)
        {
            HorarioFiltrados.Clear();
            foreach (HorarioDataSet.HorarioRow hcrow in HorarioDatos)
            {
                if (!hcrow.IsIdCursoNull())
                    if ((hcrow.IdCurso == idCurso) && (hcrow.Activo))
                        HorarioFiltrados.Rows.Add(hcrow.ItemArray);
            }
        }

        private void AdicionarTextoCurso(string texto, int posicion)
        {
            CursoDataSet.CursoRow arow = CursoDatos.NewCursoRow();
            arow.Id = 0;
            arow.Nombre = texto;
            arow.Activo = true;
            if (posicion >= 0)
                CursoDatos.Rows.InsertAt(arow, posicion);
            else
                CursoDatos.Rows.Add(arow);
        }
        #endregion

        #region Métodos Públicos
        public void CargarDatos()
        {
            CursoDatos = CursoServicio.SeleccionarActivos();
            HorarioDatos = HorarioServicio.SeleccionarTodos();
            HorarioDatos.Columns.Add("Docente", typeof(string));
            HorarioDatos.Columns.Add("Aula", typeof(string));
            HorarioDatos.Columns.Add("Curso", typeof(string));
            HorarioDatos.Columns.Add("Nivel", typeof(string));

            HorarioFiltrados.Columns.Add("Docente", typeof(string));
            HorarioFiltrados.Columns.Add("Aula", typeof(string));
            HorarioFiltrados.Columns.Add("Curso", typeof(string));
            HorarioFiltrados.Columns.Add("Nivel", typeof(string));

            HorarioDatos.NombreHorarioColumn.Expression = MetodosGenerales.ExpresionHorarioNombre;

            if (_UsarTextoAdicionalCurso)
                AdicionarTextoCurso(_TextoAdicionalCurso, _PosicionTextoAdicionalCurso);
            CursoComboBox.DataSource = CursoDatos;
        }

        public void SetIdCurso(int idCurso)
        {
            CursoComboBox.SelectedValue = idCurso;
        }

        public void SetIdHorario(int idHorario)
        {
            if (idHorario == 0)
                HorarioComboBox.SelectedValue = 0;
            foreach (HorarioDataSet.HorarioRow nrow in HorarioDatos)
            {
                if (nrow.Id == idHorario)
                {
                    CursoComboBox.SelectedValue = nrow.IdCurso;
                    HorarioComboBox.SelectedValue = idHorario;
                    break;
                }
            }
            if (HorarioComboBox.SelectedValue == null)
                throw new Exception("El horario que intenta elegir no está activo");
        }

        public int GetIdCurso()
        {
            return (int)CursoComboBox.SelectedValue;
        }

        public string GetNombreCurso()
        {
            return ((CursoComboBox.SelectedItem as DataRowView).Row as CursoDataSet.CursoRow).Nombre;
        }

        public int GetIdHorario()
        {
            return (int)HorarioComboBox.SelectedValue;
        }

        public string GetNombreHorario()
        {
            HorarioDataSet.HorarioRow hcrow = ((HorarioComboBox.SelectedItem as DataRowView).Row as HorarioDataSet.HorarioRow);
            return string.Format("{0:HH:mm} - {1:HH:mm}", hcrow.HoraInicio, hcrow.HoraFin);
        }

        public int GetIdDocente()
        {
            return ((HorarioComboBox.SelectedItem as DataRowView).Row as HorarioDataSet.HorarioRow).IdDocente;
        }

        public bool ValidarHorario()
        {
            MarcaError.SetError(HorarioComboBox, "");
            if (HorarioComboBox.SelectedValue.Equals(0))
            {
                MarcaError.SetError(HorarioComboBox, "Debe elegir un valor de la lista");
                return false;
            }
            return true;
        }

        public bool ValidarCurso()
        {
            MarcaError.SetError(CursoComboBox, "");
            if (CursoComboBox.SelectedValue.Equals(0))
            {
                MarcaError.SetError(CursoComboBox, "Debe elegir un valor de la lista");
                return false;
            }
            return true;
        }

        public void LimpiarCursoHorario()
        {
            SetIdCurso(0);
            LimpiarMarcaError();
        }

        public void LimpiarMarcaError()
        {
            MarcaError.Clear();
        }
        #endregion

    }
}
