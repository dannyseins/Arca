using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Verdezul.IDH.Business;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Presentacion.Controles
{
    public partial class AreaNivelUserControl : UserControl
    {
        #region Campos
        private AreaManager AreaServicio;
        private AreaDataSet.NivelDataTable NivelDatos;
        #endregion

        #region Eventos
        //private delegate void EventoNivel(object sender, EventArgs e);
        //public event EventoNivel NivelCambiado; 

        public event EventHandler NivelCambiado;
        protected virtual void OnNivelCambiado(System.EventArgs e)
        {
            if (NivelCambiado != null)
            {
                NivelCambiado(this, e);
            }
        }
        #endregion

        #region Propiedades Diseño
        [Category("Verdezul - IDH")]
        public FlowDirection FlowDirection
        {
            get { return AreaNivelFlowLayoutPanel.FlowDirection; }
            set { AreaNivelFlowLayoutPanel.FlowDirection = value; }
        }

        [Description("Indica si el ComboBox de Nivel será visible")]
        [Category("Verdezul - IDH")]
        public bool NivelVisible
        {
            get { return NivelComboBox.Visible; }
            set
            {
                NivelComboBox.Visible = value;
                AreaNivelLabel.Text = value ? "Área/Nivel" : "Área";
            }
        }

        private string _TextoAdicionalArea = "(Seleccione)";
        [Category("Verdezul - IDH")]
        public string TextoAdicionalArea
        {
            get { return _TextoAdicionalArea; }
            set { _TextoAdicionalArea = value; }
        }

        private string _TextoAdicionalNivel = "(Seleccione)";
        [Category("Verdezul - IDH")]
        public string TextoAdicionalNivel
        {
            get { return _TextoAdicionalNivel; }
            set { _TextoAdicionalNivel = value; }
        }

        private bool _UsarTextoAdicionalArea = true;
        [Category("Verdezul - IDH")]
        public bool UsarTextoAdicionalArea
        {
            get { return _UsarTextoAdicionalArea; }
            set { _UsarTextoAdicionalArea = value; }
        }

        private bool _UsarTextoAdicionalNivel = true;
        [Category("Verdezul - IDH")]
        public bool UsarTextoAdicionalNivel
        {
            get { return _UsarTextoAdicionalNivel; }
            set { _UsarTextoAdicionalNivel = value; }
        }

        private int _PosicionTextoAdicionalArea = 0;
        [Category("Verdezul - IDH")]
        public int PosicionTextoAdicionalArea
        {
            get { return _PosicionTextoAdicionalArea; }
            set { _PosicionTextoAdicionalArea = value; }
        }

        private int _PosicionTextoAdicionalNivel = 0;
        [Category("Verdezul - IDH")]
        public int PosicionTextoAdicionalNivel
        {
            get { return _PosicionTextoAdicionalNivel; }
            set { _PosicionTextoAdicionalNivel = value; }
        }

        [Category("Verdezul - IDH")]
        public bool PermitirEdicion
        {
            set
            {
                AreaComboBox.DropDownStyle = (value) ? ComboBoxStyle.DropDownList : ComboBoxStyle.Simple;
                NivelComboBox.DropDownStyle = (value) ? ComboBoxStyle.DropDownList : ComboBoxStyle.Simple;
                AreaComboBox.Enabled = value;
                NivelComboBox.Enabled = value;
            }
            get
            {
                return AreaComboBox.Enabled;
            }
        }
        #endregion

        #region Propiedades Ejecucion
        /// <summary>
        /// Indica si los datos han sido cargados con el método CargarDatos()
        /// </summary>
        public bool DatosCargados
        { get { return (AreaComboBox.DataSource != null); } }
        #endregion

        #region Constructor
        public AreaNivelUserControl()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }

        public void InicializarComponentesAdicionales()
        {
            AreaServicio = new AreaManager();
            NivelDatos = new AreaDataSet.NivelDataTable();
        }
        #endregion

        #region Eventos
        private void AreaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NivelVisible)
            {
                FiltrarNivelesxArea((int)AreaComboBox.SelectedValue);
                if (_UsarTextoAdicionalNivel)
                    AdicionarTextoNivel(_TextoAdicionalNivel, _PosicionTextoAdicionalNivel);
                NivelComboBox.DataSource = NivelDatos;
                NivelComboBox.SelectedIndex = 0;
            }
        }

        private void NivelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnNivelCambiado(e);
        }
        #endregion

        #region Métodos Privados
        private void FiltrarNivelesxArea(int idArea)
        {
            NivelDatos.Clear();
            foreach (AreaDataSet.NivelRow nrow in AreaNivelDatos.Nivel)
            {
                if (nrow.IdArea == idArea)
                    NivelDatos.Rows.Add(nrow.Id, nrow.IdArea, nrow.Nombre);
            }
        }

        private void AdicionarTextoArea(string texto, int posicion)
        {
            AreaDataSet.AreaRow arow = AreaNivelDatos.Area.NewAreaRow();
            arow.Id = 0;
            arow.Nombre = texto;
            if (posicion >= 0)
                AreaNivelDatos.Area.Rows.InsertAt(arow, posicion);
            else
                AreaNivelDatos.Area.Rows.Add(arow);
        }

        private void AdicionarTextoNivel(string texto, int posicion)
        {
            AreaDataSet.NivelRow nrow = NivelDatos.NewNivelRow();
            nrow.Id = 0;
            nrow.IdArea = 0;
            nrow.Nombre = texto;
            if (posicion >= 0)
                NivelDatos.Rows.InsertAt(nrow, posicion);
            else
                NivelDatos.Rows.Add(nrow);
        }
        #endregion

        #region Métodos Públicos
        public void CargarDatos()
        {
            AreaNivelDatos = AreaServicio.SeleccionarConNiveles(0);
            if (_UsarTextoAdicionalArea)
                AdicionarTextoArea(_TextoAdicionalArea, _PosicionTextoAdicionalArea);
            AreaComboBox.DataSource = AreaNivelDatos.Area;
        }

        public void SetIdArea(int idArea)
        {
            AreaComboBox.SelectedValue = idArea;
        }

        public void SetIdNivel(int idNivel)
        {
            foreach (AreaDataSet.NivelRow nrow in AreaNivelDatos.Nivel)
            {
                if (nrow.Id == idNivel)
                {
                    AreaComboBox.SelectedValue = nrow.IdArea;
                    NivelComboBox.SelectedValue = idNivel;
                    break;
                }
            }
        }

        public int GetIdArea()
        {
            return (int)AreaComboBox.SelectedValue;
        }

        public string GetNombreArea()
        {
            return ((AreaComboBox.SelectedItem as DataRowView).Row as AreaDataSet.AreaRow).Nombre;
        }

        public int GetIdNivel()
        {
            try
            {
                return (int)NivelComboBox.SelectedValue;
            }
            catch
            {
                return 0;
            }
        }

        public string GetNombreNivel()
        {
            return ((NivelComboBox.SelectedItem as DataRowView).Row as AreaDataSet.NivelRow).Nombre;
        }

        public bool ValidarNivel()
        {
            MarcaError.SetError(NivelComboBox, "");
            if (NivelComboBox.SelectedValue.Equals(0))
            {
                MarcaError.SetError(NivelComboBox, "Debe elegir un valor de la lista");
                return false;
            }
            return true;
        }

        public bool ValidarArea()
        {
            MarcaError.SetError(AreaComboBox, "");
            if (AreaComboBox.SelectedValue.Equals(0))
            {
                MarcaError.SetError(AreaComboBox, "Debe elegir un valor de la lista");
                return false;
            }
            return true;
        }

        public void LimpiarAreaNivel()
        {
            SetIdArea(0);
            LimpiarMarcaError();
        }

        public void LimpiarMarcaError()
        {
            MarcaError.Clear();
        }
        #endregion
    }
}
