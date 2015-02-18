using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Verdezul.Utilidades;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Configuracion.Enumerados;

namespace Verdezul.IDH.Presentacion.Controles
{
    public partial class DataGridPagos : Control
    {
        #region Constructor
        public DataGridPagos()
        {
            InitializeComponent();
        }
        #endregion

        #region Propiedades
        public PagoDataSet.PagoDataTable DataSource
        {
            get { return (PagoDataSet.PagoDataTable)this.DataGridView.DataSource; }
            set
            {
                if (value != null)
                {
                    if (!value.Columns.Contains("Escogido"))
                        value.Columns.Add("Escogido", typeof(bool));
                    this.DataGridView.DataSource = value;

                    foreach (DataRow dr in value.Rows)
                    {
                        dr["EstadoTexto"] = ((EstadoPago)dr["Estado"]).ToString();
                        dr["FormaPagoTexto"] = ((FormasPago)dr["FormaPago"]).ToString();
                        dr["TipoDocumentoPagoTexto"] = ((TipoDocumentoPago)dr["TipoDocumentoPago"]).ToString();
                    }
                }
            }
        }

        private List<string> _ColumnasNoVisibles = new List<string>();
        public List<string> ColumnasNoVisibles
        {
            get { return _ColumnasNoVisibles; }
            set { _ColumnasNoVisibles = value; }
        }

        public string ElementosEscogidosString
        {
            get
            {
                List<string> listaElementos = new List<string>();
                foreach (PagoDataSet.PagoRow row in this.DataSource)
                {
                    if (row["Escogido"].Equals(true))
                        listaElementos.Add(row.Id.ToString());
                }

                return String.Join(", ", listaElementos.ToArray());
            }
        }

        public DataGridViewRowCollection Rows
        {
            get
            {
                return DataGridView.Rows;
            }
        }
        #endregion

        #region Delegados de Eventos
        public event DataGridViewCellMouseEventHandler PagoDoubleClick;
        protected virtual void OnPagoDoubleClick(DataGridViewCellMouseEventArgs e)
        {
            if (PagoDoubleClick != null)
            {
                PagoDoubleClick(this, e);
            }
        }
        #endregion

        #region Eventos
        private void DataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OnPagoDoubleClick(e);
        }

        private void DataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hti = this.DataGridView.HitTest(e.X, e.Y);

            if ((hti.RowIndex != -1) && (this.DataGridView.Columns[hti.ColumnIndex].Name == "Escogido"))
            {
                DataGridViewCheckBoxCell cellCheckBox = (DataGridViewCheckBoxCell)this.DataGridView.Rows[hti.RowIndex].Cells["Escogido"];
                cellCheckBox.Value = (cellCheckBox.Value != DBNull.Value) ? !(bool)cellCheckBox.Value : true;
            }
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.Yellow;
            if (this.DataGridView.Columns[e.ColumnIndex].Name == "Estado")
            {
                switch ((EstadoPago)e.Value)
                {
                    case EstadoPago.Facturado:
                        this.DataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
                        this.DataGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Blue;
                        break;
                    case EstadoPago.Anulado:
                        this.DataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                        this.DataGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Gray;
                        break;
                    case EstadoPago.Ingresado:
                        this.DataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Salmon;
                        this.DataGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Salmon;
                        break;
                }
                e.CellStyle.SelectionForeColor = Color.Yellow;
            }
        }
        #endregion

        #region Métodos
        public void VisibilidadColumnas(bool visible)
        {
            foreach (string str in _ColumnasNoVisibles)
            {
                this.DataGridView.Columns[str].Visible = visible;
            }
        }
        #endregion

        void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

    }
}
