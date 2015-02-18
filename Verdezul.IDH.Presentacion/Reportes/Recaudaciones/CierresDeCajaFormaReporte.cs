using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Business;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Presentacion.Reportes
{
    public partial class CierresDeCajaFormaReporte : FormaReporte
    {
        #region Campos
        private CierreDeCajaManager objCierre;
        #endregion

        #region Botones
        private ToolStripButton BuscarBoton;
        #endregion

        #region Constructor
        public CierresDeCajaFormaReporte()
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
        }
        
        public CierresDeCajaFormaReporte(int idUsuario)
        {
            InitializeComponent();
            InicializarComponentesAdicionales();
            IdUsuario = idUsuario;
        }

        private void InicializarComponentesAdicionales()
        {
            objCierre = new CierreDeCajaManager();
            BuscarBoton = AgregarBotonAccion("BuscarBoton", "Buscar", Imagenes.Buscar, BuscarBoton_Click);
            this.MostrarBoton.Image = Imagenes.MostrarReporte;
            this.BarraBotones.Items.Remove(BuscarBoton);
            this.BarraBotones.Items.Insert(0, BuscarBoton);
        }
        #endregion

        #region Eventos
        protected override bool DatosReporte()
        {
            try
            {
                this.Elementos.ParametrosReporte.Clear();
                this.Elementos.ParametrosReporte.Add(new ReportParameter("RangoFechas", string.Format("{0:dd/MMMM/yy} a {1:dd/MMMM/yy}", DesdeDateTimePicker.Value.Date, HastaDateTimePicker.Value.Date)));
                this.Elementos.ParametrosReporte.Add(new ReportParameter("Titulo", this.Text));
                this.Elementos.Titulo = this.Text;
                this.Elementos.NombreReporte = "ReporteCierreDeCaja.rdlc";
                this.Elementos.DataSource = objCierre.SeleccionarEntreFechas(DesdeDateTimePicker.Value.Date, HastaDateTimePicker.Value.Date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            CierresDataGridView.DataSource = objCierre.SeleccionarEntreFechas(DesdeDateTimePicker.Value.Date, HastaDateTimePicker.Value.Date);
            ConfigurarDataGrid();
        }

        private void CierresDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CierreDeCajaDataSet.CierreDeCajaRow dr = (CierresDataGridView.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as CierreDeCajaDataSet.CierreDeCajaRow;
                this.FormaContenedora.MostrarForma(typeof(PagosxCierreFormaReporte), new object[] { dr });
            }
        }
        #endregion

        #region Métodos
        private void ConfigurarDataGrid()
        {
            CierresDataGridView.Columns["FechaApertura"].HeaderText = "Apertura";
            CierresDataGridView.Columns["FechaCierre"].HeaderText = "Cierre";
            CierresDataGridView.Columns["Id"].Visible = false;
            CierresDataGridView.Columns["IdCaja"].Visible = false;
            CierresDataGridView.Columns["IdUsuario"].Visible = false;
            CierresDataGridView.Columns["Caja"].DisplayIndex = 1;
            CierresDataGridView.Columns["Usuario"].DisplayIndex = 2;
        }
        #endregion
    }
}

