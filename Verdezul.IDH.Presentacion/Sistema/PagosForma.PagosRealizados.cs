using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Verdezul.Utilidades.Formas;
using Verdezul.IDH.Business;
using Verdezul.IDH.Entidades;
using Verdezul.IDH.Configuracion.Enumerados;
using Verdezul.IDH.Presentacion.Controles;
using Verdezul.IDH.Configuracion;
using Verdezul.IDH.Presentacion.Reportes;

namespace Verdezul.IDH.Presentacion.Sistema
{
    public partial class PagosForma
    {
        #region Campos
        private PagoDataSet PagosRealizadosDataSet;
        private EstadoPago EstadoPagoActivo;
        #endregion

        #region Botones
        private ToolStripButton CerrarCajaBoton;
        private ToolStripDropDownButton MarcarComoDropDownButton;
        private ToolStripButton ImprimirBoton;
        #endregion

        #region Eventos
        private void IniciarPagosRealizados()
        {
            LlenarPagos();

            PagosRealizadosDataGrid.ColumnasNoVisibles.Add("IdCierreDeCaja");
            PagosRealizadosDataGrid.ColumnasNoVisibles.Add("IdAlumno");
            PagosRealizadosDataGrid.ColumnasNoVisibles.Add("IdSecuencia");
            PagosRealizadosDataGrid.ColumnasNoVisibles.Add("Id");
            PagosRealizadosDataGrid.ColumnasNoVisibles.Add("FormaPago");
            PagosRealizadosDataGrid.ColumnasNoVisibles.Add("Observacion");
            PagosRealizadosDataGrid.ColumnasNoVisibles.Add("FormaPagoTexto");
            PagosRealizadosDataGrid.ColumnasNoVisibles.Add("TipoDocumentoPago");
            PagosRealizadosDataGrid.VisibilidadColumnas(false);
        }

        private void LlenarPagos()
        {
            try
            {
                PagosRealizadosDataSet = PagoServicio.SeleccionarConDetallexCierreDeCaja(IdCierreDeCaja.Value);
                PagosRealizadosDataGrid.DataSource = PagosRealizadosDataSet.Pago;
            }
            catch (Exception ex)
            {
                MostrarMensaje("No se puede recuperar los Pagos", ex);
            }
        }

        private void CerrarCajaBoton_Click(object sender, EventArgs e)
        {
            PagoTabControl.SelectedTab = PagosRealizadosTabPage;
            if (Preguntar("Antes de Cerrar la Caja tome en cuenta que..." +
                "\n - El total del dinero (físico) sea igual al 'Valor de Cierre de Caja'." +
                "\n - Existen Pagos anulados que no son tomados en cuenta." +
                "\n - Este Proceso no es reversible." +
                "\n¿ Desea cerrar la caja en este momento ?").Equals(DialogResult.Yes))
            {
                try
                {
                    CierreDeCajaServicio.CerrarCaja(IdCierreDeCaja.Value);
                    MostrarMensaje("La Caja ha sido cerrada con éxito");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MostrarMensaje("La Caja no pudo ser cerrada", ex);
                }
            }
        }
        
        private void ImprimirBoton_Click(object sender, EventArgs e)
        {
            if (Preguntar("Desea imprimir los pagos antes de realizar el cierre de caja ?").Equals(DialogResult.Yes))
            {
                CierreDeCajaDataSet.CierreDeCajaDataTable dt = CierreDeCajaServicio.SeleccionarxId(IdCierreDeCaja.Value);
                this.FormaContenedora.MostrarForma(typeof(PagosxCierreFormaReporte), new object[] { dt.Rows[0] });
            }
        }

        private void MarcarComoDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem tsi = e.ClickedItem;
            EstadoPagoActivo = (EstadoPago)tsi.Tag;
            MarcarComoDropDownButton.Text = "Marcar como " + tsi.Text;
            PonerMarcaPagos();
        }

        private void MarcarComoDropDownButton_DoubleClick(object sender, EventArgs e)
        {
            PonerMarcaPagos();
        }

        private void PagosRealizadosDataGrid_PagoDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DetallePagoVentana.DataSource = DetallexPago(((PagosRealizadosDataGrid.Rows[e.RowIndex].DataBoundItem as DataRowView).Row as PagoDataSet.PagoRow).Id);
                DetallePagoVentana.Visible = true;
            }
        }
        #endregion

        #region Métodos
        private PagoDataSet.DetallePagoDataTable DetallexPago(object idPago)
        {
            PagoDataSet.DetallePagoDataTable dpdt = PagosRealizadosDataSet.DetallePago.Clone() as PagoDataSet.DetallePagoDataTable;
            dpdt.HorarioNombreColumn.Expression = MetodosGenerales.ExpresionHorarioNombre;
            dpdt.DescripcionColumn.Expression = MetodosGenerales.ExpresionDetallePago;
            foreach (PagoDataSet.DetallePagoRow dr in PagosRealizadosDataSet.DetallePago.Rows)
            {
                if (dr.IdPago.Equals(idPago))
                    dpdt.Rows.Add(dr.ItemArray);
            }
            return dpdt;
        }

        private void PonerMarcaPagos()
        {
            if (Preguntar(string.Format("Desea marcar como '{0}s' los Pagos escogidos ?", EstadoPagoActivo.ToString())).Equals(DialogResult.Yes))
            {
                string listaPagos = PagosRealizadosDataGrid.ElementosEscogidosString;
                if (listaPagos != "")
                {
                    try
                    {
                        PagoServicio.CambiarEstado(listaPagos, EstadoPagoActivo);
                    }
                    catch (Exception ex)
                    {
                        MostrarMensaje("No se pudo cambiar el estado de los Pagos.", ex);
                    }

                    LlenarPagos();
                }
                else
                {
                    MostrarMensaje("Debe seleccionar al menos un Pago");
                }
            }
        }
        #endregion
    }
}