using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.DataAccess;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Business
{
    /// <summary>
    /// Clase de Negocios para Pago.
    /// </summary>
    public partial class PagoManager
    {
        /// <summary>
        /// Objeto de Acceso a Datos.
        /// </summary>
        PagoDataAccess objPago;

        /// <summary>
        /// Constructor
        /// </summary>
        public PagoManager()
        {
            this.objPago = new PagoDataAccess();
        }

        /// <summary>
        /// Selecciona Pagos dado su Identificador
        /// </summary>
        /// <param name="Id">Id de Pago</param>
        /// <returns>PagoDataSet</returns>
        public PagoDataSet.PagoDataTable SeleccionarxId(int id)
        {
            return objPago.Seleccionar(id);
        }

        /// <summary>
        /// Selecciona Todos los Pagos
        /// </summary>
        /// <returns>PagoDataSet</returns>
        public PagoDataSet.PagoDataTable SeleccionarTodos()
        {
            return objPago.Seleccionar(0);
        }

        /// <summary>
        /// Inserta un nuevo Pago.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Pago a Insertar.</param>
        /// <returns>Id de Pago Insertado</returns>
        public int Insertar(PagoDataSet ds)
        {
            return objPago.Insertar(ds);
        }

        /// <summary>
        /// Modifica un Pago.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Pago a Modificar.</param>
        public void Modificar(PagoDataSet ds)
        {
            objPago.Modificar(ds);
        }

        /// <summary>
        /// Borra un Pago
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Pago a Borrar.</param>
        public void Borrar(PagoDataSet ds)
        {
            objPago.Borrar(ds);
        }

        /// <summary>
        /// Borra un Pago
        /// </summary>
        /// <param name="id">Identificador de Pago</param>
        public void Borrar(int id)
        {
            objPago.Borrar(id);
        }
    }
}
