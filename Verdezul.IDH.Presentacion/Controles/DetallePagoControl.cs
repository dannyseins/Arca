using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Configuracion;

namespace Verdezul.IDH.Presentacion.Controles
{
    public partial class DetallePagoControl : UserControl
    {
        #region Propiedades
        public PagoDataSet.DetallePagoDataTable DataSource
        {
            get { return (PagoDataSet.DetallePagoDataTable)DetallePagosDataGrid.DataSource; }
            set
            {
                if (value != null)
                {
                    DetallePagosDataGrid.DataSource = value;
                    VisibilidadColumnas(false);
                }
            }
        }
        #endregion

        #region Constructor
        public DetallePagoControl()
        {
            InitializeComponent();
            this.TipoAbono.ValueMember = "Valor";
            this.TipoAbono.DisplayMember = "Texto";
            this.TipoAbono.ValueType = typeof(int);
            this.TipoAbono.DataSource = MetodosGenerales.PedirTiposAbono();
        }
        #endregion

        #region Eventos
        private void DetallePagoControl_Load(object sender, EventArgs e)
        {

        }

        public void QuitarVisualizacion()
        {
            ColumnasNoVisibles.Add("IdPago");
            ColumnasNoVisibles.Add("IdMotivoPago");
            ColumnasNoVisibles.Add("IdRubro");
            ColumnasNoVisibles.Add("Rubro");
            ColumnasNoVisibles.Add("IdConferencia");
            ColumnasNoVisibles.Add("Conferencia");
            ColumnasNoVisibles.Add("Nivel");
            ColumnasNoVisibles.Add("Area");
            ColumnasNoVisibles.Add("IdHorarioAlumno");
            ColumnasNoVisibles.Add("MesPago");
            ColumnasNoVisibles.Add("HorarioNombre");
            ColumnasNoVisibles.Add("Curso");
            ColumnasNoVisibles.Add("HoraInicio");
            ColumnasNoVisibles.Add("HoraFin");
            ColumnasNoVisibles.Add("Dias");

            this.PVP.DisplayIndex = 6;
        }

        private void MoverPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.SetBounds(Location.X + e.X, Location.Y + e.Y, this.Width, this.Height);
        }

        private void SalirPanel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        #endregion
    }
}