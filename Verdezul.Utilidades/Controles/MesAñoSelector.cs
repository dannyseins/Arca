using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Verdezul.Utilidades.Controles
{
    public partial class MesAñoSelector : UserControl
    {
        #region Propiedades
        public DateTime FechaSeleccionada
        {
            get
            {
                return new DateTime((int)AñoComboBox.SelectedValue, (int)MesComboBox.SelectedValue, 1);
            }
            set
            {
                AñoComboBox.SelectedValue = value.Year;
                if (AñoComboBox.SelectedValue == null) AñoComboBox.SelectedValue = AñoInicio;
                MesComboBox.SelectedValue = value.Month;
                if (MesComboBox.SelectedValue == null) MesComboBox.SelectedValue = MesInicio;
            }
        }

        private DisplayMode _Formato = DisplayMode.MesAñoHorizontal;
        public DisplayMode Formato
        {
            get { return _Formato; }
            set
            {
                _Formato = value;
                switch (value)
                {
                    case DisplayMode.MesAñoHorizontal:
                        this.MesComboBox.Location = new System.Drawing.Point(0, 0);
                        this.AñoComboBox.Location = new System.Drawing.Point(80, 0);
                        this.MaximumSize = new System.Drawing.Size(130, 21);
                        this.MinimumSize = new System.Drawing.Size(130, 21);
                        this.Size = new System.Drawing.Size(130, 21);
                        break;
                    case DisplayMode.AñoMesHorizontal:
                        this.MesComboBox.Location = new System.Drawing.Point(55, 0);
                        this.AñoComboBox.Location = new System.Drawing.Point(0, 0);
                        this.MaximumSize = new System.Drawing.Size(130, 21);
                        this.MinimumSize = new System.Drawing.Size(130, 21);
                        this.Size = new System.Drawing.Size(130, 21);
                        break;
                    case DisplayMode.MesAñoVertical:
                        this.MesComboBox.Location = new System.Drawing.Point(0, 0);
                        this.AñoComboBox.Location = new System.Drawing.Point(0, 25);
                        this.MaximumSize = new System.Drawing.Size(80, 46);
                        this.MinimumSize = new System.Drawing.Size(80, 46);
                        this.Size = new System.Drawing.Size(80, 46);
                        break;
                    case DisplayMode.AñoMesVertical:
                        this.MesComboBox.Location = new System.Drawing.Point(0, 25);
                        this.AñoComboBox.Location = new System.Drawing.Point(0, 0);
                        this.MaximumSize = new System.Drawing.Size(80, 46);
                        this.MinimumSize = new System.Drawing.Size(80, 46);
                        this.Size = new System.Drawing.Size(80, 46);
                        break;
                }
            }

        }

        private int _MesInicio = 1;
        public int MesInicio
        {
            get { return _MesInicio; }
            set
            {
                _MesInicio = (value > 12) ? 12 : (value < 1) ? 1 : value;
                if (_MesInicio > _MesFin) _MesInicio = _MesFin;
                PedirMeses();
            }
        }

        private int _MesFin = 12;
        public int MesFin
        {
            get { return _MesFin; }
            set
            {
                _MesFin = (value > 12) ? 12 : (value < 1) ? 1 : value;
                if (_MesFin < _MesInicio) _MesFin = _MesInicio;
                PedirMeses();
            }
        }

        private int _AñoInicio = DateTime.MinValue.Year;
        public int AñoInicio
        {
            get { return _AñoInicio; }
            set
            {
                _AñoInicio = (value > DateTime.MaxValue.Year) ? DateTime.MaxValue.Year : (value < DateTime.MinValue.Year) ? DateTime.MinValue.Year : value;
                if (_AñoInicio > _AñoFin) _AñoInicio = _AñoFin;
                PedirAños();
            }
        }

        private int _AñoFin = DateTime.MaxValue.Year;
        public int AñoFin
        {
            get { return _AñoFin; }
            set
            {
                _AñoFin = (value > DateTime.MaxValue.Year) ? DateTime.MaxValue.Year : (value < DateTime.MinValue.Year) ? DateTime.MinValue.Year : value;
                if (_AñoFin < _AñoInicio) _AñoFin = _AñoInicio;
                PedirAños();
            }
        }
        #endregion

        #region Constructor
        public MesAñoSelector()
        {
            InitializeComponent();
            PedirAños();
            PedirMeses();
        }
        #endregion

        #region Eventos
        private void MesAñoSelector_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Métodos
        private void PedirAños()
        {
            List<ElementoLista> años = new List<ElementoLista>();
            for (int i = _AñoInicio; i <= _AñoFin; i++)
            {
                años.Add(new ElementoLista(i, i.ToString()));
            }
            AñoComboBox.DataSource = años;
        }

        private void PedirMeses()
        {
            List<ElementoLista> meses = new List<ElementoLista>();
            for (int i = _MesInicio; i <= _MesFin; i++)
            {
                meses.Add(new ElementoLista(i, new DateTime(2000, i, 1).ToString("MMMM")));
            }
            MesComboBox.DataSource = meses;
        }
        #endregion

        #region Clases
        public enum DisplayMode
        {
            MesAñoHorizontal = 1,
            AñoMesHorizontal = 2,
            MesAñoVertical = 3,
            AñoMesVertical = 4,
        }

        private class ElementoLista
        {
            public ElementoLista(int valor, string texto)
            {
                Valor = valor;
                Texto = texto;
            }
            private int _Valor;
            public int Valor
            {
                get { return _Valor; }
                set { _Valor = value; }
            }
            private string _Texto;
            public string Texto
            {
                get { return _Texto; }
                set { _Texto = value; }
            }
        }
        #endregion
    }
}
