using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Configuracion.Enumerados;

namespace Verdezul.IDH.Presentacion.Controles
{
    public partial class DetallePagoControl
    {
        #region Propiedades
        private List<string> _ColumnasNoVisibles = new List<string>();
        public List<string> ColumnasNoVisibles
        {
            get { return _ColumnasNoVisibles; }
            set { _ColumnasNoVisibles = value; }
        }
        #endregion

        #region Eventos
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.DetallePagosDataGrid.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.DetallePagosDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
        #endregion

        #region Métodos
        private void VisibilidadColumnas(bool visible)
        {
            foreach (string str in _ColumnasNoVisibles)
            {
                this.DetallePagosDataGrid.Columns[str].Visible = visible;
            }
        }
        #endregion
    }
}
